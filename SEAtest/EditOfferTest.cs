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
   public class EditOfferTest : SEAtest
    {
       
  //*********************Test case: with Calculate Budget by Dollar $ (Enter Edit Mode View)

        [TestMethod]
        public void Edit_Offer()
        {
            //*****************Add New Offer View******************
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
            //*****************Marketing Information View******************
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
            //*****************Edit Offer View******************
            EditOffer.EnterEditMode();
            Assert.IsTrue(EditOffer.IsEditOferView, "Failed to Edit Offer");
            Elements.Delay(5000);
            EditOffer.EditOfferDescription();
            Elements.Delay(5000);
            Assert.IsTrue(EditOffer.IsEditOferDescription(), "Failed to edit offer description");
            Elements.Delay(3000);
            Assert.IsTrue(EditOffer.NotLockOfferDescription(), "Error: Offer Description field is enabled");
            Elements.Delay(3000);
            EditOffer.EditDropDate();
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockOfferCode(), "Error: Offer Code field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockGS1PrefixDescription(), "Error: GS1 Prefix Description field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockGS1Prefix(), "Error: GS1 Prefix  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockFaceValue(), "Error: Face Value  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockAutoAssign(), "Error: Face Value  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockFreeOffer(), "Error: Free Offer  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockMinimun(), "Error: Minimun  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockMaximun(), "Error: Maximun  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockPurchaseRequirements(), "Error: PurchaseRequirements  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockFamilyCode(), "Error: FamilyCode  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockFamilyCodeDescription(), "Error: familyCodeDescription  field is not enabled");
            Elements.Delay(3000);
            Assert.IsFalse(EditOffer.LockNoExpirationDate(), "Error: NoExpirationDate  field is not enabled");
            EditOffer.SaveChanges();

        }

    }
}
