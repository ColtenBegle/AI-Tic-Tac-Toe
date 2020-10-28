using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.UI
{
    public partial class MainScreen : Form
    {
        public static bool aiGame = false;
        public MainScreen()
        {
            InitializeComponent();
            GameTypePanel.Visible = false;
            panelCustomize.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreenPic.Visible = false;
            panelCustomize.Visible = false;
            //gametype panel changed to false temporaily
            GameTypePanel.Visible = false;
            // temp code added to start gameform
            GameForm Game = new GameForm();
            this.Hide();
            Game.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            GameTypePanel.Visible = false;
            panelCustomize.Visible = true;
            MainScreenPic.Visible = false;
        }

        private void GameNameLabel_Click(object sender, EventArgs e)
        {
            MainScreenPic.Visible = true;
            panelCustomize.Visible = false;
            GameTypePanel.Visible = false;
        }

        private void btnLocalMult_Click(object sender, EventArgs e)
        {
            GameForm Game = new GameForm();
            this.Hide();
            Game.ShowDialog();
        }

        
    }
}
