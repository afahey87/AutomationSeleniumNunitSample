using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ConsoleApp3
{
    [TestFixture]
    class WebDriverTest
    {
        [Test]
        public void SampleTest()  // Do not put ; here. I know you want too. :)


        {

            int a = 10;
            int b = 10;

            Assert.AreEqual(a, b);

        
        }

        [Test]

        public void sampletestwebdriver()
        {


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");

            Assert.True(driver.Url.Contains("helloworld"));                      // Verifying that the url contains the "webapp"
            driver.Close();


        }



    }

}