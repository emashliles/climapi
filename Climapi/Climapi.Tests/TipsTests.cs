using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Climapi;

namespace Climapi.Tests
{
    [TestFixture]
    public class TipsTests
    {

        private List<string> _tips;

        [SetUp]
        public void SetUp()
        {
            _tips = new List<string>();

          //  _tips.Add("Don't drive an SUV");
            _tips.Add("Help Pandas");
            _tips.Add("Walk don't drive");
        }

        [Test]
        public void Can_Retrun_a_random_tip()
        {
            //given
            TipsRepository tips = new TipsRepository();

            tips.AddTips(_tips);

            //when

            var returnedTip = tips.GetRandomTip();

            //then
            Assert.That(_tips.Contains(returnedTip), Is.True);
        }

        [Test]
        public void Tips_Can_be_added_to_repository()
        {
            //given
            TipsRepository tips = new TipsRepository();

            tips.AddTips(_tips);
            //when
            var numberOfTips = tips.TipList.Count();
            //then

            Assert.That(numberOfTips, Is.GreaterThan(0));
        }

    }
}
