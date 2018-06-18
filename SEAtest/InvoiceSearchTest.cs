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
    public class InvoiceSearchTest : SEAtest
    {

        [TestMethod]
        public void Invoice_tab()
       {

            InvoiceSearch.SelectClient();
            InvoiceSearch.GoToInvoiceSearchTab();
            Assert.IsTrue(InvoiceSearch.IsInvoice, "Failed to Invoice");
            InvoiceSearch.SearchByInvoiceNumber("20161206");
            Assert.IsTrue(InvoiceSearch.SearchHadSome, "failed to Invoice Search number");
            InvoiceSearch.SearchByRetailerSubmitter("UKIAH NATURAL FOODS");
            Assert.IsTrue(InvoiceSearch.SearchHadSome, " Failed to Search By Retailer Submitter");
            //InvoiceSearch.SearchByRetailer();
            //InvoiceSearch.SearchByRetailerZipCode();
       
        }
    }
}
