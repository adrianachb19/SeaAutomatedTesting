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
    public class MarketingInformation
    {


        public static bool IsMarketingInformation
        {
              get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-finish/div/div[1]/div/h3");
            }
        }


        public static void Distribution()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[2]/div[5]/input", "500,000");
        }



        public static bool IsDistribution()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[2]/div[5]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "500,000";
        }


        public static void BudgetPercentage()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[3]/div[1]/div[1]/label/input");
        }

        public static void EnterBudget()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[3]/div[2]/div[1]/input", "40.00");
        }

        public static bool IsEnterBudget()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[3]/div[2]/div[1]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "40.00";
        }

        public static void BudgetDollar()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[3]/div[1]/div[2]/label/input");
        }

        public static void EnterBudgetDollar()
        {
            Elements.SendKeysByCssSelector("body > sea-app > offer-finish > div > offer-marketing-form > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div > input", "14,000.00");
        }

        public static bool IsEnterBudgetDollar()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.CssSelector("body > sea-app > offer-finish > div > offer-marketing-form > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div > input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "14,000.00";  
        }

        public static void CreativeCost()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[4]/div[1]/div/input", "999999");
        }

        public static bool IsCreativeCost()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[4]/div[1]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "999,999";  
        }

        public static void PrintCost()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[4]/div[2]/div/input", "999999");
        }

        public static bool IsPrintCost()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[4]/div[2]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "999,999"; 
        }

        public static void DistributionMethod()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[6]/div/div/button");
            Elements.ClickElementByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[6]/div/div/ul/li[6]/a");
            Elements.FindButton();
        }

        public static bool IsDistributionMethod()
        {
            var findTag = Driver.Instance.FindElements(By.TagName("button"));
            var a = findTag[1].Text;
            Console.WriteLine(a);
            return a == "HO (Handout) ";
        }

        public static void EventDescription()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[7]/div[1]/input", "Test 001");
        }

        public static bool IsEventDescription()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[7]/div[1]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "Test 001"; 
        }

        public static void MediaType()
        {
            Elements.SendKeysByXPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[7]/div[2]/input", "test 002");
        }

        public static bool IsMediaType()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-finish/div/offer-marketing-form/div[7]/div[2]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "test 002"; 
        }

        public static void Save()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-finish/div/div[2]/div[2]/button");
        }

        public static void ReturnToManageOffers()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-edit/div/div[4]/div[2]/div/div/a");
        }

        public static bool IsManageOffer
        {
               get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/div/div[2]/h3");
            }
        }

    }
}
