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

            TipList.Add(new Tip("Y","Y","tag"));
            TipList.Add(new Tip("X","X", "tag"));
            TipList.Add(new Tip("foo","bar", "tag"));
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

        public List<Tip> GetTipsByTag(string tag)
        {
            //write some code here to get all of the tips in the tip list that have a tag that is equal to "tag" and return that list

            throw new NotImplementedException();
        }
    }
}
