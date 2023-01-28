namespace RPS_game
{
    partial class rules
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
            this.bachbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bachbtn
            // 
            this.bachbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.bachbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bachbtn.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bachbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bachbtn.Location = new System.Drawing.Point(697, 210);
            this.bachbtn.Name = "bachbtn";
            this.bachbtn.Size = new System.Drawing.Size(98, 81);
            this.bachbtn.TabIndex = 1;
            this.bachbtn.Text = "BACK";
            this.bachbtn.UseVisualStyleBackColor = false;
            this.bachbtn.Click += new System.EventHandler(this.bachbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPS_game.Properties.Resources.rps_rules;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 517);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(807, 528);
            this.Controls.Add(this.bachbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "rules";
            this.Text = "rules";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bachbtn;
    }
}