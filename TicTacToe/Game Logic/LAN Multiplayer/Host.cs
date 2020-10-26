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
using System.Net;
using System.Runtime.CompilerServices;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    public class Host : Player
    {
        private int _port;
        private bool _hosting;
        private string _clientIP;

        // Establish the local endpoint  
        // for the socket. Dns.GetHostName 
        // returns the name of the host  
        // running the application. 
        private IPHostEntry _ipHost;
        private IPAddress _ipAddr;
        private IPEndPoint _localEndPoint;

        // Creation TCP/IP Socket using  
        // Socket Class Costructor 
        private Socket _listener;
        private Socket _sender;

        public delegate void DetectHit(Point location, PlayerSymbols playerChar);
        private DetectHit _detectHit; 
        

        public Host(string name, PlayerSymbols symbol, int port, Action<Point, PlayerSymbols> detectHit) : base(name, symbol)
        {
            _port = port;
            _detectHit = new DetectHit(detectHit);
            ExecuteHost();
        }

        private void ExecuteHost()
        {
            _ipHost = Dns.GetHostEntry(Dns.GetHostName());
            _ipAddr = _ipHost.AddressList[2];
            _localEndPoint = new IPEndPoint(_ipAddr, 11111);
            _sender = new Socket(_ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);
            _listener = new Socket(_ipAddr.AddressFamily,
                     SocketType.Stream, ProtocolType.Tcp);
            // Using Bind() method we associate a 
            // network address to the Server Socket 
            // All client that will connect to this  
            // Server Socket must know this network 
            // Address 
            _listener.Bind(_localEndPoint);

            // Using Listen() method we create  
            // the Client list that will want 
            // to connect to Server 
            _listener.Listen(1);

            //while(true)
            //{
            //    MessageBox.Show("Waiting for connection...");
            //    Socket clientSocket = _listener.Accept();

            //    // Data buffer 
            //    byte[] bytes = new byte[2];

            //    while (true)
            //    {

            //        int numByte = clientSocket.Receive(bytes);
            //        int x = 0;
            //        int y = 0;
            //        if (numByte == 2)
            //        {
            //            x = bytes[0];
            //            y = bytes[1];
            //        }
            //        else
            //        {
            //            MessageBox.Show("Did not recieve the sufficient number of bytes!");
            //        }
            //        Point location = new Point(x, y);
            //        _detectHit(location, Symbol);

            //    }
            //}
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

        public void RecieveMove()
        {
            // Using Bind() method we associate a 
            // network address to the Server Socket 
            // All client that will connect to this  
            // Server Socket must know this network 
            // Address 
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
            _sender.Connect(_localEndPoint);
            try
            {
                
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
