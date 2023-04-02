﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class ZeroaccidentaTest1Test
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void zeroaccidents_Test1()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }

    [Test]
    public void fouraccidents_Test2()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void twoaccidents_Test3()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1350"));
        }
    }

    [Test]
    public void zeroaccidents_Test4()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }

    [Test]
    public void zeroaccidents_Test5()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }

    [Test]
    public void oneaccidents_Test6()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1350"));
        }
    }

    [Test]
    public void ageomitted_Test7()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo(string.Empty));
        }
    }

    [Test]
    public void omittedaccidents_Test8()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo(string.Empty));
        }
    }

    [Test]
    public void experienceomitted_Test9()
    {
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/getQuote.html");
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zahra");
        driver.FindElement(By.Id("lastName")).SendKeys("Sheybani Far");
        driver.FindElement(By.Id("address")).SendKeys("260 Oston Bridge ");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("M4H 6Y8");
        driver.FindElement(By.Id("phone")).SendKeys("456-789-1230");
        driver.FindElement(By.Id("email")).SendKeys("zahrasheybanifar8@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo(string.Empty));
        }
    }


    
}
