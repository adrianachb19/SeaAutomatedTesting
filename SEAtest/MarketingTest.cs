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
    public class MarketingTest: SEAtest
    {

//*********************Test case: with Calculate Budget by % (Return to Manage Offers View)
        [TestMethod]
        public void NewOffer_MarketingInformation()
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
               Assert.IsTrue(MarketingInformation.IsMarketingInformation, "Failed to Marketing Information");
               Elements.Delay(5000);
               MarketingInformation.Distribution();
               Elements.Delay(5000);
               Assert.IsTrue(MarketingInformation.IsDistribution(), "Failed to Distribution#");
               MarketingInformation.BudgetPercentage();
               Elements.Delay(5000);
               MarketingInformation.EnterBudget();
               Elements.Delay(5000);
               Assert.IsTrue(MarketingInformation.IsEnterBudget(), "Failed to Enter Budget %");
               MarketingInformation.CreativeCost();
               Elements.Delay(5000);
               Assert.IsTrue(MarketingInformation.IsCreativeCost(), "Failed to Creative Cost");
               MarketingInformation.PrintCost();
               Elements.Delay(5000);
               Assert.IsTrue(MarketingInformation.IsPrintCost(), "Failed to Print Cost");
               MarketingInformation.DistributionMethod();
               Elements.Delay(5000);
               //Assert.IsTrue(MarketingInformation.IsDistributionMethod(), "Failed to Distribution Method");
               MarketingInformation.EventDescription();
               Elements.Delay(5000);
               Assert.IsTrue(MarketingInformation.IsEventDescription(), "Failed to EventDescription");
               MarketingInformation.MediaType();
               Elements.Delay(5000);
               Assert.IsTrue(MarketingInformation.IsMediaType(), "Failed to MediaType");
               Elements.Delay(10000);
               MarketingInformation.Save();
               MarketingInformation.ReturnToManageOffers();
               Assert.IsTrue(MarketingInformation.IsManageOffer, "Failed to Manage Offer");

        }

 //*********************Test case: with Calculate Budget by Dollar $ (Return to Manage Offers View)

        [TestMethod]
        public void NewOffer_MarketingInformation2()
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
            Assert.IsTrue(MarketingInformation.IsMarketingInformation, "Failed to Marketing Information");
            Elements.Delay(5000);
            MarketingInformation.Distribution();
            Elements.Delay(5000);
            Assert.IsTrue(MarketingInformation.IsDistribution(), "Failed to Distribution#");
            MarketingInformation.BudgetDollar();
            Elements.Delay(5000);
            MarketingInformation.EnterBudgetDollar();
            Elements.Delay(5000);
            Assert.IsTrue(MarketingInformation.IsEnterBudgetDollar(), "Failed to Enter Budget $");
            MarketingInformation.CreativeCost();
            Elements.Delay(5000);
            Assert.IsTrue(MarketingInformation.IsCreativeCost(), "Failed to Creative Cost");
            MarketingInformation.PrintCost();
            Elements.Delay(5000);
            Assert.IsTrue(MarketingInformation.IsPrintCost(), "Failed to Print Cost");
            MarketingInformation.DistributionMethod();
            Elements.Delay(5000);
            //Assert.IsTrue(MarketingInformation.IsDistributionMethod(), "Failed to Distribution Method");
            MarketingInformation.EventDescription();
            Elements.Delay(5000);
            Assert.IsTrue(MarketingInformation.IsEventDescription(), "Failed to EventDescription");
            MarketingInformation.MediaType();
            Elements.Delay(5000);
            Assert.IsTrue(MarketingInformation.IsMediaType(), "Failed to MediaType");
            Elements.Delay(10000);
            MarketingInformation.Save();
            MarketingInformation.ReturnToManageOffers();
            Assert.IsTrue(MarketingInformation.IsManageOffer, "Failed to Manage Offer");

        }

    }
}
