
namespace GameDevAssign2
{
    partial class lvl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl2));
            this.PicRoof = new System.Windows.Forms.PictureBox();
            this.picBonnet = new System.Windows.Forms.PictureBox();
            this.picWheel2 = new System.Windows.Forms.PictureBox();
            this.picTrunk = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.Lvl1Timer = new System.Windows.Forms.Timer(this.components);
            this.btnRoof = new System.Windows.Forms.Button();
            this.btnBody = new System.Windows.Forms.Button();
            this.btnWheel = new System.Windows.Forms.Button();
            this.btnBonnet = new System.Windows.Forms.Button();
            this.picBody = new System.Windows.Forms.PictureBox();
            this.PotatoLife3 = new System.Windows.Forms.PictureBox();
            this.potatoLife1 = new System.Windows.Forms.PictureBox();
            this.potatoLife2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicRoof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWheel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotatoLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife2)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRoof
            // 
            this.PicRoof.BackColor = System.Drawing.Color.Transparent;
            this.PicRoof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicRoof.Image = ((System.Drawing.Image)(resources.GetObject("PicRoof.Image")));
            this.PicRoof.Location = new System.Drawing.Point(185, 286);
            this.PicRoof.Name = "PicRoof";
            this.PicRoof.Size = new System.Drawing.Size(243, 53);
            this.PicRoof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRoof.TabIndex = 0;
            this.PicRoof.TabStop = false;
            this.PicRoof.Visible = false;
            // 
            // picBonnet
            // 
            this.picBonnet.BackColor = System.Drawing.Color.Transparent;
            this.picBonnet.Image = ((System.Drawing.Image)(resources.GetObject("picBonnet.Image")));
            this.picBonnet.Location = new System.Drawing.Point(127, 311);
            this.picBonnet.Name = "picBonnet";
            this.picBonnet.Size = new System.Drawing.Size(57, 80);
            this.picBonnet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBonnet.TabIndex = 1;
            this.picBonnet.TabStop = false;
            this.picBonnet.Visible = false;
            this.picBonnet.Click += new System.EventHandler(this.picBonnet_Click);
            // 
            // picWheel2
            // 
            this.picWheel2.BackColor = System.Drawing.Color.Transparent;
            this.picWheel2.Image = ((System.Drawing.Image)(resources.GetObject("picWheel2.Image")));
            this.picWheel2.Location = new System.Drawing.Point(140, 364);
            this.picWheel2.Name = "picWheel2";
            this.picWheel2.Size = new System.Drawing.Size(302, 69);
            this.picWheel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWheel2.TabIndex = 4;
            this.picWheel2.TabStop = false;
            this.picWheel2.Visible = false;
            // 
            // picTrunk
            // 
            this.picTrunk.BackColor = System.Drawing.Color.Transparent;
            this.picTrunk.Image = ((System.Drawing.Image)(resources.GetObject("picTrunk.Image")));
            this.picTrunk.Location = new System.Drawing.Point(363, 333);
            this.picTrunk.Name = "picTrunk";
            this.picTrunk.Size = new System.Drawing.Size(115, 69);
            this.picTrunk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrunk.TabIndex = 5;
            this.picTrunk.TabStop = false;
            this.picTrunk.Visible = false;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHeading.Location = new System.Drawing.Point(329, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(231, 32);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "What is the name of the image that appears";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lvl1Timer
            // 
            this.Lvl1Timer.Enabled = true;
            this.Lvl1Timer.Interval = 1000;
            this.Lvl1Timer.Tick += new System.EventHandler(this.Lvl1Timer_Tick);
            // 
            // btnRoof
            // 
            this.btnRoof.BackColor = System.Drawing.Color.Fuchsia;
            this.btnRoof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoof.Location = new System.Drawing.Point(738, 286);
            this.btnRoof.Name = "btnRoof";
            this.btnRoof.Size = new System.Drawing.Size(115, 53);
            this.btnRoof.TabIndex = 7;
            this.btnRoof.Text = "Rūfu";
            this.btnRoof.UseVisualStyleBackColor = false;
            this.btnRoof.Click += new System.EventHandler(this.btnRoof_Click);
            // 
            // btnBody
            // 
            this.btnBody.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBody.Location = new System.Drawing.Point(617, 286);
            this.btnBody.Name = "btnBody";
            this.btnBody.Size = new System.Drawing.Size(115, 53);
            this.btnBody.TabIndex = 8;
            this.btnBody.Text = "Doa";
            this.btnBody.UseVisualStyleBackColor = false;
            this.btnBody.Click += new System.EventHandler(this.btnBody_Click);
            // 
            // btnWheel
            // 
            this.btnWheel.BackColor = System.Drawing.Color.Fuchsia;
            this.btnWheel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWheel.Location = new System.Drawing.Point(738, 368);
            this.btnWheel.Name = "btnWheel";
            this.btnWheel.Size = new System.Drawing.Size(115, 53);
            this.btnWheel.TabIndex = 9;
            this.btnWheel.Text = "Bōdo";
            this.btnWheel.UseVisualStyleBackColor = false;
            this.btnWheel.Click += new System.EventHandler(this.btnWheel_Click);
            // 
            // btnBonnet
            // 
            this.btnBonnet.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBonnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBonnet.Location = new System.Drawing.Point(617, 368);
            this.btnBonnet.Name = "btnBonnet";
            this.btnBonnet.Size = new System.Drawing.Size(115, 53);
            this.btnBonnet.TabIndex = 10;
            this.btnBonnet.Text = "Sora";
            this.btnBonnet.UseVisualStyleBackColor = false;
            this.btnBonnet.Click += new System.EventHandler(this.btnBonnet_Click);
            // 
            // picBody
            // 
            this.picBody.BackColor = System.Drawing.Color.Transparent;
            this.picBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBody.BackgroundImage")));
            this.picBody.Image = ((System.Drawing.Image)(resources.GetObject("picBody.Image")));
            this.picBody.Location = new System.Drawing.Point(185, 318);
            this.picBody.Name = "picBody";
            this.picBody.Size = new System.Drawing.Size(243, 73);
            this.picBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBody.TabIndex = 2;
            this.picBody.TabStop = false;
            this.picBody.Visible = false;
            this.picBody.Click += new System.EventHandler(this.picBody_Click);
            // 
            // PotatoLife3
            // 
            this.PotatoLife3.BackColor = System.Drawing.Color.Transparent;
            this.PotatoLife3.Image = ((System.Drawing.Image)(resources.GetObject("PotatoLife3.Image")));
            this.PotatoLife3.Location = new System.Drawing.Point(738, 12);
            this.PotatoLife3.Name = "PotatoLife3";
            this.PotatoLife3.Size = new System.Drawing.Size(35, 41);
            this.PotatoLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PotatoLife3.TabIndex = 18;
            this.PotatoLife3.TabStop = false;
            this.PotatoLife3.Click += new System.EventHandler(this.PotatoLife3_Click);
            // 
            // potatoLife1
            // 
            this.potatoLife1.BackColor = System.Drawing.Color.Transparent;
            this.potatoLife1.Image = ((System.Drawing.Image)(resources.GetObject("potatoLife1.Image")));
            this.potatoLife1.Location = new System.Drawing.Point(818, 12);
            this.potatoLife1.Name = "potatoLife1";
            this.potatoLife1.Size = new System.Drawing.Size(35, 41);
            this.potatoLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potatoLife1.TabIndex = 19;
            this.potatoLife1.TabStop = false;
            this.potatoLife1.Click += new System.EventHandler(this.potatoLife1_Click);
            // 
            // potatoLife2
            // 
            this.potatoLife2.BackColor = System.Drawing.Color.Transparent;
            this.potatoLife2.Image = ((System.Drawing.Image)(resources.GetObject("potatoLife2.Image")));
            this.potatoLife2.Location = new System.Drawing.Point(777, 12);
            this.potatoLife2.Name = "potatoLife2";
            this.potatoLife2.Size = new System.Drawing.Size(35, 41);
            this.potatoLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potatoLife2.TabIndex = 19;
            this.potatoLife2.TabStop = false;
            this.potatoLife2.Click += new System.EventHandler(this.potatoLife2_Click);
            // 
            // lvl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 512);
            this.Controls.Add(this.potatoLife2);
            this.Controls.Add(this.potatoLife1);
            this.Controls.Add(this.PotatoLife3);
            this.Controls.Add(this.picWheel2);
            this.Controls.Add(this.PicRoof);
            this.Controls.Add(this.btnBonnet);
            this.Controls.Add(this.btnWheel);
            this.Controls.Add(this.btnBody);
            this.Controls.Add(this.btnRoof);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.picBonnet);
            this.Controls.Add(this.picTrunk);
            this.Controls.Add(this.picBody);
            this.Name = "lvl2";
            this.Text = "lvl1";
            this.Load += new System.EventHandler(this.lvl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicRoof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWheel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotatoLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potatoLife2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRoof;
        private System.Windows.Forms.PictureBox picBonnet;
        private System.Windows.Forms.PictureBox picWheel2;
        private System.Windows.Forms.PictureBox picTrunk;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Timer Lvl1Timer;
        private System.Windows.Forms.Button btnRoof;
        private System.Windows.Forms.Button btnBody;
        private System.Windows.Forms.Button btnWheel;
        private System.Windows.Forms.Button btnBonnet;
        private System.Windows.Forms.PictureBox picBody;
        private System.Windows.Forms.PictureBox PotatoLife3;
        private System.Windows.Forms.PictureBox potatoLife1;
        private System.Windows.Forms.PictureBox potatoLife2;
    }
}