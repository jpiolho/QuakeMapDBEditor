using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuakeMapDBEditor.Models
{
    public class Episode
    {
        public string Name { get; set; }
        [JsonPropertyName("dir")]
        public string Directory { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool NeedsSkillSelect { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Map { get; set; } = null;

        public override string ToString() => $"{Name} ({Directory})";
    }
}
