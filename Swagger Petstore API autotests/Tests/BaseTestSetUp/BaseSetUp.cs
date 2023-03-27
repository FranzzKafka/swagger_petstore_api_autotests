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
            Client = new RestClient("https://petstore.swagger.io/v2");
        }
    }
}

