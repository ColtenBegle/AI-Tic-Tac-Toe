using System;
using AutomatedUITesting.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace AutomatedUITesting
{
    [TestClass]
    public class UITest
    {
        
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string TicTacToeAppID = @"C:\Users\darkw\source\repos\AI-Tic-Tac-Toe\TicTacToe\bin\Debug\TicTacToe.exe";

        [TestMethod]
        public void AIPlayTest()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", TicTacToeAppID);

            BasePage.session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);

            MainMenuPage mainMenu = new MainMenuPage();
            mainMenu.PlayAI();
            mainMenu.PlayLocalMult();
            mainMenu.OpenSettings();
            mainMenu.Exit();
        }
    }
}
