using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game_Logic.LAN_Multiplayer
{
    class HostSniffer
    {
        private int boardSize;
        private int port;
        private UdpClient client;
        private IPEndPoint serverEp;
        private Dictionary<string, string> potentialHosts = new Dictionary<string, string>();
        public HostSniffer(string _boardSize, int _port)
        {
            boardSize = boardSize;
            port = _port;
            potentialHosts = FindHosts();
        }

        public Dictionary<string, string> FindHosts()
        {
            Dictionary<string, string> hosts = new Dictionary<string, string>();
            client = new UdpClient();
            string RequestData = Encoding.ASCII.GetBytes(boardSize);
            serverEp = new IPEndPoint(IPAddress.Any, 0);
            client.EnableBroadcast = true;
            client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Any, port));

            var ServerResponseData = client.Receive(ref serverEp);
            string[] ServerResponse = Encoding.ASCII.GetString(ServerResponseData).Split(',');
            if (ServerResponse[0] == boardSize.ToString())
            {
                hosts.Add(ServerResponse[0], ServerResponse[1]);
            }
            return hosts;
        }

        public Dictionary<string, string> PotentialHosts
        {
            get { return potentialHosts; }
            set { potentialHosts = value; }
        }
    }
}
