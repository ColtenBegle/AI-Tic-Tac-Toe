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
            GameForm game = new GameForm(3);
            Client client = new Client(username, Game_Logic.PlayerSymbols.O, false, hostIP, PORT);
            game.Client = client;
            
            if (!game.IsDisposed)
                game.ShowDialog();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string hostIP = txtHostIP.Text;
            GameForm game = new GameForm(3);
            Host host = new Host(username, Game_Logic.PlayerSymbols.X, PORT, true);
            game.Host = host;

            if (!game.IsDisposed)
                game.ShowDialog();
        }
    }
}
