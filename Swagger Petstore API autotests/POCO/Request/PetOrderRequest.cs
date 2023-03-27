using System;
using Newtonsoft.Json;

namespace Swagger_Petstore_API_autotests.POCO.Request
{
	public class PetOrderRequest
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

        public PetOrderRequest(
            int id,
            int petId,
            int quantity,
            string shipdDate,
            string status,
            bool complete)
        {
            this.ID = id;
            this.PetID = petId;
            this.Quantity = quantity;
            this.ShipDate = shipdDate;
            this.Status = status;
            this.Complete = complete;
        }
    }
}

