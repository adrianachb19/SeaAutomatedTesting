using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SEAautomation;
using SeaCoupon;

namespace SEAtest
{
    [TestClass]
   public class ManageTest : SEAtest
    {

        [TestMethod]
        public void Manage_Offers()
        {
            Assert.IsTrue(ManageOffers.IsManageOffers, "Failed to Manage Offers");
            ManageOffers.SearchOffers();
            ManageOffers.FlagForFollowUp();


        }

    }
}
