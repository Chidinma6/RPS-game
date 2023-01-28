namespace RPS_game
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.rockBtn = new System.Windows.Forms.Button();
            this.playerlbl = new System.Windows.Forms.Label();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.computerlbl = new System.Windows.Forms.Label();
            this.roundslbl = new System.Windows.Forms.Label();
            this.pointslbl = new System.Windows.Forms.Label();
            this.countdownlbl = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.exitbtn = new System.Windows.Forms.Button();
            this.piccomputer = new System.Windows.Forms.PictureBox();
            this.picplayer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pausebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piccomputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // rockBtn
            // 
            this.rockBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.rockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rockBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockBtn.Location = new System.Drawing.Point(45, 100);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(107, 61);
            this.rockBtn.TabIndex = 0;
            this.rockBtn.Text = "ROCK";
            this.rockBtn.UseVisualStyleBackColor = false;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // playerlbl
            // 
            this.playerlbl.AutoSize = true;
            this.playerlbl.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerlbl.Location = new System.Drawing.Point(234, 112);
            this.playerlbl.Name = "playerlbl";
            this.playerlbl.Size = new System.Drawing.Size(71, 17);
            this.playerlbl.TabIndex = 1;
            this.playerlbl.Text = "PLAYER";
            this.playerlbl.Click += new System.EventHandler(this.playerlbl_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.paperBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paperBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperBtn.Location = new System.Drawing.Point(45, 204);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(107, 60);
            this.paperBtn.TabIndex = 3;
            this.paperBtn.Text = "PAPER";
            this.paperBtn.UseVisualStyleBackColor = false;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.scissorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scissorsBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsBtn.Location = new System.Drawing.Point(45, 298);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(107, 60);
            this.scissorsBtn.TabIndex = 4;
            this.scissorsBtn.Text = "SCISSORS";
            this.scissorsBtn.UseVisualStyleBackColor = false;
            this.scissorsBtn.Click += new System.EventHandler(this.scissorsBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rulesBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesBtn.Location = new System.Drawing.Point(777, 12);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(85, 60);
            this.rulesBtn.TabIndex = 5;
            this.rulesBtn.Text = "RULES";
            this.rulesBtn.UseVisualStyleBackColor = false;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(618, 361);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(112, 60);
            this.restartBtn.TabIndex = 6;
            this.restartBtn.Text = "RESTART";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // computerlbl
            // 
            this.computerlbl.AutoSize = true;
            this.computerlbl.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerlbl.Location = new System.Drawing.Point(697, 112);
            this.computerlbl.Name = "computerlbl";
            this.computerlbl.Size = new System.Drawing.Size(97, 17);
            this.computerlbl.TabIndex = 8;
            this.computerlbl.Text = "COMPUTER";
            this.computerlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // roundslbl
            // 
            this.roundslbl.AutoSize = true;
            this.roundslbl.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundslbl.Location = new System.Drawing.Point(457, 282);
            this.roundslbl.Name = "roundslbl";
            this.roundslbl.Size = new System.Drawing.Size(78, 17);
            this.roundslbl.TabIndex = 9;
            this.roundslbl.Text = "Round: 3";
            this.roundslbl.Click += new System.EventHandler(this.roundslbl_Click);
            // 
            // pointslbl
            // 
            this.pointslbl.AutoSize = true;
            this.pointslbl.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointslbl.Location = new System.Drawing.Point(414, 160);
            this.pointslbl.Name = "pointslbl";
            this.pointslbl.Size = new System.Drawing.Size(190, 17);
            this.pointslbl.TabIndex = 10;
            this.pointslbl.Text = "Player: 0 - Computer: 0";
            this.pointslbl.Click += new System.EventHandler(this.pointslbl_Click);
            // 
            // countdownlbl
            // 
            this.countdownlbl.AutoSize = true;
            this.countdownlbl.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownlbl.Location = new System.Drawing.Point(493, 226);
            this.countdownlbl.Name = "countdownlbl";
            this.countdownlbl.Size = new System.Drawing.Size(18, 17);
            this.countdownlbl.TabIndex = 11;
            this.countdownlbl.Text = "5";
            this.countdownlbl.Click += new System.EventHandler(this.countdownlbl_Click);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(750, 361);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(112, 60);
            this.exitbtn.TabIndex = 12;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // piccomputer
            // 
            this.piccomputer.Image = global::RPS_game.Properties.Resources.qq1;
            this.piccomputer.Location = new System.Drawing.Point(656, 160);
            this.piccomputer.Name = "piccomputer";
            this.piccomputer.Size = new System.Drawing.Size(170, 183);
            this.piccomputer.TabIndex = 7;
            this.piccomputer.TabStop = false;
            // 
            // picplayer
            // 
            this.picplayer.Image = global::RPS_game.Properties.Resources.qq1;
            this.picplayer.Location = new System.Drawing.Point(197, 160);
            this.picplayer.Name = "picplayer";
            this.picplayer.Size = new System.Drawing.Size(170, 183);
            this.picplayer.TabIndex = 2;
            this.picplayer.TabStop = false;
            this.picplayer.Click += new System.EventHandler(this.picplayer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pausebtn
            // 
            this.pausebtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.pausebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pausebtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausebtn.Location = new System.Drawing.Point(496, 361);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(112, 60);
            this.pausebtn.TabIndex = 14;
            this.pausebtn.Text = "PAUSE";
            this.pausebtn.UseVisualStyleBackColor = false;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.countdownlbl);
            this.Controls.Add(this.pointslbl);
            this.Controls.Add(this.roundslbl);
            this.Controls.Add(this.computerlbl);
            this.Controls.Add(this.piccomputer);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.scissorsBtn);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.picplayer);
            this.Controls.Add(this.playerlbl);
            this.Controls.Add(this.rockBtn);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.KeyPreview = true;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piccomputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Label playerlbl;
        private System.Windows.Forms.PictureBox picplayer;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorsBtn;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.PictureBox piccomputer;
        private System.Windows.Forms.Label computerlbl;
        private System.Windows.Forms.Label roundslbl;
        private System.Windows.Forms.Label pointslbl;
        private System.Windows.Forms.Label countdownlbl;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pausebtn;
    }
}