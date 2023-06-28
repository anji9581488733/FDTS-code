using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.ObjectModel;
using System.Threading;

internal static class ProgramHelpers
{
    public static void Main(string[] args)
    {

        WindowsDriver<WindowsElement> FDTS, sessionFDTS;
        AppiumOptions desiredCapabilities = new AppiumOptions();

        // DesiredCapabilities appCapabilities = new DesiredCapabilities();


        // appCapabilities.SetCapability("appWorkingDir", "C:\\Program Files (x86)\\ReSound\\Palpatine6.4.4.16-RP-S\\AlgoLabtest.exe");
        desiredCapabilities.AddAdditionalCapability("app", @"C:\Program Files (x86)\GN Hearing\Camelot\WorkflowRuntime\Camelot.WorkflowRuntime.exe");
        desiredCapabilities.AddAdditionalCapability("appWorkingDir", @"C:\Program Files (x86)\GN Hearing\Camelot\WorkflowRuntime");
        FDTS = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities);
        Thread.Sleep(40000);



        FDTS.SwitchTo().Window(FDTS.WindowHandles[0]);
        FDTS.FindElementByAccessibilityId("textBoxFilter").SendKeys("RE977-DWT");
        Thread.Sleep(10000);

        //Actions action = new Actions(FDTS);
        var st = FDTS.FindElementByName("ReSound LiNX Quattro 9");

        Actions action = new Actions(FDTS);
        action.MoveToElement(st).DoubleClick().Perform();
        action.DoubleClick(st);
        FDTS.FindElementByName("RE977-DWT (Final)").Click();
        Thread.Sleep(10000);

        var sd = FDTS.FindElementByAccessibilityId("buttonContinue");
        sd.Click();
        Thread.Sleep(6000);
        FDTS.SwitchTo().Window(FDTS.WindowHandles[0]);
        var sd1 = FDTS.FindElementByAccessibilityId("buttonContinue");
        sd1.Click();
        FDTS.SwitchTo().Window(FDTS.WindowHandles[0]);
        Thread.Sleep(7000);
        FDTS.FindElementByName("Read").Click();
        Thread.Sleep(10000);
        FDTS.FindElementByName("Continue >>").Click();
        Thread.Sleep(6000);
        //FDTS.SwitchTo().Window(FDTS.WindowHandles[0]);
        //Thread.Sleep(6000);
        //FDTS.FindElementByName("Full").Click();
        //Thread.Sleep(5000);


        //Thread.Sleep(10000);
        //Thread.Sleep(20000);
        //if (FDTS.FindElementByName("Full").Click();)
        //FDTS.SwitchTo().Window(FDTS.WindowHandles[0]);

        FDTS.SwitchTo().Window(FDTS.WindowHandles[0]);
        Thread.Sleep(6000);
        var sd2 = FDTS.FindElementByClassName("WindowsForms10.EDIT.app.0.27a2811_r17_ad1");
        sd2.SendKeys("1234");
        Thread.Sleep(3000);
        FDTS.FindElementByName("Continue >>").Click();

        Thread.Sleep(200000);

        //AppiumOptions desiredcapabilities = new AppiumOptions();

