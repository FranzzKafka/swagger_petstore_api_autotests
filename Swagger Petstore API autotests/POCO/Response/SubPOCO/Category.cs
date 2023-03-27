using System;
using Newtonsoft.Json;

namespace Swagger_Petstore_API_autotests.POCO.Response
{
	public class Category
	{
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

