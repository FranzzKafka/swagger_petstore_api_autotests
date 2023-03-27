using System;
using Newtonsoft.Json;

namespace Swagger_Petstore_API_autotests.POCO.Request.SubPOCO
{
	public class Category
	{
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public Category(int id, string name)
		{
            this.ID = id;
            this.Name = name;
		}
	}
}

