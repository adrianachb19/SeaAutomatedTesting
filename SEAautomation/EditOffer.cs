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
     public class EditOffer
    {


        public static void EnterEditMode()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-edit/div/div[4]/div[2]/div/div/button");
        }

        public static bool IsEditOferView
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-edit/div/div[1]/div/h3");
            }

        }


        public static void EditOfferDescription()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[2]/div[4]/input", "EDITED");
        }

        public static bool IsEditOferDescription()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[2]/div[4]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "EDITED";
        }

        public static bool Bloqueda()
        {
                 IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[1]/div[2]/div/input"));
                 string getValue = TargetElement.GetAttribute("value");
                 Console.WriteLine(getValue);
                 if (TargetElement.Enabled)
                     return true;
                     return false;               
        }


        public static bool LockOfferCode()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[2]/div[1]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool NotLockOfferDescription()
        {

            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[2]/div[4]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockGS1PrefixDescription()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[1]/div[2]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockGS1Prefix()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.Id("gs1codeDropdownButton"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockFaceValue()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[3]/div[1]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockAutoAssign()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[2]/div[3]/button"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockFreeOffer()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[3]/div[2]/div/label/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockMinimun()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[3]/div[3]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockMaximun()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[3]/div[4]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockPurchaseRequirements()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[3]/div[6]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockFamilyCode()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("//*[@id='FamilyCodeDropdownButton']"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockFamilyCodeDescription()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[4]/div[2]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static bool LockNoExpirationDate()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[5]/div[3]/div/label/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        public static void EditDropDate()
        {
           
            Elements.Delay(2000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[5]/div[1]/div/ng-datepicker/div");
            Elements.Delay(4000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[5]/div[1]/div/ng-datepicker/div/div/div[2]/div[2]/span[16]");
        }

        public static void SaveChanges()
        {
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-edit/div/div[4]/div[2]/div/button");
        }
    }
}
