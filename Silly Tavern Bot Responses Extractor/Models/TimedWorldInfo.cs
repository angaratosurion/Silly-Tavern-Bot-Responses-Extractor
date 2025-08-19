using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silly_Tavern_Bot_Responses_Extractor.Models
{
   public class TimedWorldInfo
    {
        [JsonProperty("sticky")]
        public Dictionary<string, object> Sticky { get; set; }

        [JsonProperty("cooldown")]
        public Dictionary<string, object> Cooldown { get; set; }
    }
}
