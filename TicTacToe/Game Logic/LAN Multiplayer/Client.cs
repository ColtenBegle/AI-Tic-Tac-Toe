﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    public class Client : Player
    {
        private int _port;
        private string _hostIP;
        private Socket _socket;
        private TcpClient client;


        public Client(string name, PlayerSymbols symbol, bool isTurn, string hostIP, int port) : base(name, symbol, isTurn)
        {
            _hostIP = hostIP;
            _port = port;
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
