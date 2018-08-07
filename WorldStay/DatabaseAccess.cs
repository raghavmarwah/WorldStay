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
        /// Inserts a new user to the database
        /// </summary>
        /// <param name="u">User Object</param>
        public void InsertUser(User u)
        {
            string sql = "Insert Into Users (UserName, Password, LoyaltyPoints) Values " +
                $"('{u.UserName}', '{u.Password}', '{u.LoyaltyPoints}')";

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
        /// Inserts a new favourite to the database
        /// </summary>
        /// <param name="f">Favourite Object</param>
        public void AddToFavourites(Favourite f)
        {
            /*if (CheckInFavourites(f))
                return;*/

            string sql = "Insert Into Favourites (UserId, SuiteId) Values " +
                $"('{f.UserId}', '{f.SuiteId}')";

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
        /// Removes the given favourite from the database
        /// </summary>
        /// <param name="f">Favourite Object</param>
        public void RemoveFromFavourites(Favourite f)
        {
            string sql = "Delete from Favourites where " +
                $"Favourites.UserId = {f.UserId} and Favourites.SuiteId = {f.SuiteId}";

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
        /// Checks existence of a favourite in the db.
        /// </summary>
        /// <param name="f">Favourite Object</param>
        /// <returns>Boolean</returns>
        public bool CheckInFavourites(Favourite f)
        {
            bool existsInFavourites = false;

            string sql = "Select * From Favourites where " +
                $"Favourites.UserId = {f.UserId} and Favourites.SuiteId = {f.SuiteId}";

            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                        existsInFavourites = true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return existsInFavourites;
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

        /// <summary>
        /// Using SQL Select, return a List of all suites in the database
        /// </summary>
        /// <returns>List of suites</returns>
        public List<DisplayData> GetSuites(int suiteId)
        {
            List<DisplayData> dataList = new List<DisplayData>();
            String sql = "";

            if(suiteId==0)
                sql = "Select * From Suites "+
                             "join Hotels on Suites.HotelId = Hotels.HotelId "+
                             "join Countries on Hotels.CountryId = Countries.CountryId";
            else
                sql = "Select * From Suites " +
                             "join Hotels on Suites.HotelId = Hotels.HotelId " +
                             "join Countries on Hotels.CountryId = Countries.CountryId "+
                             "where Suites.SuiteId = "+suiteId;

            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dataList.Add(new DisplayData
                    {
                        SuiteId = (int)dataReader["SuiteId"],
                        HotelName = (String)dataReader["HotelName"],
                        RoomType = (String)dataReader["RoomType"],
                        RoomNumber = (String)dataReader["RoomNumber"],
                        NumBedrooms = (int)dataReader["NumberOfBedrooms"],
                        NumBathrooms = (int)dataReader["NumberOfBathrooms"],
                        NightlyRate = (int)dataReader["NightlyRate"],
                        Country = (String)dataReader["CountryName"],
                        ThumbnailURL = (String)dataReader["ThumbnailURL"]

                    });
                }
                dataReader.Close();
            }
            return dataList;
        }

        /// <summary>
        /// Using SQL Select, return a List of all room types in the database
        /// </summary>
        /// <returns>List of room types</returns>
        public List<String> GetRoomTypes()
        {
            List<String> dataList = new List<String>();
            string sql = "Select Distinct RoomType from Suites ";
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dataList.Add((String)dataReader["RoomType"]);
                }
                dataReader.Close();
            }
            return dataList;
        }

        /// <summary>
        /// Using SQL Select, return a List of all users in the database
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetUsers()
        {
            List<User> dataList = new List<User>();
            string sql = "Select * from Users";
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dataList.Add(new User {
                        UserId = (int)dataReader["UserId"],
                        UserName = (String)dataReader["UserName"],
                        Password = (String)dataReader["Password"],
                        LoyaltyPoints = (int)dataReader["LoyaltyPoints"]
                    });
                }
                dataReader.Close();
            }
            return dataList;
        }

        /// <summary>
        /// Using SQL Select, return a List of number of bedrooms in the database
        /// </summary>
        /// <returns>List of number of bedrooms</returns>
        public List<int> GetNumberOfBedrooms()
        {
            List<int> dataList = new List<int>();
            string sql = "Select Distinct NumberofBedrooms from Suites ";
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dataList.Add((int)dataReader["NumberOfBedrooms"]);
                }
                dataReader.Close();
            }
            return dataList;
        }

        /// <summary>
        /// Using SQL Select, return a List of number of bathrooms in the database
        /// </summary>
        /// <returns>List of number of bathrooms</returns>
        public List<int> GetNumberOfBathrooms()
        {
            List<int> dataList = new List<int>();
            string sql = "Select Distinct NumberofBathrooms from Suites ";
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dataList.Add((int)dataReader["NumberOfBathrooms"]);
                }
                dataReader.Close();
            }
            return dataList;
        }
    }
}
