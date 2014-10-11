using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climapi
{
    public class TipsRepository
    {
      //  public List<string> TipList;

        public TipsRepository()
        {
            TipList = new List<Tip>();

            TipList.Add(new Tip("Y","Y"));
            TipList.Add(new Tip("X","X"));
            TipList.Add(new Tip("foo","bar"));
        }
        public List<Tip> TipList;

        public Tip GetRandomTip()
        {
            var RandomTip = new Random();

            return TipList.ElementAt(RandomTip.Next(0, TipList.Count));
        }


        public void AddTips(List<Tip> tipList)
        {
            TipList = tipList;
        }
    }
}
