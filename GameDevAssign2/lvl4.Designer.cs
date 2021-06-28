
namespace GameDevAssign2
{
    partial class lvl4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl4));
            this.AnswertxtBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.PotatoLife3 = new System.Windows.Forms.PictureBox();
            this.potatoLife2 = new System.Windows.Forms.PictureBox();
            this.potatoLife1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PotatoLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnswertxtBox
            // 
            this.AnswertxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AnswertxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswertxtBox.Location = new System.Drawing.Point(271, 432);
            this.AnswertxtBox.Name = "AnswertxtBox";
            this.AnswertxtBox.Size = new System.Drawing.Size(239, 20);
            this.AnswertxtBox.TabIndex = 0;
            this.AnswertxtBox.TextChanged += new System.EventHandler(this.AnswertxtBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(535, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PotatoLife3
            // 
            this.PotatoLife3.BackColor = System.Drawing.Color.Transparent;
            this.PotatoLife3.Image = ((System.Drawing.Image)(resources.GetObject("PotatoLife3.Image")));
            this.PotatoLife3.Location = new System.Drawing.Point(700, 12);
            this.PotatoLife3.Name = "PotatoLife3";
            this.PotatoLife3.Size = new System.Drawing.Size(35, 41);
            this.PotatoLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PotatoLife3.TabIndex = 19;
            this.PotatoLife3.TabStop = false;
            // 
            // potatoLife2
            // 
            this.potatoLife2.BackColor = System.Drawing.Color.Transparent;
            this.potatoLife2.Image = ((System.Drawing.Image)(resources.GetObject("potatoLife2.Image")));
            this.potatoLife2.Location = new System.Drawing.Point(741, 12);
            this.potatoLife2.Name = "potatoLife2";
            this.potatoLife2.Size = new System.Drawing.Size(35, 41);
            this.potatoLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potatoLife2.TabIndex = 20;
            this.potatoLife2.TabStop = false;
            // 
            // potatoLife1
            // 
            this.potatoLife1.BackColor = System.Drawing.Color.Transparent;
            this.potatoLife1.Image = ((System.Drawing.Image)(resources.GetObject("potatoLife1.Image")));
            this.potatoLife1.Location = new System.Drawing.Point(782, 12);
            this.potatoLife1.Name = "potatoLife1";
            this.potatoLife1.Size = new System.Drawing.Size(35, 41);
            this.potatoLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potatoLife1.TabIndex = 21;
            this.potatoLife1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lvl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.potatoLife1);
            this.Controls.Add(this.potatoLife2);
            this.Controls.Add(this.PotatoLife3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswertxtBox);
            this.Name = "lvl4";
            this.Text = "lvl4";
            ((System.ComponentModel.ISupportInitialize)(this.PotatoLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnswertxtBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PotatoLife3;
        private System.Windows.Forms.PictureBox potatoLife2;
        private System.Windows.Forms.PictureBox potatoLife1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}