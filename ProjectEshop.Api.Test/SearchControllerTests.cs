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
    
    public class SearchControllerTests : IntegrationTest
    {

        public SearchControllerTests(ApiWebApplicationFactory fixture) : base(fixture)
        {

        }

       


        [Fact]
        public async Task GetAll_ShouldReturn_NonEmptyList()
        {
            //arrange
            var text = "puma";
            //act
            var response = await client.GetAsync(string.Format("api/Search/?text={0}", text));

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = await response.Content.ReadAsStringAsync();
            var searchResult = JsonConvert.DeserializeObject<SearchModel>(responseBody);
            searchResult.manufacturers.Should().HaveCountGreaterThan(0);
        }

        [Fact]
        public async Task GetAll_ShouldReturn_EmptyList()
        {
            //arrange
            var text = "kljafvkjladfvnkladfvnkladvnkladfnklvakjlklnajdcvklnaleurvndkfnvblzkxncvblakdfjvbkljdfvbzxkljcvbiaudfvbalskdvjnaiudfkljnadfgbsbjladfkjabdfhkufbehujlfahjafhgafjhagsfghzbvtyivcyuizhdfbjhkdfahjkffbnadfhbd";
            //act
            var response = await client.GetAsync(string.Format("api/Search/?text={0}", text));

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = await response.Content.ReadAsStringAsync();
            var searchResult = JsonConvert.DeserializeObject<SearchModel>(responseBody);
            searchResult.manufacturers.Should().HaveCount(0);
        }


    }
}
