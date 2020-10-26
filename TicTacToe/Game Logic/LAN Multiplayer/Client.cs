﻿using System;
using System.ComponentModel;
using System.Deployment.Application;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    public class Client : Player
    {
        private int _port;
        private string _hostIP;
        private Socket _socket;
        private TcpClient client;
        public delegate void DetectHit(Point location, PlayerSymbols playerChar);
        private DetectHit _detectHit;


        public Client(string name, PlayerSymbols symbol, string hostIP, int port, 
            Action<Point, PlayerSymbols> detectHit) : base(name, symbol)
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
                client = new TcpClient(_hostIP, _port);
                _socket = client.Client;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void KillClient()
        {
            _socket.Close();
        }

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public string HostIP
        {
            get { return _hostIP; }
            set { _hostIP = value; }
        }

        public void RecieveMove()
        {
            // Data buffer 
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
            x = ConvertXToLocation(x);
            y = ConvertYToLocation(y);
            Point location = new Point(x, y);
            if (Symbol == PlayerSymbols.X)
                _detectHit(location, PlayerSymbols.O);
            else
                _detectHit(location, PlayerSymbols.X);
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

        private int ConvertXToLocation(int x)
        {
            if (x == 0)
                return 165;
            else if (x == 1)
                return 333;
            else if (x == 2)
                return 335;
            else
                return -1;
        }
        private int ConvertYToLocation(int y)
        {
            if (y == 0)
                return 165;
            else if (y == 1)
                return 333;
            else if (y == 2)
                return 335;
            else
                return -1;
        }
    }
}
