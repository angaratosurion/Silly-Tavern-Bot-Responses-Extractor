using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silly_Tavern_Bot_Responses_Extractor.Models
{
    internal class ChatMetadata
    {
        [JsonProperty("integrity")]
        public string Integrity { get; set; }

        [JsonProperty("chat_id_hash")]
        public long ChatIdHash { get; set; }

        [JsonProperty("note_prompt")]
        public string NotePrompt { get; set; }

        [JsonProperty("note_interval")]
        public int NoteInterval { get; set; }

        [JsonProperty("note_position")]
        public int NotePosition { get; set; }

        [JsonProperty("note_depth")]
        public int NoteDepth { get; set; }

        [JsonProperty("note_role")]
        public int NoteRole { get; set; }

        [JsonProperty("tainted")]
        public bool Tainted { get; set; }

        [JsonProperty("timedWorldInfo")]
        public TimedWorldInfo TimedWorldInfo { get; set; }
    }
}
