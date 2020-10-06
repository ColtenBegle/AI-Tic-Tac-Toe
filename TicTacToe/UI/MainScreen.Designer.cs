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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAI = new System.Windows.Forms.Button();
            this.btnLocalMult = new System.Windows.Forms.Button();
            this.btnLANMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "AI TIC-TAC-TOE";
            // 
            // btnAI
            // 
            this.btnAI.Location = new System.Drawing.Point(327, 135);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(135, 44);
            this.btnAI.TabIndex = 1;
            this.btnAI.Text = "AI";
            this.btnAI.UseVisualStyleBackColor = true;
            // 
            // btnLocalMult
            // 
            this.btnLocalMult.Location = new System.Drawing.Point(327, 185);
            this.btnLocalMult.Name = "btnLocalMult";
            this.btnLocalMult.Size = new System.Drawing.Size(135, 44);
            this.btnLocalMult.TabIndex = 2;
            this.btnLocalMult.Text = "Local Multiplayer";
            this.btnLocalMult.UseVisualStyleBackColor = true;
            // 
            // btnLANMult
            // 
            this.btnLANMult.Location = new System.Drawing.Point(327, 235);
            this.btnLANMult.Name = "btnLANMult";
            this.btnLANMult.Size = new System.Drawing.Size(135, 44);
            this.btnLANMult.TabIndex = 3;
            this.btnLANMult.Text = "LAN Multiplayer";
            this.btnLANMult.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLANMult);
            this.Controls.Add(this.btnLocalMult);
            this.Controls.Add(this.btnAI);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAI;
        private System.Windows.Forms.Button btnLocalMult;
        private System.Windows.Forms.Button btnLANMult;
    }
}