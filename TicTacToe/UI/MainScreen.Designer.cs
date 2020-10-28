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
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.btnAI = new System.Windows.Forms.Button();
            this.btnLocalMult = new System.Windows.Forms.Button();
            this.btnLANMult = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LeftDock = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TopDock = new System.Windows.Forms.Panel();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.GameTypePanel = new System.Windows.Forms.Panel();
            this.MainScreenPic = new System.Windows.Forms.PictureBox();
            this.panelCustomize = new System.Windows.Forms.Panel();
            this.labelCustomize = new System.Windows.Forms.Label();
            this.LeftDock.SuspendLayout();
            this.TopDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.GameTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPic)).BeginInit();
            this.panelCustomize.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameNameLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameLabel.Location = new System.Drawing.Point(199, 9);
            this.GameNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(462, 81);
            this.GameNameLabel.TabIndex = 0;
            this.GameNameLabel.Text = "AI TIC-TAC-TOE";
            this.GameNameLabel.Click += new System.EventHandler(this.GameNameLabel_Click);
            // 
            // btnAI
            // 
            this.btnAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAI.BackColor = System.Drawing.SystemColors.Window;
            this.btnAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAI.Location = new System.Drawing.Point(34, 26);
            this.btnAI.Margin = new System.Windows.Forms.Padding(2);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(434, 80);
            this.btnAI.TabIndex = 1;
            this.btnAI.Text = "AI";
            this.btnAI.UseVisualStyleBackColor = false;
            // 
            // btnLocalMult
            // 
            this.btnLocalMult.BackColor = System.Drawing.SystemColors.Window;
            this.btnLocalMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalMult.Location = new System.Drawing.Point(36, 123);
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
            this.btnLANMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLANMult.Location = new System.Drawing.Point(36, 231);
            this.btnLANMult.Margin = new System.Windows.Forms.Padding(2);
            this.btnLANMult.Name = "btnLANMult";
            this.btnLANMult.Size = new System.Drawing.Size(434, 94);
            this.btnLANMult.TabIndex = 3;
            this.btnLANMult.Text = "LAN Multiplayer";
            this.btnLANMult.UseVisualStyleBackColor = false;
            // 
            // LeftDock
            // 
            this.LeftDock.BackColor = System.Drawing.SystemColors.WindowText;
            this.LeftDock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeftDock.Controls.Add(this.button2);
            this.LeftDock.Controls.Add(this.button1);
            this.LeftDock.Location = new System.Drawing.Point(3, 106);
            this.LeftDock.Name = "LeftDock";
            this.LeftDock.Size = new System.Drawing.Size(194, 373);
            this.LeftDock.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 156);
            this.button2.TabIndex = 1;
            this.button2.Text = "SETTINGS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 156);
            this.button1.TabIndex = 0;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TopDock
            // 
            this.TopDock.BackColor = System.Drawing.SystemColors.Window;
            this.TopDock.Controls.Add(this.LogoPic);
            this.TopDock.Controls.Add(this.GameNameLabel);
            this.TopDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopDock.Location = new System.Drawing.Point(0, 0);
            this.TopDock.Name = "TopDock";
            this.TopDock.Size = new System.Drawing.Size(708, 100);
            this.TopDock.TabIndex = 6;
            // 
            // LogoPic
            // 
            this.LogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.Location = new System.Drawing.Point(45, 3);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(100, 94);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 1;
            this.LogoPic.TabStop = false;
            // 
            // GameTypePanel
            // 
            this.GameTypePanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.GameTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameTypePanel.Controls.Add(this.btnLANMult);
            this.GameTypePanel.Controls.Add(this.btnAI);
            this.GameTypePanel.Controls.Add(this.btnLocalMult);
            this.GameTypePanel.Location = new System.Drawing.Point(203, 106);
            this.GameTypePanel.Name = "GameTypePanel";
            this.GameTypePanel.Size = new System.Drawing.Size(502, 373);
            this.GameTypePanel.TabIndex = 7;
            // 
            // MainScreenPic
            // 
            this.MainScreenPic.BackColor = System.Drawing.SystemColors.Window;
            this.MainScreenPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainScreenPic.Image = ((System.Drawing.Image)(resources.GetObject("MainScreenPic.Image")));
            this.MainScreenPic.Location = new System.Drawing.Point(265, 111);
            this.MainScreenPic.Name = "MainScreenPic";
            this.MainScreenPic.Size = new System.Drawing.Size(386, 360);
            this.MainScreenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainScreenPic.TabIndex = 8;
            this.MainScreenPic.TabStop = false;
            // 
            // panelCustomize
            // 
            this.panelCustomize.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelCustomize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCustomize.Controls.Add(this.labelCustomize);
            this.panelCustomize.Location = new System.Drawing.Point(203, 106);
            this.panelCustomize.Name = "panelCustomize";
            this.panelCustomize.Size = new System.Drawing.Size(502, 373);
            this.panelCustomize.TabIndex = 9;
            // 
            // labelCustomize
            // 
            this.labelCustomize.BackColor = System.Drawing.SystemColors.Window;
            this.labelCustomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCustomize.Font = new System.Drawing.Font("Franklin Gothic Heavy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomize.Location = new System.Drawing.Point(0, 0);
            this.labelCustomize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomize.Name = "labelCustomize";
            this.labelCustomize.Size = new System.Drawing.Size(498, 81);
            this.labelCustomize.TabIndex = 1;
            this.labelCustomize.Text = "Customize";
            this.labelCustomize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(708, 483);
            this.Controls.Add(this.TopDock);
            this.Controls.Add(this.LeftDock);
            this.Controls.Add(this.GameTypePanel);
            this.Controls.Add(this.MainScreenPic);
            this.Controls.Add(this.panelCustomize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.LeftDock.ResumeLayout(false);
            this.TopDock.ResumeLayout(false);
            this.TopDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.GameTypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPic)).EndInit();
            this.panelCustomize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Button btnAI;
        private System.Windows.Forms.Button btnLocalMult;
        private System.Windows.Forms.Button btnLANMult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel LeftDock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel TopDock;
        private System.Windows.Forms.Panel GameTypePanel;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.PictureBox MainScreenPic;
        private System.Windows.Forms.Panel panelCustomize;
        private System.Windows.Forms.Label labelCustomize;
    }
}