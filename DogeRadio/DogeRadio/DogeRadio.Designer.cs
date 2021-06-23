
namespace DogeRadio
{
    partial class DogeRadio
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogeRadio));
            this.drpdwnSender = new System.Windows.Forms.ComboBox();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtBxSender = new System.Windows.Forms.TextBox();
            this.btnAbspielen = new System.Windows.Forms.Button();
            this.picDoge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoge)).BeginInit();
            this.SuspendLayout();
            // 
            // drpdwnSender
            // 
            this.drpdwnSender.FormattingEnabled = true;
            this.drpdwnSender.Location = new System.Drawing.Point(11, 12);
            this.drpdwnSender.Name = "drpdwnSender";
            this.drpdwnSender.Size = new System.Drawing.Size(266, 21);
            this.drpdwnSender.TabIndex = 0;
            this.drpdwnSender.Tag = "";
            this.drpdwnSender.Text = "Sender wählen";
            this.drpdwnSender.SelectedIndexChanged += new System.EventHandler(this.drpdwnSender_SelectedIndexChanged);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(11, 95);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(266, 161);
            this.wmp.TabIndex = 1;
            // 
            // txtBxSender
            // 
            this.txtBxSender.ForeColor = System.Drawing.Color.Gray;
            this.txtBxSender.Location = new System.Drawing.Point(11, 39);
            this.txtBxSender.Name = "txtBxSender";
            this.txtBxSender.Size = new System.Drawing.Size(266, 20);
            this.txtBxSender.TabIndex = 2;
            this.txtBxSender.Text = "Eigener Sender";
            this.txtBxSender.Enter += new System.EventHandler(this.txtBxSender_Enter);
            this.txtBxSender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxSender_KeyDown);
            this.txtBxSender.Leave += new System.EventHandler(this.txtBxSender_Leave);
            // 
            // btnAbspielen
            // 
            this.btnAbspielen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAbspielen.FlatAppearance.BorderSize = 0;
            this.btnAbspielen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbspielen.ForeColor = System.Drawing.Color.White;
            this.btnAbspielen.Location = new System.Drawing.Point(11, 66);
            this.btnAbspielen.Name = "btnAbspielen";
            this.btnAbspielen.Size = new System.Drawing.Size(266, 23);
            this.btnAbspielen.TabIndex = 3;
            this.btnAbspielen.Text = "Abspielen";
            this.btnAbspielen.UseVisualStyleBackColor = false;
            this.btnAbspielen.Click += new System.EventHandler(this.btnAbspielen_Click);
            this.btnAbspielen.MouseHover += new System.EventHandler(this.btnAbspielen_MouseHover);
            // 
            // picDoge
            // 
            this.picDoge.Image = global::DogeRadio.Properties.Resources.doge;
            this.picDoge.Location = new System.Drawing.Point(283, 12);
            this.picDoge.Name = "picDoge";
            this.picDoge.Size = new System.Drawing.Size(245, 244);
            this.picDoge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoge.TabIndex = 4;
            this.picDoge.TabStop = false;
            // 
            // DogeRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(540, 267);
            this.Controls.Add(this.picDoge);
            this.Controls.Add(this.btnAbspielen);
            this.Controls.Add(this.txtBxSender);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.drpdwnSender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DogeRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doge Radio";
            this.Load += new System.EventHandler(this.DogeRadio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drpdwnSender;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.TextBox txtBxSender;
        private System.Windows.Forms.Button btnAbspielen;
        private System.Windows.Forms.PictureBox picDoge;
    }
}

