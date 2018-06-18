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
    [TestClass]
    public class OfferSearchTest : SEAtest
    {

        [TestMethod]
        public void Offer_Search()
        {
            Elements.Delay(5000);
            OfferSearch.SelectClient();
            //OfferSearch.ShowFlagForFollowUp();
            //Elements.Delay(3000);
            //OfferSearch.ShowWatchList();
            //Elements.Delay(3000);
            //OfferSearch.Search( "offerCode","brand","mediaType","Hola","marketArea","prodCateg");
            //Elements.Delay(3000);
            //OfferSearch.Download();
            //OfferSearch.GoToOfferSearchTab();
            Elements.Delay(3000);
            OfferSearch.SearchByOfferCode("010001");
            //Elements.Delay(3000);
            //OfferSearch.SearchByBrand("");
            Elements.Delay(3000);
            OfferSearch.SearchByMediaType("IRC");
            //Elements.Delay(3000);
            //OfferSearch.SearchByDivision("");
            //Elements.Delay(3000);
            //OfferSearch.SearchByMarketArea("");
            //Elements.Delay(3000);
            //OfferSearch.SearchByProductCategory("");

            



        }
    }
}
