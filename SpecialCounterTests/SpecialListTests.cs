using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecialCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCounter.Tests
{
    [TestClass()]
    public class SpecialListTests
    {
        [TestMethod()]
        public void GenerateTestusingDefaults()
        {
            SpecialList list = new SpecialList();
            Dictionary<int, string> newlist = list.Generate();
            Assert.IsTrue(newlist.Count == 100);
        }

        [TestMethod()]
        public void GenerateTestusing5andFunwithMaxof50()
        {
            SpecialList list = new SpecialList();
            list.CounterHighlights = new Dictionary<int, string>() { { 5, "Fun" } };
            list.Max = 50;
            Dictionary<int, string> newlist = list.Generate();
            Assert.IsTrue(newlist.Count == 50);
            string outstring = string.Empty;
            newlist.TryGetValue(5, out outstring);
            Assert.IsTrue(outstring == "Fun");
        }
    }
}