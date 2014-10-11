using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climapi
{
    public class TipsRepository
    {
        public List<string> TipList;

        public string GetRandomTip()
        {
            var RandomTip = new Random();

            return TipList.ElementAt(RandomTip.Next(0, TipList.Count));
        }


        public void AddTips(List<string> tipList)
        {
            TipList = tipList;
        }
    }
}
