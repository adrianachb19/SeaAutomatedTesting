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
    public class ManageFamilyCodeTest : SEAtest
    {

        [TestMethod]
        public void Manage_Family_Code()
        {
            ManageFamilyCode.SelectClient();
            ManageFamilyCode.GoToManageCode();
            Assert.IsTrue(ManageFamilyCode.IsManageFamilyCode, "Failed to Manage Family Code");
            ManageFamilyCode.AddNewFamilyCode();
            Assert.IsTrue(ManageFamilyCode.IsAddNewFamilyCode(), "Failed to IsAddNewFamilyCode");

        
        }
    }
}
