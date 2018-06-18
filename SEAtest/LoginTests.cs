using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SEAautomation;
using SeaCoupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAtest
{
    [TestClass]
    public class LoginTests : SEAtest
    {

        [TestMethod]
        public void Admin_User_Can_Login()
        {
          
            Assert.IsTrue(LoginPage.IsLogin, "Failed to login");       

        }

    }
}
