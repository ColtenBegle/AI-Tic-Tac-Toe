using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Game_Logic;
using TicTacToe.Game_Logic.AI;

namespace TicTacToe.UI
{
    public partial class MainScreen : Form
    {
        Bitmap XSymbol1 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol2 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol3 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol4 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol5 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap CrownSymbol = new Bitmap(Properties.Resources.CrownSymbol);

        public void ClickPlay()
        {
            buttonPlay.PerformClick();
        }

        public static bool aiGame = false;
        public MainScreen()
        {
            InitializeComponent();
            tabControlRight.ItemSize = new Size(0, 1);
            tabControlLeft.ItemSize = new Size(0, 1);
        }

        private void GameNameLabel_Click(object sender, EventArgs e)
        {
            //Back to Main Screen
            tabControlRight.SelectedIndex = (0);
        }
        private void picboxLogo_Click(object sender, EventArgs e)
        {
            //Back to Main Screen
            tabControlRight.SelectedIndex = (0);
            tabControlLeft.SelectedIndex = (0);
        }

        public void buttonPlay_Click(object sender, EventArgs e)
        {
            //show Select Player Mode
            tabControlRight.SelectedIndex = (1);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //show Customize tab
            tabControlRight.SelectedIndex = (2);
        }
        private void btnLocalMult_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(3);
            if (!game.IsDisposed)
                game.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Testing
            button1.BackgroundImage = CrownSymbol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Testing
            button2.BackgroundImage = XSymbol2;
        }

        private void buttonGameForm_Click(object sender, EventArgs e)
        {
            //GameForm Game = new GameForm();
            //this.Hide();
            //Game.ShowDialog();
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(3);
            AIPlayer aIPlayer = new AIPlayer(PlayerSymbols.O, false, game.CheckState, game.IsFull);
            game.AI = aIPlayer;
            if (!game.IsDisposed)
                game.ShowDialog();
        }

        public void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
       
}
