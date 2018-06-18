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
   public class TabsTest : SEAtest
    {
       
        [TestMethod]
        public void Navigate_tabs()
        {           
            NavigateTabs.GoToInvoice();
            Assert.IsTrue(NavigateTabs.IsInvoice, "Failed to Invoice");

            NavigateTabs.GoToReports();
            Assert.IsTrue(NavigateTabs.IsReports, "Failed to Reports ");

            NavigateTabs.GoToPromoCalendar();
            Assert.IsTrue(NavigateTabs.IsPromoCalendar, "Failed to Promo Calendar ");

            NavigateTabs.GoToManageOffers();
            Assert.IsTrue(NavigateTabs.IsManageOffers, "Failed to Manage Offers ");

            NavigateTabs.GoToSearchOffers();
            Assert.IsTrue(NavigateTabs.IsSearchOffers, "Failed to Search Offers ");
            NavigateTabs.Close();

            NavigateTabs.GoToAddOffer();
            Assert.IsTrue(NavigateTabs.IsAddNewOffer, "Failed to Search Offers ");

        }
    }
}
