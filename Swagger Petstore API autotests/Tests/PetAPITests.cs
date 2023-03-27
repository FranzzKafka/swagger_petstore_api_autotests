using System;
using System.Net;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using RestSharp;
using Swagger_Petstore_API_autotests.POCO.Request;
using Swagger_Petstore_API_autotests.POCO.Response;
using Swagger_Petstore_API_autotests.Tests.BaseTestSetUp;

namespace Swagger_Petstore_API_autotests.Tests
{
	[TestFixture]
    [AllureNUnit]
    [AllureSuite("Pet API tests")]
    public class PetAPITests : BaseSetUp
    {
        [Test]
        [Description("Find pet by ID")]
        public async Task FindPetByIdTest()
        {
            RestRequest request = new RestRequest("/pet/0", Method.Get);

            FindPetByIdResponse response = await Client.GetAsync<FindPetByIdResponse>(request);

            string expectedDogStatus = "available";

            Assert.That(response.Name, Is.Not.Null);
            Assert.That(response.Status, Is.EqualTo(expectedDogStatus));
        }

        [Test]
        [Description("Add a new pet to the store")]
        public async Task AddNewPetTest()
        {
            const int newDogId = 1000;
            const int newDogTagId = 1;
            const int newDogCategoryId = 1;

            RestRequest request = new RestRequest("/pet", Method.Post)
                .AddJsonBody(new AddNewPetRequest(
                    newDogId,
                    new POCO.Request.SubPOCO.Category(newDogCategoryId, "dog"),
                    "Lassy",
                    new[] { "photoUrl"},
                    new[] { new POCO.Request.SubPOCO.Tags(newDogTagId, "dog") },
                    "available"));

            RestResponse response = await Client.PostAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        [Description("Delete a pet")]
        public async Task DeletePetTest()
        {
            RestRequest request = new RestRequest("/pet/1000", Method.Delete)
                .AddHeader("api_key", "special-key");

            RestResponse response =  await Client.DeleteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}

