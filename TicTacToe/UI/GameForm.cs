using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Game_Logic;
using TicTacToe.Game_Logic.LAN_Multiplayer;

namespace TicTacToe
{
    public partial class GameForm : Form
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
        private PlayerSymbols _playerSymbol;
        private BackgroundWorker _messageReceiver = new BackgroundWorker();


        public static bool getAiGame()
        {
            return aiGame;
        }

        public GameForm(bool client = false, bool host = false)
        {
            InitializeComponent();
            if (client == true || host == true)
            {
                CheckForIllegalCrossThreadCalls = false;
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
        }

        public void InitializeMessageReciever()
        {
            _messageReceiver.DoWork += MessageReceiver_DoWork;
            if (_client != null)
                _messageReceiver.RunWorkerAsync();
            
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (theBoard.detectRow())
                return;
            //FreezeBoard();
            if (_client != null)
            {
                _client.RecieveMove();
            }
            else
            {
                _host.RecieveMove();
            }
            if (!theBoard.detectRow())
            {
                //UnfreezeBoard();
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
            if (_client != null || _host != null)
            {
                theBoard.detectHit(mouse, _playerSymbol);
                byte[] buffer = { (byte)theBoard.XPos, (byte)theBoard.YPos };
                if (_client != null)
                {
                    _client.SendMove(buffer);
                    _messageReceiver.RunWorkerAsync();
                }
                if (_host != null)
                {
                    _host.SendMove(buffer);
                    _messageReceiver.RunWorkerAsync();
                }
            }
            else
            {
                if (theBoard.playersTurn == 0)
                {
                    theBoard.detectHit(mouse, PlayerSymbols.X);
                }
                else
                    theBoard.detectHit(mouse, PlayerSymbols.O);
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

        //private void FreezeBoard()
        //{
        //    panel1.Enabled = false;
        //}

        //private void UnfreezeBoard()
        //{
        //    panel1.Enabled = true;
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_host != null)
            {
                _host.KillHost();
            }
            if (_client != null)
            {
                _client.KillClient();
            }
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
         //   if (MessageBox.Show("Would you like to play against the computer?", "Tic Tac Toe", MessageBoxButtons.YesNo) == DialogResult.Yes)
         //   {
         //       aiGame = true;
         //   }
        //}
    }
}
