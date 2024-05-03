namespace TimViec
{
    partial class FAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAppointment));
            label5 = new Label();
            dtpAppoinment = new DateTimePicker();
            btnSaveAppointment = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            txtContent = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            lbDate = new MaterialSkin.Controls.MaterialLabel();
            lbContent = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGreen;
            label5.Location = new Point(104, 97);
            label5.Name = "label5";
            label5.Size = new Size(455, 54);
            label5.TabIndex = 25;
            label5.Text = "Appointment Schedule";
            // 
            // dtpAppoinment
            // 
            dtpAppoinment.Location = new Point(147, 209);
            dtpAppoinment.Name = "dtpAppoinment";
            dtpAppoinment.Size = new Size(278, 27);
            dtpAppoinment.TabIndex = 26;
            // 
            // btnSaveAppointment
            // 
            btnSaveAppointment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveAppointment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveAppointment.Depth = 0;
            btnSaveAppointment.HighEmphasis = true;
            btnSaveAppointment.Icon = null;
            btnSaveAppointment.Location = new Point(193, 465);
            btnSaveAppointment.Margin = new Padding(4, 6, 4, 6);
            btnSaveAppointment.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveAppointment.Name = "btnSaveAppointment";
            btnSaveAppointment.NoAccentTextColor = Color.Empty;
            btnSaveAppointment.Size = new Size(64, 36);
            btnSaveAppointment.TabIndex = 27;
            btnSaveAppointment.Text = "Save";
            btnSaveAppointment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveAppointment.UseAccentColor = false;
            btnSaveAppointment.UseVisualStyleBackColor = true;
            btnSaveAppointment.Click += btnSaveAppointment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.FromArgb(255, 255, 255);
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Depth = 0;
            txtContent.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContent.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtContent.Location = new Point(147, 300);
            txtContent.MouseState = MaterialSkin.MouseState.HOVER;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(361, 135);
            txtContent.TabIndex = 29;
            txtContent.Text = "";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Depth = 0;
            lbDate.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.LightGreen;
            lbDate.Location = new Point(42, 209);
            lbDate.MouseState = MaterialSkin.MouseState.HOVER;
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(34, 19);
            lbDate.TabIndex = 30;
            lbDate.Text = "Date";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Depth = 0;
            lbContent.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.LightGreen;
            lbContent.Location = new Point(42, 300);
            lbContent.MouseState = MaterialSkin.MouseState.HOVER;
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(56, 19);
            lbContent.TabIndex = 31;
            lbContent.Text = "Content";
            // 
            // FAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 547);
            Controls.Add(lbContent);
            Controls.Add(lbDate);
            Controls.Add(txtContent);
            Controls.Add(pictureBox1);
            Controls.Add(btnSaveAppointment);
            Controls.Add(dtpAppoinment);
            Controls.Add(label5);
            Name = "FAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment";
            Load += Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dtpAppoinment;
        private MaterialSkin.Controls.MaterialButton btnSaveAppointment;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtContent;
        private MaterialSkin.Controls.MaterialLabel lbDate;
        private MaterialSkin.Controls.MaterialLabel lbContent;
    }
}