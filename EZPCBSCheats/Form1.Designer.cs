namespace EZPCBSCheats
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add_Money_BN = new MaterialSkin.Controls.MaterialButton();
            this.Money_Textbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.Freeze = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.freezemoney_Cb = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Money_BN
            // 
            this.Add_Money_BN.AutoSize = false;
            this.Add_Money_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_Money_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add_Money_BN.Depth = 0;
            this.Add_Money_BN.HighEmphasis = true;
            this.Add_Money_BN.Icon = null;
            this.Add_Money_BN.Location = new System.Drawing.Point(269, 79);
            this.Add_Money_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add_Money_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_Money_BN.Name = "Add_Money_BN";
            this.Add_Money_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add_Money_BN.Size = new System.Drawing.Size(128, 48);
            this.Add_Money_BN.TabIndex = 0;
            this.Add_Money_BN.Text = "Set money";
            this.Add_Money_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add_Money_BN.UseAccentColor = false;
            this.Add_Money_BN.UseVisualStyleBackColor = true;
            this.Add_Money_BN.Click += new System.EventHandler(this.Add_Money_BN_Click);
            // 
            // Money_Textbox
            // 
            this.Money_Textbox.AnimateReadOnly = false;
            this.Money_Textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Money_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Money_Textbox.Depth = 0;
            this.Money_Textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Money_Textbox.HideSelection = true;
            this.Money_Textbox.LeadingIcon = null;
            this.Money_Textbox.Location = new System.Drawing.Point(9, 79);
            this.Money_Textbox.MaxLength = 32767;
            this.Money_Textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Money_Textbox.Name = "Money_Textbox";
            this.Money_Textbox.PasswordChar = '\0';
            this.Money_Textbox.PrefixSuffixText = null;
            this.Money_Textbox.ReadOnly = false;
            this.Money_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Money_Textbox.SelectedText = "";
            this.Money_Textbox.SelectionLength = 0;
            this.Money_Textbox.SelectionStart = 0;
            this.Money_Textbox.ShortcutsEnabled = true;
            this.Money_Textbox.Size = new System.Drawing.Size(250, 48);
            this.Money_Textbox.TabIndex = 1;
            this.Money_Textbox.TabStop = false;
            this.Money_Textbox.Text = "1000";
            this.Money_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Money_Textbox.TrailingIcon = null;
            this.Money_Textbox.UseSystemPasswordChar = false;
            // 
            // Freeze
            // 
            this.Freeze.Interval = 250;
            this.Freeze.Tick += new System.EventHandler(this.Freeze_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 205);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // freezemoney_Cb
            // 
            this.freezemoney_Cb.AutoSize = true;
            this.freezemoney_Cb.Depth = 0;
            this.freezemoney_Cb.Location = new System.Drawing.Point(9, 130);
            this.freezemoney_Cb.Margin = new System.Windows.Forms.Padding(0);
            this.freezemoney_Cb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.freezemoney_Cb.MouseState = MaterialSkin.MouseState.HOVER;
            this.freezemoney_Cb.Name = "freezemoney_Cb";
            this.freezemoney_Cb.ReadOnly = false;
            this.freezemoney_Cb.Ripple = true;
            this.freezemoney_Cb.Size = new System.Drawing.Size(133, 37);
            this.freezemoney_Cb.TabIndex = 3;
            this.freezemoney_Cb.Text = "Freeze money";
            this.freezemoney_Cb.UseVisualStyleBackColor = true;
            this.freezemoney_Cb.CheckedChanged += new System.EventHandler(this.freezemoney_Cb_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.freezemoney_Cb);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Money_Textbox);
            this.Controls.Add(this.Add_Money_BN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 238);
            this.MinimumSize = new System.Drawing.Size(420, 238);
            this.Name = "Form1";
            this.Text = "EZPCBSCheats";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Add_Money_BN;
        private MaterialSkin.Controls.MaterialTextBox2 Money_Textbox;
        private System.Windows.Forms.Timer Freeze;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox freezemoney_Cb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

