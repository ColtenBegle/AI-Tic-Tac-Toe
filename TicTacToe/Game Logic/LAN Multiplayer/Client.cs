using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    public class Client : Player
    {
        private int _port;
        private bool _isConnected;
        private string _hostIP;
        private IPHostEntry _ipHost;
        private IPAddress _ipAddr;
        private IPEndPoint _localEndPoint;
        private Socket _listener;
        private Socket _sender;
        public delegate void DetectHit(Point location, PlayerSymbols playerChar);
        private DetectHit _detectHit;

        public Client(string name, PlayerSymbols symbol, string hostIP, int port, Action<Point, PlayerSymbols> detectHit) : base(name, symbol)
        {
            _hostIP = hostIP;
            _port = port;
            _detectHit = new DetectHit(detectHit);
            ExecuteClient();
        }

        private void ExecuteClient()
        {
            try
            {

                // Establish the remote endpoint  
                // for the socket. This example  
                // uses port 11111 on the local  
                // computer. 
                _ipHost = Dns.GetHostEntry(Dns.GetHostName());
                _ipAddr = _ipHost.AddressList[2];
                _localEndPoint = new IPEndPoint(_ipAddr, 11111);

                // Creation TCP/IP Socket using  
                // Socket Class Costructor 
                _sender = new Socket(_ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);
                _listener = new Socket(_ipAddr.AddressFamily,
                     SocketType.Stream, ProtocolType.Tcp);

            //    try
            //    {

            //        // Connect Socket to the remote  
            //        // endpoint using method Connect() 
            //        _sender.Connect(_localEndPoint);

            //        // We print EndPoint information  
            //        // that we are connected 
            //        MessageBox.Show("Socket connected to -> {0} ",
            //                      _sender.RemoteEndPoint.ToString());

            //        // Creation of messagge that 
            //        // we will send to Server 
            //        byte[] messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>");
            //        int byteSent = _sender.Send(messageSent);

            //        // Data buffer 
            //        byte[] messageReceived = new byte[1024];

            //        // We receive the messagge using  
            //        // the method Receive(). This  
            //        // method returns number of bytes 
            //        // received, that we'll use to  
            //        // convert them to string 
            //        int byteRecv = _sender.Receive(messageReceived);
            //        MessageBox.Show("Message from Server -> {0}",
            //              Encoding.ASCII.GetString(messageReceived,
            //                                         0, byteRecv));

            //        // Close Socket using  
            //        // the method Close() 
            //        _sender.Shutdown(SocketShutdown.Both);
            //        _sender.Close();
            //    }

            //    // Manage of Socket's Exceptions 
            //    catch (ArgumentNullException ane)
            //    {

            //        MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
            //    }

            //    catch (SocketException se)
            //    {

            //        MessageBox.Show("SocketException : {0}", se.ToString());
            //    }

            //    catch (Exception e)
            //    {
            //        MessageBox.Show("Unexpected exception : {0}", e.ToString());
            //    }
            }

            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        //private void MessageReciever_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    RecieveMove();
        //}

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

        public void RecieveMove()
        {
            _listener.Bind(_localEndPoint);

            // Using Listen() method we create  
            // the Client list that will want 
            // to connect to Server 
            _listener.Listen(1);

            Socket clientSocket = _listener.Accept();

            // Data buffer 
            byte[] bytes = new byte[2];
            int numByte = clientSocket.Receive(bytes);
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
            Point location = new Point(x, y);
            _detectHit(location, Symbol);
            _listener.Close();
        }

        public void SendMove(byte[] move)
        {
            try
            {
                _sender.Connect(_localEndPoint);
                int bytesSent = _sender.Send(move);

                // Close Socket using  
                // the method Close() 
                _sender.Shutdown(SocketShutdown.Both);
                _sender.Close();
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
