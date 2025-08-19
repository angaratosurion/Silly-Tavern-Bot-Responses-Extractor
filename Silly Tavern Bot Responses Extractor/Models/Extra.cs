using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silly_Tavern_Bot_Responses_Extractor.Models
{
    internal class Extra
    {
        [JsonProperty("isSmallSys")]
        public bool IsSmallSys { get; set; }

        [JsonProperty("display_text")]
        public string DisplayText { get; set; }

        [JsonProperty("reasoning")]
        public string Reasoning { get; set; }
    }
}
