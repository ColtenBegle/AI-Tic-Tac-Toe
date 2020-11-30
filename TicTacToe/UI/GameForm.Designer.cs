namespace TicTacToe
{
    partial class GameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelGameName = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayingAgainst = new System.Windows.Forms.Label();
            this.btnPoint9 = new System.Windows.Forms.Button();
            this.btnPoint8 = new System.Windows.Forms.Button();
            this.btnPoint7 = new System.Windows.Forms.Button();
            this.btnPoint6 = new System.Windows.Forms.Button();
            this.btnPoint5 = new System.Windows.Forms.Button();
            this.btnPoint4 = new System.Windows.Forms.Button();
            this.btnPoint3 = new System.Windows.Forms.Button();
            this.btnPoint2 = new System.Windows.Forms.Button();
            this.btnPoint1 = new System.Windows.Forms.Button();
            this.btnPoint10 = new System.Windows.Forms.Button();
            this.btnPoint11 = new System.Windows.Forms.Button();
            this.btnPoint12 = new System.Windows.Forms.Button();
            this.btnPoint13 = new System.Windows.Forms.Button();
            this.btnPoint14 = new System.Windows.Forms.Button();
            this.btnPoint15 = new System.Windows.Forms.Button();
            this.btnPoint16 = new System.Windows.Forms.Button();
            this.btnPoint17 = new System.Windows.Forms.Button();
            this.btnPoint18 = new System.Windows.Forms.Button();
            this.btnPoint19 = new System.Windows.Forms.Button();
            this.btnPoint20 = new System.Windows.Forms.Button();
            this.btnPoint21 = new System.Windows.Forms.Button();
            this.btnPoint22 = new System.Windows.Forms.Button();
            this.btnPoint23 = new System.Windows.Forms.Button();
            this.btnPoint24 = new System.Windows.Forms.Button();
            this.btnPoint25 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.player1Wins = new System.Windows.Forms.Label();
            this.lblPlayer2Wins = new System.Windows.Forms.Label();
            this.player1WinsCount = new System.Windows.Forms.Label();
            this.player2WinsCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 608);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblPlayer2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblPlayer1);
            this.panel3.Controls.Add(this.lblPlayingAgainst);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 608);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.labelGameName);
            this.panel5.Location = new System.Drawing.Point(12, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(643, 45);
            this.panel5.TabIndex = 7;
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.BackColor = System.Drawing.Color.White;
            this.labelGameName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelGameName.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.Location = new System.Drawing.Point(216, 6);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(239, 38);
            this.labelGameName.TabIndex = 6;
            this.labelGameName.Text = "AI TIC-TAC-TOE";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPlayer2.Location = new System.Drawing.Point(564, 47);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(91, 36);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(467, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(12, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 516);
            this.panel4.TabIndex = 3;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPlayer1.Location = new System.Drawing.Point(116, 47);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(91, 36);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "player1";
            // 
            // lblPlayingAgainst
            // 
            this.lblPlayingAgainst.AutoSize = true;
            this.lblPlayingAgainst.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingAgainst.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPlayingAgainst.Location = new System.Drawing.Point(6, 47);
            this.lblPlayingAgainst.Name = "lblPlayingAgainst";
            this.lblPlayingAgainst.Size = new System.Drawing.Size(104, 36);
            this.lblPlayingAgainst.TabIndex = 1;
            this.lblPlayingAgainst.Text = "Player 1:";
            // 
            // btnPoint9
            // 
            this.btnPoint9.Location = new System.Drawing.Point(0, 0);
            this.btnPoint9.Name = "btnPoint9";
            this.btnPoint9.Size = new System.Drawing.Size(75, 23);
            this.btnPoint9.TabIndex = 0;
            // 
            // btnPoint8
            // 
            this.btnPoint8.Location = new System.Drawing.Point(0, 0);
            this.btnPoint8.Name = "btnPoint8";
            this.btnPoint8.Size = new System.Drawing.Size(75, 23);
            this.btnPoint8.TabIndex = 0;
            // 
            // btnPoint7
            // 
            this.btnPoint7.Location = new System.Drawing.Point(0, 0);
            this.btnPoint7.Name = "btnPoint7";
            this.btnPoint7.Size = new System.Drawing.Size(75, 23);
            this.btnPoint7.TabIndex = 0;
            // 
            // btnPoint6
            // 
            this.btnPoint6.Location = new System.Drawing.Point(0, 0);
            this.btnPoint6.Name = "btnPoint6";
            this.btnPoint6.Size = new System.Drawing.Size(75, 23);
            this.btnPoint6.TabIndex = 0;
            // 
            // btnPoint5
            // 
            this.btnPoint5.Location = new System.Drawing.Point(0, 0);
            this.btnPoint5.Name = "btnPoint5";
            this.btnPoint5.Size = new System.Drawing.Size(75, 23);
            this.btnPoint5.TabIndex = 0;
            // 
            // btnPoint4
            // 
            this.btnPoint4.Location = new System.Drawing.Point(0, 0);
            this.btnPoint4.Name = "btnPoint4";
            this.btnPoint4.Size = new System.Drawing.Size(75, 23);
            this.btnPoint4.TabIndex = 0;
            // 
            // btnPoint3
            // 
            this.btnPoint3.Location = new System.Drawing.Point(0, 0);
            this.btnPoint3.Name = "btnPoint3";
            this.btnPoint3.Size = new System.Drawing.Size(75, 23);
            this.btnPoint3.TabIndex = 0;
            // 
            // btnPoint2
            // 
            this.btnPoint2.Location = new System.Drawing.Point(0, 0);
            this.btnPoint2.Name = "btnPoint2";
            this.btnPoint2.Size = new System.Drawing.Size(75, 23);
            this.btnPoint2.TabIndex = 0;
            // 
            // btnPoint1
            // 
            this.btnPoint1.Location = new System.Drawing.Point(0, 0);
            this.btnPoint1.Name = "btnPoint1";
            this.btnPoint1.Size = new System.Drawing.Size(75, 23);
            this.btnPoint1.TabIndex = 0;
            // 
            // btnPoint10
            // 
            this.btnPoint10.Location = new System.Drawing.Point(0, 0);
            this.btnPoint10.Name = "btnPoint10";
            this.btnPoint10.Size = new System.Drawing.Size(75, 23);
            this.btnPoint10.TabIndex = 0;
            // 
            // btnPoint11
            // 
            this.btnPoint11.Location = new System.Drawing.Point(0, 0);
            this.btnPoint11.Name = "btnPoint11";
            this.btnPoint11.Size = new System.Drawing.Size(75, 23);
            this.btnPoint11.TabIndex = 0;
            // 
            // btnPoint12
            // 
            this.btnPoint12.Location = new System.Drawing.Point(0, 0);
            this.btnPoint12.Name = "btnPoint12";
            this.btnPoint12.Size = new System.Drawing.Size(75, 23);
            this.btnPoint12.TabIndex = 0;
            // 
            // btnPoint13
            // 
            this.btnPoint13.Location = new System.Drawing.Point(0, 0);
            this.btnPoint13.Name = "btnPoint13";
            this.btnPoint13.Size = new System.Drawing.Size(75, 23);
            this.btnPoint13.TabIndex = 0;
            // 
            // btnPoint14
            // 
            this.btnPoint14.Location = new System.Drawing.Point(0, 0);
            this.btnPoint14.Name = "btnPoint14";
            this.btnPoint14.Size = new System.Drawing.Size(75, 23);
            this.btnPoint14.TabIndex = 0;
            // 
            // btnPoint15
            // 
            this.btnPoint15.Location = new System.Drawing.Point(0, 0);
            this.btnPoint15.Name = "btnPoint15";
            this.btnPoint15.Size = new System.Drawing.Size(75, 23);
            this.btnPoint15.TabIndex = 0;
            // 
            // btnPoint16
            // 
            this.btnPoint16.Location = new System.Drawing.Point(0, 0);
            this.btnPoint16.Name = "btnPoint16";
            this.btnPoint16.Size = new System.Drawing.Size(75, 23);
            this.btnPoint16.TabIndex = 0;
            // 
            // btnPoint17
            // 
            this.btnPoint17.Location = new System.Drawing.Point(0, 0);
            this.btnPoint17.Name = "btnPoint17";
            this.btnPoint17.Size = new System.Drawing.Size(75, 23);
            this.btnPoint17.TabIndex = 0;
            // 
            // btnPoint18
            // 
            this.btnPoint18.Location = new System.Drawing.Point(0, 0);
            this.btnPoint18.Name = "btnPoint18";
            this.btnPoint18.Size = new System.Drawing.Size(75, 23);
            this.btnPoint18.TabIndex = 0;
            // 
            // btnPoint19
            // 
            this.btnPoint19.Location = new System.Drawing.Point(0, 0);
            this.btnPoint19.Name = "btnPoint19";
            this.btnPoint19.Size = new System.Drawing.Size(75, 23);
            this.btnPoint19.TabIndex = 0;
            // 
            // btnPoint20
            // 
            this.btnPoint20.Location = new System.Drawing.Point(0, 0);
            this.btnPoint20.Name = "btnPoint20";
            this.btnPoint20.Size = new System.Drawing.Size(75, 23);
            this.btnPoint20.TabIndex = 0;
            // 
            // btnPoint21
            // 
            this.btnPoint21.Location = new System.Drawing.Point(0, 0);
            this.btnPoint21.Name = "btnPoint21";
            this.btnPoint21.Size = new System.Drawing.Size(75, 23);
            this.btnPoint21.TabIndex = 0;
            // 
            // btnPoint22
            // 
            this.btnPoint22.Location = new System.Drawing.Point(0, 0);
            this.btnPoint22.Name = "btnPoint22";
            this.btnPoint22.Size = new System.Drawing.Size(75, 23);
            this.btnPoint22.TabIndex = 0;
            // 
            // btnPoint23
            // 
            this.btnPoint23.Location = new System.Drawing.Point(0, 0);
            this.btnPoint23.Name = "btnPoint23";
            this.btnPoint23.Size = new System.Drawing.Size(75, 23);
            this.btnPoint23.TabIndex = 0;
            // 
            // btnPoint24
            // 
            this.btnPoint24.Location = new System.Drawing.Point(0, 0);
            this.btnPoint24.Name = "btnPoint24";
            this.btnPoint24.Size = new System.Drawing.Size(75, 23);
            this.btnPoint24.TabIndex = 0;
            // 
            // btnPoint25
            // 
            this.btnPoint25.Location = new System.Drawing.Point(0, 0);
            this.btnPoint25.Name = "btnPoint25";
            this.btnPoint25.Size = new System.Drawing.Size(75, 23);
            this.btnPoint25.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.player2WinsCount);
            this.panel2.Controls.Add(this.player1WinsCount);
            this.panel2.Controls.Add(this.lblPlayer2Wins);
            this.panel2.Controls.Add(this.player1Wins);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Location = new System.Drawing.Point(12, 609);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 129);
            this.panel2.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Window;
            this.exitButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(511, 77);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // player1Wins
            // 
            this.player1Wins.AutoSize = true;
            this.player1Wins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Wins.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.player1Wins.Location = new System.Drawing.Point(3, 1);
            this.player1Wins.Name = "player1Wins";
            this.player1Wins.Size = new System.Drawing.Size(91, 36);
            this.player1Wins.TabIndex = 4;
            this.player1Wins.Text = "player1";
            // 
            // lblPlayer2Wins
            // 
            this.lblPlayer2Wins.AutoSize = true;
            this.lblPlayer2Wins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Wins.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPlayer2Wins.Location = new System.Drawing.Point(509, 1);
            this.lblPlayer2Wins.Name = "lblPlayer2Wins";
            this.lblPlayer2Wins.Size = new System.Drawing.Size(91, 36);
            this.lblPlayer2Wins.TabIndex = 6;
            this.lblPlayer2Wins.Text = "player2";
            // 
            // player1WinsCount
            // 
            this.player1WinsCount.AutoSize = true;
            this.player1WinsCount.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1WinsCount.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.player1WinsCount.Location = new System.Drawing.Point(100, 1);
            this.player1WinsCount.Name = "player1WinsCount";
            this.player1WinsCount.Size = new System.Drawing.Size(29, 36);
            this.player1WinsCount.TabIndex = 7;
            this.player1WinsCount.Text = "0";
            // 
            // player2WinsCount
            // 
            this.player2WinsCount.AutoSize = true;
            this.player2WinsCount.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2WinsCount.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.player2WinsCount.Location = new System.Drawing.Point(606, 1);
            this.player2WinsCount.Name = "player2WinsCount";
            this.player2WinsCount.Size = new System.Drawing.Size(29, 36);
            this.player2WinsCount.TabIndex = 8;
            this.player2WinsCount.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(666, 738);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected void GenerateGrid(int gridSize)
        {
            if (gridSize == 3)
            {
                int startingXPos = 101;
                int startingYPos = 88;

                int distanceBetweenX = 97;
                int distanceBetweenY = 92;
                // 
                // btnPoint1
                // 
               
                this.btnPoint1.BackColor = System.Drawing.Color.White;
                this.btnPoint1.ForeColor = System.Drawing.Color.Black;
                this.btnPoint1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint1.Location = new System.Drawing.Point(startingXPos, startingYPos);
                this.btnPoint1.Name = "btnPoint1";
                this.btnPoint1.Size = new System.Drawing.Size(75, 75);
                this.btnPoint1.TabIndex = 0;
                this.btnPoint1.UseVisualStyleBackColor = false;
                this.btnPoint1.Click += CellClicked;
                Grid.Cells[0, 0] = btnPoint1;
                // 
                // btnPoint2
                // 
                this.btnPoint2.BackColor = System.Drawing.Color.White;
                this.btnPoint2.ForeColor = System.Drawing.Color.Black;
                this.btnPoint2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint2.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos);
                this.btnPoint2.Name = "btnPoint2";
                this.btnPoint2.Size = new System.Drawing.Size(75, 75);
                this.btnPoint2.TabIndex = 1;
                this.btnPoint2.UseVisualStyleBackColor = false;
                this.btnPoint2.Click += CellClicked;
                Grid.Cells[1, 0] = btnPoint2;
                // 
                // btnPoint3
                // 
                this.btnPoint3.BackColor = System.Drawing.Color.White;
                this.btnPoint3.ForeColor = System.Drawing.Color.Black;
                this.btnPoint3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint3.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 2), startingYPos);
                this.btnPoint3.Name = "btnPoint3";
                this.btnPoint3.Size = new System.Drawing.Size(75, 75);
                this.btnPoint3.TabIndex = 2;
                this.btnPoint3.UseVisualStyleBackColor = false;
                this.btnPoint3.Click += CellClicked;
                Grid.Cells[2, 0] = btnPoint3;
                // 
                // btnPoint4
                // 
                this.btnPoint4.BackColor = System.Drawing.Color.White;
                this.btnPoint4.ForeColor = System.Drawing.Color.Black;
                this.btnPoint4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint4.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY);
                this.btnPoint4.Name = "btnPoint4";
                this.btnPoint4.Size = new System.Drawing.Size(75, 75);
                this.btnPoint4.TabIndex = 3;
                this.btnPoint4.UseVisualStyleBackColor = false;
                this.btnPoint4.Click += CellClicked;
                Grid.Cells[0, 1] = btnPoint4;
                // 
                // btnPoint5
                // 
                
                this.btnPoint5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.btnPoint5.BackColor = System.Drawing.Color.White;
                this.btnPoint5.ForeColor = System.Drawing.Color.Black;
                this.btnPoint5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint5.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + distanceBetweenY);
                this.btnPoint5.Name = "btnPoint5";
                this.btnPoint5.Size = new System.Drawing.Size(75, 75);
                this.btnPoint5.TabIndex = 4;
                this.btnPoint5.UseVisualStyleBackColor = false;
                this.btnPoint5.Click += CellClicked;
                Grid.Cells[1, 1] = btnPoint5;
                // 
                // btnPoint6
                // 
                this.btnPoint6.BackColor = System.Drawing.Color.White;
                this.btnPoint6.ForeColor = System.Drawing.Color.Black;
                this.btnPoint6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint6.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 2), startingYPos + distanceBetweenY);
                this.btnPoint6.Name = "btnPoint6";
                this.btnPoint6.Size = new System.Drawing.Size(75, 75);
                this.btnPoint6.TabIndex = 5;
                this.btnPoint6.UseVisualStyleBackColor = false;
                this.btnPoint6.Click += CellClicked;
                Grid.Cells[2, 1] = btnPoint6;
                // 
                // btnPoint7
                // 
                this.btnPoint7.BackColor = System.Drawing.Color.White;
                this.btnPoint7.ForeColor = System.Drawing.Color.Black;
                this.btnPoint7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint7.Location = new System.Drawing.Point(startingXPos, startingYPos + (distanceBetweenY * 2));
                this.btnPoint7.Name = "btnPoint7";
                this.btnPoint7.Size = new System.Drawing.Size(75, 75);
                this.btnPoint7.TabIndex = 6;
                this.btnPoint7.UseVisualStyleBackColor = false;
                this.btnPoint7.Click += CellClicked;
                Grid.Cells[0, 2] = btnPoint7;
                // 
                // btnPoint8
                // 
                this.btnPoint8.BackColor = System.Drawing.Color.White;
                this.btnPoint8.ForeColor = System.Drawing.Color.Black;
                this.btnPoint8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint8.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + (distanceBetweenY * 2));
                this.btnPoint8.Name = "btnPoint8";
                this.btnPoint8.Size = new System.Drawing.Size(75, 75);
                this.btnPoint8.TabIndex = 7;
                this.btnPoint8.UseVisualStyleBackColor = false;
                this.btnPoint8.Click += CellClicked;
                Grid.Cells[1, 2] = btnPoint8;
                // 
                // btnPoint9
                // 
                this.btnPoint9.BackColor = System.Drawing.Color.White;
                this.btnPoint9.ForeColor = System.Drawing.Color.Black;
                this.btnPoint9.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint9.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 2), startingYPos + (distanceBetweenY * 2));
                this.btnPoint9.Name = "btnPoint9";
                this.btnPoint9.Size = new System.Drawing.Size(75, 75);
                this.btnPoint9.TabIndex = 8;
                this.btnPoint9.UseVisualStyleBackColor = false;
                this.btnPoint9.Click += CellClicked;
                Grid.Cells[2, 2] = btnPoint9;

                this.panel4.Controls.Add(this.btnPoint9);
                this.panel4.Controls.Add(this.btnPoint8);
                this.panel4.Controls.Add(this.btnPoint7);
                this.panel4.Controls.Add(this.btnPoint6);
                this.panel4.Controls.Add(this.btnPoint5);
                this.panel4.Controls.Add(this.btnPoint4);
                this.panel4.Controls.Add(this.btnPoint3);
                this.panel4.Controls.Add(this.btnPoint2);
                this.panel4.Controls.Add(this.btnPoint1);
            }
            else if (gridSize == 4)
            {
                int startingXPos = 60;
                int startingYPos = 35;

                int distanceBetweenX = 97;
                int distanceBetweenY = 92;
                // 
                // btnPoint1
                // 
                this.btnPoint1.BackColor = System.Drawing.Color.White;
                this.btnPoint1.ForeColor = System.Drawing.Color.Black;
                this.btnPoint1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint1.Location = new System.Drawing.Point(startingXPos, startingYPos);
                this.btnPoint1.Name = "btnPoint1";
                this.btnPoint1.Size = new System.Drawing.Size(75, 75);
                this.btnPoint1.TabIndex = 0;
                this.btnPoint1.UseVisualStyleBackColor = false;
                this.btnPoint1.Click += CellClicked;
                Grid.Cells[0, 0] = btnPoint1;
                // 
                // btnPoint2
                // 
                this.btnPoint2.BackColor = System.Drawing.Color.White;
                this.btnPoint2.ForeColor = System.Drawing.Color.Black;
                this.btnPoint2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint2.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos);
                this.btnPoint2.Name = "btnPoint2";
                this.btnPoint2.Size = new System.Drawing.Size(75, 75);
                this.btnPoint2.TabIndex = 1;
                this.btnPoint2.UseVisualStyleBackColor = false;
                this.btnPoint2.Click += CellClicked;
                Grid.Cells[1, 0] = btnPoint2;
                // 
                // btnPoint3
                // 
                this.btnPoint3.BackColor = System.Drawing.Color.White;
                this.btnPoint3.ForeColor = System.Drawing.Color.Black;
                this.btnPoint3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint3.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 2), startingYPos);
                this.btnPoint3.Name = "btnPoint3";
                this.btnPoint3.Size = new System.Drawing.Size(75, 75);
                this.btnPoint3.TabIndex = 2;
                this.btnPoint3.UseVisualStyleBackColor = false;
                this.btnPoint3.Click += CellClicked;
                Grid.Cells[2, 0] = btnPoint3;
                // 
                // btnPoint4
                // 
                this.btnPoint4.BackColor = System.Drawing.Color.White;
                this.btnPoint4.ForeColor = System.Drawing.Color.Black;
                this.btnPoint4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint4.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 3), startingYPos);
                this.btnPoint4.Name = "btnPoint4";
                this.btnPoint4.Size = new System.Drawing.Size(75, 75);
                this.btnPoint4.TabIndex = 3;
                this.btnPoint4.UseVisualStyleBackColor = false;
                this.btnPoint4.Click += CellClicked;
                Grid.Cells[3, 0] = btnPoint4;
                // 
                // btnPoint5
                // 
                this.btnPoint5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.btnPoint5.BackColor = System.Drawing.Color.White;
                this.btnPoint5.ForeColor = System.Drawing.Color.Black;
                this.btnPoint5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint5.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY);
                this.btnPoint5.Name = "btnPoint5";
                this.btnPoint5.Size = new System.Drawing.Size(75, 75);
                this.btnPoint5.TabIndex = 4;
                this.btnPoint5.UseVisualStyleBackColor = false;
                this.btnPoint5.Click += CellClicked;
                Grid.Cells[0, 1] = btnPoint5;
                // 
                // btnPoint6
                // 
                this.btnPoint6.BackColor = System.Drawing.Color.White;
                this.btnPoint6.ForeColor = System.Drawing.Color.Black;
                this.btnPoint6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint6.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + distanceBetweenY);
                this.btnPoint6.Name = "btnPoint6";
                this.btnPoint6.Size = new System.Drawing.Size(75, 75);
                this.btnPoint6.TabIndex = 5;
                this.btnPoint6.UseVisualStyleBackColor = false;
                this.btnPoint6.Click += CellClicked;
                Grid.Cells[1, 1] = btnPoint6;
                // 
                // btnPoint7
                // 
                this.btnPoint7.BackColor = System.Drawing.Color.White;
                this.btnPoint7.ForeColor = System.Drawing.Color.Black;
                this.btnPoint7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint7.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 2), startingYPos + distanceBetweenY);
                this.btnPoint7.Name = "btnPoint7";
                this.btnPoint7.Size = new System.Drawing.Size(75, 75);
                this.btnPoint7.TabIndex = 6;
                this.btnPoint7.UseVisualStyleBackColor = false;
                this.btnPoint7.Click += CellClicked;
                Grid.Cells[2, 1] = btnPoint7;
                // 
                // btnPoint8
                // 
                this.btnPoint8.BackColor = System.Drawing.Color.White;
                this.btnPoint8.ForeColor = System.Drawing.Color.Black;
                this.btnPoint8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint8.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 3), startingYPos + distanceBetweenY);
                this.btnPoint8.Name = "btnPoint8";
                this.btnPoint8.Size = new System.Drawing.Size(75, 75);
                this.btnPoint8.TabIndex = 7;
                this.btnPoint8.UseVisualStyleBackColor = false;
                this.btnPoint8.Click += CellClicked;
                Grid.Cells[3, 1] = btnPoint8;
                // 
                // btnPoint9
                // 
                this.btnPoint9.BackColor = System.Drawing.Color.White;
                this.btnPoint9.ForeColor = System.Drawing.Color.Black;
                this.btnPoint9.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint9.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY * 2);
                this.btnPoint9.Name = "btnPoint9";
                this.btnPoint9.Size = new System.Drawing.Size(75, 75);
                this.btnPoint9.TabIndex = 8;
                this.btnPoint9.UseVisualStyleBackColor = false;
                this.btnPoint9.Click += CellClicked;
                Grid.Cells[0, 2] = btnPoint9;
                // 
                // btnPoint10
                // 
                this.btnPoint10.BackColor = System.Drawing.Color.White;
                this.btnPoint10.ForeColor = System.Drawing.Color.Black;
                this.btnPoint10.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint10.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + distanceBetweenY * 2);
                this.btnPoint10.Name = "btnPoint10";
                this.btnPoint10.Size = new System.Drawing.Size(75, 75);
                this.btnPoint10.TabIndex = 8;
                this.btnPoint10.UseVisualStyleBackColor = false;
                this.btnPoint10.Click += CellClicked;
                Grid.Cells[1, 2] = btnPoint10;
                // 
                // btnPoint11
                // 
                this.btnPoint11.BackColor = System.Drawing.Color.White;
                this.btnPoint11.ForeColor = System.Drawing.Color.Black;
                this.btnPoint11.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint11.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 2, startingYPos + distanceBetweenY * 2);
                this.btnPoint11.Name = "btnPoint11";
                this.btnPoint11.Size = new System.Drawing.Size(75, 75);
                this.btnPoint11.TabIndex = 8;
                this.btnPoint11.UseVisualStyleBackColor = false;
                this.btnPoint11.Click += CellClicked;
                Grid.Cells[2, 2] = btnPoint11;
                // 
                // btnPoint12
                // 
                this.btnPoint12.BackColor = System.Drawing.Color.White;
                this.btnPoint12.ForeColor = System.Drawing.Color.Black;
                this.btnPoint12.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint12.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint12.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 3, startingYPos + distanceBetweenY * 2);
                this.btnPoint12.Name = "btnPoint12";
                this.btnPoint12.Size = new System.Drawing.Size(75, 75);
                this.btnPoint12.TabIndex = 8;
                this.btnPoint12.UseVisualStyleBackColor = false;
                this.btnPoint12.Click += CellClicked;
                Grid.Cells[3, 2] = btnPoint12;
                // 
                // btnPoint13
                // 
                this.btnPoint13.BackColor = System.Drawing.Color.White;
                this.btnPoint13.ForeColor = System.Drawing.Color.Black;
                this.btnPoint13.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint13.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY * 3);
                this.btnPoint13.Name = "btnPoint13";
                this.btnPoint13.Size = new System.Drawing.Size(75, 75);
                this.btnPoint13.TabIndex = 8;
                this.btnPoint13.UseVisualStyleBackColor = false;
                this.btnPoint13.Click += CellClicked;
                Grid.Cells[0, 3] = btnPoint13;
                // 
                // btnPoint14
                // 
                this.btnPoint14.BackColor = System.Drawing.Color.White;
                this.btnPoint14.ForeColor = System.Drawing.Color.Black;
                this.btnPoint14.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint14.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint14.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + distanceBetweenY * 3);
                this.btnPoint14.Name = "btnPoint14";
                this.btnPoint14.Size = new System.Drawing.Size(75, 75);
                this.btnPoint14.TabIndex = 8;
                this.btnPoint14.UseVisualStyleBackColor = false;
                this.btnPoint14.Click += CellClicked;
                Grid.Cells[1, 3] = btnPoint14;
                // 
                // btnPoint15
                // 
                this.btnPoint15.BackColor = System.Drawing.Color.White;
                this.btnPoint15.ForeColor = System.Drawing.Color.Black;
                this.btnPoint15.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint15.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint15.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 2, startingYPos + distanceBetweenY * 3);
                this.btnPoint15.Name = "btnPoint15";
                this.btnPoint15.Size = new System.Drawing.Size(75, 75);
                this.btnPoint15.TabIndex = 8;
                this.btnPoint15.UseVisualStyleBackColor = false;
                this.btnPoint15.Click += CellClicked;
                Grid.Cells[2, 3] = btnPoint15;
                // 
                // btnPoint16
                // 
                this.btnPoint16.BackColor = System.Drawing.Color.White;
                this.btnPoint16.ForeColor = System.Drawing.Color.Black;
                this.btnPoint16.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint16.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint16.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 3, startingYPos + distanceBetweenY * 3);
                this.btnPoint16.Name = "btnPoint16";
                this.btnPoint16.Size = new System.Drawing.Size(75, 75);
                this.btnPoint16.TabIndex = 8;
                this.btnPoint16.UseVisualStyleBackColor = false;
                this.btnPoint16.Click += CellClicked;
                this.btnPoint16.Visible = true;
                Grid.Cells[3, 3] = btnPoint16;

                this.panel4.Controls.Add(this.btnPoint9);
                this.panel4.Controls.Add(this.btnPoint8);
                this.panel4.Controls.Add(this.btnPoint7);
                this.panel4.Controls.Add(this.btnPoint6);
                this.panel4.Controls.Add(this.btnPoint5);
                this.panel4.Controls.Add(this.btnPoint4);
                this.panel4.Controls.Add(this.btnPoint3);
                this.panel4.Controls.Add(this.btnPoint2);
                this.panel4.Controls.Add(this.btnPoint1);
                this.panel4.Controls.Add(this.btnPoint10);
                this.panel4.Controls.Add(this.btnPoint11);
                this.panel4.Controls.Add(this.btnPoint12);
                this.panel4.Controls.Add(this.btnPoint13);
                this.panel4.Controls.Add(this.btnPoint14);
                this.panel4.Controls.Add(this.btnPoint15);
                this.panel4.Controls.Add(this.btnPoint16);

            }
            else if (gridSize == 5)
            {
                int startingXPos = 20;
                int startingYPos = 7;

                int distanceBetweenX = 90;
                int distanceBetweenY = 82;
                // 
                // btnPoint1
                // 
                this.btnPoint1.BackColor = System.Drawing.Color.White;
                this.btnPoint1.ForeColor = System.Drawing.Color.Black;
                this.btnPoint1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint1.Location = new System.Drawing.Point(startingXPos, startingYPos);
                this.btnPoint1.Name = "btnPoint1";
                this.btnPoint1.Size = new System.Drawing.Size(75, 75);
                this.btnPoint1.TabIndex = 0;
                this.btnPoint1.UseVisualStyleBackColor = false;
                this.btnPoint1.Click += CellClicked;
                Grid.Cells[0, 0] = btnPoint1;
                // 
                // btnPoint2
                // 
                this.btnPoint2.BackColor = System.Drawing.Color.White;
                this.btnPoint2.ForeColor = System.Drawing.Color.Black;
                this.btnPoint2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint2.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos);
                this.btnPoint2.Name = "btnPoint2";
                this.btnPoint2.Size = new System.Drawing.Size(75, 75);
                this.btnPoint2.TabIndex = 1;
                this.btnPoint2.UseVisualStyleBackColor = false;
                this.btnPoint2.Click += CellClicked;
                Grid.Cells[1, 0] = btnPoint2;
                // 
                // btnPoint3
                // 
                this.btnPoint3.BackColor = System.Drawing.Color.White;
                this.btnPoint3.ForeColor = System.Drawing.Color.Black;
                this.btnPoint3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint3.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 2), startingYPos);
                this.btnPoint3.Name = "btnPoint3";
                this.btnPoint3.Size = new System.Drawing.Size(75, 75);
                this.btnPoint3.TabIndex = 2;
                this.btnPoint3.UseVisualStyleBackColor = false;
                this.btnPoint3.Click += CellClicked;
                Grid.Cells[2, 0] = btnPoint3;
                // 
                // btnPoint4
                // 
                this.btnPoint4.BackColor = System.Drawing.Color.White;
                this.btnPoint4.ForeColor = System.Drawing.Color.Black;
                this.btnPoint4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint4.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 3), startingYPos);
                this.btnPoint4.Name = "btnPoint4";
                this.btnPoint4.Size = new System.Drawing.Size(75, 75);
                this.btnPoint4.TabIndex = 3;
                this.btnPoint4.UseVisualStyleBackColor = false;
                this.btnPoint4.Click += CellClicked;
                Grid.Cells[3, 0] = btnPoint4;
                // 
                // btnPoint5
                // 
                this.btnPoint5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.btnPoint5.BackColor = System.Drawing.Color.White;
                this.btnPoint5.ForeColor = System.Drawing.Color.Black;
                this.btnPoint5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint5.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 4, startingYPos);
                this.btnPoint5.Name = "btnPoint5";
                this.btnPoint5.Size = new System.Drawing.Size(75, 75);
                this.btnPoint5.TabIndex = 4;
                this.btnPoint5.UseVisualStyleBackColor = false;
                this.btnPoint5.Click += CellClicked;
                Grid.Cells[4, 0] = btnPoint5;
                // 
                // btnPoint6
                // 
                this.btnPoint6.BackColor = System.Drawing.Color.White;
                this.btnPoint6.ForeColor = System.Drawing.Color.Black;
                this.btnPoint6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint6.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY);
                this.btnPoint6.Name = "btnPoint6";
                this.btnPoint6.Size = new System.Drawing.Size(75, 75);
                this.btnPoint6.TabIndex = 5;
                this.btnPoint6.UseVisualStyleBackColor = false;
                this.btnPoint6.Click += CellClicked;
                Grid.Cells[0, 1] = btnPoint6;
                // 
                // btnPoint7
                // 
                this.btnPoint7.BackColor = System.Drawing.Color.White;
                this.btnPoint7.ForeColor = System.Drawing.Color.Black;
                this.btnPoint7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint7.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX), startingYPos + distanceBetweenY);
                this.btnPoint7.Name = "btnPoint7";
                this.btnPoint7.Size = new System.Drawing.Size(75, 75);
                this.btnPoint7.TabIndex = 6;
                this.btnPoint7.UseVisualStyleBackColor = false;
                this.btnPoint7.Click += CellClicked;
                Grid.Cells[1, 1] = btnPoint7;
                // 
                // btnPoint8
                // 
                this.btnPoint8.BackColor = System.Drawing.Color.White;
                this.btnPoint8.ForeColor = System.Drawing.Color.Black;
                this.btnPoint8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint8.Location = new System.Drawing.Point(startingXPos + (distanceBetweenX * 2), startingYPos + distanceBetweenY);
                this.btnPoint8.Name = "btnPoint8";
                this.btnPoint8.Size = new System.Drawing.Size(75, 75);
                this.btnPoint8.TabIndex = 7;
                this.btnPoint8.UseVisualStyleBackColor = false;
                this.btnPoint8.Click += CellClicked;
                Grid.Cells[2, 1] = btnPoint8;
                // 
                // btnPoint9
                // 
                this.btnPoint9.BackColor = System.Drawing.Color.White;
                this.btnPoint9.ForeColor = System.Drawing.Color.Black;
                this.btnPoint9.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint9.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 3, startingYPos + distanceBetweenY);
                this.btnPoint9.Name = "btnPoint9";
                this.btnPoint9.Size = new System.Drawing.Size(75, 75);
                this.btnPoint9.TabIndex = 8;
                this.btnPoint9.UseVisualStyleBackColor = false;
                this.btnPoint9.Click += CellClicked;
                Grid.Cells[3, 1] = btnPoint9;
                // 
                // btnPoint10
                // 
                this.btnPoint10.BackColor = System.Drawing.Color.White;
                this.btnPoint10.ForeColor = System.Drawing.Color.Black;
                this.btnPoint10.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint10.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 4, startingYPos + distanceBetweenY);
                this.btnPoint10.Name = "btnPoint10";
                this.btnPoint10.Size = new System.Drawing.Size(75, 75);
                this.btnPoint10.TabIndex = 8;
                this.btnPoint10.UseVisualStyleBackColor = false;
                this.btnPoint10.Click += CellClicked;
                Grid.Cells[4, 1] = btnPoint10;
                // 
                // btnPoint11
                // 
                this.btnPoint11.BackColor = System.Drawing.Color.White;
                this.btnPoint11.ForeColor = System.Drawing.Color.Black;
                this.btnPoint11.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint11.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY * 2);
                this.btnPoint11.Name = "btnPoint11";
                this.btnPoint11.Size = new System.Drawing.Size(75, 75);
                this.btnPoint11.TabIndex = 8;
                this.btnPoint11.UseVisualStyleBackColor = false;
                this.btnPoint11.Click += CellClicked;
                Grid.Cells[0, 2] = btnPoint11;
                // 
                // btnPoint12
                // 
                this.btnPoint12.BackColor = System.Drawing.Color.White;
                this.btnPoint12.ForeColor = System.Drawing.Color.Black;
                this.btnPoint12.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint12.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint12.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + distanceBetweenY * 2);
                this.btnPoint12.Name = "btnPoint12";
                this.btnPoint12.Size = new System.Drawing.Size(75, 75);
                this.btnPoint12.TabIndex = 8;
                this.btnPoint12.UseVisualStyleBackColor = false;
                this.btnPoint12.Click += CellClicked;
                Grid.Cells[1, 2] = btnPoint12;
                // 
                // btnPoint13
                // 
                this.btnPoint13.BackColor = System.Drawing.Color.White;
                this.btnPoint13.ForeColor = System.Drawing.Color.Black;
                this.btnPoint13.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint13.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 2, startingYPos + distanceBetweenY * 2);
                this.btnPoint13.Name = "btnPoint13";
                this.btnPoint13.Size = new System.Drawing.Size(75, 75);
                this.btnPoint13.TabIndex = 8;
                this.btnPoint13.UseVisualStyleBackColor = false;
                this.btnPoint13.Click += CellClicked;
                Grid.Cells[2, 2] = btnPoint13;
                // 
                // btnPoint14
                // 
                this.btnPoint14.BackColor = System.Drawing.Color.White;
                this.btnPoint14.ForeColor = System.Drawing.Color.Black;
                this.btnPoint14.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint14.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint14.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 3, startingYPos + distanceBetweenY * 2);
                this.btnPoint14.Name = "btnPoint14";
                this.btnPoint14.Size = new System.Drawing.Size(75, 75);
                this.btnPoint14.TabIndex = 8;
                this.btnPoint14.UseVisualStyleBackColor = false;
                this.btnPoint14.Click += CellClicked;
                Grid.Cells[3, 2] = btnPoint14;
                // 
                // btnPoint15
                // 
                this.btnPoint15.BackColor = System.Drawing.Color.White;
                this.btnPoint15.ForeColor = System.Drawing.Color.Black;
                this.btnPoint15.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint15.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint15.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 4, startingYPos + distanceBetweenY * 2);
                this.btnPoint15.Name = "btnPoint15";
                this.btnPoint15.Size = new System.Drawing.Size(75, 75);
                this.btnPoint15.TabIndex = 8;
                this.btnPoint15.UseVisualStyleBackColor = false;
                this.btnPoint15.Click += CellClicked;
                Grid.Cells[4, 2] = btnPoint15;
                // 
                // btnPoint16
                // 
                this.btnPoint16.BackColor = System.Drawing.Color.White;
                this.btnPoint16.ForeColor = System.Drawing.Color.Black;
                this.btnPoint16.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint16.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint16.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY * 3);
                this.btnPoint16.Name = "btnPoint16";
                this.btnPoint16.Size = new System.Drawing.Size(75, 75);
                this.btnPoint16.TabIndex = 8;
                this.btnPoint16.UseVisualStyleBackColor = false;
                this.btnPoint16.Click += CellClicked;
                this.btnPoint16.Visible = true;
                Grid.Cells[0, 3] = btnPoint16;
                // 
                // btnPoint17
                // 
                this.btnPoint17.BackColor = System.Drawing.Color.White;
                this.btnPoint17.ForeColor = System.Drawing.Color.Black;
                this.btnPoint17.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint17.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint17.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + distanceBetweenY * 3);
                this.btnPoint17.Name = "btnPoint17";
                this.btnPoint17.Size = new System.Drawing.Size(75, 75);
                this.btnPoint17.TabIndex = 8;
                this.btnPoint17.UseVisualStyleBackColor = false;
                this.btnPoint17.Click += CellClicked;
                this.btnPoint17.Visible = true;
                Grid.Cells[1, 3] = btnPoint17;
                // 
                // btnPoint18
                // 
                this.btnPoint18.BackColor = System.Drawing.Color.White;
                this.btnPoint18.ForeColor = System.Drawing.Color.Black;
                this.btnPoint18.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint18.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint18.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 2, startingYPos + distanceBetweenY * 3);
                this.btnPoint18.Name = "btnPoint18";
                this.btnPoint18.Size = new System.Drawing.Size(75, 75);
                this.btnPoint18.TabIndex = 8;
                this.btnPoint18.UseVisualStyleBackColor = false;
                this.btnPoint18.Click += CellClicked;
                this.btnPoint18.Visible = true;
                Grid.Cells[2, 3] = btnPoint18;
                // 
                // btnPoint19
                // 
                this.btnPoint19.BackColor = System.Drawing.Color.White;
                this.btnPoint19.ForeColor = System.Drawing.Color.Black;
                this.btnPoint19.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint19.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint19.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 3, startingYPos + distanceBetweenY * 3);
                this.btnPoint19.Name = "btnPoint19";
                this.btnPoint19.Size = new System.Drawing.Size(75, 75);
                this.btnPoint19.TabIndex = 8;
                this.btnPoint19.UseVisualStyleBackColor = false;
                this.btnPoint19.Click += CellClicked;
                this.btnPoint19.Visible = true;
                Grid.Cells[3, 3] = btnPoint19;
                // 
                // btnPoint20
                // 
                this.btnPoint20.BackColor = System.Drawing.Color.White;
                this.btnPoint20.ForeColor = System.Drawing.Color.Black;
                this.btnPoint20.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint20.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint20.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 4, startingYPos + distanceBetweenY * 3);
                this.btnPoint20.Name = "btnPoint20";
                this.btnPoint20.Size = new System.Drawing.Size(75, 75);
                this.btnPoint20.TabIndex = 8;
                this.btnPoint20.UseVisualStyleBackColor = false;
                this.btnPoint20.Click += CellClicked;
                this.btnPoint20.Visible = true;
                Grid.Cells[4, 3] = btnPoint20;
                // 
                // btnPoint21
                // 
                this.btnPoint21.BackColor = System.Drawing.Color.White;
                this.btnPoint21.ForeColor = System.Drawing.Color.Black;
                this.btnPoint21.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint21.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint21.Location = new System.Drawing.Point(startingXPos, startingYPos + distanceBetweenY * 4);
                this.btnPoint21.Name = "btnPoint21";
                this.btnPoint21.Size = new System.Drawing.Size(75, 75);
                this.btnPoint21.TabIndex = 8;
                this.btnPoint21.UseVisualStyleBackColor = false;
                this.btnPoint21.Click += CellClicked;
                this.btnPoint21.Visible = true;
                Grid.Cells[0, 4] = btnPoint21;
                // 
                // btnPoint22
                // 
                this.btnPoint22.BackColor = System.Drawing.Color.White;
                this.btnPoint22.ForeColor = System.Drawing.Color.Black;
                this.btnPoint22.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint22.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint22.Location = new System.Drawing.Point(startingXPos + distanceBetweenX, startingYPos + distanceBetweenY * 4);
                this.btnPoint22.Name = "btnPoint22";
                this.btnPoint22.Size = new System.Drawing.Size(75, 75);
                this.btnPoint22.TabIndex = 8;
                this.btnPoint22.UseVisualStyleBackColor = false;
                this.btnPoint22.Click += CellClicked;
                this.btnPoint22.Visible = true;
                Grid.Cells[1, 4] = btnPoint22;
                // 
                // btnPoint23
                // 
                this.btnPoint23.BackColor = System.Drawing.Color.White;
                this.btnPoint23.ForeColor = System.Drawing.Color.Black;
                this.btnPoint23.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint23.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint23.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 2, startingYPos + distanceBetweenY * 4);
                this.btnPoint23.Name = "btnPoint23";
                this.btnPoint23.Size = new System.Drawing.Size(75, 75);
                this.btnPoint23.TabIndex = 8;
                this.btnPoint23.UseVisualStyleBackColor = false;
                this.btnPoint23.Click += CellClicked;
                this.btnPoint23.Visible = true;
                Grid.Cells[2, 4] = btnPoint23;
                // 
                // btnPoint24
                // 
                this.btnPoint24.BackColor = System.Drawing.Color.White;
                this.btnPoint24.ForeColor = System.Drawing.Color.Black;
                this.btnPoint24.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint24.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint24.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 3, startingYPos + distanceBetweenY * 4);
                this.btnPoint24.Name = "btnPoint24";
                this.btnPoint24.Size = new System.Drawing.Size(75, 75);
                this.btnPoint24.TabIndex = 8;
                this.btnPoint24.UseVisualStyleBackColor = false;
                this.btnPoint24.Click += CellClicked;
                this.btnPoint24.Visible = true;
                Grid.Cells[3, 4] = btnPoint24;
                // 
                // btnPoint25
                // 
                this.btnPoint25.BackColor = System.Drawing.Color.White;
                this.btnPoint25.ForeColor = System.Drawing.Color.Black;
                this.btnPoint25.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnPoint25.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnPoint25.Location = new System.Drawing.Point(startingXPos + distanceBetweenX * 4, startingYPos + distanceBetweenY * 4);
                this.btnPoint25.Name = "btnPoint25";
                this.btnPoint25.Size = new System.Drawing.Size(75, 75);
                this.btnPoint25.TabIndex = 8;
                this.btnPoint25.UseVisualStyleBackColor = false;
                this.btnPoint25.Click += CellClicked;
                this.btnPoint25.Visible = true;
                Grid.Cells[4, 4] = btnPoint25;



                this.panel4.Controls.Add(this.btnPoint9);
                this.panel4.Controls.Add(this.btnPoint8);
                this.panel4.Controls.Add(this.btnPoint7);
                this.panel4.Controls.Add(this.btnPoint6);
                this.panel4.Controls.Add(this.btnPoint5);
                this.panel4.Controls.Add(this.btnPoint4);
                this.panel4.Controls.Add(this.btnPoint3);
                this.panel4.Controls.Add(this.btnPoint2);
                this.panel4.Controls.Add(this.btnPoint1);
                this.panel4.Controls.Add(this.btnPoint10);
                this.panel4.Controls.Add(this.btnPoint11);
                this.panel4.Controls.Add(this.btnPoint12);
                this.panel4.Controls.Add(this.btnPoint13);
                this.panel4.Controls.Add(this.btnPoint14);
                this.panel4.Controls.Add(this.btnPoint15);
                this.panel4.Controls.Add(this.btnPoint16);
                this.panel4.Controls.Add(this.btnPoint17);
                this.panel4.Controls.Add(this.btnPoint18);
                this.panel4.Controls.Add(this.btnPoint19);
                this.panel4.Controls.Add(this.btnPoint20);
                this.panel4.Controls.Add(this.btnPoint21);
                this.panel4.Controls.Add(this.btnPoint22);
                this.panel4.Controls.Add(this.btnPoint23);
                this.panel4.Controls.Add(this.btnPoint24);
                this.panel4.Controls.Add(this.btnPoint25);
            }
           
        }

        private void BtnPoint1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayingAgainst;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPoint1;
        private System.Windows.Forms.Button btnPoint2;
        private System.Windows.Forms.Button btnPoint3;
        private System.Windows.Forms.Button btnPoint4;
        private System.Windows.Forms.Button btnPoint5;
        private System.Windows.Forms.Button btnPoint7;
        private System.Windows.Forms.Button btnPoint6;
        private System.Windows.Forms.Button btnPoint8;
        private System.Windows.Forms.Button btnPoint9;
        private System.Windows.Forms.Button btnPoint10;
        private System.Windows.Forms.Button btnPoint11;
        private System.Windows.Forms.Button btnPoint12;
        private System.Windows.Forms.Button btnPoint13;
        private System.Windows.Forms.Button btnPoint14;
        private System.Windows.Forms.Button btnPoint15;
        private System.Windows.Forms.Button btnPoint16;
        private System.Windows.Forms.Button btnPoint17;
        private System.Windows.Forms.Button btnPoint18;
        private System.Windows.Forms.Button btnPoint19;
        private System.Windows.Forms.Button btnPoint20;
        private System.Windows.Forms.Button btnPoint21;
        private System.Windows.Forms.Button btnPoint22;
        private System.Windows.Forms.Button btnPoint23;
        private System.Windows.Forms.Button btnPoint24;
        private System.Windows.Forms.Button btnPoint25;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player2WinsCount;
        private System.Windows.Forms.Label player1WinsCount;
        private System.Windows.Forms.Label lblPlayer2Wins;
        private System.Windows.Forms.Label player1Wins;
    }
}

