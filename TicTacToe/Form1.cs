using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public GFX engine;
        public Board theBoard;
        public static bool aiGame = false;

        public static bool getAiGame()
        {
            return aiGame;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            engine = new GFX(toPass);

            theBoard = new Board();
            theBoard.initBoard();

            refreshLabel();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mouse = Cursor.Position;
            mouse = panel1.PointToClient(mouse);
            theBoard.detectHit(mouse);

            refreshLabel();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            theBoard.reset();
            GFX.setUpCanvas();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Dr. Srishti! I hope you enjoy my tic-tac-toe game! \n\nHave an amazing summer! You're truly an amazing person and professor!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void refreshLabel()
        {
            String newText = "It is ";
            if(theBoard.getPlayerForTurn() == Board.X)
            {
                newText += "X";
            }
            else
            {
                newText += "O";
            }
            newText += "'s turn\n";
            newText += "X has won " + theBoard.getXwins() + " times. \nO has won " + theBoard.getOwins() + " times." ;

            label1.Text = newText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to play against the computer?", "Tic Tac Toe", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                aiGame = true;
            }
        }
    }
}
