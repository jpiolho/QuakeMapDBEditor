using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuakeMapDBEditor.Models
{
    public class MapDatabase
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();
        public List<Map> Maps { get; set; } = new List<Map>();
    }
}
