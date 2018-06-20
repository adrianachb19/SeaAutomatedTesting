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
      
        // metodo para verificar si esta habilitado ( assert)
        public static bool ElementEnabledByXPath(string xPath)
        {
            if (Driver.Instance.FindElement(By.XPath(xPath)).Enabled)
                return true;
            return false;
        }

        public static bool ElementEnabledCssSelector(string cssSelector)
        {
            if (Driver.Instance.FindElement(By.CssSelector(cssSelector)).Enabled)
                return true;
            return false;
        }

        public static bool ElementEnabledById(string id)
        {
            if (Driver.Instance.FindElement(By.Id(id)).Enabled)
                return true;
            return false;
        }

        // metodo para verificar un check ( assert)

        public static bool ElementSelectedByXPath(string xPath)
        {
            if (Driver.Instance.FindElement(By.XPath(xPath)).Selected)
                return true;
            return false;
        }

        public static bool ElementSelectedCssSelector(string cssSelector)
        {
            if (Driver.Instance.FindElement(By.CssSelector(cssSelector)).Selected)
                return true;
            return false;
        }

        public static bool ElementSelectedById(string id)
        {
            if (Driver.Instance.FindElement(By.Id(id)).Selected)
                return true;
            return false;
        }

        // metodo para verificar que esta desplegado ( assert)
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
    }
}
