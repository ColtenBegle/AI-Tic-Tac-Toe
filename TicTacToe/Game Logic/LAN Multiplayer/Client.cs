using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    class Client : Player
    {
        private int _port;
        private bool _isConnected;
        private string _hostIP;
        private TcpClient _client;
        private Socket _socket;
        private BackgroundWorker _messageReciever = new BackgroundWorker();

        public Client(string name, PlayerSymbols symbol, string hostIP, int port) : base(name, symbol)
        {
            _hostIP = hostIP;
            _port = port;
            Initialize_Connection();
        }

        private void Initialize_Connection()
        {
            try
            {
                _client = new TcpClient(_hostIP, _port);
                _socket = _client.Client;
                _messageReciever.RunWorkerAsync();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public bool IsConnected 
        {
            get { return _isConnected; }
            set { _isConnected = value; }
        }

        public string HostIP
        {
            get { return _hostIP; }
            set { _hostIP = value; }
        }

    }
}
