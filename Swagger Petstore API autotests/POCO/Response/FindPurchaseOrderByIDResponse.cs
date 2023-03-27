using System;
using Newtonsoft.Json;

namespace Swagger_Petstore_API_autotests.POCO.Response
{
	public class FindPurchaseOrderByIDResponse
	{
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("petId")]
        public int PetID { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("shipDate")]
        public string ShipDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }
    }
}

