using Microsoft.VisualStudio.TestTools.UnitTesting;
using M320_SmartHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHome.Tests
{
    [TestClass()]
    public class ZimmerTests
    {
        [TestMethod()]
        public void TestHeizungsventilBei20GradNichtÖffnet()
        {
            var zimmer = new Heizungsventil(new Kueche());
            var wetterdaten = new Wetterdaten(20, 10, false);
            zimmer.VerarbeiteWetterdaten(wetterdaten);
            Assert.IsFalse(zimmer.HeizungsventilOffen);
        }

        [TestMethod]
        public void TestHeizungsventilBei19GradNichtÖffnet()
        {
            var zimmer = new Heizungsventil(new BadWC());
            var wetterdaten = new Wetterdaten(19, 10, false);
            zimmer.VerarbeiteWetterdaten(wetterdaten);
            Assert.IsFalse(zimmer.HeizungsventilOffen);
        }

        [TestMethod]
        public void TestHeizungsventilBeiMinus25GradÖffnet()
        {
            var zimmer = new Heizungsventil(new Schlafzimmer());
            var wetterdaten = new Wetterdaten(-25, 10, false);
            zimmer.VerarbeiteWetterdaten(wetterdaten);
            Assert.IsTrue(zimmer.HeizungsventilOffen);
        }

        [TestMethod()]
        public void TestHeizungsventilBei35GradNichtÖffnet()
        {
            var zimmer = new Heizungsventil(new Wohnzimmer());
            var wetterdaten = new Wetterdaten(35, 10, false);
            zimmer.VerarbeiteWetterdaten(wetterdaten);
            Assert.IsFalse(zimmer.HeizungsventilOffen);
        }
    }
}