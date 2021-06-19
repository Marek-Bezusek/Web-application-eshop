using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using ProjectEshop.Controllers;
using ProjectEshop.Models;
using ProjectEshop.Repository;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ProjectEshop.Api.Test
{
    
    public class ScoreControllerTests : IntegrationTest
    {

        public ScoreControllerTests(ApiWebApplicationFactory fixture) : base(fixture)
        {

        }

        [Fact]
        public async Task Create_ShouldReturn_Id()
        {
            //arrange
            var newScore = new Score()
            {
                IdProduct = 3,
                TextScore = "Funguje jak má",
                NumberScore = 5
                
            };
            
            var content = new StringContent(JsonConvert.SerializeObject(newScore), Encoding.UTF8, "application/json");

            //act
            var response =await client.PostAsync("api/Score/Create/", content);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var newScoreId = JsonConvert.DeserializeObject<int>(await response.Content.ReadAsStringAsync());
            newScoreId.Should().NotBe(0);
        }

        [Fact]
        public async Task Create_ShouldReturn_InternalServerError()
        {
            //arrange
            var newScore = new Score()
            {
                IdProduct = 0,
                TextScore = "Nefunguje",
                NumberScore = 5
            };

            var content = new StringContent(JsonConvert.SerializeObject(newScore), Encoding.UTF8, "application/json");

            //act
            var response = await client.PostAsync("api/Score/Create/", content);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        }
        [Fact]
        public async Task Create_ShouldReturn_BadRequest()
        {
            //arrange
            var newScore = new Score()
            {
                IdProduct = 3,
                TextScore = "Nefunguje",
                NumberScore = 6
            };

            var content = new StringContent(JsonConvert.SerializeObject(newScore), Encoding.UTF8, "application/json");

            //act
            var response = await client.PostAsync("api/Score/Create/", content);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }


        [Fact]
        public async Task GetAll_ShouldReturn_NonEmptyList()
        {
            //arrange
            var id = 3;
            //act
            var response = await client.GetAsync(string.Format("api/Score/GetAll/?productId={0}", id));

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = await response.Content.ReadAsStringAsync();
            var scores = JsonConvert.DeserializeObject<List<Score>>(responseBody);
            scores.Should().HaveCountGreaterThan(0);
        }

        [Fact]
        public async Task GetDetail_ShouldReturn_Score()
        {
            //arrange
            var id = 2;
            var content = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
            //act
            var response = await client.GetAsync(string.Format("api/Score/GetDetail/?id={0}",id));

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = await response.Content.ReadAsStringAsync();
            var score = JsonConvert.DeserializeObject<Manufacturer>(responseBody);
            score.Id.Should().Be(id);
        }

        [Fact]
        public async Task GetDetail_ShouldReturn_NotFound()
        {
            //arrange
            var id = int.MaxValue;
            var content = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
            //act
            var response = await client.GetAsync(string.Format("api/Score/GetDetail/?id={0}", id));

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        }



        [Fact]
        public async Task Edit_ShouldReturn_OK()
        {
            //arrange
            var scoreEditData = new Score()
            {
                Id = 2,
                TextScore = DateTime.Now.ToString(),
                NumberScore = 4
            };

            var content = new StringContent(JsonConvert.SerializeObject(scoreEditData), Encoding.UTF8, "application/json");

            //act
            var response = await client.PutAsync("api/Score/Edit/", content);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Edit_ShouldReturn_NoContent()
        {
            //arrange
            var scoreEditData = new Score()
            {
                Id = int.MaxValue,
                TextScore = DateTime.Now.ToString(),
                NumberScore = 4
            };
            var content = new StringContent(JsonConvert.SerializeObject(scoreEditData), Encoding.UTF8, "application/json");

            //act
            var response = await client.PutAsync("api/Score/Edit/", content);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        }

        [Fact]
        public async Task Edit_ShouldReturn_BadRequest()
        {
            //arrange
            var scoreEditData = new Score()
            {
                Id = 2,
                TextScore = DateTime.Now.ToString(),
                NumberScore = 6
            };
            var content = new StringContent(JsonConvert.SerializeObject(scoreEditData), Encoding.UTF8, "application/json");

            //act
            var response = await client.PutAsync("api/Score/Edit/", content);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        //[Fact]
        //public async Task TestDelete_ShouldReturn_OK()
        //{
        //    //arrange
        //    var responseMock = new HttpResponseMessage
        //    {
        //        StatusCode = HttpStatusCode.OK,
        //    };
        //    var id = int.MaxValue;
        //    var handlerMock = new Mock<HttpMessageHandler>();
        //    handlerMock.Setup("DeleteAsync", ItExpr.IsAny<HttpRequestMessage>(),
        //            ItExpr.IsAny<CancellationToken>())
        //        .Returns(responseMock);


        //    var clientMock = new HttpClient(handlerMock.Object);

        //    clientMock.Setup(x => x.DeleteAsync(It.IsAny<string>())).ReturnsAsync(responseMock);
        //    //act
        //    var response = await clientMock.DeleteAsync(string.Format("api/Manufacturer/Delete/?id={0}", id));

        //    //assert
        //    response.StatusCode.Should().Be(HttpStatusCode.OK);
        //}

        [Fact]
        public async Task TestDelete_ShouldReturn_InternalServerError()
        {
            //arrange
            var id = int.MaxValue;
            var content = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
            //act
            var response = await client.DeleteAsync(string.Format("api/Score/Delete/?id={0}", id));

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        }

    }
}
