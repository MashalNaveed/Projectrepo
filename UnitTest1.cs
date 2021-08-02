using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Sucuri_Plugin
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod, TestCategory("Signup Page")]
        public void TestMethod1()
        {
            SignUpPage objSignUp = new SignUpPage();
            string cover_letter = "C:\\Users\\pc\\Documents\\Mashal-SoftwareTesting\\Test Cover Letter.docx";
            string cv = "C:\\Users\\pc\\Documents\\Mashal-SoftwareTesting\\Test CV.docx";
            objSignUp.Registration("https://www.techintern.co.nz/index.php#Plans", "INTERNSHIP", "Mashal", "Naveed", "engrmashalnaveedali@gmail.com", "0225165688", "12/7/2022", "5", "Computer Engineer", "Software Tester", "Christchruch Burnside 2/7", "Full Stack", cover_letter, cv);
            
        }
    }
}
