using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GitHubAuth
{
    class Repository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }



        [JsonPropertyName("html_url")]
        public Uri GitHubHomeUrl { get; set; }



        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }
    }
}
