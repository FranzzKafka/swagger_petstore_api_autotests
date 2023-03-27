using System;
using Newtonsoft.Json;

namespace Swagger_Petstore_API_autotests.POCO.Response
{
	public class GetUserByNameResponse
	{
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("userStatus")]
        public int UserStatus { get; set; }
    }
}

