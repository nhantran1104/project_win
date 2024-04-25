using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec
{
    internal class RatingsDAO
    {
        DbConnection connection = new DbConnection();

        public bool AddReview(Ratings ratings, int workerId, int userId)
        {
            string sqlStr = "INSERT INTO Ratings(user_id, Comment) VALUES(@UserId, @Comment)";

            using (SqlCommand command = new SqlCommand(sqlStr, connection.Connection))
            {
                command.Parameters.AddWithValue("@Comment", ratings.Commment);
                command.Parameters.AddWithValue("@WorkerId", workerId);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
                return rowsAffected > 0;
            }
        }

        public bool AddRate(Ratings ratings, int workerId, int userId)
        {
            string sqlStr = "INSERT INTO Ratings(Worker_id, user_id, Stars) VALUES(@WorkerId, @UserId, @Stars)";

            using (SqlCommand command = new SqlCommand(sqlStr, connection.Connection))
            {
                command.Parameters.AddWithValue("@Stars", ratings.Stars);
                command.Parameters.AddWithValue("@WorkerId", workerId);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
                return rowsAffected > 0;
            }
        }
    }
}
