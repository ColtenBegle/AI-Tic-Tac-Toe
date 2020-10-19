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
        private Host _host;
        private string _ip;
        private PlayerSymbols _playerSymbol;
        private PlayerSymbols _opponentSymbol;
        private Socket _socket;
        private BackgroundWorker _messageReciever;
        private TcpListener _server = null;
        private TcpClient _tcpClient;


        public static bool getAiGame()
        {
            return aiGame;
        }

        public Form1()
        {
            InitializeComponent();
            _playerSymbol = PlayerSymbols.X;
        }

        public Form1(Client client, string ip)
        {
            InitializeComponent();
            theBoard.initBoard();
            _client = client;
            _ip = ip;
            _playerSymbol = client.Symbol;
            if (_playerSymbol == PlayerSymbols.O)
                _opponentSymbol = PlayerSymbols.X;
            else
                _opponentSymbol = PlayerSymbols.O;
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                _tcpClient = new TcpClient(ip, _client.Port);
                _socket = _tcpClient.Client;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void _messageReciever_DoWork(object sender, DoWorkEventArgs e)
        {
            if (theBoard.detectRow())
                return;
            FreezeBoard();
            RecieveMove();
            if (!theBoard.detectRow())
                UnfreezeBoard();
        }

        public Form1(Host host)
        {
            InitializeComponent();
            theBoard.initBoard();
            _host = host;
            _playerSymbol = host.Symbol;
            if (_playerSymbol == PlayerSymbols.X)
                _opponentSymbol = PlayerSymbols.O;
            else
                _opponentSymbol = PlayerSymbols.X;
            CheckForIllegalCrossThreadCalls = false;
            _server = new TcpListener(System.Net.IPAddress.Any, host.Port);
            _server.Start();
            _socket = _server.AcceptSocket();
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
            if (_messageReciever == null)
            {
                _messageReciever = new BackgroundWorker();
                _messageReciever.DoWork += _messageReciever_DoWork;
            }
            Point mouse = Cursor.Position;
            mouse = panel1.PointToClient(mouse);
            theBoard.detectHit(mouse, _playerSymbol);
            if (_client != null || _host != null)
            {
                byte[] buffer = { (byte)theBoard.XPos, (byte)theBoard.YPos };
                _socket.Send(buffer);
                _messageReciever.RunWorkerAsync();
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

        private void RecieveMove()
        {
            byte[] buffer = new byte[2];
            _socket.Receive(buffer);
            Point location = new Point(buffer[0], buffer[1]);
            theBoard.detectHit(location, _opponentSymbol);

            refreshLabel();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _messageReciever.WorkerSupportsCancellation = true;
            _messageReciever.CancelAsync();
            if (_host != null)
            {
                _server.Stop();
                _socket.Close();
            }
            if (_client != null)
            {
                _socket.Close();
            }
        }
    }
}
