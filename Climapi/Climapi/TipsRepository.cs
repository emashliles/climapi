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
            var tags = new List<string>();

            tags.Add("home");

            var tags2 = new List<string>();

            tags2.Add("leisure");

            var tags3 = new List<string>();

            tags3.Add("work");


            TipList = new List<Tip>();

            TipList.Add(new Tip("Consider making a donation", "Personal cars and trucks in the United States emit 20 percent of the United States' carbon emissions.", tags));
            TipList.Add(new Tip("Keep stuff out of landfills by composting kitchen scraps and garden trimmings, and recycling paper, plastic, metal and glass.","There is more carbon dioxide in the atmosphere today than at any point in the last 800,000 years.", tags2));
            TipList.Add(new Tip("Consider greener options such as buses or trains, or try vacationing closer to home. You can also stay in touch with people by videoconferencing", "Personal cars and trucks in the United States emit 20 percent of the United States' carbon emissions", tags3));
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
            //write some code here to get all of the tips in the tip list that have a tag that is equal to 
            //"tag" and return that list

            var result = TipList.FindAll(tip => tip.Tags.Contains(tag));

            return result;
        }
    }
}
