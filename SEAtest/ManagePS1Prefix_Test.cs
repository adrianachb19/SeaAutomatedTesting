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
     public class ManagePS1Prefix_Test: SEAtest
    {

        [TestMethod]         
         public void Add_New_GS1_Prefix()
         {
             ManageGS1Prefix.SelectClient();
             ManageGS1Prefix.GoTo_ManageGs1Prefixes();
             Assert.IsTrue(ManageGS1Prefix.IsManageGS1Prefix, "Failed to IsManageGS1Prefix");
             ManageGS1Prefix.AddNewGS1Prefix();
             Assert.IsTrue(ManageGS1Prefix.IsAddNewGS1Prefix, "Failed IsAddNewGS1Prefix");
             ManageGS1Prefix.Prefix("000000000004");
             Assert.IsTrue(ManageGS1Prefix.IsPrefix("000000000004"), "Failed to IsPrefix ");


         }

        
    }
}
