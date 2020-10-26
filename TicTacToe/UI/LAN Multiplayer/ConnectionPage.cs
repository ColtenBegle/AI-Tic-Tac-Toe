using System;
using System.Windows.Forms;
using TicTacToe.Game_Logic.LAN_Multiplayer;

namespace TicTacToe.UI.LAN_Multiplayer
{
    public partial class ConnectionPage : Form
    {
        private const int PORT = 5757;
        public ConnectionPage()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string hostIP = txtHostIP.Text;
            Form1 form1 = new Form1(client:true);
            Client client = new Client(username, Game_Logic.PlayerSymbols.O, hostIP, PORT, form1.theBoard.detectHit);
            form1.Client = client;
            form1.InitializeMessageReciever();
            
            if (!form1.IsDisposed)
                form1.ShowDialog();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            
            Form1 form1 = new Form1(host:true);
            Host host = new Host(username, Game_Logic.PlayerSymbols.X, PORT, form1.theBoard.detectHit);
            form1.Host = host;
            form1.InitializeMessageReciever();

            if (!form1.IsDisposed)
                form1.ShowDialog();
        }
    }
}
