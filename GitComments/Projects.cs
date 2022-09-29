using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace GitComments
{
    class Projects
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }
        [JsonProperty("name")]
        public string ProjectName { get; set; }
    }
}
