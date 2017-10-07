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


        /// <summary>
        /// Creating actual test case setup.
        /// </summary>



        IWebDriver driver;                                                       // Outside so others can use.
       
        [SetUp]                                                                 //Setup attribute
        public void setup()
        {
            driver = new ChromeDriver();                                       //Setting up the driver. 
        }





        [Test]                                                                // Here is the actual test

        public void sampletestwebdriver()
        {
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");
            Assert.True(driver.Url.Contains("webapp"));                      // Verifying that the url contains the "webapp"
        


        }
        [TearDown]                                                          // Tead down attribute
        public void tearDown()
        {

            driver.Close();
            driver.Quit();
            

        }



    }

}