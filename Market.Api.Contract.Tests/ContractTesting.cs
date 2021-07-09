using SwaggerHubValidator.Factory;
using System;
using System.Net.Http;
using Xunit;

namespace Market.Api.Contract.Tests
{
    public class ContractTesting
    {
        [Fact]
        public async void Test1()
        {
            var url = "https://app.swaggerhub.com/apiproxy/registry/pedroaz/market-api/v1?resolved=true&flatten=true&pretty=true";
            using HttpClient httpClient = new HttpClient();
            var swaggerHubResponse = await httpClient.GetAsync(url);
            var json = await swaggerHubResponse.Content.ReadAsStringAsync();

            var validator = new ValidatorFactory(json).CreateNewValidator();

            var validationResponse = 
                validator
                .Path("/Market/Products")
                .Validate();

            Assert.True(validationResponse.IsValid);
        }
    }
}
