using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Sucuri_Plugin
{
    public class SignUpPage
    {
        IWebDriver webDriver;
        public void Registration(string url, string plnSelect, string fName, string lName, string emailId, string phNo, string startDate, string howMnyMonths, string qualification, string currntWork, string loc, string intresIn, string coverLetter, string cv)
        {

            try
            {
                webDriver = new ChromeDriver();
                webDriver.Url = url;
                webDriver.Manage().Window.Maximize();


                //Declaring Locators

                //By btnSignUp = By.LinkText("Sign up!");
                By btnSignUp = By.XPath("//*[contains(@onclick,'addPrice1()')]");
                By planSelected = By.XPath("//input[@id='plan-selected']");
                By firstName = By.XPath("//input[@name='firstName']");
                By lastName = By.XPath("//input[@name='lastName']");
                By emailID = By.Name("internEmail");
                By phoneNumber = By.XPath("//input[@type='number']");
                By startedDate = By.Id("startDate");
                By howManyMonths = By.Id("months");
                By qualificationSelect = By.Name("qualification");
                By currentWork = By.Name("currentWork");
                By location = By.Name("currentLocation");
                By interestedIn = By.Id("interestedIn");
                //By fileCoverLetter = By.Name("attachment");
                //By fileCv = By.Name("attachment2");


                // Assign values to Locators
                webDriver.FindElement(btnSignUp).Click();
                Thread.Sleep(2000);
                webDriver.FindElement(planSelected).Click();
                webDriver.FindElement(planSelected).Clear();

                webDriver.FindElement(planSelected).SendKeys(plnSelect);
                Thread.Sleep(2000);
                webDriver.FindElement(firstName).Click();
                webDriver.FindElement(firstName).SendKeys(fName);
                Thread.Sleep(2000);
                webDriver.FindElement(lastName).Click();
                webDriver.FindElement(lastName).SendKeys(lName);
                Thread.Sleep(2000);
                webDriver.FindElement(emailID).Click();
                webDriver.FindElement(emailID).SendKeys(emailId);
                Thread.Sleep(2000);
                webDriver.FindElement(phoneNumber).Click();
                webDriver.FindElement(phoneNumber).SendKeys(phNo);
                Thread.Sleep(2000);
                webDriver.FindElement(startedDate).Click();
                webDriver.FindElement(startedDate).SendKeys(startDate);
                Thread.Sleep(2000);

                //Assign drop down list
                var select = webDriver.FindElement(howManyMonths);
                var selectDropMonth = new SelectElement(select);
                Thread.Sleep(2000);
                selectDropMonth.SelectByText(howMnyMonths);
                Thread.Sleep(2000);
                webDriver.FindElement(qualificationSelect).Click();
                webDriver.FindElement(qualificationSelect).SendKeys(qualification);
                Thread.Sleep(2000);
                webDriver.FindElement(currentWork).Click();
                webDriver.FindElement(currentWork).SendKeys(currntWork);
                Thread.Sleep(2000);
                webDriver.FindElement(location).Click();
                webDriver.FindElement(location).SendKeys(loc);
                var selectint = webDriver.FindElement(interestedIn);
                var selectDropInterested = new SelectElement(selectint);
                Thread.Sleep(2000);
                selectDropInterested.SelectByText(intresIn);
                //Assign file uploaders

                IWebElement uplaodFile = webDriver.FindElement(By.Name("attachment"));
                Thread.Sleep(2000);
                uplaodFile.SendKeys(coverLetter);

                IWebElement uplaodFile2 = webDriver.FindElement(By.Name("attachment2"));
                Thread.Sleep(2000);
                uplaodFile2.SendKeys(cv);
                IWebElement btnSendEmail = webDriver.FindElement(By.XPath("//input[@class='btn btn-primary']"));
                btnSendEmail.Click();
                Thread.Sleep(2000);
            }
            catch (Exception er)
            {

                ITakesScreenshot ts = webDriver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\pc\source\repos\Sucuri Plugin\ScreenShots\ss1.png", ScreenshotImageFormat.Png);
                Console.WriteLine(er.StackTrace);
                throw;
         
            }
            finally
            {
                webDriver.Quit();
            }
        }
    }
}
