using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climapi
{
    public class Tip
    {
        public string SingleTip { get; set; }
        public string Fact { get; set; }
        public List<string> Tags { get; set; }

        public Tip(string tip, string fact, List<string> tags)
        {
            SingleTip = tip;
            Fact = fact;
            Tags = tags;
        }
    }
}