        desiredCapabilities.AddAdditionalCapability("app", @"C:\Program Files (x86)\GN Hearing\Camelot\TestRuntimePC\Camelot.TestRuntimePC.exe");
        sessionFDTS = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities);
        Thread.Sleep(10000);
        sessionFDTS.SwitchTo().Window(sessionFDTS.WindowHandles[0]);
        var bu = sessionFDTS.FindElementByAccessibilityId("buttonDone");
        bu.Click();

        sessionFDTS.Quit();

        WindowsDriver<WindowsElement> Storagel;
        AppiumOptions desiredCapabilities1 = new AppiumOptions();
        desiredCapabilities1.AddAdditionalCapability("app", @"C:\Program Files (x86)\ReSound\Dooku1.1.18.1\StorageLayoutViewer.exe");
        desiredCapabilities1.AddAdditionalCapability("appWorkingDir", @"C:\Program Files (x86)\ReSound\Dooku1.1.18.1");
        Storagel = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities1);

        Storagel.FindElementByAccessibilityId("ToggleButton").Click();
        Storagel.FindElementByAccessibilityId("SpeedLink:0").Click();

        //Storagel.FindElementByAccessibilityId("PROGRESSBAR").Click();
        //Thread.Sleep(10000);

         var uc = Storagel.FindElementByAccessibilityId("elementHost1");
        ReadOnlyCollection<AppiumWebElement> Control = (ReadOnlyCollection<AppiumWebElement>)uc.FindElementsByClassName("Button");
        Control[Control.Count - 1].Click();
        Thread.Sleep(5000);
        Storagel.FindElementByName("_Read from").Click();
        Thread.Sleep(6000);
        Storagel.FindElementByAccessibilityId("layoutItemsFilterCb").SendKeys("productionTestdata");
        Storagel.FindElementByName("0f8e00:0004a ProductionTestData").Click();

        Actions action1 = new Actions(Storagel);
        var cleare = Storagel.FindElementByName("Value  -   from SpeedLink:0/Left Row 0");
        action1.MoveToElement(cleare).DoubleClick().SendKeys("2022-11-30 12:48:54Z").Perform();

        //MouseButton Rc = new MouseButton(Storagel);
        //var Bt = Storagel.FindElementByName("0f8e00:0004a ProductionTestData");
        //Rc.

        //Actions Rc = new Actions(Storagel);
        //var bt = Storagel.FindElementByName("0f8e00:0004a ProductionTestData");
        //Rc.ContextClick(bt).Perform();

        Actions element = new Actions(Storagel);
        var element1 = Storagel.FindElementByName("0f8e00:0004a ProductionTestData");
        element.ContextClick(element1).SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter);
        element.Build().Perform();
        Thread.Sleep(2000);

        Storagel.FindElementByAccessibilityId("layoutItemsFilterCb").SendKeys("MiniIdentification");
        Storagel.FindElementByName("057000:00026 MiniIdentification").Click();
        Thread.Sleep(5000);
        
        Actions action2 = new Actions(Storagel);
        var UnixID = Storagel.FindElementByName("Value  -   from SpeedLink:0/Left Row 6");
        action2.MoveToElement(UnixID).DoubleClick().SendKeys("1669792734").Perform();
        //action1.MoveToElement(UnixID).DoubleClick().SendKeys("1").Perform();
        Thread.Sleep(5000);

        Actions Mini = new Actions(Storagel);
        var miniclick = Storagel.FindElementByName("057000:00026 MiniIdentification");
        Mini.ContextClick(miniclick).SendKeys(Keys.ArrowUp).SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter);
        Mini.Build().Perform();
        

        Storagel.Quit();



        WindowsDriver<WindowsElement> SandR;
        AppiumOptions desiredCapabilities3 = new AppiumOptions();

        desiredCapabilities3.AddAdditionalCapability("app", @"C:\Program Files (x86)\GN Hearing\Lucan\App\Lucan.App.UI.exe");
        desiredCapabilities3.AddAdditionalCapability("appWorkingDir", @"C:\Program Files (x86)\GN Hearing\Lucan\App");
        SandR = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities3);

        Thread.Sleep(40000);
        //IWebDriver driver;

        //    IWebDriver chrome = new ChromeDriver();
        //    chrome.Navigate().GoToUrl("http
        //    .s://www.unixtimestamp.com/");
        //    Console.WriteLine("Print");







        //Thread.Sleep(5000);


        //// Accept the Alert 

        //Storagel.SwitchTo().Alert().Accept();
        //var elementOpen = Storagel.FindElementByAccessibilityId("Item 258");
        //elementOpen.Click();


        //Console.WriteLine("Right click Alert Accepted");

        //Storagel.SwitchTo().Window(Storagel.WindowHandles[0]);

        //Storagel.FindElementByAccessibilityId("Item 258").Click();





        //DateTime dt1 = new DateTime(2018, 7, 23, 08, 20, 10);
        //Console.WriteLine("Old Date: " + dt1.ToString());
        //DateTime dt2 = dt1.AddDays(7);
        //Console.WriteLine("New Date: " + dt2.ToString());



        //Control[Control.Count - 4].Click();
        //var parentId = Storagel.FindElementByAccessibilityId("elementHost1");

        //ReadOnlyCollection<AppiumWebElement> Custombox = (ReadOnlyCollection<AppiumWebElement>)parentId.FindElementsByClassName("DeviceConnectionControl");
        //Thread.Sleep(5000);



        //foreach(WindowsElement Uc in Control) 
        //{
        //    string s = Uc.Location.ToString();

        //    Console.WriteLine(s);
        //}

        //Console.ReadLine();


    }

}
    