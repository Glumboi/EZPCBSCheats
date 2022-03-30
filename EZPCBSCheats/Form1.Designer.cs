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
            this.Freeze_money = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.freezemoney_Cb = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add_5000_Xp_BN = new MaterialSkin.Controls.MaterialButton();
            this.freezexp_Cb = new MaterialSkin.Controls.MaterialCheckbox();
            this.Add_50000_Xp_BN = new MaterialSkin.Controls.MaterialButton();
            this.Xp_Textbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.Add_Xp_BN = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Subtract_5000_Xp_BN = new MaterialSkin.Controls.MaterialButton();
            this.Subtract_50000_Xp_BN = new MaterialSkin.Controls.MaterialButton();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.Subtract_10000_Money_BN = new MaterialSkin.Controls.MaterialButton();
            this.Subtract_1000_Money_BN = new MaterialSkin.Controls.MaterialButton();
            this.Add_10000_Money_BN = new MaterialSkin.Controls.MaterialButton();
            this.Add_1000_Money_BN = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Show_Hotkeys_BN = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.Add_Money_BN.Location = new System.Drawing.Point(11, 28);
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
            this.Money_Textbox.Location = new System.Drawing.Point(146, 28);
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
            // Freeze_money
            // 
            this.Freeze_money.Interval = 250;
            this.Freeze_money.Tick += new System.EventHandler(this.Freeze_money_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 587);
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
            this.freezemoney_Cb.Location = new System.Drawing.Point(265, 84);
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
            this.pictureBox1.Location = new System.Drawing.Point(6, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Add_5000_Xp_BN
            // 
            this.Add_5000_Xp_BN.AutoSize = false;
            this.Add_5000_Xp_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_5000_Xp_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add_5000_Xp_BN.Depth = 0;
            this.Add_5000_Xp_BN.HighEmphasis = true;
            this.Add_5000_Xp_BN.Icon = null;
            this.Add_5000_Xp_BN.Location = new System.Drawing.Point(273, 107);
            this.Add_5000_Xp_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add_5000_Xp_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_5000_Xp_BN.Name = "Add_5000_Xp_BN";
            this.Add_5000_Xp_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add_5000_Xp_BN.Size = new System.Drawing.Size(128, 48);
            this.Add_5000_Xp_BN.TabIndex = 6;
            this.Add_5000_Xp_BN.Text = "+1 Level";
            this.Add_5000_Xp_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add_5000_Xp_BN.UseAccentColor = false;
            this.Add_5000_Xp_BN.UseVisualStyleBackColor = true;
            this.Add_5000_Xp_BN.Click += new System.EventHandler(this.Add_5000_Xp_BN_Click);
            // 
            // freezexp_Cb
            // 
            this.freezexp_Cb.AutoSize = true;
            this.freezexp_Cb.Depth = 0;
            this.freezexp_Cb.Location = new System.Drawing.Point(296, 73);
            this.freezexp_Cb.Margin = new System.Windows.Forms.Padding(0);
            this.freezexp_Cb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.freezexp_Cb.MouseState = MaterialSkin.MouseState.HOVER;
            this.freezexp_Cb.Name = "freezexp_Cb";
            this.freezexp_Cb.ReadOnly = false;
            this.freezexp_Cb.Ripple = true;
            this.freezexp_Cb.Size = new System.Drawing.Size(105, 37);
            this.freezexp_Cb.TabIndex = 7;
            this.freezexp_Cb.Text = "Freeze XP";
            this.freezexp_Cb.UseVisualStyleBackColor = true;
            this.freezexp_Cb.CheckedChanged += new System.EventHandler(this.freezexp_Cb_CheckedChanged);
            // 
            // Add_50000_Xp_BN
            // 
            this.Add_50000_Xp_BN.AutoSize = false;
            this.Add_50000_Xp_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_50000_Xp_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add_50000_Xp_BN.Depth = 0;
            this.Add_50000_Xp_BN.HighEmphasis = true;
            this.Add_50000_Xp_BN.Icon = null;
            this.Add_50000_Xp_BN.Location = new System.Drawing.Point(273, 160);
            this.Add_50000_Xp_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add_50000_Xp_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_50000_Xp_BN.Name = "Add_50000_Xp_BN";
            this.Add_50000_Xp_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add_50000_Xp_BN.Size = new System.Drawing.Size(128, 48);
            this.Add_50000_Xp_BN.TabIndex = 8;
            this.Add_50000_Xp_BN.Text = "+10 Level";
            this.Add_50000_Xp_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add_50000_Xp_BN.UseAccentColor = false;
            this.Add_50000_Xp_BN.UseVisualStyleBackColor = true;
            this.Add_50000_Xp_BN.Click += new System.EventHandler(this.Add_50000_Xp_BN_Click);
            // 
            // Xp_Textbox
            // 
            this.Xp_Textbox.AnimateReadOnly = false;
            this.Xp_Textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Xp_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Xp_Textbox.Depth = 0;
            this.Xp_Textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Xp_Textbox.HideSelection = true;
            this.Xp_Textbox.LeadingIcon = null;
            this.Xp_Textbox.Location = new System.Drawing.Point(151, 22);
            this.Xp_Textbox.MaxLength = 32767;
            this.Xp_Textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Xp_Textbox.Name = "Xp_Textbox";
            this.Xp_Textbox.PasswordChar = '\0';
            this.Xp_Textbox.PrefixSuffixText = null;
            this.Xp_Textbox.ReadOnly = false;
            this.Xp_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Xp_Textbox.SelectedText = "";
            this.Xp_Textbox.SelectionLength = 0;
            this.Xp_Textbox.SelectionStart = 0;
            this.Xp_Textbox.ShortcutsEnabled = true;
            this.Xp_Textbox.Size = new System.Drawing.Size(250, 48);
            this.Xp_Textbox.TabIndex = 9;
            this.Xp_Textbox.TabStop = false;
            this.Xp_Textbox.Text = "5000";
            this.Xp_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Xp_Textbox.TrailingIcon = null;
            this.Xp_Textbox.UseSystemPasswordChar = false;
            // 
            // Add_Xp_BN
            // 
            this.Add_Xp_BN.AutoSize = false;
            this.Add_Xp_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_Xp_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add_Xp_BN.Depth = 0;
            this.Add_Xp_BN.HighEmphasis = true;
            this.Add_Xp_BN.Icon = null;
            this.Add_Xp_BN.Location = new System.Drawing.Point(11, 22);
            this.Add_Xp_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add_Xp_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_Xp_BN.Name = "Add_Xp_BN";
            this.Add_Xp_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add_Xp_BN.Size = new System.Drawing.Size(128, 48);
            this.Add_Xp_BN.TabIndex = 10;
            this.Add_Xp_BN.Text = "Add xp";
            this.Add_Xp_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add_Xp_BN.UseAccentColor = false;
            this.Add_Xp_BN.UseVisualStyleBackColor = true;
            this.Add_Xp_BN.Click += new System.EventHandler(this.Add_Xp_BN_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(156, 82);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "5000 = +1 level";
            // 
            // Subtract_5000_Xp_BN
            // 
            this.Subtract_5000_Xp_BN.AutoSize = false;
            this.Subtract_5000_Xp_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subtract_5000_Xp_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Subtract_5000_Xp_BN.Depth = 0;
            this.Subtract_5000_Xp_BN.HighEmphasis = true;
            this.Subtract_5000_Xp_BN.Icon = null;
            this.Subtract_5000_Xp_BN.Location = new System.Drawing.Point(140, 107);
            this.Subtract_5000_Xp_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Subtract_5000_Xp_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Subtract_5000_Xp_BN.Name = "Subtract_5000_Xp_BN";
            this.Subtract_5000_Xp_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Subtract_5000_Xp_BN.Size = new System.Drawing.Size(128, 48);
            this.Subtract_5000_Xp_BN.TabIndex = 12;
            this.Subtract_5000_Xp_BN.Text = "-1 Level";
            this.Subtract_5000_Xp_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Subtract_5000_Xp_BN.UseAccentColor = false;
            this.Subtract_5000_Xp_BN.UseVisualStyleBackColor = true;
            this.Subtract_5000_Xp_BN.Click += new System.EventHandler(this.Subtract_5000_Xp_BN_Click);
            // 
            // Subtract_50000_Xp_BN
            // 
            this.Subtract_50000_Xp_BN.AutoSize = false;
            this.Subtract_50000_Xp_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subtract_50000_Xp_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Subtract_50000_Xp_BN.Depth = 0;
            this.Subtract_50000_Xp_BN.HighEmphasis = true;
            this.Subtract_50000_Xp_BN.Icon = null;
            this.Subtract_50000_Xp_BN.Location = new System.Drawing.Point(140, 160);
            this.Subtract_50000_Xp_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Subtract_50000_Xp_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Subtract_50000_Xp_BN.Name = "Subtract_50000_Xp_BN";
            this.Subtract_50000_Xp_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Subtract_50000_Xp_BN.Size = new System.Drawing.Size(128, 48);
            this.Subtract_50000_Xp_BN.TabIndex = 13;
            this.Subtract_50000_Xp_BN.Text = "-10 Level";
            this.Subtract_50000_Xp_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Subtract_50000_Xp_BN.UseAccentColor = false;
            this.Subtract_50000_Xp_BN.UseVisualStyleBackColor = true;
            this.Subtract_50000_Xp_BN.Click += new System.EventHandler(this.Subtract_50000_Xp_BN_Click);
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 1000;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // Subtract_10000_Money_BN
            // 
            this.Subtract_10000_Money_BN.AutoSize = false;
            this.Subtract_10000_Money_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subtract_10000_Money_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Subtract_10000_Money_BN.Depth = 0;
            this.Subtract_10000_Money_BN.HighEmphasis = true;
            this.Subtract_10000_Money_BN.Icon = null;
            this.Subtract_10000_Money_BN.Location = new System.Drawing.Point(208, 177);
            this.Subtract_10000_Money_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Subtract_10000_Money_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Subtract_10000_Money_BN.Name = "Subtract_10000_Money_BN";
            this.Subtract_10000_Money_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Subtract_10000_Money_BN.Size = new System.Drawing.Size(193, 48);
            this.Subtract_10000_Money_BN.TabIndex = 17;
            this.Subtract_10000_Money_BN.Text = "-10000 $";
            this.Subtract_10000_Money_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Subtract_10000_Money_BN.UseAccentColor = false;
            this.Subtract_10000_Money_BN.UseVisualStyleBackColor = true;
            this.Subtract_10000_Money_BN.Click += new System.EventHandler(this.Subtract_10000_Money_BN_Click);
            // 
            // Subtract_1000_Money_BN
            // 
            this.Subtract_1000_Money_BN.AutoSize = false;
            this.Subtract_1000_Money_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subtract_1000_Money_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Subtract_1000_Money_BN.Depth = 0;
            this.Subtract_1000_Money_BN.HighEmphasis = true;
            this.Subtract_1000_Money_BN.Icon = null;
            this.Subtract_1000_Money_BN.Location = new System.Drawing.Point(11, 177);
            this.Subtract_1000_Money_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Subtract_1000_Money_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Subtract_1000_Money_BN.Name = "Subtract_1000_Money_BN";
            this.Subtract_1000_Money_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Subtract_1000_Money_BN.Size = new System.Drawing.Size(193, 48);
            this.Subtract_1000_Money_BN.TabIndex = 16;
            this.Subtract_1000_Money_BN.Text = "-1000 $";
            this.Subtract_1000_Money_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Subtract_1000_Money_BN.UseAccentColor = false;
            this.Subtract_1000_Money_BN.UseVisualStyleBackColor = true;
            this.Subtract_1000_Money_BN.Click += new System.EventHandler(this.Subtract_1000_Money_BN_Click);
            // 
            // Add_10000_Money_BN
            // 
            this.Add_10000_Money_BN.AutoSize = false;
            this.Add_10000_Money_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_10000_Money_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add_10000_Money_BN.Depth = 0;
            this.Add_10000_Money_BN.HighEmphasis = true;
            this.Add_10000_Money_BN.Icon = null;
            this.Add_10000_Money_BN.Location = new System.Drawing.Point(208, 122);
            this.Add_10000_Money_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add_10000_Money_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_10000_Money_BN.Name = "Add_10000_Money_BN";
            this.Add_10000_Money_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add_10000_Money_BN.Size = new System.Drawing.Size(193, 48);
            this.Add_10000_Money_BN.TabIndex = 15;
            this.Add_10000_Money_BN.Text = "+10000 $";
            this.Add_10000_Money_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add_10000_Money_BN.UseAccentColor = false;
            this.Add_10000_Money_BN.UseVisualStyleBackColor = true;
            this.Add_10000_Money_BN.Click += new System.EventHandler(this.Add_10000_Money_BN_Click);
            // 
            // Add_1000_Money_BN
            // 
            this.Add_1000_Money_BN.AutoSize = false;
            this.Add_1000_Money_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_1000_Money_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add_1000_Money_BN.Depth = 0;
            this.Add_1000_Money_BN.HighEmphasis = true;
            this.Add_1000_Money_BN.Icon = null;
            this.Add_1000_Money_BN.Location = new System.Drawing.Point(11, 122);
            this.Add_1000_Money_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add_1000_Money_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_1000_Money_BN.Name = "Add_1000_Money_BN";
            this.Add_1000_Money_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add_1000_Money_BN.Size = new System.Drawing.Size(193, 48);
            this.Add_1000_Money_BN.TabIndex = 14;
            this.Add_1000_Money_BN.Text = "+1000 $";
            this.Add_1000_Money_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add_1000_Money_BN.UseAccentColor = false;
            this.Add_1000_Money_BN.UseVisualStyleBackColor = true;
            this.Add_1000_Money_BN.Click += new System.EventHandler(this.Add_1000_Money_BN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Show_Hotkeys_BN);
            this.groupBox1.Controls.Add(this.Xp_Textbox);
            this.groupBox1.Controls.Add(this.Add_5000_Xp_BN);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.freezexp_Cb);
            this.groupBox1.Controls.Add(this.Add_50000_Xp_BN);
            this.groupBox1.Controls.Add(this.Add_Xp_BN);
            this.groupBox1.Controls.Add(this.Subtract_50000_Xp_BN);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.Subtract_5000_Xp_BN);
            this.groupBox1.Location = new System.Drawing.Point(18, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 252);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XP Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Add_1000_Money_BN);
            this.groupBox2.Controls.Add(this.Add_Money_BN);
            this.groupBox2.Controls.Add(this.Subtract_10000_Money_BN);
            this.groupBox2.Controls.Add(this.Money_Textbox);
            this.groupBox2.Controls.Add(this.Subtract_1000_Money_BN);
            this.groupBox2.Controls.Add(this.freezemoney_Cb);
            this.groupBox2.Controls.Add(this.Add_10000_Money_BN);
            this.groupBox2.Location = new System.Drawing.Point(18, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 262);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Money Options";
            // 
            // Show_Hotkeys_BN
            // 
            this.Show_Hotkeys_BN.AutoSize = false;
            this.Show_Hotkeys_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Show_Hotkeys_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Show_Hotkeys_BN.Depth = 0;
            this.Show_Hotkeys_BN.HighEmphasis = true;
            this.Show_Hotkeys_BN.Icon = null;
            this.Show_Hotkeys_BN.Location = new System.Drawing.Point(273, 213);
            this.Show_Hotkeys_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Show_Hotkeys_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Show_Hotkeys_BN.Name = "Show_Hotkeys_BN";
            this.Show_Hotkeys_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Show_Hotkeys_BN.Size = new System.Drawing.Size(128, 29);
            this.Show_Hotkeys_BN.TabIndex = 14;
            this.Show_Hotkeys_BN.Text = "Show hotkeys";
            this.Show_Hotkeys_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Show_Hotkeys_BN.UseAccentColor = false;
            this.Show_Hotkeys_BN.UseVisualStyleBackColor = true;
            this.Show_Hotkeys_BN.Click += new System.EventHandler(this.Show_Hotkeys_BN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(446, 609);
            this.MinimumSize = new System.Drawing.Size(446, 609);
            this.Name = "Form1";
            this.Text = "EZPCBSCheats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Add_Money_BN;
        private MaterialSkin.Controls.MaterialTextBox2 Money_Textbox;
        private System.Windows.Forms.Timer Freeze_money;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox freezemoney_Cb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton Add_5000_Xp_BN;
        private MaterialSkin.Controls.MaterialCheckbox freezexp_Cb;
        private MaterialSkin.Controls.MaterialButton Add_50000_Xp_BN;
        private MaterialSkin.Controls.MaterialTextBox2 Xp_Textbox;
        private MaterialSkin.Controls.MaterialButton Add_Xp_BN;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton Subtract_5000_Xp_BN;
        private MaterialSkin.Controls.MaterialButton Subtract_50000_Xp_BN;
        private System.Windows.Forms.Timer Update;
        private MaterialSkin.Controls.MaterialButton Subtract_10000_Money_BN;
        private MaterialSkin.Controls.MaterialButton Subtract_1000_Money_BN;
        private MaterialSkin.Controls.MaterialButton Add_10000_Money_BN;
        private MaterialSkin.Controls.MaterialButton Add_1000_Money_BN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton Show_Hotkeys_BN;
    }
}

