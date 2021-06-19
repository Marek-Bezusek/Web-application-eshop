using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ProjectEshop.Models;
using ProjectEshop.Repository;
using ProjectEshop.DTOs;

namespace ProjectEshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoreController : ControllerBase
    {
        #region private properties

        private readonly int scoreUpperLimit = 5;
        private readonly int scoreLowerLimit = 1;


        private readonly IRepository<Score> scoreRepository;

        #endregion

        #region ctor
        public ScoreController(IRepository<Score> scoreRepository)
        {
            this.scoreRepository = scoreRepository;
        }
        #endregion

        #region public GET methods

        [HttpGet]
        [Route("ScoreGetAll")]
        public ActionResult<IEnumerable<ScoreDto>> GetAllScores(int productId)
        {
            var scores = scoreRepository.Get(x => x.IdProduct == productId).ToList();
            return scores.Select(x => x.AdaptToDto()).ToList();
        }

        [HttpGet]
        [Route("ScoreGetDetail")]
        public ActionResult<ScoreDto> GetScoreDetail(int id)
        {
            var result =
                scoreRepository.GetById(id, includeProperties: "IdProductNavigation");
            if (result is null)
            {
                return NoContent();
            }

            return result.AdaptToDto();
        }

        #endregion

        #region public POST methods

        [HttpPost]
        [Route("ScoreCreate")]
        public ActionResult<int> CreateScore(ScoreDto newScoreDto)
        {
            var newScore = newScoreDto.AdaptToScore();

            if (newScore.NumberScore > 5 || newScore.NumberScore < 1)
            {
                return BadRequest();
            }

            scoreRepository.Insert(newScore);

            if (scoreRepository.Commit() < 1)
            {
                return Problem();
            }

            return newScore.Id;
        }

        [HttpPut]
        [Route("ScoreEdit")]
        public IActionResult EditScore(ScoreDto scoreEditDataDto)
        {
            var scoreEditData = scoreEditDataDto.AdaptToScore();
            if (!validateScore(scoreEditData.NumberScore))
            {
                return BadRequest();
            }

            var scoreToEdit = scoreRepository.GetByID(scoreEditData.Id);
            if (scoreToEdit == null)
            {
                return NoContent();
            }

            scoreToEdit.TextScore = scoreEditData.TextScore;
            scoreToEdit.NumberScore = scoreEditData.NumberScore;

            scoreRepository.Commit();
            return Ok();
        }

        private bool validateScore(int score)
        {
            if (score > this.scoreUpperLimit || score < this.scoreLowerLimit) return false;
            return true;
        }

        #endregion


        #region public delete methods


        [HttpDelete]
        [Route("ScoreDelete")]
        public IActionResult DeleteScore(int id)
        {

            scoreRepository.Delete(id);
            if (scoreRepository.Commit() < 1)
            {
                return Problem();
            }
            return Ok();
        }

        #endregion

    }

}


