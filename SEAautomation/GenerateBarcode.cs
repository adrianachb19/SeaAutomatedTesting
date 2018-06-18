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
   public class GenerateBarcode
    {
        public static bool IsBarcodeOrder
        {

            get
            {
                return Elements.ElementDisplayedCssSelector(
                    "body > bs-modal.fade.modal.in > div > div > bs-modal-header > div > h4");
            }
        
        }


        public static void FileTypePDF()
        {
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[1]/div/button");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[1]/div/ul/li[1]/a");
            
        }


        public static bool IsPDF()
        {
            var findTag = Driver.Instance.FindElements(By.TagName("button"));
            var a = findTag[7].Text;
            Console.WriteLine(a);
            return a == "PDF";
        }


        public static void FileTypeEPF()
        {
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[1]/div/button");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[1]/div/ul/li[2]/a");
            Elements.FindButton(); 
        }

        public static bool IsEPF()
        {
            var findTag = Driver.Instance.FindElements(By.TagName("button"));
            var a = findTag[7].Text;
            Console.WriteLine(a);
            return a == "EPF";
        }

        public static void FileTypeIllustrator()
        {
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[1]/div/button");
            Elements.Delay(3000);
            Elements.ClickElementByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[1]/div/ul/li[3]/a");
            
        }

        public static bool IsIllustrator()
        {
            var findTag = Driver.Instance.FindElements(By.TagName("button"));
            var a = findTag[7].Text;
            Console.WriteLine(a);
            return a == "Illustrator";
        }


        public static void EmailBarcodeTo(string email)
        {
            Elements.Delay(2000);
            Elements.SendKeysByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[2]/input", email);
        }

        public static bool IsEmail()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[1]/div[2]/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "achacon@pernixlabs.com";
        }

        public static void SpecialInstructions(string instructions)
        {
            Elements.SendKeysByXPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[2]/div/input", instructions);
        }


        public static bool IsSpecialInstructions()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/bs-modal[1]/div/div/bs-modal-body/div/div[2]/div/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            return getValue == "Test";
        }

        public static void ButtonNext()
        {
            Elements.ClickElementByXPath("/html/body/bs-modal[1]/div/div/bs-modal-footer/div/div/button[2]");
        }

        public static bool IsReviewAndSubmitBarcodeOrderToSymbology
        {
           get
            {
                return Elements.ElementDisplayedCssSelector(
                   "body > bs-modal.fade.modal.in > div > div > bs-modal-body > div > div:nth-child(1) > div > p");
            }
        }

        public static void AcceptConditions()
        {
            Elements.Delay(3000);
            Elements.ClickElementByCssSelector("body > bs-modal.fade.modal.in > div > div > bs-modal-body > div > div:nth-child(3) > div > div > label > input");
        }

        public static bool IsChecked()
        {
            IWebElement TargetElement = Driver.Instance.FindElement(By.XPath("/html/body/bs-modal[2]/div/div/bs-modal-body/div/div[3]/div/div/label/input"));
            string getValue = TargetElement.GetAttribute("value");
            Console.WriteLine(getValue);
            if (TargetElement.Selected)
                return true;
            return false;
        }

        public static void ButtonAccept()
        {
            Elements.ClickElementByXPath("/html/body/bs-modal[2]/div/div/bs-modal-footer/div/div/button[2]");
        }
    }
}
