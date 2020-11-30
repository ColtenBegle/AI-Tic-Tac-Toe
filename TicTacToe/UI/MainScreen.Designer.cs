namespace TicTacToe.UI
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.labelGameName = new System.Windows.Forms.Label();
            this.btnAI = new System.Windows.Forms.Button();
            this.btnLocalMult = new System.Windows.Forms.Button();
            this.btnLANMult = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.TopDock = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.tabControlRight = new System.Windows.Forms.TabControl();
            this.tabPlayerMode = new System.Windows.Forms.TabPage();
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btn4x4 = new System.Windows.Forms.Button();
            this.btn3x3 = new System.Windows.Forms.Button();
            this.tabCustomize = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Player2Textbx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.musicCheckBox = new System.Windows.Forms.CheckBox();
            this.labelCustomize = new System.Windows.Forms.Label();
            this.tab3Grid = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabStartPage = new System.Windows.Forms.TabPage();
            this.MainScreenPic = new System.Windows.Forms.PictureBox();
            this.tabClientOrHost = new System.Windows.Forms.TabPage();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.tabLanConnectionPage = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.lbHosts = new System.Windows.Forms.ListBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tabHostName = new System.Windows.Forms.TabPage();
            this.btnBeginHosting = new System.Windows.Forms.Button();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.tabControlLeft = new System.Windows.Forms.TabControl();
            this.tabPlaySettings = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tabScoreboard = new System.Windows.Forms.TabPage();
            this.TopDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.tabControlRight.SuspendLayout();
            this.tabPlayerMode.SuspendLayout();
            this.tabCustomize.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab3Grid.SuspendLayout();
            this.tabStartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPic)).BeginInit();
            this.tabClientOrHost.SuspendLayout();
            this.tabLanConnectionPage.SuspendLayout();
            this.tabHostName.SuspendLayout();
            this.tabControlLeft.SuspendLayout();
            this.tabPlaySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelGameName.Font = new System.Drawing.Font("Franklin Gothic Heavy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.Location = new System.Drawing.Point(209, 0);
            this.labelGameName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(462, 81);
            this.labelGameName.TabIndex = 0;
            this.labelGameName.Text = "AI TIC-TAC-TOE";
            this.labelGameName.Click += new System.EventHandler(this.GameNameLabel_Click);
            // 
            // btnAI
            // 
            this.btnAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAI.BackColor = System.Drawing.SystemColors.Window;
            this.btnAI.Enabled = false;
            this.btnAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAI.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAI.Location = new System.Drawing.Point(41, 49);
            this.btnAI.Margin = new System.Windows.Forms.Padding(2);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(434, 80);
            this.btnAI.TabIndex = 1;
            this.btnAI.Text = "AI";
            this.btnAI.UseVisualStyleBackColor = false;
            this.btnAI.Click += new System.EventHandler(this.btnAI_Click);
            // 
            // btnLocalMult
            // 
            this.btnLocalMult.BackColor = System.Drawing.SystemColors.Window;
            this.btnLocalMult.Enabled = false;
            this.btnLocalMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalMult.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalMult.Location = new System.Drawing.Point(41, 158);
            this.btnLocalMult.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalMult.Name = "btnLocalMult";
            this.btnLocalMult.Size = new System.Drawing.Size(434, 89);
            this.btnLocalMult.TabIndex = 2;
            this.btnLocalMult.Text = "Local Multiplayer";
            this.btnLocalMult.UseVisualStyleBackColor = false;
            this.btnLocalMult.Click += new System.EventHandler(this.btnLocalMult_Click);
            // 
            // btnLANMult
            // 
            this.btnLANMult.BackColor = System.Drawing.SystemColors.Window;
            this.btnLANMult.Enabled = false;
            this.btnLANMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLANMult.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLANMult.Location = new System.Drawing.Point(41, 264);
            this.btnLANMult.Margin = new System.Windows.Forms.Padding(2);
            this.btnLANMult.Name = "btnLANMult";
            this.btnLANMult.Size = new System.Drawing.Size(434, 94);
            this.btnLANMult.TabIndex = 3;
            this.btnLANMult.Text = "LAN Multiplayer";
            this.btnLANMult.UseVisualStyleBackColor = false;
            this.btnLANMult.Click += new System.EventHandler(this.btnLANMult_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(3, 137);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(180, 118);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // TopDock
            // 
            this.TopDock.BackColor = System.Drawing.SystemColors.Window;
            this.TopDock.Controls.Add(this.picboxLogo);
            this.TopDock.Controls.Add(this.labelGameName);
            this.TopDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopDock.Location = new System.Drawing.Point(0, 0);
            this.TopDock.Name = "TopDock";
            this.TopDock.Size = new System.Drawing.Size(732, 100);
            this.TopDock.TabIndex = 6;
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picboxLogo.Image = global::TicTacToe.Properties.Resources.TicTacToeLogo;
            this.picboxLogo.Location = new System.Drawing.Point(45, 3);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(100, 94);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 1;
            this.picboxLogo.TabStop = false;
            // 
            // tabControlRight
            // 
            this.tabControlRight.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlRight.Controls.Add(this.tabPlayerMode);
            this.tabControlRight.Controls.Add(this.tabCustomize);
            this.tabControlRight.Controls.Add(this.tab3Grid);
            this.tabControlRight.Controls.Add(this.tabStartPage);
            this.tabControlRight.Controls.Add(this.tabClientOrHost);
            this.tabControlRight.Controls.Add(this.tabLanConnectionPage);
            this.tabControlRight.Controls.Add(this.tabHostName);
            this.tabControlRight.Location = new System.Drawing.Point(212, 106);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(507, 408);
            this.tabControlRight.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlRight.TabIndex = 4;
            this.tabControlRight.TabStop = false;
            // 
            // tabPlayerMode
            // 
            this.tabPlayerMode.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabPlayerMode.Controls.Add(this.btn5x5);
            this.tabPlayerMode.Controls.Add(this.btn4x4);
            this.tabPlayerMode.Controls.Add(this.btn3x3);
            this.tabPlayerMode.Controls.Add(this.btnLANMult);
            this.tabPlayerMode.Controls.Add(this.btnAI);
            this.tabPlayerMode.Controls.Add(this.btnLocalMult);
            this.tabPlayerMode.Location = new System.Drawing.Point(4, 25);
            this.tabPlayerMode.Name = "tabPlayerMode";
            this.tabPlayerMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerMode.Size = new System.Drawing.Size(499, 379);
            this.tabPlayerMode.TabIndex = 1;
            this.tabPlayerMode.Text = "tabPlayerMode";
            // 
            // btn5x5
            // 
            this.btn5x5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5x5.BackColor = System.Drawing.SystemColors.Window;
            this.btn5x5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5x5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5x5.Location = new System.Drawing.Point(368, 5);
            this.btn5x5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(108, 32);
            this.btn5x5.TabIndex = 6;
            this.btn5x5.Text = "5x5";
            this.btn5x5.UseVisualStyleBackColor = false;
            this.btn5x5.Click += new System.EventHandler(this.btn5x5_Click);
            // 
            // btn4x4
            // 
            this.btn4x4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4x4.BackColor = System.Drawing.SystemColors.Window;
            this.btn4x4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4x4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4x4.Location = new System.Drawing.Point(205, 5);
            this.btn4x4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4x4.Name = "btn4x4";
            this.btn4x4.Size = new System.Drawing.Size(108, 32);
            this.btn4x4.TabIndex = 5;
            this.btn4x4.Text = "4x4";
            this.btn4x4.UseVisualStyleBackColor = false;
            this.btn4x4.Click += new System.EventHandler(this.btn4x4_Click);
            // 
            // btn3x3
            // 
            this.btn3x3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3x3.BackColor = System.Drawing.SystemColors.Window;
            this.btn3x3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3x3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3x3.Location = new System.Drawing.Point(41, 5);
            this.btn3x3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(108, 32);
            this.btn3x3.TabIndex = 4;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = false;
            this.btn3x3.Click += new System.EventHandler(this.btn3x3_Click);
            // 
            // tabCustomize
            // 
            this.tabCustomize.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabCustomize.Controls.Add(this.panel2);
            this.tabCustomize.Controls.Add(this.panel1);
            this.tabCustomize.Controls.Add(this.Player2Textbx);
            this.tabCustomize.Controls.Add(this.label2);
            this.tabCustomize.Controls.Add(this.label1);
            this.tabCustomize.Controls.Add(this.musicListBox);
            this.tabCustomize.Controls.Add(this.musicCheckBox);
            this.tabCustomize.Controls.Add(this.labelCustomize);
            this.tabCustomize.Location = new System.Drawing.Point(4, 25);
            this.tabCustomize.Name = "tabCustomize";
            this.tabCustomize.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomize.Size = new System.Drawing.Size(499, 379);
            this.tabCustomize.TabIndex = 2;
            this.tabCustomize.Text = "tabCustomize";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Location = new System.Drawing.Point(332, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 87);
            this.panel2.TabIndex = 13;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton4.Location = new System.Drawing.Point(18, 63);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 19);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Bomb";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton5.Location = new System.Drawing.Point(18, 35);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(56, 19);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Crown";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton6.Location = new System.Drawing.Point(18, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(80, 19);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Traditional";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(334, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 87);
            this.panel1.TabIndex = 11;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(18, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 19);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bomb";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(18, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Crown";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(18, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Traditional";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Player2Textbx
            // 
            this.Player2Textbx.AutoSize = true;
            this.Player2Textbx.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Textbx.ForeColor = System.Drawing.SystemColors.Window;
            this.Player2Textbx.Location = new System.Drawing.Point(324, 227);
            this.Player2Textbx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2Textbx.Name = "Player2Textbx";
            this.Player2Textbx.Size = new System.Drawing.Size(131, 44);
            this.Player2Textbx.TabIndex = 9;
            this.Player2Textbx.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(324, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(34, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Songs";
            // 
            // musicListBox
            // 
            this.musicListBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.musicListBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.ItemHeight = 21;
            this.musicListBox.Location = new System.Drawing.Point(25, 227);
            this.musicListBox.Margin = new System.Windows.Forms.Padding(2);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(132, 88);
            this.musicListBox.TabIndex = 4;
            this.musicListBox.SelectedIndexChanged += new System.EventHandler(this.musicListBox_SelectedIndexChanged);
            // 
            // musicCheckBox
            // 
            this.musicCheckBox.AutoSize = true;
            this.musicCheckBox.Checked = true;
            this.musicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.musicCheckBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.musicCheckBox.Location = new System.Drawing.Point(16, 97);
            this.musicCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.musicCheckBox.Name = "musicCheckBox";
            this.musicCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.musicCheckBox.Size = new System.Drawing.Size(123, 48);
            this.musicCheckBox.TabIndex = 3;
            this.musicCheckBox.Text = "Music";
            this.musicCheckBox.UseVisualStyleBackColor = true;
            this.musicCheckBox.CheckedChanged += new System.EventHandler(this.musicCheckBox_CheckedChanged);
            // 
            // labelCustomize
            // 
            this.labelCustomize.BackColor = System.Drawing.SystemColors.Window;
            this.labelCustomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCustomize.Font = new System.Drawing.Font("Franklin Gothic Heavy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomize.Location = new System.Drawing.Point(3, 3);
            this.labelCustomize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomize.Name = "labelCustomize";
            this.labelCustomize.Size = new System.Drawing.Size(493, 81);
            this.labelCustomize.TabIndex = 1;
            this.labelCustomize.Text = "Customize";
            this.labelCustomize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab3Grid
            // 
            this.tab3Grid.BackColor = System.Drawing.SystemColors.WindowText;
            this.tab3Grid.Controls.Add(this.button9);
            this.tab3Grid.Controls.Add(this.button8);
            this.tab3Grid.Controls.Add(this.button7);
            this.tab3Grid.Controls.Add(this.button6);
            this.tab3Grid.Controls.Add(this.button5);
            this.tab3Grid.Controls.Add(this.button4);
            this.tab3Grid.Controls.Add(this.button3);
            this.tab3Grid.Controls.Add(this.button2);
            this.tab3Grid.Controls.Add(this.button1);
            this.tab3Grid.Location = new System.Drawing.Point(4, 25);
            this.tab3Grid.Name = "tab3Grid";
            this.tab3Grid.Padding = new System.Windows.Forms.Padding(3);
            this.tab3Grid.Size = new System.Drawing.Size(499, 379);
            this.tab3Grid.TabIndex = 3;
            this.tab3Grid.Text = "tab3Grid";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Window;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(332, 258);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(198, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(65, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(332, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(198, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(65, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(332, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(198, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(65, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabStartPage
            // 
            this.tabStartPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabStartPage.Controls.Add(this.MainScreenPic);
            this.tabStartPage.Location = new System.Drawing.Point(4, 25);
            this.tabStartPage.Name = "tabStartPage";
            this.tabStartPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStartPage.Size = new System.Drawing.Size(499, 379);
            this.tabStartPage.TabIndex = 0;
            this.tabStartPage.Text = "tabStartPage";
            // 
            // MainScreenPic
            // 
            this.MainScreenPic.BackColor = System.Drawing.SystemColors.Window;
            this.MainScreenPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainScreenPic.Image = ((System.Drawing.Image)(resources.GetObject("MainScreenPic.Image")));
            this.MainScreenPic.Location = new System.Drawing.Point(57, 14);
            this.MainScreenPic.Name = "MainScreenPic";
            this.MainScreenPic.Size = new System.Drawing.Size(386, 360);
            this.MainScreenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainScreenPic.TabIndex = 8;
            this.MainScreenPic.TabStop = false;
            // 
            // tabClientOrHost
            // 
            this.tabClientOrHost.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabClientOrHost.Controls.Add(this.btnHost);
            this.tabClientOrHost.Controls.Add(this.btnClient);
            this.tabClientOrHost.ForeColor = System.Drawing.Color.Black;
            this.tabClientOrHost.Location = new System.Drawing.Point(4, 25);
            this.tabClientOrHost.Margin = new System.Windows.Forms.Padding(2);
            this.tabClientOrHost.Name = "tabClientOrHost";
            this.tabClientOrHost.Size = new System.Drawing.Size(499, 379);
            this.tabClientOrHost.TabIndex = 5;
            this.tabClientOrHost.Text = "tabClientorHost";
            // 
            // btnHost
            // 
            this.btnHost.BackColor = System.Drawing.SystemColors.Window;
            this.btnHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHost.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.Location = new System.Drawing.Point(101, 193);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(302, 118);
            this.btnHost.TabIndex = 5;
            this.btnHost.Text = "HOST";
            this.btnHost.UseVisualStyleBackColor = false;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.Window;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(101, 20);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(302, 118);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "CLIENT";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // tabLanConnectionPage
            // 
            this.tabLanConnectionPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabLanConnectionPage.Controls.Add(this.btnRefresh);
            this.tabLanConnectionPage.Controls.Add(this.btnJoin);
            this.tabLanConnectionPage.Controls.Add(this.lbHosts);
            this.tabLanConnectionPage.Controls.Add(this.txtUserName);
            this.tabLanConnectionPage.Location = new System.Drawing.Point(4, 25);
            this.tabLanConnectionPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabLanConnectionPage.Name = "tabLanConnectionPage";
            this.tabLanConnectionPage.Size = new System.Drawing.Size(499, 379);
            this.tabLanConnectionPage.TabIndex = 4;
            this.tabLanConnectionPage.Text = "tabPage1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(404, 288);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 30);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.SystemColors.Window;
            this.btnJoin.Enabled = false;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(181, 301);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(151, 57);
            this.btnJoin.TabIndex = 5;
            this.btnJoin.Text = "JOIN";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lbHosts
            // 
            this.lbHosts.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbHosts.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHosts.ForeColor = System.Drawing.SystemColors.Window;
            this.lbHosts.FormattingEnabled = true;
            this.lbHosts.ItemHeight = 28;
            this.lbHosts.Location = new System.Drawing.Point(39, 58);
            this.lbHosts.Margin = new System.Windows.Forms.Padding(2);
            this.lbHosts.Name = "lbHosts";
            this.lbHosts.Size = new System.Drawing.Size(430, 200);
            this.lbHosts.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(111, 11);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(289, 44);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // tabHostName
            // 
            this.tabHostName.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabHostName.Controls.Add(this.btnBeginHosting);
            this.tabHostName.Controls.Add(this.txtHostName);
            this.tabHostName.Location = new System.Drawing.Point(4, 25);
            this.tabHostName.Margin = new System.Windows.Forms.Padding(2);
            this.tabHostName.Name = "tabHostName";
            this.tabHostName.Size = new System.Drawing.Size(499, 379);
            this.tabHostName.TabIndex = 6;
            this.tabHostName.Text = "hostNameTab";
            // 
            // btnBeginHosting
            // 
            this.btnBeginHosting.BackColor = System.Drawing.SystemColors.Window;
            this.btnBeginHosting.Enabled = false;
            this.btnBeginHosting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginHosting.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginHosting.Location = new System.Drawing.Point(159, 153);
            this.btnBeginHosting.Name = "btnBeginHosting";
            this.btnBeginHosting.Size = new System.Drawing.Size(187, 96);
            this.btnBeginHosting.TabIndex = 4;
            this.btnBeginHosting.Text = "BEGIN HOSTING";
            this.btnBeginHosting.UseVisualStyleBackColor = false;
            this.btnBeginHosting.Click += new System.EventHandler(this.btnBeginHosting_Click);
            // 
            // txtHostName
            // 
            this.txtHostName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostName.Location = new System.Drawing.Point(110, 48);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(2);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(289, 44);
            this.txtHostName.TabIndex = 1;
            this.txtHostName.TextChanged += new System.EventHandler(this.txtHostName_TextChanged);
            // 
            // tabControlLeft
            // 
            this.tabControlLeft.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlLeft.Controls.Add(this.tabPlaySettings);
            this.tabControlLeft.Controls.Add(this.tabScoreboard);
            this.tabControlLeft.Location = new System.Drawing.Point(12, 106);
            this.tabControlLeft.Name = "tabControlLeft";
            this.tabControlLeft.SelectedIndex = 0;
            this.tabControlLeft.Size = new System.Drawing.Size(194, 409);
            this.tabControlLeft.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlLeft.TabIndex = 9;
            // 
            // tabPlaySettings
            // 
            this.tabPlaySettings.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabPlaySettings.Controls.Add(this.button10);
            this.tabPlaySettings.Controls.Add(this.buttonPlay);
            this.tabPlaySettings.Controls.Add(this.buttonSettings);
            this.tabPlaySettings.Location = new System.Drawing.Point(4, 25);
            this.tabPlaySettings.Name = "tabPlaySettings";
            this.tabPlaySettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaySettings.Size = new System.Drawing.Size(186, 380);
            this.tabPlaySettings.TabIndex = 0;
            this.tabPlaySettings.Text = "tabPlaySettings";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Window;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(3, 264);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(180, 118);
            this.button10.TabIndex = 3;
            this.button10.Text = "EXIT";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(3, 11);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(180, 118);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // tabScoreboard
            // 
            this.tabScoreboard.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabScoreboard.Location = new System.Drawing.Point(4, 25);
            this.tabScoreboard.Name = "tabScoreboard";
            this.tabScoreboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabScoreboard.Size = new System.Drawing.Size(186, 380);
            this.tabScoreboard.TabIndex = 1;
            this.tabScoreboard.Text = "tabScoreboard";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(732, 532);
            this.Controls.Add(this.tabControlLeft);
            this.Controls.Add(this.tabControlRight);
            this.Controls.Add(this.TopDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.TopDock.ResumeLayout(false);
            this.TopDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.tabControlRight.ResumeLayout(false);
            this.tabPlayerMode.ResumeLayout(false);
            this.tabCustomize.ResumeLayout(false);
            this.tabCustomize.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab3Grid.ResumeLayout(false);
            this.tabStartPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPic)).EndInit();
            this.tabClientOrHost.ResumeLayout(false);
            this.tabLanConnectionPage.ResumeLayout(false);
            this.tabLanConnectionPage.PerformLayout();
            this.tabHostName.ResumeLayout(false);
            this.tabHostName.PerformLayout();
            this.tabControlLeft.ResumeLayout(false);
            this.tabPlaySettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Button btnAI;
        private System.Windows.Forms.Button btnLocalMult;
        private System.Windows.Forms.Button btnLANMult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel TopDock;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.PictureBox MainScreenPic;
        private System.Windows.Forms.Label labelCustomize;
        private System.Windows.Forms.TabControl tabControlRight;
        private System.Windows.Forms.TabPage tabStartPage;
        private System.Windows.Forms.TabPage tabPlayerMode;
        private System.Windows.Forms.TabPage tabCustomize;
        private System.Windows.Forms.TabControl tabControlLeft;
        private System.Windows.Forms.TabPage tabPlaySettings;
        private System.Windows.Forms.TabPage tabScoreboard;
        public System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TabPage tab3Grid;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.Button btn4x4;
        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.CheckBox musicCheckBox;
        private System.Windows.Forms.ListBox musicListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabLanConnectionPage;
        public System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.ListBox lbHosts;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TabPage tabClientOrHost;
        public System.Windows.Forms.Button btnHost;
        public System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.TabPage tabHostName;
        public System.Windows.Forms.Button btnBeginHosting;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Player2Textbx;
        private System.Windows.Forms.Label label2;
    }
}