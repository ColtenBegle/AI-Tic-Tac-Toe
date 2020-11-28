using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Game_Logic;
using TicTacToe.Game_Logic.AI;
using TicTacToe.Game_Logic.LAN_Multiplayer;
using TicTacToe.Music;

namespace TicTacToe.UI
{
    public partial class MainScreen : Form
    {
        Bitmap XSymbol1 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol2 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol3 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol4 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap XSymbol5 = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap CrownSymbol = new Bitmap(Properties.Resources.CrownSymbol);

        BackgroundMusic backgroundMusic = new BackgroundMusic();
        Sound sound;

        private int gridSize;
        private Dictionary<string, string> hosts = new Dictionary<string, string>();


        public void ClickPlay()
        {
            buttonPlay.PerformClick();
        }

        public static bool aiGame = false;

        public MainScreen()
        {
            InitializeComponent();
            InitializeSound();
            InitializeMusicSelection();

            tabControlRight.ItemSize = new Size(0, 1);
            tabControlLeft.ItemSize = new Size(0, 1);
            tabControlRight.SelectedTab = tabStartPage;
        }

        private void InitializeMusicSelection()
        {
            foreach (Sound sound in backgroundMusic.Sounds)
            {
                musicListBox.Items.Add(sound.SoundName);
            }
        }

        private void InitializeSound()
        {
            sound = backgroundMusic.GetSound("Chamber of Secrets");
            sound.PlaySound();
        }

        private void GameNameLabel_Click(object sender, EventArgs e)
        {
            //Back to Main Screen
            tabControlRight.SelectedIndex = (0);
        }
        private void picboxLogo_Click(object sender, EventArgs e)
        {
            //Back to Main Screen
            tabControlRight.SelectedIndex = (0);
            tabControlLeft.SelectedIndex = (0);
        }

        public void buttonPlay_Click(object sender, EventArgs e)
        {
            //show Select Player Mode
            tabControlRight.SelectedTab = tabPlayerMode;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //show Customize tab
            tabControlRight.SelectedTab = tabCustomize;
        }
        private void btnLocalMult_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(gridSize);
            game.InitializePlayerNames("Player 1", "Player 2");
            if (!game.IsDisposed)
                game.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Testing
            button1.BackgroundImage = CrownSymbol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Testing
            button2.BackgroundImage = XSymbol2;
        }

        private void buttonGameForm_Click(object sender, EventArgs e)
        {
            //GameForm Game = new GameForm();
            //this.Hide();
            //Game.ShowDialog();
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(gridSize);
            AIPlayer aIPlayer = new AIPlayer(PlayerSymbols.O, false, game.CheckState, game.IsFull);
            game.AI = aIPlayer;
            game.InitializePlayerNames("Human", "AI");
            if (!game.IsDisposed)
                game.ShowDialog();
        }

        public void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            gridSize = 3;
            btn3x3.Enabled = false;
            btn4x4.Enabled = true;
            btn5x5.Enabled = true;
            btnAI.Enabled = true;
            btnLocalMult.Enabled = true;
            btnLANMult.Enabled = true;
        }

        private void btn4x4_Click(object sender, EventArgs e)
        {
            gridSize = 4;
            btn3x3.Enabled = true;
            btn4x4.Enabled = false;
            btn5x5.Enabled = true;
            btnAI.Enabled = true;
            btnLocalMult.Enabled = true;
            btnLANMult.Enabled = true;
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            gridSize = 5;
            btn3x3.Enabled = true;
            btn4x4.Enabled = true;
            btn5x5.Enabled = false;
            btnAI.Enabled = true;
            btnLocalMult.Enabled = true;
            btnLANMult.Enabled = true;
        }

        private void musicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (musicCheckBox.Checked)
            {
                sound.PlaySound();
            }
            else
            {
                sound.StopSound();
            }
        }

        private void musicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sound.StopSound();
            string soundName = musicListBox.SelectedItem.ToString();
            sound = backgroundMusic.GetSound(soundName);
            sound.PlaySound();
            musicCheckBox.Checked = true;
        }

        private void btnLANMult_Click(object sender, EventArgs e)
        {
            tabControlRight.SelectedTab = tabClientOrHost;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Client client = new Client(txtUserName.Text, PlayerSymbols.O, false, hosts[lbHosts.SelectedItem.ToString()], 8888);
            GameForm game = new GameForm(gridSize);
            game.Client = client;
            game.InitializePlayerNames(client.HostUser, txtUserName.Text);
            if (game.IsDisposed == false)
            {
                game.ShowDialog();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                btnJoin.Enabled = false;
                lbHosts.Enabled = false;
            }
            else if (txtUserName.Text.Length > 10)
            {
                btnJoin.Enabled = false;
                lbHosts.Enabled = false;
            }
            else
            {
                btnJoin.Enabled = true;
                lbHosts.Enabled = true;
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            try
            {
                tabControlRight.SelectedTab = tabLanConnectionPage;
                lbHosts.Items.Clear();
                HostSniffer sniffer = new HostSniffer(gridSize.ToString(), 8888);
                hosts = sniffer.PotentialHosts;
                if (hosts.Count > 0)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in hosts)
                    {
                        lbHosts.Items.Add(keyValuePair.Key);
                    }
                    lbHosts.Enabled = true;
                }
                else
                {
                    lbHosts.Items.Clear();
                    lbHosts.Items.Add("No compatible hosts found :(");
                    lbHosts.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            tabControlRight.SelectedTab = tabHostName;
        }

        private void btnBeginHosting_Click(object sender, EventArgs e)
        {
            Host host = new Host(txtHostName.Text, PlayerSymbols.X, 8888, true, gridSize.ToString());
            GameForm game = new GameForm(gridSize);
            game.Host = host;
            game.InitializePlayerNames(txtHostName.Text, host.ClientUser);
            if (game.IsDisposed == false && host.IsHosting)
                game.ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbHosts.Items.Clear();
            try
            {
                HostSniffer sniffer = new HostSniffer(gridSize.ToString(), 8888);
                hosts = sniffer.PotentialHosts;
                if (hosts.Count > 0)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in hosts)
                    {
                        lbHosts.Items.Add(keyValuePair.Key);
                    }
                    lbHosts.Enabled = true;
                }
                else
                {
                    lbHosts.Items.Add("No compatible hosts found :(");
                    lbHosts.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtHostName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHostName.Text))
            {
                btnBeginHosting.Enabled = false;
            }
            else if (txtHostName.Text.Length > 10)
            {
                btnBeginHosting.Enabled = false;
            }
            else
            {
                btnBeginHosting.Enabled = true;
            }
        }
    }
}
