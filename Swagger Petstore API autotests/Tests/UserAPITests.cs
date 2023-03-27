using System;
using System.Net;
using Newtonsoft.Json.Linq;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using Swagger_Petstore_API_autotests.POCO.Request;
using Swagger_Petstore_API_autotests.POCO.Response;
using Swagger_Petstore_API_autotests.Tests.BaseTestSetUp;

namespace Swagger_Petstore_API_autotests.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("User API tests")]
    public class UserAPITests : BaseSetUp
    {
        const int UserId = 1834;
        const int UserStatus = 0;

        [Test]
        [Description("Create new user")]
        public async Task CreateNewUserTest()
        {
            RestRequest request = new RestRequest("/user", Method.Post)
                .AddJsonBody(new CreateNewUserRequest(
                    UserId,
                    "BigJohn12",
                    "John",
                    "Johnson",
                    "john12231@gmail.com",
                    "asd213_1!",
                    "88005353535",
                    UserStatus
                    ));

            RestResponse response = await Client.PostAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        [Description("Get user by username")]
        public async Task GetUserInfoByUsernameTest()
        {
            RestRequest request = new RestRequest("/user/BigJohn12", Method.Get);

            GetUserByNameResponse response = await Client.GetAsync<GetUserByNameResponse>(request);

            const string expectedFirstName = "John";
            const string expectedEmail = "john12231@gmail.com";

            Assert.That(response.FirstName, Is.EqualTo(expectedFirstName));
            Assert.That(response.Email, Is.EqualTo(expectedEmail));
        }

        [Test]
        [Description("Updated user object")]
        public async Task UpdateExistingUser()
        {
            RestRequest request = new RestRequest("/user/BigJohn12", Method.Put)
                .AddJsonBody(new UpdateUserRequest(
                    UserId,
                    "BigJohn12",
                    "John",
                    "Black",
                    "john12231@gmail.com",
                    "asd213_1!",
                    "88005353535",
                    UserStatus
                    ));

            UpdateUserResponse response = await Client.PutAsync<UpdateUserResponse>(request);

            const string expectedLastName = "Black";

            Assert.That(response.LastName, Is.EqualTo(expectedLastName));
        }
    }
}

