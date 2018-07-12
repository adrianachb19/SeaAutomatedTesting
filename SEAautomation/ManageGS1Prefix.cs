using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SEAautomation;
using SeaCoupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SEAautomation
{
    public class ManageGS1Prefix
    {

        public static void SelectClient()
        {
            Elements.Delay(5000);
            Elements.RefreshPage();
            Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/a");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/ul/li[2]/a");
        }

        public static void GoTo_ManageGs1Prefixes()
        {
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/ul/li[7]/a");
        }

        public static bool IsManageGS1Prefix
        {
             get
           {
               return Elements.ElementDisplayedByXPath(
                   "/html/body/sea-app/offer-landing/tabs/tab[7]/div/gs1code-manager/div/div[1]/div/h3");
           } 
        }

        public static void AddNewGS1Prefix()
        {
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[7]/div/gs1code-manager/div/div[2]/div/a");
        }

        public static bool IsAddNewGS1Prefix
        {
              get
           {
               return Elements.ElementDisplayedCssSelector(
                   "body > bs-modal.fade.modal.in > div > div > bs-modal-header > div > h4");
           } 
        }

        public static void Prefix(string prefix)
        {
            Elements.Delay(3000);
            Elements.SendKeysByXPath("/html/body/bs-modal[5]/div/div/bs-modal-body/div/form/div/div[2]", prefix);
        }

        public static bool IsPrefix(string b)
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("xPath"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == b; 
        }
    }
}
