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
     public class AddNewOfferTest : LoginTests
    {

/***************Test Case:Validate the positive entry data on the Add New Offer***************/
 // With Auto Assign Next Available Code

         [TestMethod]
         public void Add_New_Offer()
         {
              
              AddNewOffer.GoTo();
              Assert.IsTrue(AddNewOffer.IsAddNewOffer, "Failed to Test ");
              AddNewOffer.GS1Prefix();
              Assert.IsTrue(AddNewOffer.IsGS1Prefix(), "Failed to IsGS1Prefix");
              AddNewOffer.AutoAssign();
              //Assert.IsTrue(AddNewOffer.IsAutoAssign(), "Failed to IsAutoAssign");
              AddNewOffer.OfferDescription();
              Assert.IsTrue(AddNewOffer.IsOfferDescription(), "Failed to IsOfferDescription");
              AddNewOffer.FamilyyCode();
              Assert.IsTrue(AddNewOffer.IsFamilyCode(), "Failed  to IsFamilyCode");
              AddNewOffer.FreeOffer();
              AddNewOffer.Minimun();
              Assert.IsTrue(AddNewOffer.IsMinimun(), "Failed to IsMinimun");
              AddNewOffer.Maximun();
              Assert.IsTrue(AddNewOffer.IsMaximun(), "Failed to IsMaximun");
              AddNewOffer.PurchaseRequirements();
              Assert.IsTrue(AddNewOffer.IsPurchaseRequirements(), "Failed to IsPurchaseRequirements");
              Elements.Delay(10000);
              AddNewOffer.Date_Drop_Expiration();
              //Assert.IsTrue(AddNewOffer.IsDropDate(), "Failed to Drop Date");
              AddNewOffer.SaveOffer();
              
         }

// With out Auto Assign Next Available Code
         //[TestMethod]
         //public void Add_New_Offer2()
         //{

         //    AddNewOffer.GoTo();
         //    Assert.IsTrue(AddNewOffer.IsAddNewOffer, "Failed to Test ");
         //    AddNewOffer.GS1Prefix();
         //    Assert.IsTrue(AddNewOffer.IsGS1Prefix(), "Failed to IsGS1Prefix");
         //    AddNewOffer.OfferCode();
         //    //Assert.IsTrue(AddNewOffer.IsOfferCode(), "Failed to IsOfferCode");
         //    AddNewOffer.OfferDescription();
         //    Assert.IsTrue(AddNewOffer.IsOfferDescription(), "Failed to IsOfferDescription");
         //    AddNewOffer.FamilyyCode();
         //    Assert.IsTrue(AddNewOffer.IsFamilyCode(), "Failed  to IsFamilyCode");
         //    AddNewOffer.FreeOffer();
         //    AddNewOffer.Minimun();
         //    Assert.IsTrue(AddNewOffer.IsMinimun(), "Failed to IsMinimun");
         //    AddNewOffer.Maximun();
         //    Assert.IsTrue(AddNewOffer.IsMaximun(), "Failed to IsMaximun");
         //    AddNewOffer.PurchaseRequirements();
         //    Assert.IsTrue(AddNewOffer.IsPurchaseRequirements(), "Failed to IsPurchaseRequirements");
         //    Elements.Delay(10000);
         //    AddNewOffer.Date_Drop_Expiration();
         //    //Assert.IsTrue(AddNewOffer.IsDropDate(), "Failed to Drop Date");
         //    AddNewOffer.SaveOffer();
            
         //}
    }
}
