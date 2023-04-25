using System;
using Newtonsoft.Json;

namespace Swagger_Petstore_API_autotests.POCO.Response
{
	public class UpdateExistingPetResponse
	{
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photoUrls")]
        public string[] PhotoUrls { get; set; }

        [JsonProperty("tags")]
        public Tags[] Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

