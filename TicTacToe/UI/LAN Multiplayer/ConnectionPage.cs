using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Game_Logic.LAN_Multiplayer;

namespace TicTacToe.UI.LAN_Multiplayer
{
    public partial class ConnectionPage : Form
    {
        public ConnectionPage()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string hostIP = txtHostIP.Text;
            Client client = new Client(username, Game_Logic.PlayerSymbols.O, hostIP, 5757);
            

        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            
        }
    }
}
