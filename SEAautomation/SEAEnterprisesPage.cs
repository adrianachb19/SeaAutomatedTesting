using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAautomation
{
    public class SEAEnterprisesPage
    {
        public static bool IsAt
        {
            get
            {
                var h3s = Driver.Instance.FindElements(By.TagName("h3"));
                if (h3s.Count > 0)
                    return h3s[0].Text == "Manage Offers";
                return false;
            }


        }

       
    }
}
