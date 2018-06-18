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
    public class ReportsTest : SEAtest
    {

        [TestMethod]
        public void Reports_tab()
        {
            NavigateTabs.GoToReports();
            Assert.IsTrue(NavigateTabs.IsReports, "Failed to Reports ");
        }
    }
}
