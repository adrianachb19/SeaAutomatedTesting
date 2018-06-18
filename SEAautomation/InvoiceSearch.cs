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
    public class InvoiceSearch
    {


        public static void SelectClient()
        {
            Elements.Delay(5000);
            Elements.RefreshPage();
            Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/a");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("//*[@id='navbar']/ul/li[2]/client-selector/div/ul/li[2]/a");
        }

        public static void GoToInvoiceSearchTab()
        {
            //Go to the tab offer Entry
            Elements.ClickElementByLinkText("Invoice Search");

            
        }


        public static bool IsInvoice
        {
            get
            {
                return Elements.ElementDisplayedByXPath(
                    "/html/body/sea-app/offer-landing/tabs/tab[2]/div/invoice-search/invoice-table/div/div[2]/table/thead/tr/th[2]/mfdefaultsorter/a/span");
            }
        }

        public static void SearchByInvoiceNumber(string InvoiceNumber)
        {
            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand to see advanced search options']");

            Elements.Delay(3000);

            Elements.SendKeysByXPath("//input[@name='invoiceNumberInput']", InvoiceNumber);

            //Click Submit button
            Elements.ClickElementByCssSelector("#advanced-search-modal > div > div > div.modal-footer > button");

        }

        public static void SearchByRetailerSubmitter(string RetailerSubmitter)
        {
            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand to see advanced search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='invoiceRetailerSubmitter']", RetailerSubmitter);

            //Click Submit button
            Elements.ClickElementByCssSelector("#advanced-search-modal > div > div > div.modal-footer > button");
        }

        public static void SearchByRetailer(string Retailer)
        {
            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand to see advanced search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='invoiceRetailer']", Retailer);

            //Click Submit button
            Elements.ClickElementByCssSelector("#advanced-search-modal > div > div > div.modal-footer > button");
        }

        public static void SearchByRetailerZipCode(string RetailerZipCode)
        {
            Elements.Delay(5000);

            Elements.ClickElementByXPath("//a[@tooltip='Expand to see advanced search options']");

            Elements.Delay(5000);

            Elements.SendKeysByXPath("//input[@name='invoiceRetailerZipCode']", RetailerZipCode);

            //Click Submit button
            Elements.ClickElementByCssSelector("#advanced-search-modal > div > div > div.modal-footer > button");
        }

        public static void SearchByRangeOfDates(string StarDate, string EndDate)
        {
            Elements.Delay(5000);
            
            Elements.ClickElementByXPath("//a[@tooltip='Expand to see advanced search options']");

            Elements.Delay(5000);

            //Elements.ClickElementByXPath("//g[@id='calendar']");

            Elements.SendKeysByCssSelector("#advanced-search-modal > div > div > div.modal-body > div:nth-child(2) > div:nth-child(1) > ng2-datepicker > div > div > input",StarDate);

            Elements.SendKeysByCssSelector("#advanced-search-modal > div > div > div.modal-body > div:nth-child(2) > div:nth-child(2) > ng2-datepicker > div > div > input", EndDate);

            //Click Submit button
            Elements.ClickElementByCssSelector("#advanced-search-modal > div > div > div.modal-footer > button");
            
        }


        //Assert for the searchs.
        public static bool SearchHadSome
        {
            get
            {
                try
                {
                    Driver.Instance.FindElement(By.CssSelector("body > sea-app > offer-landing > tabs > tab:nth-child(3) > div > invoice-search > invoice-table > div > div:nth-child(2) > table > tbody"));
                }
                catch (NoSuchElementException e)
                {
                    return false;
                }
                return true;

            }

        }
    }
}
