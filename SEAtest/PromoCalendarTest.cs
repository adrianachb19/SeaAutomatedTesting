using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SEAautomation;
using SeaCoupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAtest
{
    [TestClass]
    public class PromoCalendarTest : SEAtest
    {

        [TestMethod]
        public void PromoCalendar_tab()
        {
            NavigateTabs.GoToPromoCalendar();
            Assert.IsTrue(NavigateTabs.IsPromoCalendar, "Failed to Promo Calendar ");
        }
    }
}
