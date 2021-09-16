using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuakeMapDBEditor.Models
{
    public class Map
    {
        public string Title { get; set; }
        public string BSP { get; set; }
        public string Episode { get; set; }
        public string Game { get; set; }
        [JsonPropertyName("dm")]
        public bool Deathmatch { get; set; }
        [JsonPropertyName("coop")]
        public bool Cooperative { get; set; }
        public bool Bots { get; set; }
        [JsonPropertyName("sp")]
        public bool Singleplayer { get; set; }


        public override string ToString() => $"{BSP}: {Title}";
    }
}
