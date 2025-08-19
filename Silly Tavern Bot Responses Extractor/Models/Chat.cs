using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silly_Tavern_Bot_Responses_Extractor.Models
{
    internal class Chat
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("character_name")]
        public string CharacterName { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("chat_metadata")]
        public ChatMetadata ChatMetadata { get; set; }
    }
}
