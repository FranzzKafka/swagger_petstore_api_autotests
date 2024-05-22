using System;
using RestSharp;

namespace Swagger_Petstore_API_autotests.Tests.BaseTestSetUp
{
	public class BaseSetUp
	{
        public RestClient Client;

        [SetUp]
        public void SetUp()
        {
            string baseUrl = Environment.GetEnvironmentVariable("BaseUrl") ?? "Default String";
            Client = new RestClient(baseUrl);
        }
    }
}

