using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppMail
{
    class UsersJSON
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("accountId")]
        public string AccountId { get; set; }

        [JsonPropertyName("accountType")]
        public string AccountType { get; set; }

        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }

    }
}
