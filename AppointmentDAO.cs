using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec
{
    internal class AppointmentDAO
    {
        DbConnection connection = new DbConnection();

        public bool AddAppointment(Appointment appointment, int userId, int workerId)
        {
            string sqlStr = "INSERT INTO Appointment(Worker_id, user_id, Date, Content, Status) VALUES(@WorkerId, @UserId, @Date, @Content, @Status)";

            using(SqlCommand command = new SqlCommand(sqlStr, connection.Connection))
            {
                command.Parameters.AddWithValue("userId", userId);
                command.Parameters.AddWithValue("WorkerId", workerId);
                command.Parameters.AddWithValue("Date", appointment.DateTime);
                command.Parameters.AddWithValue("Content", appointment.Content);
                command.Parameters.AddWithValue("Status", appointment.Status);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
                return rowsAffected > 0;
            }
        }
    }
}
