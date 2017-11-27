using FashionWebStoreApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FashionWebStoreAppIntegrationTests
{
    public class FashionStoreTests
    {
        private readonly HttpClient Client;
        private readonly TestServer Server;

        public FashionStoreTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await Client.GetAsync("/warehouse");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusApi()
        {
            var response = await Client.GetAsync("/warehouse/query?price=50&type=lower");

            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}