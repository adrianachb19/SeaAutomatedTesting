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
   public class ManageFamilyCode
    {

       public static void SelectClient()
       {
           Elements.Delay(5000);
           Elements.RefreshPage();
           Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/a");
           Elements.Delay(3000);
           Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/ul/li[2]/a");
       }



       public static void GoToManageFamilyCode()
       {
           Elements.Delay(3000);
           Elements.ClickElementByCssSelector("body > sea-app > offer-landing > tabs > ul > li:nth-child(5) > a");




       }

       public static bool IsManageFamilyCode
       {
           get
           {
               return Elements.ElementDisplayedCssSelector(
                   "body > sea-app > offer-landing > tabs > tab:nth-child(6) > div > family-code-manager > div > div:nth-child(1) > div > h3");
           }       
       
       }

       public static void AddNewFamilyCode()
       {
           Elements.Delay(5000);
           Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[5]/div/family-code-manager/div/div[2]/div/a");
           Elements.Delay(5000);
       }

       public static bool IsAddNewFamilyCode
       {
           get
           {
               return Elements.ElementDisplayedCssSelector(
                   "body > bs-modal.fade.modal.in > div > div > bs-modal-header > div > h4");
           }
       }



       public static void SelectGS1Prefix()
       {
           Elements.Delay(3000);
           Elements.ClickElementByXPath("//*[@id='gs1codeDropdownButton']");
           Elements.Delay(3000);
           Elements.ClickElementByXPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/div/div[1]/div/div/ul/li[1]/a");
           Elements.FindButton();
       }



       public static bool IsSelectGSIPrefix()
       {
           var findTag = Driver.Instance.FindElements(By.TagName("button"));
           var a = findTag[31].Text;
           Console.WriteLine(a);
           return a == "000000000000";
       }


       public static bool IsGs1PrefixDescription()
       {
           return Elements.ElementEnabledByXPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/div/div[2]/input");

       }

       public static void FamilyCode(string familyCode)
       {
           Elements.Delay(3000);
           Elements.SendKeysByXPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/form/div/div[1]/input", familyCode);
       }

       public static bool IsFamilyCode(string a)
       {
           IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/form/div/div[1]/input"));
           string getValue = TargetElement.GetAttribute("value");
           Console.WriteLine(getValue);
           return getValue == a; // texto que debe mostrar
       }

       public static void Description(string description)
       {
           Elements.Delay(3000);
           Elements.SendKeysByXPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/form/div/div[2]/input", description);
       }

       public static bool IsDescription()
       {
           IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/form/div/div[2]/input"));
           string getValue = TargetElement.GetAttribute("value");
           Console.WriteLine(getValue);
           return getValue == "test"; // texto que debe mostrar
       }

       public static void ButtonOk()
       {
           Elements.Delay(3000);
           Elements.ClickElementByXPath("/html/body/bs-modal[2]/div/div/bs-modal-footer/div/div/button[2]");
       }


       public static void NumberFamilyCode()
       {
           Elements.Delay(3000);
           Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[6]/div/family-code-manager/div/div[3]/div/table/tbody/tr[5]/td[2]/a");
       }

       public static bool DisabledButtonOk()
       {
           return Elements.ElementEnabledByXPath("/html/body/bs-modal[2]/div/div/bs-modal-footer/div/div/button[2]");
       }
    }
}
