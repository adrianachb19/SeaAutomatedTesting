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
        public void Add_New_Family_Code()
        {
            ManageFamilyCode.SelectClient();
            ManageFamilyCode.GoToManageCode();
            Assert.IsTrue(ManageFamilyCode.IsManageFamilyCode, "Failed to Manage Family Code");
            ManageFamilyCode.AddNewFamilyCode();
            Assert.IsTrue(ManageFamilyCode.IsAddNewFamilyCode, "Failed to IsAddNewFamilyCode");
            ManageFamilyCode.SelectGS1Prefix();
            Assert.IsTrue(ManageFamilyCode.IsSelectGSIPrefix(), "Failed to IsSelectGSIPrefix");
            Assert.IsFalse(ManageFamilyCode.IsGs1PrefixDescription(), "Failed to IsGs1PrefixDescription");
            ManageFamilyCode.FamilyCode("003");
            Assert.IsTrue(ManageFamilyCode.IsFamilyCode(), "Failed to IsFamilyCode");
            ManageFamilyCode.Description("test");
            Assert.IsTrue(ManageFamilyCode.IsDescription(), "Failed to description");
            ManageFamilyCode.ButtonOk();

        }

        [TestMethod]
        public void Edit_Family_Code()
        {
            ManageFamilyCode.SelectClient();
            ManageFamilyCode.GoToManageCode();
            Assert.IsTrue(ManageFamilyCode.IsManageFamilyCode, "Failed to Manage Family Code");
            ManageFamilyCode.NumberFamilyCode();

        }



    }
}
