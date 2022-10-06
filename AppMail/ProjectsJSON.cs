using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace AppMail
{
    class ProjectsJSON
    {

      [JsonPropertyName("expand")]
            public string Expand { get; set; }

            [JsonPropertyName("self")]
            public string Self { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("projectTypeKey")]
            public string ProjectTypeKey { get; set; }

            [JsonPropertyName("simplified")]
            public bool Simplified { get; set; }

            [JsonPropertyName("style")]
            public string Style { get; set; }

            [JsonPropertyName("isPrivate")]
            public bool IsPrivate { get; set; }

            [JsonPropertyName("entityId")]
            public string EntityId { get; set; }

            [JsonPropertyName("uuid")]
            public string Uuid { get; set; }
        






    }
}
