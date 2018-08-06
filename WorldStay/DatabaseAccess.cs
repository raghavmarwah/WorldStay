using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStay
{
    class DatabaseAccess
    {
        private SqlConnection dbConnection = null;

        /// <summary>
        /// Open a connection to the WorldStay Database.
        /// Uses a private SqlConnection object.
        /// </summary>
        public void OpenConnection()
        {
            dbConnection = new SqlConnection()
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WorldStayDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True"
            };
            dbConnection.Open();
        }

        /// <summary>
        /// Close the SqlConnection
        /// </summary>
        public void CloseConnection()
        {
            dbConnection.Close();
        }

        /// <summary>
        /// Inserts a new country to the database
        /// </summary>
        /// <param name="c">Country Object</param>
        public void InsertCountry(Country c)
        {
            string sql = "Insert Into Countries (CountryName) Values " +
                $"('{c.CountryName}')";

            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Inserts a new hotel to the database
        /// </summary>
        /// <param name="h">Hotel Object</param>
        public void InsertHotel(Hotel h)
        {
            string sql = "Insert Into Hotels (HotelName, CountryId) Values " +
                $"('{h.HotelName}', '{h.CountryId}')";

            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Inserts a new suite to the database
        /// </summary>
        /// <param name="s">Suite Object</param>
        public void InsertSuite(Suite s)
        {
            string sql = "Insert Into Suites (RoomNumber, Floor, RoomType, NumberOfBedrooms, NumberOfBathrooms, NightlyRate, IsAvailable, ThumbnailURL, HotelId) Values " +
                $"('{s.RoomNumber}', '{s.Floor}', '{s.RoomType}', '{s.NumberOfBedrooms}', '{s.NumberOfBathrooms}', '{s.NightlyRate}', '{s.IsAvailable}', '{s.ThumbnailURL}', '{s.HotelId}')";

            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Truncate a table, but this does not reseed identity
        /// </summary>
        /// <param name="table"></param>

        public void TruncateData(string table)
        {
            string sql = "TRUNCATE TABLE " + table;

            // Execute using our connection.
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
