﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimViec
{
    public partial class FAppointment : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        AppointmentDAO appointmentDAO = new AppointmentDAO();
        private int userId;
        private int workerId;

        public FAppointment(int userId, int workerId)
        {
            this.userId = userId;
            this.workerId = workerId;
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

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment(dtpAppoinment.Value, txtContent.Text);
            bool isUpdated = appointmentDAO.AddAppointment(appointment, this.userId, this.workerId);
            if (isUpdated)
            {
                MessageBox.Show("Your appointment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update your appointment information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
