
namespace GameDevAssign2
{
    partial class lvl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl1));
            this.btnShoe = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnLamp = new System.Windows.Forms.Button();
            this.lightsTimer = new System.Windows.Forms.Timer(this.components);
            this.lblShoe = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblLamp = new System.Windows.Forms.Label();
            this.lightsOutPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lightsOutPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShoe
            // 
            this.btnShoe.BackColor = System.Drawing.Color.Transparent;
            this.btnShoe.FlatAppearance.BorderSize = 0;
            this.btnShoe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShoe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoe.ForeColor = System.Drawing.Color.Transparent;
            this.btnShoe.Location = new System.Drawing.Point(394, 523);
            this.btnShoe.Name = "btnShoe";
            this.btnShoe.Size = new System.Drawing.Size(78, 59);
            this.btnShoe.TabIndex = 1;
            this.btnShoe.UseVisualStyleBackColor = false;
            this.btnShoe.Click += new System.EventHandler(this.btnShoe_Click);
            this.btnShoe.MouseHover += new System.EventHandler(this.btnShoe_MouseHover);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.ForeColor = System.Drawing.Color.Transparent;
            this.btnPicture.Location = new System.Drawing.Point(708, 342);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(78, 59);
            this.btnPicture.TabIndex = 2;
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnLamp
            // 
            this.btnLamp.BackColor = System.Drawing.Color.Transparent;
            this.btnLamp.FlatAppearance.BorderSize = 0;
            this.btnLamp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLamp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamp.ForeColor = System.Drawing.Color.Transparent;
            this.btnLamp.Location = new System.Drawing.Point(794, 215);
            this.btnLamp.Name = "btnLamp";
            this.btnLamp.Size = new System.Drawing.Size(57, 82);
            this.btnLamp.TabIndex = 3;
            this.btnLamp.UseVisualStyleBackColor = false;
            this.btnLamp.Click += new System.EventHandler(this.btnLamp_Click);
            // 
            // lightsTimer
            // 
            this.lightsTimer.Enabled = true;
            this.lightsTimer.Interval = 800;
            this.lightsTimer.Tick += new System.EventHandler(this.lightsTimer_Tick);
            // 
            // lblShoe
            // 
            this.lblShoe.Location = new System.Drawing.Point(861, 68);
            this.lblShoe.Name = "lblShoe";
            this.lblShoe.Size = new System.Drawing.Size(91, 19);
            this.lblShoe.TabIndex = 4;
            this.lblShoe.Text = "Kutsu";
            this.lblShoe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoto
            // 
            this.lblPhoto.Location = new System.Drawing.Point(861, 99);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(91, 19);
            this.lblPhoto.TabIndex = 5;
            this.lblPhoto.Text = "Kazoku shashin";
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLamp
            // 
            this.lblLamp.Location = new System.Drawing.Point(861, 128);
            this.lblLamp.Name = "lblLamp";
            this.lblLamp.Size = new System.Drawing.Size(91, 19);
            this.lblLamp.TabIndex = 6;
            this.lblLamp.Text = "Ranpu";
            this.lblLamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lightsOutPicBox
            // 
            this.lightsOutPicBox.BackColor = System.Drawing.Color.Black;
            this.lightsOutPicBox.Location = new System.Drawing.Point(-2, -6);
            this.lightsOutPicBox.Name = "lightsOutPicBox";
            this.lightsOutPicBox.Size = new System.Drawing.Size(968, 588);
            this.lightsOutPicBox.TabIndex = 7;
            this.lightsOutPicBox.TabStop = false;
            this.lightsOutPicBox.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(838, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find these objects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 577);
            this.Controls.Add(this.lblLamp);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblShoe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightsOutPicBox);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnLamp);
            this.Controls.Add(this.btnShoe);
            this.Name = "lvl1";
            this.Text = "lvl2";
            ((System.ComponentModel.ISupportInitialize)(this.lightsOutPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShoe;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnLamp;
        private System.Windows.Forms.Timer lightsTimer;
        private System.Windows.Forms.Label lblShoe;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblLamp;
        private System.Windows.Forms.PictureBox lightsOutPicBox;
        private System.Windows.Forms.Label label1;
    }
}