namespace TimViec
{
    partial class FReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FReview));
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            pictureBox2 = new PictureBox();
            cbxRate = new ComboBox();
            lbRateStar = new Label();
            btnClearRate = new MaterialSkin.Controls.MaterialButton();
            btnSubmitRate = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label18 = new Label();
            txtReview = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btnClearReview = new MaterialSkin.Controls.MaterialButton();
            btnSubmitReview = new MaterialSkin.Controls.MaterialButton();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(pictureBox2);
            materialCard2.Controls.Add(cbxRate);
            materialCard2.Controls.Add(lbRateStar);
            materialCard2.Controls.Add(btnClearRate);
            materialCard2.Controls.Add(btnSubmitRate);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(36, 384);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(380, 132);
            materialCard2.TabIndex = 32;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(299, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // cbxRate
            // 
            cbxRate.Font = new Font("Nirmala UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxRate.FormattingEnabled = true;
            cbxRate.Items.AddRange(new object[] { "5", "4", "3", "2", "1" });
            cbxRate.Location = new Point(200, 54);
            cbxRate.Name = "cbxRate";
            cbxRate.Size = new Size(79, 49);
            cbxRate.TabIndex = 30;
            cbxRate.Text = "5";
            // 
            // lbRateStar
            // 
            lbRateStar.AutoSize = true;
            lbRateStar.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRateStar.ForeColor = Color.LightGreen;
            lbRateStar.Location = new Point(18, 14);
            lbRateStar.Name = "lbRateStar";
            lbRateStar.Size = new Size(110, 31);
            lbRateStar.TabIndex = 29;
            lbRateStar.Text = "Rate Star";
            // 
            // btnClearRate
            // 
            btnClearRate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearRate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClearRate.Depth = 0;
            btnClearRate.HighEmphasis = true;
            btnClearRate.Icon = null;
            btnClearRate.Location = new Point(100, 56);
            btnClearRate.Margin = new Padding(4, 6, 4, 6);
            btnClearRate.MouseState = MaterialSkin.MouseState.HOVER;
            btnClearRate.Name = "btnClearRate";
            btnClearRate.NoAccentTextColor = Color.Empty;
            btnClearRate.Size = new Size(66, 36);
            btnClearRate.TabIndex = 28;
            btnClearRate.Text = "clear";
            btnClearRate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnClearRate.UseAccentColor = true;
            btnClearRate.UseVisualStyleBackColor = true;
            // 
            // btnSubmitRate
            // 
            btnSubmitRate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmitRate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSubmitRate.Depth = 0;
            btnSubmitRate.HighEmphasis = true;
            btnSubmitRate.Icon = null;
            btnSubmitRate.Location = new Point(17, 56);
            btnSubmitRate.Margin = new Padding(4, 6, 4, 6);
            btnSubmitRate.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubmitRate.Name = "btnSubmitRate";
            btnSubmitRate.NoAccentTextColor = Color.Empty;
            btnSubmitRate.Size = new Size(75, 36);
            btnSubmitRate.TabIndex = 27;
            btnSubmitRate.Text = "submit ";
            btnSubmitRate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSubmitRate.UseAccentColor = true;
            btnSubmitRate.UseVisualStyleBackColor = true;
            btnSubmitRate.Click += btnSubmitRate_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label18);
            materialCard1.Controls.Add(txtReview);
            materialCard1.Controls.Add(btnClearReview);
            materialCard1.Controls.Add(btnSubmitReview);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(36, 79);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(989, 277);
            materialCard1.TabIndex = 31;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.LightGreen;
            label18.Location = new Point(14, 17);
            label18.Name = "label18";
            label18.Size = new Size(141, 31);
            label18.TabIndex = 25;
            label18.Text = "Post Review";
            // 
            // txtReview
            // 
            txtReview.AnimateReadOnly = false;
            txtReview.BackgroundImageLayout = ImageLayout.None;
            txtReview.CharacterCasing = CharacterCasing.Normal;
            txtReview.Depth = 0;
            txtReview.HideSelection = true;
            txtReview.Location = new Point(173, 17);
            txtReview.MaxLength = 32767;
            txtReview.MouseState = MaterialSkin.MouseState.OUT;
            txtReview.Name = "txtReview";
            txtReview.PasswordChar = '\0';
            txtReview.ReadOnly = false;
            txtReview.ScrollBars = ScrollBars.None;
            txtReview.SelectedText = "";
            txtReview.SelectionLength = 0;
            txtReview.SelectionStart = 0;
            txtReview.ShortcutsEnabled = true;
            txtReview.Size = new Size(778, 221);
            txtReview.TabIndex = 26;
            txtReview.TabStop = false;
            txtReview.TextAlign = HorizontalAlignment.Left;
            txtReview.UseSystemPasswordChar = false;
            // 
            // btnClearReview
            // 
            btnClearReview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearReview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClearReview.Depth = 0;
            btnClearReview.HighEmphasis = true;
            btnClearReview.Icon = null;
            btnClearReview.Location = new Point(100, 67);
            btnClearReview.Margin = new Padding(4, 6, 4, 6);
            btnClearReview.MouseState = MaterialSkin.MouseState.HOVER;
            btnClearReview.Name = "btnClearReview";
            btnClearReview.NoAccentTextColor = Color.Empty;
            btnClearReview.Size = new Size(66, 36);
            btnClearReview.TabIndex = 28;
            btnClearReview.Text = "clear";
            btnClearReview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnClearReview.UseAccentColor = true;
            btnClearReview.UseVisualStyleBackColor = true;
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmitReview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSubmitReview.Depth = 0;
            btnSubmitReview.HighEmphasis = true;
            btnSubmitReview.Icon = null;
            btnSubmitReview.Location = new Point(14, 67);
            btnSubmitReview.Margin = new Padding(4, 6, 4, 6);
            btnSubmitReview.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.NoAccentTextColor = Color.Empty;
            btnSubmitReview.Size = new Size(75, 36);
            btnSubmitReview.TabIndex = 27;
            btnSubmitReview.Text = "submit ";
            btnSubmitReview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSubmitReview.UseAccentColor = true;
            btnSubmitReview.UseVisualStyleBackColor = true;
            btnSubmitReview.Click += btnSubmitReview_Click;
            // 
            // FReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 565);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "FReview";
            Text = "Review";
            Load += Review_Load;
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard2;
        private PictureBox pictureBox2;
        private ComboBox cbxRate;
        private Label lbRateStar;
        private MaterialSkin.Controls.MaterialButton btnClearRate;
        private MaterialSkin.Controls.MaterialButton btnSubmitRate;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label18;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtReview;
        private MaterialSkin.Controls.MaterialButton btnClearReview;
        private MaterialSkin.Controls.MaterialButton btnSubmitReview;
    }
}