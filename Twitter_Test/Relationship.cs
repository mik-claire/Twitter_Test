using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test
{
    public class Relationship
    {
        public string name { get; set; }
        public string screen_name { get; set; }
        public long id { get; set; }
        public string id_str { get; set; }
        public List<string> connections { get; set; }
    }
}
