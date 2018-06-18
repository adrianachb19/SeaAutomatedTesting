using System;
using System.Threading;
using OpenQA.Selenium;
using SEAautomation;
//using OpenQA.Selenium.StaleElementReferenceException;

namespace SeaCoupon
{
    public class Elements
    {
        public static void Delay(int miliSeconds)
        {
            Thread.Sleep(miliSeconds);
        }

        public static void GoToUrl(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
        }

        public static void RefreshPage()
        {
            Driver.Instance.Navigate().Refresh();
        }


        public static string returnDriverURL()
        {
            return Driver.Instance.Url;
        }

        public static void ClickElementById(string id)
        {
            Driver.Instance.FindElement(By.Id(id)).Click();
        }

        public static void ClickElementByXPath(string xPath)
        {
            Driver.Instance.FindElement(By.XPath(xPath)).Click();
        }


        public static void ClickElementByLinkText(string linkText)
        {
            Driver.Instance.FindElement(By.LinkText(linkText)).Click();
        }

        public static void ClickElementByCssSelector(string cssSelector)
        {
            Driver.Instance.FindElement(By.CssSelector(cssSelector)).Click();
        }

        public static void SendKeysById(string id, string text)
        {
            IWebElement element = Driver.Instance.FindElement(By.Id(id));
            element.Clear();
            element.SendKeys(text);
        }

        public static void SendKeysByXPath(string xPath, string text)
        {
            IWebElement element = Driver.Instance.FindElement(By.XPath(xPath));
            element.Clear();
            element.SendKeys(text);
        }

        public static void SendKeysByCssSelector(string cssSelector, string text)
        {
            IWebElement element = Driver.Instance.FindElement(By.CssSelector(cssSelector));
            element.Clear();
            element.SendKeys(text);
        }


        public static void SendKeysByName(string name, string text)
        {
            IWebElement element = Driver.Instance.FindElement(By.Name(name));
            element.SendKeys(text);
        }

        public static IWebElement ReturnElementByXPath(string xPath)
        {
            IWebElement element = Driver.Instance.FindElement(By.XPath(xPath));
            return element;
        }

        public static dynamic ReturnElementsByXPath(string xPath)
        {
            var element = Driver.Instance.FindElements(By.XPath(xPath));
            return element;
        }

        public static bool ElementDisplayedById(string id)
        {
            if (Driver.Instance.FindElement(By.Id(id)).Displayed)
                return true;
            return false;
        }

        public static bool ElementDisplayedByXPath(string xPath)
        {
            if (Driver.Instance.FindElement(By.XPath(xPath)).Displayed)
                return true;
            return false;
        }

        public static bool ElementDisplayedCssSelector(string cssSelector)
        {
            if (Driver.Instance.FindElement(By.CssSelector(cssSelector)).Displayed)
                return true;
            return false;
        }

        public static void FindButton()
       {
           var c = Driver.Instance.FindElements(By.TagName("button"));
           int d = 0;
           while (d < c.Count)
           {
               Console.WriteLine(d);
               Console.WriteLine(d +"  "+ c[d].Text);
               d++;
           }
       }
        public static void FindInput()
        {
            var c = Driver.Instance.FindElements(By.TagName("input"));
            int d = 0;
            while (d < c.Count)
            {
                Console.WriteLine(d);
                Console.WriteLine(d + "  " + c[d].Text);
                d++;
            }
        }

        public static void FindSpan()
        {
            var c = Driver.Instance.FindElements(By.TagName("span"));
            int d = 0;
            while (d < c.Count)
            {
                Console.WriteLine(d);
                Console.WriteLine(d + "  " + c[d].Text);
                d++;
            }
        }

        // metodo para encontrar un texto y hacer un assert
        public static bool ValidateTeamName()
        {

            var findTag = Driver.Instance.FindElements(By.TagName("span"));
            //Console.WriteLine(findTag.Count);

            var a = findTag[2].Text;

            return a == "El nombre del equipo no debe contener caracteres especiales o números";
        }

        // metodo para verificar un check ( assert)
        public static bool IsChecked()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/div[3]/div/div/label/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Selected)
                return true;
            return false;
        }

        // metodo para verificar si esta habilitado ( assert)
        public static bool Blockled()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/sea-app/offer-edit/div/main-offer-form/form/div[1]/div[2]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Enabled)
                return true;
            return false;
        }

        
        
    }
}
