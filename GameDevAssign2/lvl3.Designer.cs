
namespace GameDevAssign2
{
    partial class lvl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.Answertxtbx1 = new System.Windows.Forms.TextBox();
            this.PotatoLife3 = new System.Windows.Forms.PictureBox();
            this.potatoLife2 = new System.Windows.Forms.PictureBox();
            this.potatoLife1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotatoLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlayTimer
            // 
            this.PlayTimer.Enabled = true;
            this.PlayTimer.Interval = 1000;
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
            // 
            // Answertxtbx1
            // 
            this.Answertxtbx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Answertxtbx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Answertxtbx1.Location = new System.Drawing.Point(346, 417);
            this.Answertxtbx1.Name = "Answertxtbx1";
            this.Answertxtbx1.Size = new System.Drawing.Size(149, 20);
            this.Answertxtbx1.TabIndex = 1;
            // 
            // PotatoLife3
            // 
            this.PotatoLife3.BackColor = System.Drawing.Color.Transparent;
            this.PotatoLife3.Image = ((System.Drawing.Image)(resources.GetObject("PotatoLife3.Image")));
            this.PotatoLife3.Location = new System.Drawing.Point(727, 12);
            this.PotatoLife3.Name = "PotatoLife3";
            this.PotatoLife3.Size = new System.Drawing.Size(35, 41);
            this.PotatoLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PotatoLife3.TabIndex = 18;
            this.PotatoLife3.TabStop = false;
            // 
            // potatoLife2
            // 
            this.potatoLife2.BackColor = System.Drawing.Color.Transparent;
            this.potatoLife2.Image = ((System.Drawing.Image)(resources.GetObject("potatoLife2.Image")));
            this.potatoLife2.Location = new System.Drawing.Point(768, 12);
            this.potatoLife2.Name = "potatoLife2";
            this.potatoLife2.Size = new System.Drawing.Size(35, 41);
            this.potatoLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potatoLife2.TabIndex = 19;
            this.potatoLife2.TabStop = false;
            // 
            // potatoLife1
            // 
            this.potatoLife1.BackColor = System.Drawing.Color.Transparent;
            this.potatoLife1.Image = ((System.Drawing.Image)(resources.GetObject("potatoLife1.Image")));
            this.potatoLife1.Location = new System.Drawing.Point(809, 12);
            this.potatoLife1.Name = "potatoLife1";
            this.potatoLife1.Size = new System.Drawing.Size(35, 41);
            this.potatoLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potatoLife1.TabIndex = 20;
            this.potatoLife1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(501, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.potatoLife1);
            this.Controls.Add(this.potatoLife2);
            this.Controls.Add(this.PotatoLife3);
            this.Controls.Add(this.Answertxtbx1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "lvl3";
            this.Text = "Listening_game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotatoLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.TextBox Answertxtbx1;
        private System.Windows.Forms.PictureBox PotatoLife3;
        private System.Windows.Forms.PictureBox potatoLife2;
        private System.Windows.Forms.PictureBox potatoLife1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}