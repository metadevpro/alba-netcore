using alba;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Net;
using System.Net.Http;
using Xunit;
using Newtonsoft.Json.Linq;

namespace alba_test
{
    public class CalComplianceTest: IDisposable
    {
        const int Port = 5000;
        const string BASEURI = "http://localhost:5000";

        private IWebHost host;
        public CalComplianceTest()
        {
            Program.Port = Port;
            host = Program.BuildWebHost(null);
        }

        public void Dispose()
        {
            host.StopAsync();
            host.Dispose();
        }

        [Fact]
        public async void H1_Ping()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(BASEURI + "/api/ping");
            dynamic data = JObject.Parse(response.Content.ToString());

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("pong", data.msg);
        }
    }
}
