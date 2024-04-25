using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TimViec
{
    public partial class FReview : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        RatingsDAO ratingDAO = new RatingsDAO();

        private DbConnection dbConnection;
        private int userId;
        private int workerId;

        public FReview()
        {
            this.userId = userId;
            dbConnection = new DbConnection();
            this.workerId = GetWorkerIdFromUserId(userId);
            InitializeComponent();
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen900,
                                                                Primary.LightGreen700,
                                                                Primary.LightGreen500,
                                                                Accent.LightGreen200,
                                                                TextShade.WHITE);
        }

        private void Review_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            Ratings ratings = new Ratings(txtReview.Text, Convert.ToInt32(cbxRate.Text));
            bool isUpdated = ratingDAO.AddReview(ratings, this.workerId, this.userId);
            if (isUpdated)
            {
                MessageBox.Show("Your review updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update your review information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmitRate_Click(object sender, EventArgs e)
        {
            Ratings ratings = new Ratings(txtReview.Text, Convert.ToInt32(cbxRate.Text));
            bool isUpdated = ratingDAO.AddRate(ratings, this.workerId, this.userId);
            if (isUpdated)
            {
                MessageBox.Show("Your review updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update your review information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GetWorkerIdFromUserId(int userId)
        {
            int workerId = -1; // Initialize to -1 to represent not found

            // Open the database connection
            dbConnection.Open();

            // Create the SQL command to get the worker_id
            string query = @"
                        SELECT W.Worker_id
                        FROM Users U
                        JOIN Worker W
                        ON U.user_id = W.user_id
                        WHERE U.user_id = @UserId
                    ";

            SqlCommand command = new SqlCommand(query, dbConnection.Connection);

            // Add the user_id parameter to the command
            command.Parameters.AddWithValue("@UserId", userId);

            // Execute the command and get the result
            object result = command.ExecuteScalar();

            // If a result was returned, set the workerId
            if (result != null)
            {
                workerId = (int)result;
            }

            // Close the database connection
            dbConnection.Close();

            return workerId;
        }

    }
}
