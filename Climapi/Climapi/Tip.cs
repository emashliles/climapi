using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climapi
{
    public class Tip
    {
        public string How { get; set; }
        public string Why { get; set; }
        public string Tag { get; set; }

        public Tip(string how, string why, string tag)
        {
            How = how;
            Why = why;
            Tag = tag;
        }
    }
}
