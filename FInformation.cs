using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimViec
{
    public partial class FInformation : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private DbConnection dbConnection;

        private int workerId;
        private int userId;
        public FInformation(int userId, int workerId)
        {
            InitializeComponent();
            dbConnection = new DbConnection();

            this.workerId = workerId;
            this.userId = userId;
            System.Diagnostics.Debug.WriteLine($"FInfor form: workerId = {this.workerId}");
            System.Diagnostics.Debug.WriteLine($"FInfor form: userId = {this.userId}");

            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen900,
                                                                Primary.LightGreen700,
                                                                Primary.LightGreen500,
                                                                Accent.LightGreen200,
                                                                TextShade.WHITE);
        }

        private void Information_Load(object sender, EventArgs e)
        {
            AddPanelToFlowLayout(workerId);
            LoadInformationWorker(workerId);
        }



        private Label CreateLabel(string text, Font font, Point location)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = font;
            label.AutoSize = true;
            label.Location = location;
            label.TextAlign = ContentAlignment.TopLeft;
            return label;
        }

        private void AddControlsToPanel(Image image, string label1Text, string label4Text, string category, string price)
        {
            // Create and configure picture box
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(180, 180);
            pictureBox.Location = new Point(610, 20);

            // Create and configure labels
            Label label1 = CreateLabel(label1Text, new Font("Nirmala UI", 14, FontStyle.Bold), new Point(40, 10));
            label1.ForeColor = Color.Chocolate;

            Label label4 = CreateLabel(label4Text, new Font("Nirmala UI", 12), new Point(40, 50));

            Label lableCategory = CreateLabel("Category: " + category, new Font("Nirmala UI", 12), new Point(40, 90));

            Label labelPrice = CreateLabel("Price: " + price, new Font("Nirmala UI", 12), new Point(40, 130));

            // Create a new panel
            MaterialCard card = new MaterialCard();
            card.Width = 820;
            card.Height = 250;
            card.BackColor = Color.White;

            // Add controls to the card
            card.Controls.Add(label1);
            card.Controls.Add(label4);
            card.Controls.Add(pictureBox);
            card.Controls.Add(lableCategory);
            card.Controls.Add(labelPrice);

            flowLayoutPanel1.Controls.Add(card);
        }



        private void AddPanelToFlowLayout(int workerId)
        {
            dbConnection.Open();
            string query = @"
                            SELECT J.JobTitle,
		                            J.JobDescription,
		                            J.Price,
		                            J.Category,
		                            J.ImagesJob
                            FROM JobHistory J
                            WHERE J.Worker_id = @workerId
                            ";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@workerId", workerId);
            DataTable dataTable = dbConnection.ExecuteQuery(command);

            foreach (DataRow row in dataTable.Rows)
            {

                var imagePath = row["ImagesJob"] as string;
                var image = !string.IsNullOrEmpty(imagePath) ? Image.FromFile(imagePath) : null;

                string label1Text = row["JobTitle"].ToString();
                string label2Text = row["JobDescription"].ToString();
                string category = row["Category"].ToString();
                string price = row["Price"].ToString();


                AddControlsToPanel(image, label1Text, label2Text, category, price);
            }
            dbConnection.Close();
        }

        private void btnGiveYourReview_Click(object sender, EventArgs e)
        {
            FReview reviewForm = new FReview(this.userId, this.workerId);
            reviewForm.Show();
        }

        private void LoadInformationWorker(int workerId)
        {
            dbConnection.Open();
            string query = @"
                            SELECT  W.Worker_id,
                                    U.Name,
                                    U.Gender,
                                    U.Address,
                                    U.PhoneNumber,
		                            U.Email,
		                            U.ImagePath,
                                    W.Salary, 
									AVG(R.Stars) as AVG_Stars
                            FROM Users U
                            JOIN Worker W ON U.user_id = w.user_id
							LEFT JOIN Ratings R ON R.Worker_id = W.Worker_id
                            WHERE W.Worker_id = @WorkerId
							GROUP BY W.Worker_id, U.Name, U.Gender, U.Address, U.PhoneNumber, U.Email, U.ImagePath, W.Salary;
                            ";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@WorkerId", workerId);
            DataTable dataTable = dbConnection.ExecuteQuery(command);

            foreach (DataRow row in dataTable.Rows)
            {
                // Process the data from the row
                var Worker_id = row["Worker_id"];
                var imagePath = row["ImagePath"] as string;
                var image = !string.IsNullOrEmpty(imagePath) ? Image.FromFile(imagePath) : null;
                if (image != null)
                {
                    picBxWorker.Image = image;
                }

                lbName.Text = row["Name"].ToString();
                lbGender.Text = row["Gender"].ToString();
                lbAddress.Text = row["Address"].ToString();
                lbPhone.Text = row["PhoneNumber"].ToString();
                lbEmail.Text = row["Email"].ToString();
                lbSalary.Text = row["Salary"].ToString();
                lbRate.Text = row["AVG_Stars"].ToString();
            }
            dbConnection.Close();
        }
    }
}
