using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectEshop.Api.Test
{
    public abstract class IntegrationTest : IClassFixture<ApiWebApplicationFactory>
    {
        protected readonly ApiWebApplicationFactory factory;
        protected readonly HttpClient client;
        


        public IntegrationTest(ApiWebApplicationFactory fixture)
        {
            this.factory = fixture;
            this.client = factory.CreateClient();
        }
    }
}
