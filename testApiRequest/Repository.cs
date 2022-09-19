using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace testApiRequest
{
   public class Repository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

      

        [JsonPropertyName("html_url")]
        public Uri GitHubHomeUrl { get; set; }

      

        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }

    }
}
