using System;
using Newtonsoft.Json;
using Swagger_Petstore_API_autotests.POCO.Request.SubPOCO;

namespace Swagger_Petstore_API_autotests.POCO.Request
{
	public class AddNewPetRequest
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

        public AddNewPetRequest(
            int id,
            Category category,
            string name,
            string[] photoUrls,
            Tags[] tags,
            string status)
        {
            this.ID = id;
            this.Category = category;
            this.Name = name;
            this.PhotoUrls = photoUrls;
            this.Tags = tags;
            this.Status = status;
        }
    }
}

