using OpenQA.Selenium;
using SeaCoupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SEAautomation
{
    public class NavigateTabs
    {
        public static void GoToInvoice()
        {
           var invoiceSearch = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-landing/tabs/ul/li[2]/a"));
           invoiceSearch.Click();

           Thread.Sleep(3000);
        }

        public static bool IsInvoice
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[2]/div/invoice-search/invoice-table/div/div[2]/table/thead/tr/th[2]/mfdefaultsorter/a/span");
            }
        }

        public static void GoToReports()
        {

           var reports = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-landing/tabs/ul/li[3]/a"));
           reports.Click();

           Thread.Sleep(3000);
        }

        public static bool IsReports
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[3]/div/activity-report/div/div[1]/div[2]/div/a[1]");
            }
        }

        public static void GoToPromoCalendar()
        {
           var promoCalendar = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-landing/tabs/ul/li[4]/a"));
           promoCalendar.Click();

           Thread.Sleep(3000);
        }

        public static bool IsPromoCalendar
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[4]/div/promotion-calendar/promotion-calendar-table/div/div/table/thead/tr/th[2]/mfdefaultsorter/a/span");
            }
        }

        public static void GoToManageOffers()
        {
           var manageOffers = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-landing/tabs/ul/li[1]/a"));
           manageOffers.Click();

           Thread.Sleep(3000);
        }

        public static bool IsManageOffers
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[2]/div/table/thead/tr/td[2]/mfdefaultsorter/a/span");
            }
        }

        public static void GoToSearchOffers()
        {
           var searchOffers = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[1]/a/span"));
           searchOffers.Click();

           Thread.Sleep(3000);
        }

        public static bool IsSearchOffers
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/summary-table/div/div[1]/div[1]/div[1]/a/span");
            }
        }

        public static void Close()
        {
           var close = Driver.Instance.FindElement(By.CssSelector("#simple-search-modal > div > div > div.modal-header > button"));
           close.Click();

           Thread.Sleep(3000);
        }

        public static void GoToAddOffer()
        {
           var addOffer = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-landing/tabs/tab[1]/div/offer-search/div/div/div[3]/a"));
           addOffer.Click();
        }

        public static bool IsAddNewOffer
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-create/div/form/div[1]/div[2]/div/label");
            }
        }
           
           
        }
    }

