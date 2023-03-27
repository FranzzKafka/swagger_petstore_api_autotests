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
    [AllureSuite("Store API tests")]
    public class StoreAPITests : BaseSetUp
    {
        [Test]
        [Description("Find purchase order by id")]
        public async Task FindPurchaseOrderByIDTest()
        {
            RestRequest request = new RestRequest("/store/order/1", Method.Get);

            FindPurchaseOrderByIDResponse response = await Client.GetAsync<FindPurchaseOrderByIDResponse>(request);

            const int expectedOrderId = 1;
            const string expectedOrderStatus = "placed";

            Assert.That(response.ID, Is.EqualTo(expectedOrderId));
            Assert.That(response.Status, Is.EqualTo(expectedOrderStatus));
        }

        [Test]
        [Description("Place an order for a pet")]
        public async Task PlaceOrderForPetTest()
        {
            const int orderId = 1;
            const int petId = 1;
            const int quantity = 1;

            RestRequest request = new RestRequest("/store/order", Method.Post)
                .AddJsonBody(new PetOrderRequest(
                    orderId,
                    petId,
                    quantity,
                    "2022-08-04T05:36:01.686+0000",
                    "placed",
                    true
                    ));

            PlaceOrderResponse response = await Client.PostAsync<PlaceOrderResponse>(request);

            const int expectedOrderId = 1;

            Assert.That(response.ID, Is.EqualTo(expectedOrderId));
            Assert.That(response.Complete, Is.EqualTo(true));
        }

        [Test]
        [Description("Delete purchase order by id")]
        public async Task DeletePurchaseOrderByID()
        {
            RestRequest request = new RestRequest("/store/order/1", Method.Delete);

            RestResponse response = await Client.DeleteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}

