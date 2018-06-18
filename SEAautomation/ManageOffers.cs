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
   public class ManageOffers
    {
        public static bool IsManageOffers
        {
             get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/div/div[2]/h3");
            }
        }

        public static void SearchOffers()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[1]/a/span");
            Elements.SendKeysByXPath("//*[@id='simple-search-modal']/div/div/div[2]/div[1]/div/input", "040316");
            Elements.ClickElementByXPath("//*[@id='simple-search-modal']/div/div/div[3]/button");
        }


        public static void FlagForFollowUp()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[2]/a");
        }
    }
}
