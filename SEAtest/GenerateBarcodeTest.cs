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
    public class GenerateBarcodeTest : SEAtest
    {

        /******Validate that the user with the Generate Barcode button can fill the information and this will 
        be send to Symbology with all the information that was entry.******/


// File Type PDF
        [TestMethod]
        public void Generate_Barcode_PDF()
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
            AddNewOffer.OrderBarcode();
            Assert.IsTrue(GenerateBarcode.IsBarcodeOrder, "Failed to IsBarcodeOrder");
            GenerateBarcode.FileTypePDF();
            Assert.IsTrue(GenerateBarcode.IsPDF(), "Failed IsPDF");
            GenerateBarcode.EmailBarcodeTo("achacon@pernixlabs.com");
            Assert.IsTrue(GenerateBarcode.IsEmail(), "Failed to IsEmail");
            GenerateBarcode.SpecialInstructions("Test");
            Assert.IsTrue(GenerateBarcode.IsSpecialInstructions(), "Failed to IsSpecialInstructions");
            GenerateBarcode.ButtonNext();
            Elements.Delay(4000);
            Assert.IsTrue(GenerateBarcode.IsReviewAndSubmitBarcodeOrderToSymbology, "Failed to Review and Submit Barcode Order to Symbology, Inc.");
            GenerateBarcode.AcceptConditions();
            Assert.IsTrue(GenerateBarcode.IsChecked(), "Falied to IsChecked");
            GenerateBarcode.ButtonAccept();

        }

 // File Type EDF
        [TestMethod]
        public void Generate_Barcode_EPF()
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
            AddNewOffer.OrderBarcode();
            Assert.IsTrue(GenerateBarcode.IsBarcodeOrder, "Failed to IsBarcodeOrder");
            GenerateBarcode.FileTypeEPF();
            Assert.IsTrue(GenerateBarcode.IsEPF(), "Failed IsEPF");
            GenerateBarcode.EmailBarcodeTo("achacon@pernixlabs.com");
            Assert.IsTrue(GenerateBarcode.IsEmail(), "Failed to IsEmail");
            GenerateBarcode.SpecialInstructions("Test");
            Assert.IsTrue(GenerateBarcode.IsSpecialInstructions(), "Failed to IsSpecialInstructions");
            GenerateBarcode.ButtonNext();
            Assert.IsTrue(GenerateBarcode.IsReviewAndSubmitBarcodeOrderToSymbology, "Failed to Review and Submit Barcode Order to Symbology, Inc.");
            GenerateBarcode.AcceptConditions();
            Assert.IsTrue(GenerateBarcode.IsChecked(), "Falied to IsChecked");
            GenerateBarcode.ButtonAccept();

        }
        // File Type Illustrator
        [TestMethod]
        public void Generate_Barcode_Illustrator()
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
            AddNewOffer.OrderBarcode();
            Assert.IsTrue(GenerateBarcode.IsBarcodeOrder, "Failed to IsBarcodeOrder");
            GenerateBarcode.FileTypeIllustrator();
            Assert.IsTrue(GenerateBarcode.IsIllustrator(), "Failed to  IsIllustrator");
            GenerateBarcode.EmailBarcodeTo("achacon@pernixlabs.com");
            Assert.IsTrue(GenerateBarcode.IsEmail(), "Failed to IsEmail");
            GenerateBarcode.SpecialInstructions("Test");
            Assert.IsTrue(GenerateBarcode.IsSpecialInstructions(), "Failed to IsSpecialInstructions");
            GenerateBarcode.ButtonNext();
            Assert.IsTrue(GenerateBarcode.IsReviewAndSubmitBarcodeOrderToSymbology, "Failed to Review and Submit Barcode Order to Symbology, Inc.");
            GenerateBarcode.AcceptConditions();
            Assert.IsTrue(GenerateBarcode.IsChecked(), "Falied to IsChecked");
            GenerateBarcode.ButtonAccept();

        }


    }
}
