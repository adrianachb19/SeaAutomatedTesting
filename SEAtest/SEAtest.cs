using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SEAautomation;
using SeaCoupon;

namespace SEAtest
{
    public class SEAtest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("achacon@pernixlabs.com").WithPassword("achacon123.").Login();
            
        }

        //[TestCleanup]
        //public void Cleanup()
        //{
        //    Drivers.Close();
            
        //}

    }
}
