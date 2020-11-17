using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.ComponentModel;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    public class Host : Player
    {

        private int _port;
        private TcpListener server = null;
        private Socket _socket;
        private BackgroundWorker _messageReceiver = new BackgroundWorker();


        public Host(string name, PlayerSymbols symbol, int port, bool isTurn) : base(name, symbol, isTurn)
        {
            _port = port;
            //_messageReceiver.DoWork += MessageReceiver_DoWork;
            ExecuteHost();
        }

        private void ExecuteHost()
        {
            server = new TcpListener(IPAddress.Any, _port);
            server.Start();
            _socket = server.AcceptSocket();
        }

        public void KillHost()
        {
            server.Stop();
            _socket.Close();
        }


        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public void RecieveMove(Button[,] cells)
        {
            //// Data buffer 
            byte[] bytes = new byte[2];
            int numByte = _socket.Receive(bytes);
            int x = 0;
            int y = 0;
            if (numByte == 2)
            {
                x = bytes[0];
                y = bytes[1];
            }
            else
            {
                MessageBox.Show("Did not recieve the sufficient number of bytes!");
            }
            if (Symbol == PlayerSymbols.X)
                cells[x, y].Text = PlayerSymbols.O.ToString();
            else
                cells[x, y].Text = PlayerSymbols.X.ToString();
        }

        public void SendMove(byte[] move)
        {
            try
            {
                _socket.Send(move);
            }
            // Manage of Socket's Exceptions 
            catch (ArgumentNullException ane)
            {

                MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
            }

            catch (SocketException se)
            {

                MessageBox.Show("SocketException : {0}", se.ToString());
            }

            catch (Exception e)
            {
                MessageBox.Show("Unexpected exception : {0}", e.ToString());
            }
        }
    }
}
