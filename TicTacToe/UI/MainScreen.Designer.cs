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
            this.tabStartPage = new System.Windows.Forms.TabPage();
            this.MainScreenPic = new System.Windows.Forms.PictureBox();
            this.tabPlayerMode = new System.Windows.Forms.TabPage();
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btn4x4 = new System.Windows.Forms.Button();
            this.btn3x3 = new System.Windows.Forms.Button();
            this.tabCustomize = new System.Windows.Forms.TabPage();
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
            this.tabControlLeft = new System.Windows.Forms.TabControl();
            this.tabPlaySettings = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tabScoreboard = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TopDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.tabControlRight.SuspendLayout();
            this.tabStartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPic)).BeginInit();
            this.tabPlayerMode.SuspendLayout();
            this.tabCustomize.SuspendLayout();
            this.tab3Grid.SuspendLayout();
            this.tabControlLeft.SuspendLayout();
            this.tabPlaySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelGameName.Font = new System.Drawing.Font("Franklin Gothic Heavy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.Location = new System.Drawing.Point(279, 0);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(577, 101);
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
            this.btnAI.Location = new System.Drawing.Point(55, 60);
            this.btnAI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(579, 98);
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
            this.btnLocalMult.Location = new System.Drawing.Point(55, 194);
            this.btnLocalMult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocalMult.Name = "btnLocalMult";
            this.btnLocalMult.Size = new System.Drawing.Size(579, 110);
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
            this.btnLANMult.Location = new System.Drawing.Point(55, 325);
            this.btnLANMult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLANMult.Name = "btnLANMult";
            this.btnLANMult.Size = new System.Drawing.Size(579, 116);
            this.btnLANMult.TabIndex = 3;
            this.btnLANMult.Text = "LAN Multiplayer (Under construction)";
            this.btnLANMult.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(4, 169);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(240, 145);
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
            this.TopDock.Margin = new System.Windows.Forms.Padding(4);
            this.TopDock.Name = "TopDock";
            this.TopDock.Size = new System.Drawing.Size(976, 123);
            this.TopDock.TabIndex = 6;
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picboxLogo.Image = global::TicTacToe.Properties.Resources.TicTacToeLogo;
            this.picboxLogo.Location = new System.Drawing.Point(60, 4);
            this.picboxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(133, 116);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 1;
            this.picboxLogo.TabStop = false;
            // 
            // tabControlRight
            // 
            this.tabControlRight.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlRight.Controls.Add(this.tabStartPage);
            this.tabControlRight.Controls.Add(this.tabPlayerMode);
            this.tabControlRight.Controls.Add(this.tabCustomize);
            this.tabControlRight.Controls.Add(this.tab3Grid);
            this.tabControlRight.Location = new System.Drawing.Point(283, 130);
            this.tabControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(676, 503);
            this.tabControlRight.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlRight.TabIndex = 4;
            this.tabControlRight.TabStop = false;
            // 
            // tabStartPage
            // 
            this.tabStartPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabStartPage.Controls.Add(this.MainScreenPic);
            this.tabStartPage.Location = new System.Drawing.Point(4, 28);
            this.tabStartPage.Margin = new System.Windows.Forms.Padding(4);
            this.tabStartPage.Name = "tabStartPage";
            this.tabStartPage.Padding = new System.Windows.Forms.Padding(4);
            this.tabStartPage.Size = new System.Drawing.Size(668, 471);
            this.tabStartPage.TabIndex = 0;
            this.tabStartPage.Text = "tabStartPage";
            // 
            // MainScreenPic
            // 
            this.MainScreenPic.BackColor = System.Drawing.SystemColors.Window;
            this.MainScreenPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainScreenPic.Image = ((System.Drawing.Image)(resources.GetObject("MainScreenPic.Image")));
            this.MainScreenPic.Location = new System.Drawing.Point(76, 17);
            this.MainScreenPic.Margin = new System.Windows.Forms.Padding(4);
            this.MainScreenPic.Name = "MainScreenPic";
            this.MainScreenPic.Size = new System.Drawing.Size(515, 443);
            this.MainScreenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainScreenPic.TabIndex = 8;
            this.MainScreenPic.TabStop = false;
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
            this.tabPlayerMode.Location = new System.Drawing.Point(4, 28);
            this.tabPlayerMode.Margin = new System.Windows.Forms.Padding(4);
            this.tabPlayerMode.Name = "tabPlayerMode";
            this.tabPlayerMode.Padding = new System.Windows.Forms.Padding(4);
            this.tabPlayerMode.Size = new System.Drawing.Size(668, 471);
            this.tabPlayerMode.TabIndex = 1;
            this.tabPlayerMode.Text = "tabPlayerMode";
            // 
            // btn5x5
            // 
            this.btn5x5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5x5.BackColor = System.Drawing.SystemColors.Window;
            this.btn5x5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5x5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5x5.Location = new System.Drawing.Point(490, 6);
            this.btn5x5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(144, 40);
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
            this.btn4x4.Location = new System.Drawing.Point(273, 6);
            this.btn4x4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4x4.Name = "btn4x4";
            this.btn4x4.Size = new System.Drawing.Size(144, 40);
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
            this.btn3x3.Location = new System.Drawing.Point(55, 6);
            this.btn3x3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(144, 40);
            this.btn3x3.TabIndex = 4;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = false;
            this.btn3x3.Click += new System.EventHandler(this.btn3x3_Click);
            // 
            // tabCustomize
            // 
            this.tabCustomize.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabCustomize.Controls.Add(this.label1);
            this.tabCustomize.Controls.Add(this.musicListBox);
            this.tabCustomize.Controls.Add(this.musicCheckBox);
            this.tabCustomize.Controls.Add(this.labelCustomize);
            this.tabCustomize.Location = new System.Drawing.Point(4, 28);
            this.tabCustomize.Margin = new System.Windows.Forms.Padding(4);
            this.tabCustomize.Name = "tabCustomize";
            this.tabCustomize.Padding = new System.Windows.Forms.Padding(4);
            this.tabCustomize.Size = new System.Drawing.Size(668, 471);
            this.tabCustomize.TabIndex = 2;
            this.tabCustomize.Text = "tabCustomize";
            // 
            // musicListBox
            // 
            this.musicListBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.musicListBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.ItemHeight = 25;
            this.musicListBox.Location = new System.Drawing.Point(165, 190);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(174, 129);
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
            this.musicCheckBox.Location = new System.Drawing.Point(21, 119);
            this.musicCheckBox.Name = "musicCheckBox";
            this.musicCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.musicCheckBox.Size = new System.Drawing.Size(155, 65);
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
            this.labelCustomize.Location = new System.Drawing.Point(4, 4);
            this.labelCustomize.Name = "labelCustomize";
            this.labelCustomize.Size = new System.Drawing.Size(660, 100);
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
            this.tab3Grid.Location = new System.Drawing.Point(4, 28);
            this.tab3Grid.Margin = new System.Windows.Forms.Padding(4);
            this.tab3Grid.Name = "tab3Grid";
            this.tab3Grid.Padding = new System.Windows.Forms.Padding(4);
            this.tab3Grid.Size = new System.Drawing.Size(668, 471);
            this.tab3Grid.TabIndex = 3;
            this.tab3Grid.Text = "tab3Grid";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Window;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(443, 318);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 123);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(264, 318);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 123);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(87, 318);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 123);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(443, 164);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 123);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(264, 164);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 123);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(87, 164);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 123);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(443, 7);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 123);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(264, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 123);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(87, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 123);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlLeft
            // 
            this.tabControlLeft.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlLeft.Controls.Add(this.tabPlaySettings);
            this.tabControlLeft.Controls.Add(this.tabScoreboard);
            this.tabControlLeft.Location = new System.Drawing.Point(16, 130);
            this.tabControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlLeft.Name = "tabControlLeft";
            this.tabControlLeft.SelectedIndex = 0;
            this.tabControlLeft.Size = new System.Drawing.Size(259, 503);
            this.tabControlLeft.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlLeft.TabIndex = 9;
            // 
            // tabPlaySettings
            // 
            this.tabPlaySettings.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabPlaySettings.Controls.Add(this.button10);
            this.tabPlaySettings.Controls.Add(this.buttonPlay);
            this.tabPlaySettings.Controls.Add(this.buttonSettings);
            this.tabPlaySettings.Location = new System.Drawing.Point(4, 28);
            this.tabPlaySettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabPlaySettings.Name = "tabPlaySettings";
            this.tabPlaySettings.Padding = new System.Windows.Forms.Padding(4);
            this.tabPlaySettings.Size = new System.Drawing.Size(251, 471);
            this.tabPlaySettings.TabIndex = 0;
            this.tabPlaySettings.Text = "tabPlaySettings";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Window;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(4, 325);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(240, 145);
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
            this.buttonPlay.Location = new System.Drawing.Point(4, 13);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(240, 145);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // tabScoreboard
            // 
            this.tabScoreboard.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabScoreboard.Location = new System.Drawing.Point(4, 28);
            this.tabScoreboard.Margin = new System.Windows.Forms.Padding(4);
            this.tabScoreboard.Name = "tabScoreboard";
            this.tabScoreboard.Padding = new System.Windows.Forms.Padding(4);
            this.tabScoreboard.Size = new System.Drawing.Size(251, 471);
            this.tabScoreboard.TabIndex = 1;
            this.tabScoreboard.Text = "tabScoreboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(23, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "Songs";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(976, 655);
            this.Controls.Add(this.tabControlLeft);
            this.Controls.Add(this.tabControlRight);
            this.Controls.Add(this.TopDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.TopDock.ResumeLayout(false);
            this.TopDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.tabControlRight.ResumeLayout(false);
            this.tabStartPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPic)).EndInit();
            this.tabPlayerMode.ResumeLayout(false);
            this.tabCustomize.ResumeLayout(false);
            this.tabCustomize.PerformLayout();
            this.tab3Grid.ResumeLayout(false);
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
    }
}