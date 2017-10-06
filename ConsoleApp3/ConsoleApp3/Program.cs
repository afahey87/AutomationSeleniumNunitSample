using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;   


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");
            driver.FindElement(By.Id("contact_link")).Click();
            driver.FindElement(By.TagName("input")).SendKeys("Jon Snow");
            driver.FindElement(By.Name("address_field")).SendKeys("123 elm street");


            IWebElement element = driver.FindElement(By.XPath("id('cdona' )"));
            element.Click();


            IList<IWebElement> links = driver.FindElements(By.TagName("a"));

            foreach (IWebElement link in links)
                if (link.Text.Equals("ABOUT"))
                {
                    link.Click();
                    break;

                }

           // driver.Close();
           // driver.Quit();

        }
    }
}
