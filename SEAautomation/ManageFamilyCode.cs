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



       public static void GoToManageCode()
       {
           Elements.Delay(3000);
           Elements.ClickElementByCssSelector("body > sea-app > offer-landing > tabs > ul > li:nth-child(6) > a");




       }

       public static bool IsManageFamilyCode
       {
           get
           {
               return Elements.ElementDisplayedCssSelector(
                   "body > sea-app > offer-landing > tabs > tab:nth-child(7) > div > family-code-manager > div > div:nth-child(1) > div > h3 ");
           }       
       
       }

       public static void AddNewFamilyCode()
       {
           Elements.Delay(5000);
           Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[6]/div/family-code-manager/div/div[2]/div/a");
       }

       public static bool IsAddNewFamilyCode
       {
           get
           {
               return Elements.ElementDisplayedCssSelector(
                   "body > bs-modal.fade.modal.in > div > div > bs-modal-header > div > h4");
           }
       }
    }
}
