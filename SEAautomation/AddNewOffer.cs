using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeaCoupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAautomation
{
   public class AddNewOffer
    {
       
        public static void GoTo()
        {
           var addOffer = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/div/div[3]/a"));
           addOffer.Click();
            
        }

        public static bool IsAddNewOffer
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-create/div/div[1]/div/h3");
            }
        }


        public static void GS1Prefix()
        {
            Elements.ClickElementById("gs1codeDropdownButton");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[1]/div[1]/div/div/ul/li[2]/a");
            
        }

        public static bool IsGS1Prefix()
        {
            var findTag = Driver.Instance.FindElements(By.TagName("button"));
            var a = findTag[3].Text;
            Console.WriteLine(a);
            return a == "000000000002";
        }


        public static void AutoAssign()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[2]/div[3]/button");
            Elements.Delay(3000);
           
        }
        public static bool IsAutoAssign()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[2]/div[1]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "040137";
        }

        public static void OfferCode()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[2]/div[1]/input", "456787");     
        }

        public static bool IsOfferCode()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[2]/div[1]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "456789";
        }

        public static void OfferDescription()
        {
           Elements.SendKeysByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[2]/div[4]/input","Tester");
        }

        public static bool IsOfferDescription()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[2]/div[4]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "Tester";
        }

        public static void FamilyyCode()
        {
            Elements.ClickElementById("FamilyCodeDropdownButton");
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[4]/div[1]/div/ul/li/a");
        }

        public static bool IsFamilyCode()
        {
            var findTag = Driver.Instance.FindElements(By.TagName("button"));
            var a = findTag[5].Text;
            Console.WriteLine(a);
            return a == "000";
        }

        public static void FreeOffer()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[3]/div[2]/div/label/input");
        }

        public static void Minimun()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[3]/div[3]/div/input", "15.00");
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[5]/div/div/bs-modal-footer/div/div/a[2]");
            
        }


        public static bool IsMinimun()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[3]/div[3]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "15.00";
        }

        public static void Maximun()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[3]/div[4]/div/input", "30.00");
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[6]/div/div/bs-modal-footer/div/div/a[2]");

        }

        public static bool IsMaximun()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[3]/div[4]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "30.00";
        }

        public static void PurchaseRequirements()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[3]/div[6]/input", "01");
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[7]/div/div/bs-modal-footer/div/div/a[2]");
        }

        public static bool IsPurchaseRequirements()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[3]/div[6]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "01";
        }
        public static void Date_Drop_Expiration()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]/div[1]/div/my-date-picker/div/div/div/button/span");
            Elements.Delay(4000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]/div[1]/div/my-date-picker/div/div[2]/table[2]/tbody/tr[4]/td[4]/div/span");
            Elements.Delay(2000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]/div[2]/div/my-date-picker/div/div/div/button/span");
            Elements.Delay(4000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]/div[2]/div/my-date-picker/div/div[2]/table[2]/tbody/tr[5]/td[6]/div/span");
            
            
        }
        public static bool IsDropDate()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-create/div/main-offer-form/form/div[5]/div[1]/div/ng-datepicker/div/div/div[2]/div[2]/span[27]"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "25";
        }

        public static void SaveOffer()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/div[2]/div[1]/button");
        }



        public static void OrderBarcode()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-create/div/div[3]/div[2]/button");
        }
    }
}
