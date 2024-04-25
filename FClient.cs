﻿using MaterialSkin;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;


namespace TimViec
{
    public partial class FClient : MaterialForm
    {

        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private DbConnection dbConnection;

        ClientDAO clientDAO = new ClientDAO();
        JobDAO jobDAO = new JobDAO();

        private int userId;


        public FClient(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            System.Diagnostics.Debug.WriteLine($"FClient form: userId = {this.userId}");


            dbConnection = new DbConnection();

            materialSkinManager.EnforceBackcolorOnAllComponents = false;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen900,
                                                                Primary.LightGreen700,
                                                                Primary.LightGreen500,
                                                                Accent.LightGreen200,
                                                                TextShade.WHITE);


            List<MaterialCard> materialCards = new List<MaterialCard> { materialCard6, materialCard14, materialCard12, materialCard10, materialCard15, materialCard16, materialCard17, materialCard18 };
            List<PictureBox> pictureBoxes = new List<PictureBox> { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            // Attach a click event handler to each MaterialCard
            foreach (var materialCard in materialCards)
            {
                materialCard.Click += MaterialCard_Click;
            }
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Click += PictureBox_Click;
            }



        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadDataHired();
            LoadDataFavourite();
        }

        //  Log out
        private void materialTabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.materialTabControl1.SelectedIndex == 5) // Assuming the "Log out" tab is at index 5
            {
                this.Hide(); // Hide the current form
                new FLogin().Show(); // Show the Login form
            }
        }

        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (switchTheme.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                switchTheme.Text = "DARK   ";
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                switchTheme.Text = "LIGHT   ";
            }
        }



        private Dictionary<string, string> pictureToCategoryMap = new Dictionary<string, string>
        {
            { "pictureBox2", "Devlopment-IT" },
            { "pictureBox3", "AI-Services" },
            { "pictureBox4", "Design-Creative" },
            { "pictureBox5", "Sales-Marketing" },
            { "pictureBox6", "Engineering-Architecture" },
            { "pictureBox7", "Finance-Accounting" },
            { "pictureBox8", "Admin-Custome-Support" },
            { "pictureBox9", "Writing-Traslation" },
            // Add more if needed
        };


        private Dictionary<string, string> cardToCategoryMap = new Dictionary<string, string>
        {
            { "materialCard6", "Devlopment-IT" },
            { "materialCard14", "AI-Services" },
            { "materialCard12", "Design-Creative" },
            { "materialCard10", "Sales-Marketing" },
            { "materialCard15", "Writing-Traslation" },
            { "materialCard16", "Admin-Custome Support" },
            { "materialCard17", "Finance-Accounting" },
            { "materialCard18", "Engineering-Architecture" },
            // Add more if needed
        };

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Determine which PictureBox was clicked
            PictureBox clickedPictureBox = sender as PictureBox;

            // Create and show the appropriate form based on the clicked PictureBox
            if (clickedPictureBox != null && pictureToCategoryMap.TryGetValue(clickedPictureBox.Name, out string category))
            {
                OpenWokerListForm(category, userId);
            }
        }


        private void MaterialCard_Click(object sender, EventArgs e)
        {
            // Determine which MaterialCard was clicked
            MaterialCard clickedCard = sender as MaterialCard;

            // Fetch the data for the category of the clicked card
            if (clickedCard != null && cardToCategoryMap.TryGetValue(clickedCard.Name, out string category))
            {
                OpenWokerListForm(category, userId);
            }
        }

        private void OpenWokerListForm(string category, int userID)
        {
            FListWorker workerList = new FListWorker(category, userID);
            workerList.Show();
        }

        private string imagePath;
        private string imageJob;

        private string SelectImageFile(PictureBox pictureBox)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = new Bitmap(ofd.FileName);
                    return ofd.FileName;
                }
            }
            return null;
        }

        private void btnImportImage_Click(object sender, EventArgs e)
        {
            imagePath = SelectImageFile(picBoxUser);
        }

        private void btnImportJob_Click(object sender, EventArgs e)
        {
            imageJob = SelectImageFile(pictureBoxJob);
        }



        private string gender;

        private void ckbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFemale.Checked == true)
            {
                ckbMale.Checked = false;
                gender = "Female";
            }
        }

        private void ckbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMale.Checked == true)
            {
                ckbFemale.Checked = false;
                gender = "Male";
            }
        }

        private void AddControlsToPanelHIred(Image image, string label1Text, string label2Text, string email, string phone)
        {
            var pictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(80, 80),
                Location = new Point(10, 10)
            };

            var label1 = new Label
            {
                Text = label1Text,
                AutoSize = true,
                ForeColor = Color.Chocolate,
                Font = new Font("Nirmala UI", 16, FontStyle.Bold),
                Location = new Point(20, 90)
            };

            var label2 = new Label
            {
                Text = label2Text,
                AutoSize = true,
                ForeColor = Color.LightGreen,
                Font = new Font("Nirmala UI", 14, FontStyle.Bold),
                Location = new Point(20, 150),
                TextAlign = ContentAlignment.TopLeft
            };

            var emailLabel = new Label
            {
                Text = "Email: " + email,
                AutoSize = true,
                ForeColor = Color.DarkGray,
                Font = new Font("Nirmala UI", 12, FontStyle.Bold),
                Location = new Point(20, 200),
                TextAlign = ContentAlignment.TopLeft
            };

            var phoneLabel = new Label
            {
                Text = "Phone: " + phone,
                AutoSize = true,
                ForeColor = Color.DarkGray,
                Font = new Font("Nirmala UI", 12, FontStyle.Bold),
                Location = new Point(20, 220),
                TextAlign = ContentAlignment.TopLeft
            };

            var card = new MaterialCard
            {
                Width = 300,
                Height = 290,
                BackColor = Color.White
            };

            card.Controls.Add(label1);
            card.Controls.Add(label2);
            card.Controls.Add(pictureBox);
            card.Controls.Add(emailLabel);
            card.Controls.Add(phoneLabel);

            flowLayoutPanel1.Controls.Add(card);
        }

        private void AddControlsToPanelFavourite(Image image, string FullName, string PhoneNumber, string Address, string Email, string age)
        {
            var pictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(60, 60),
                Location = new Point(10, 10)
            };

            var label1 = new Label
            {
                Text = FullName,
                AutoSize = true,
                ForeColor = Color.Chocolate,
                Font = new Font("Nirmala UI", 14, FontStyle.Bold),
                Location = new Point(80, 10)
            };

            var label2 = new Label
            {
                Text = "phone: " + PhoneNumber,
                AutoSize = true,
                ForeColor = Color.LightGreen,
                Font = new Font("Nirmala UI", 12, FontStyle.Bold),
                Location = new Point(20, 90),
                TextAlign = ContentAlignment.TopLeft
            };

            var label3 = new Label
            {
                Text = "Address: " + Address,
                AutoSize = true,
                ForeColor = Color.LightGreen,
                Font = new Font("Nirmala UI", 12, FontStyle.Bold),
                Location = new Point(20, 120),
                TextAlign = ContentAlignment.TopLeft
            };

            var label4 = new Label
            {
                Text = "email: " + Email,
                AutoSize = true,
                ForeColor = Color.LightGreen,
                Font = new Font("Nirmala UI", 12, FontStyle.Bold),
                Location = new Point(20, 150),
                TextAlign = ContentAlignment.TopLeft
            };

            var label5 = new Label
            {
                Text = "Age " + age,
                AutoSize = true,
                ForeColor = Color.LightGreen,
                Font = new Font("Nirmala UI", 12, FontStyle.Bold),
                Location = new Point(20, 180),
                TextAlign = ContentAlignment.TopLeft
            };

            MaterialButton btnUnLike = new MaterialButton();
            btnUnLike.Text = "Unlike";
            btnUnLike.Location = new Point(20, 220);


            var card = new MaterialCard
            {
                Width = 300,
                Height = 290,
                BackColor = Color.White
            };

            card.Controls.Add(label1);
            card.Controls.Add(label2);
            card.Controls.Add(label3);
            card.Controls.Add(label4);
            card.Controls.Add(label5);
            card.Controls.Add(pictureBox);
            card.Controls.Add(btnUnLike);

            flowLayoutPanel4.Controls.Add(card);
        }

        private void LoadDataHired()
        {
            dbConnection.Open();
            string query = @"
                            SELECT W.Category,
		                            U.Name,
		                            U.ImagePath,
                                    U.Email,
                                    U.PhoneNumber
                            FROM Worker W
                            JOIN HiredWorkers H
	                            ON W.Worker_id = H.Worker_id
                            JOIN Users U
	                            ON U.user_id = W.user_id
                            WHERE H.user_id = @UserId
                        ";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@UserId", userId);
            DataTable dataTable = dbConnection.ExecuteQuery(command);

            foreach (DataRow row in dataTable.Rows)
            {
                // Process the data from the row

                var imagePath = row["ImagePath"] as string;
                var image = !string.IsNullOrEmpty(imagePath) ? Image.FromFile(imagePath) : null;

                string label1Text = row["Name"].ToString();
                string label2Text = row["Category"].ToString();
                string email = row["Email"].ToString();
                string phone = row["PhoneNumber"].ToString();

                AddControlsToPanelHIred(image, label1Text, label2Text, email, phone);
            }
            dbConnection.Close();

        }

        private void LoadDataFavourite()
        {
            dbConnection.Open();
            string query = @"
                            SELECT W.Category,
		                            U.Name,
		                            U.ImagePath,
		                            U.PhoneNumber,
		                            U.Email,
		                            U.DateOfBirth,
		                            U.Address
                            FROM Worker W
                            JOIN Favourite F
	                            ON W.Worker_id = F.Worker_id
                            JOIN Users U
	                            ON U.user_id = W.user_id                     
                            WHERE F.user_id = @UserId
                        ";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@UserId", userId);
            DataTable dataTable = dbConnection.ExecuteQuery(command);

            foreach (DataRow row in dataTable.Rows)
            {
                // Process the data from the row

                var imagePath = row["ImagePath"] as string;
                var image = !string.IsNullOrEmpty(imagePath) ? Image.FromFile(imagePath) : null;

                string label1Text = row["Name"].ToString();
                string label2Text = row["PhoneNumber"].ToString();
                string label3Text = row["Category"].ToString();
                string label4Text = row["Email"].ToString();

                // Calculate age from date of birth
                DateTime dateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
                int age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                    age = age - 1;

                string label5Text = age.ToString();

                AddControlsToPanelFavourite(image, label1Text, label2Text, label3Text, label4Text, label5Text);
            }
            dbConnection.Close();

        }


        private void OpenAppointmentForm()
        {
            // Open the Appointment form
            FAppointment appointmentForm = new FAppointment();
            appointmentForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client(txtName.Text, txtEmail.Text, dtpBirth.Value, imagePath, txtPhoneNumber.Text, txtLocation.Text, gender);
            bool isUpdated = clientDAO.UpdateInformation(client, this.userId);
            if (isUpdated)
            {
                MessageBox.Show("Client information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update client information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSumitJob_Click(object sender, EventArgs e)
        {
            JobInfor jobInfor = new JobInfor(txtTitle.Text, txtDescription.Text, cbxCategory.Text, txtPrice.Text, imageJob);
            bool isUpdated = jobDAO.AddJobList(jobInfor, this.userId);
            if (isUpdated)
            {
                MessageBox.Show("Client information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update client information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }

}
