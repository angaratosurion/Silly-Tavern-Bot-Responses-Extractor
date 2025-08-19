using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silly_Tavern_Bot_Responses_Extractor.Models
{
   public class Message
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_user")]
        public bool IsUser { get; set; }

        [JsonProperty("is_system")]
        public bool IsSystem { get; set; }

        [JsonProperty("send_date")]
        public string SendDate { get; set; }

        [JsonProperty("mes")]
        public string Mes { get; set; }

        [JsonProperty("extra")]
        public Extra Extra { get; set; }

        [JsonProperty("force_avatar")]
        public string ForceAvatar { get; set; }
    }
}
