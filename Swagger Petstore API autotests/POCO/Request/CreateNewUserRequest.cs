using System;
using Newtonsoft.Json;

namespace Swagger_Petstore_API_autotests.POCO.Request
{
	public class CreateNewUserRequest
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

        public CreateNewUserRequest(int id, string username, string firstName, string lastName, string email, string password, string phone, int userStatus)
        {
            this.ID = id;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.UserStatus = userStatus;
        }
    }
}

