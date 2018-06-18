using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SEAautomation;
using SeaCoupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaCoupon
{
    public class OfferSearch
    {

        public static void SelectClient()
        {
            Elements.RefreshPage();
            Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/a");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/ul/li[2]/a");
        }

        public static void ShowFlagForFollowUp()
        {
            //shows the Pending offers
            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[2]/a");
        }

        //shows the Watchlisted offers.
        public static void ShowWatchList()
        {
            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[3]/a");
        }

        public static void Search(string offerCode, string brand, string mediaType,
            string division, string marketArea, string prodCateg)
        {

            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[1]/a");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='offerCodeInput']", offerCode);

            Elements.SendKeysByXPath("//input[@name='brandInput']", brand);

            Elements.SendKeysByXPath("//input[@name='mediaTypeInput']", mediaType);

            Elements.SendKeysByXPath("//input[@name='divisionInput']", division);

            Elements.SendKeysByXPath("//input[@name='marktetAreaFilter']", marketArea);

            Elements.SendKeysByXPath("//input[@name='productCategoryInput']", prodCateg);
        }

        //public static void SearchInRange(string startDate, string endDate)
        //{
        //    Elements.SendKeysByXPath("//*[@id='simple-search-modal']/div/div/div[2]/div[7]/div[1]/ng-datepicker/div/input", startDate);

        //    Elements.SendKeysByXPath("//*[@id='simple-search-modal']/div/div/div[2]/div[7]/div[2]/ng-datepicker/div/input", endDate);
        //}

        public static bool SearchHadSome
        {
            get
            {
                try
                {
                    Elements.ElementDisplayedByXPath("//table[@ng-reflect-input-data='[object Object]']");
                }
                catch (NoSuchElementException e)
                {
                    return false;
                }
                return true;

            }

        }


        public static void Download()
        {
            Elements.ClickElementByXPath("//a[@tooltip='Download summary to Excel']");
        }


        public static void GoToOfferSearchTab()
        {
            //Go to the tab offer Entry
            Elements.ClickElementByLinkText("Offer Search");
        }

        public static void SearchByOfferCode(string offerCode)
        {
            Elements.Delay(5000);

            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[1]/a");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='offerCodeInput']", offerCode);

            //Click Submit button
            Elements.ClickElementByCssSelector("#simple-search-modal > div > div > div.modal-footer > button");
        }

        public static void SearchByBrand(string brand)
        {

            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand advanced filter search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='brandInput']", brand);

            //Click Submit button
            Elements.ClickElementByCssSelector("#simple-search-modal > div > div > div.modal-footer > button");
        }

        public static void SearchByMediaType(string mediaType)
        {

            Elements.Delay(5000);

            Elements.ClickElementByXPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[1]/a");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='mediaTypeInput']", mediaType);

            //Click Submit button
            Elements.ClickElementByCssSelector("#simple-search-modal > div > div > div.modal-footer > button");
        }

        public static void SearchByDivision(string division)
        {

            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand advanced filter search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='divisionInput']", division);

            //Click Submit button
            Elements.ClickElementByCssSelector("#simple-search-modal > div > div > div.modal-footer > button");
        
        }


        public static void SearchByMarketArea(string marketArea)
        {

            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand advanced filter search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='marktetAreaFilter']", marketArea);

            //Click Submit button
            Elements.ClickElementByCssSelector("#simple-search-modal > div > div > div.modal-footer > button");

        }

        public static void SearchByProductCategory(string productCategory)
        {

            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand advanced filter search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='productCategoryInput']", productCategory);

            //Click Submit button
            Elements.ClickElementByCssSelector("#simple-search-modal > div > div > div.modal-footer > button");
        }

        public static void SearchByRangeOfDates(string startDate, string endDate)
        {

            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand advanced filter search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//div[@id='simple-search-modal']/div/div/div[2]/div[7]/div/ng2-datepicker/div/div/input", startDate);

            Elements.SendKeysByXPath("//div[@id='simple-search-modal']/div/div/div[2]/div[7]/div[2]/ng2-datepicker/div/div/input", endDate);

            //Click Submit button
            Elements.ClickElementByCssSelector("#simple-search-modal > div > div > div.modal-footer > button");
        }

        
    }

}
