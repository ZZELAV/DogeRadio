
namespace DogeRadio
{
    partial class DogeRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogeRadio));
            this.btnAbspielen = new System.Windows.Forms.Button();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbDogeGif = new System.Windows.Forms.PictureBox();
            this.cbSender = new System.Windows.Forms.ComboBox();
            this.tbSender = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogeGif)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbspielen
            // 
            this.btnAbspielen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAbspielen.FlatAppearance.BorderSize = 0;
            this.btnAbspielen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbspielen.ForeColor = System.Drawing.Color.White;
            this.btnAbspielen.Location = new System.Drawing.Point(18, 100);
            this.btnAbspielen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbspielen.Name = "btnAbspielen";
            this.btnAbspielen.Size = new System.Drawing.Size(387, 35);
            this.btnAbspielen.TabIndex = 0;
            this.btnAbspielen.Text = "Abspielen";
            this.btnAbspielen.UseVisualStyleBackColor = false;
            this.btnAbspielen.Click += new System.EventHandler(this.btnAbspielen_Click);
            this.btnAbspielen.MouseHover += new System.EventHandler(this.btnAbspielen_MouseHover);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(12, 94);
            this.wmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(258, 161);
            this.wmp.TabIndex = 1;
            // 
            // pbDogeGif
            // 
            this.pbDogeGif.Enabled = false;
            this.pbDogeGif.Image = ((System.Drawing.Image)(resources.GetObject("pbDogeGif.Image")));
            this.pbDogeGif.Location = new System.Drawing.Point(414, 18);
            this.pbDogeGif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDogeGif.Name = "pbDogeGif";
            this.pbDogeGif.Size = new System.Drawing.Size(378, 374);
            this.pbDogeGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDogeGif.TabIndex = 2;
            this.pbDogeGif.TabStop = false;
            // 
            // cbSender
            // 
            this.cbSender.FormattingEnabled = true;
            this.cbSender.Location = new System.Drawing.Point(18, 18);
            this.cbSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSender.Name = "cbSender";
            this.cbSender.Size = new System.Drawing.Size(385, 28);
            this.cbSender.TabIndex = 3;
            this.cbSender.Text = "Sender wählen";
            this.cbSender.SelectedIndexChanged += new System.EventHandler(this.cbSender_SelectedIndexChanged);
            this.cbSender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSender_KeyDown);
            // 
            // tbSender
            // 
            this.tbSender.ForeColor = System.Drawing.Color.Gray;
            this.tbSender.Location = new System.Drawing.Point(18, 60);
            this.tbSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(385, 26);
            this.tbSender.TabIndex = 4;
            this.tbSender.Text = "Eigener Sender";
            this.tbSender.Enter += new System.EventHandler(this.tbSender_Enter);
            this.tbSender.Leave += new System.EventHandler(this.tbSender_Leave);
            // 
            // DogeRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(810, 411);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.cbSender);
            this.Controls.Add(this.pbDogeGif);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.btnAbspielen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DogeRadio";
            this.Text = "Doge Radio";
            this.Load += new System.EventHandler(this.DogeRadio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogeGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbspielen;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.PictureBox pbDogeGif;
        private System.Windows.Forms.ComboBox cbSender;
        private System.Windows.Forms.TextBox tbSender;
    }
}