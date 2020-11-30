using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomatedUITesting.Pages
{
    class MainMenuPage : BasePage
    {
        public WindowsElement playButton = session.FindElementByName("PLAY");
        public WindowsElement settingsButton = session.FindElementByName("SETTINGS");
        public WindowsElement exitButton = session.FindElementByName("EXIT");
        public WindowsElement localMultButton = session.FindElementByName("tabPlayerMode");
        
        

        public void PlayAI()
        {
            playButton.Click();
            WindowsElement aiButton = session.FindElementByName("AI");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            aiButton.Click();
            WindowsElement cell1 = session.FindElementByAccessibilityId("btnPoint1");
            cell1.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            WindowsElement cell2 = session.FindElementByAccessibilityId("btnPoint2");
            cell2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WindowsElement cell7 = session.FindElementByAccessibilityId("btnPoint7");
            cell7.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WindowsElement cell6 = session.FindElementByAccessibilityId("btnPoint6");
            cell6.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WindowsElement cell9 = session.FindElementByAccessibilityId("btnPoint9");
            cell9.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WindowsElement exitButton = session.FindElementByName("Exit");
            exitButton.Click();
        }

        public void PlayLocalMult()
        {
            playButton.Click();
            WindowsElement localMultButton = session.FindElementByName("Local Multiplayer");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            localMultButton.Click();
            WindowsElement cell1 = session.FindElementByAccessibilityId("btnPoint1");
            cell1.Click();
            WindowsElement cell2 = session.FindElementByAccessibilityId("btnPoint2");
            cell2.Click();
            WindowsElement cell3 = session.FindElementByAccessibilityId("btnPoint3");
            cell3.Click();
            WindowsElement cell5 = session.FindElementByAccessibilityId("btnPoint5");
            cell5.Click();
            WindowsElement cell8 = session.FindElementByAccessibilityId("btnPoint8");
            cell8.Click();
            WindowsElement cell4 = session.FindElementByAccessibilityId("btnPoint4");
            cell4.Click();
            WindowsElement cell6 = session.FindElementByAccessibilityId("btnPoint6");
            cell6.Click();
            WindowsElement cell7 = session.FindElementByAccessibilityId("btnPoint7");
            cell7.Click();
            WindowsElement cell9 = session.FindElementByAccessibilityId("btnPoint9");
            cell9.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WindowsElement exitButton = session.FindElementByName("Exit");
            exitButton.Click();
        }

        public void OpenSettings()
        {
            settingsButton.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        public void Exit()
        {
            exitButton.Click();
        }
    }
}
