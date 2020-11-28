using System;
using System.Collections.Generic;
using System.Net;  
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    class HostSniffer
    {
        private string boardSize;
        private int port;
        private UdpClient client;
        private IPEndPoint serverEp;
        private Dictionary<string, string> potentialHosts = new Dictionary<string, string>();
        public HostSniffer(string _boardSize, int _port)
        {
            boardSize = _boardSize;
            port = _port;
            potentialHosts = FindHosts();
        }

        public Dictionary<string, string> FindHosts()
        {
            IPAddress myIPAddress = GetLocalIPAddress();
            IPAddress mySubnetMask = GetSubnetMask(myIPAddress);
            if (myIPAddress == mySubnetMask)
            {
                throw new ArgumentException("IP address and subnet mask cannot be the same.");
            }
            IPAddress broadCastAddress = GetBroadcastAddress(myIPAddress, mySubnetMask);

            Dictionary<string, string> hosts = new Dictionary<string, string>();
            client = new UdpClient();
            var RequestData = Encoding.ASCII.GetBytes(boardSize);
            serverEp = new IPEndPoint(IPAddress.Any, 0);
            client.EnableBroadcast = true;
            client.Client.SendTimeout = 1000;
            client.Client.ReceiveTimeout = 1000;
            client.Send(RequestData, RequestData.Length, new IPEndPoint(broadCastAddress, port));
            var ServerResponseData = client.Receive(ref serverEp);
            string[] ServerResponse = Encoding.ASCII.GetString(ServerResponseData).Split(',');
            if (ServerResponse[0] == boardSize.ToString())
            {
                hosts.Add(ServerResponse[1], serverEp.Address.ToString());
            }
            return hosts;
        }

        private IPAddress GetLocalIPAddress()
        {
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();

            IPHostEntry iPHostEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addresses = iPHostEntry.AddressList;
            
            return addresses[1];
        }

        private IPAddress GetSubnetMask(IPAddress address)
        {
            IPAddress iPAddress = address;
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (address.Equals(unicastIPAddressInformation.Address))
                        {
                            iPAddress = unicastIPAddressInformation.IPv4Mask;
                            return iPAddress;
                        }
                    }
                }
            }
            return iPAddress;
        }

        private IPAddress GetBroadcastAddress(IPAddress address, IPAddress subnetMask)
        {
            byte[] ipAddressBytes = address.GetAddressBytes();
            byte[] subnetMaskBytes = subnetMask.GetAddressBytes();

            if (ipAddressBytes.Length != subnetMaskBytes.Length)
                throw new ArgumentException("Lengths of IP addresses and subnet mask do not match");
            byte[] broadcastAddress = new byte[ipAddressBytes.Length];
            for (int i = 0; i < broadcastAddress.Length; i++)
            {
                broadcastAddress[i] = (byte)(ipAddressBytes[i] | (subnetMaskBytes[i] ^ 255));
            }
            return new IPAddress(broadcastAddress);
        }

        public Dictionary<string, string> PotentialHosts
        {
            get { return potentialHosts; }
            set { potentialHosts = value; }
        }
    }
}
