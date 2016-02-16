using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GithubRefit.Models
{
    public class RenderRequest
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }
}