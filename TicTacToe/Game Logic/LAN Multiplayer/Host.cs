using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Text;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    public class Host : Player
    {
        private int _port;
        private TcpListener tcpListener = null;
        private UdpClient udpClient = new UdpClient(8888);
        private Socket _socket;
        private string boardSize;
        private string _clientUser;
        private bool _isHosting = false;


        public Host(string name, PlayerSymbols symbol, int port, bool isTurn, string _boardSize) : base(name, symbol, isTurn)
        {
            _port = port;
            boardSize = _boardSize;
            SendMessageToClients();
        }

        private void SendMessageToClients()
        {
            var ResponseData = Encoding.ASCII.GetBytes(boardSize);
            var ClientEp = new IPEndPoint(IPAddress.Any, 8888);
            var ClientRequestData = udpClient.Receive(ref ClientEp);
            var ClientRequest = Encoding.ASCII.GetString(ClientRequestData);
            string[] requestArr = ClientRequest.Split(',');
            if (requestArr[0].ToString() != boardSize)
            {
                ResponseData = Encoding.ASCII.GetBytes("400");
                udpClient.Send(ResponseData, ResponseData.Length, ClientEp);
                SendMessageToClients();
            }
            else
            {
                string data = String.Format("{0},{1}", boardSize, Name);
                ResponseData = Encoding.ASCII.GetBytes(data);
                udpClient.Send(ResponseData, ResponseData.Length, ClientEp);
                udpClient.Close();
                ExecuteHost();
            }
        }

        private void ExecuteHost()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, _port);
                tcpListener.Start();
                _socket = tcpListener.AcceptSocket();
                _socket.Send(Encoding.ASCII.GetBytes(Name));
                byte[] client = new byte[10];
                int bytesRecieved = _socket.Receive(client);
                Array.Resize(ref client, bytesRecieved);
                string user = Encoding.ASCII.GetString(client);
                _clientUser = user;
                _isHosting = true;
            }
            catch (Exception ex)
            {
                _isHosting = false;
                MessageBox.Show(ex.Message);
            }
        }

        public void KillHost()
        {
            if (tcpListener != null && _socket != null)
            {
                tcpListener.Stop();
                _socket.Close();
            }
            
        }


        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public void RecieveMove(Button[,] cells)
        {
            try
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
                    if (Symbol == PlayerSymbols.X)
                        cells[x, y].Text = PlayerSymbols.O.ToString();
                    else
                        cells[x, y].Text = PlayerSymbols.X.ToString();
                }
                else
                {
                    MessageBox.Show("Did not recieve the sufficient number of bytes!");
                }
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

        public bool IsHosting
        {
            get { return _isHosting; }
            set { _isHosting = value; }
        }
        public string ClientUser
        {
            get { return _clientUser; }
            set { _clientUser = value; }
        }
    }
}
