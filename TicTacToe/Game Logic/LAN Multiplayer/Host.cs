using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    public class Host : Player
    {
        private int _port;
        private bool _hosting;
        private string _clientIP;
        private Socket _socket;
        private BackgroundWorker _messageReciever = new BackgroundWorker();
        private TcpListener _server = null;

        public Host(string name, PlayerSymbols symbol, int port) : base(name, symbol)
        {
            _port = port;

            Initialize_Server();
        }

        private void Initialize_Server()
        {
            _messageReciever.DoWork += MessageReciever_DoWork;
            _server = new TcpListener(System.Net.IPAddress.Any, _port);
            _server.Start();
            _socket = _server.AcceptSocket();
        }

        private void MessageReciever_DoWork(object sender, DoWorkEventArgs e)
        {
            RecieveMove();
        }

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public bool Hosting 
        {
            get { return _hosting; }
            set { _hosting = value; }
        }

        public string Client_IP
        {
            get { return _clientIP; }
            set { _clientIP = value; }
        }

        public byte[] RecieveMove()
        {
            //Wating for opponent to send move and put the move in the buffer
            byte[] buffer = new byte[2];
            _socket.Receive(buffer);
            return buffer;
        }

        public void SendMove(int x, int y)
        {
            byte[] bytes = { (byte)x, (byte)y };
            _socket.Send(bytes);
        }
    }
}
