using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Game_Logic;
using TicTacToe.Game_Logic.LAN_Multiplayer;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public GFX engine;
        public Board theBoard = new Board();
        public static bool aiGame = false;

        //LAN Game variables
        private Client _client;
        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        private Host _host;
        public Host Host
        {
            get { return _host; }
            set { _host = value; }
        }
        private string _ip;
        private PlayerSymbols _playerSymbol;


        public static bool getAiGame()
        {
            return aiGame;
        }

        public Form1(bool client = false, bool host = false)
        {
            InitializeComponent();
            if (client == true && host == false)
                _playerSymbol = PlayerSymbols.O;
            else if (host == true && client == false)
                _playerSymbol = PlayerSymbols.X;
            else
            {
                MessageBox.Show("Cannot be a host and client at the same time!");
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            engine = new GFX(toPass);

            theBoard.initBoard();

            refreshLabel();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mouse = Cursor.Position;
            mouse = panel1.PointToClient(mouse);
            theBoard.detectHit(mouse, _playerSymbol);
            if (_client != null || _host != null)
            {
                byte[] buffer = { (byte)theBoard.XPos, (byte)theBoard.YPos };
                if (_client != null)
                {
                    _client.SendMove(buffer);
                    FreezeBoard();
                    _client.RecieveMove();
                    UnfreezeBoard();
                }
                if (_host != null)
                {
                    _host.SendMove(buffer);
                    FreezeBoard();
                    _host.RecieveMove();
                    UnfreezeBoard();
                }
            }
            refreshLabel();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            theBoard.reset();
            GFX.setUpCanvas();
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
            //if (MessageBox.Show("Would you like to play against the computer?", "Tic Tac Toe", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    aiGame = true;
            //}
        }

        private void FreezeBoard()
        {
            panel1.Enabled = false;
        }

        private void UnfreezeBoard()
        {
            panel1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (_host != null)
            //{
            //    _server.Stop();
            //    _socket.Close();
            //}
            //if (_client != null)
            //{
            //    _socket.Close();
            //}
        }
    }
}
