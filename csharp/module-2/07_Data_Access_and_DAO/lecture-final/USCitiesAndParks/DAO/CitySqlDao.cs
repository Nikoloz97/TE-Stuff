using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    // CitySqlDao needs to follow all the methods outlined in ICityDao.cs
    public class CitySqlDao : ICityDao
    {
        private readonly string connectionString;

        public CitySqlDao(string connString) //CitySqlDao instantiated in Program.cs (that's where the connection string comes from)
                                             // Allows us to use SqlConnection now!
        {
            connectionString = connString;
        }

        //method to retrieve city data from the database
        public City GetCity(int cityId) 
        {
            City city = null;

            using (SqlConnection myFavoriteDBConnection = new SqlConnection(connectionString)) //name the database connection
            {
                myFavoriteDBConnection.Open(); //open the connection to the DB

                SqlCommand cmd = new SqlCommand("SELECT city_id, city_name, state_abbreviation, population, area FROM city WHERE city_id = @city_id;", myFavoriteDBConnection); // Create a command
                cmd.Parameters.AddWithValue("@city_id", cityId); //substitute the sql command's string parameter (@city_id) with function's parameter (cityId)

                SqlDataReader reader = cmd.ExecuteReader(); //runs the SQL query against the database


                // For object that takes in one value, use if statement
                // For object that takes in multiple values, use while statement

                if (reader.Read()) //if we can actually read the result set (no errors, data rows exist)
                {
                    city = CreateCityFromReader(reader); //go create a city object from the results 
                }
            }

            return city; //return the city object
        }

        public IList<City> GetCitiesByState(string stateAbbreviation)
        {
            IList<City> cities = new List<City>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT city_id, city_name, state_abbreviation, population, area FROM city WHERE state_abbreviation = @state_abbreviation;", conn);
                cmd.Parameters.AddWithValue("@state_abbreviation", stateAbbreviation);


                // For get functions, you create a reader
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    // Create a city object
                    // Create a CreateCityFromReader function (assigns each column to the object's corresponding property)
                    City city = CreateCityFromReader(reader);

                    // Add city object to cities list object you created earlier
                    cities.Add(city);
                }
            }

            return cities; // return the list of cities 
        }



     









        public City CreateCity(City city)
        {
            // We're creating a new city, and if we do, we'll return the city object (using the Get function we created before)
            // Thats why its useful to create get functions first in the DAO 

            int newCityId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO city (city_name, state_abbreviation, population, area) " +
                                                "OUTPUT INSERTED.city_id " +
                                                "VALUES (@city_name, @state_abbreviation, @population, @area);", conn);

                cmd.Parameters.AddWithValue("@city_name", city.CityName);
                cmd.Parameters.AddWithValue("@state_abbreviation", city.StateAbbreviation);
                cmd.Parameters.AddWithValue("@population", city.Population);
                cmd.Parameters.AddWithValue("@area", city.Area);


                // Scalar = return is a single value - our OUTPUT statement (number OR character - string as well maybe??) 
                newCityId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            //Already uses a SQLreader so we don't need to use it
            return GetCity(newCityId);
        }





        // not returning anything, so it's void
        public void UpdateCity(City city)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE city SET city_name = @city_name, state_abbreviation = @state_abbreviation, population = @population, area = @area WHERE city_id = @city_id;", conn);
                cmd.Parameters.AddWithValue("@city_name", city.CityName);
                cmd.Parameters.AddWithValue("@state_abbreviation", city.StateAbbreviation);
                cmd.Parameters.AddWithValue("@population", city.Population);
                cmd.Parameters.AddWithValue("@area", city.Area);
                cmd.Parameters.AddWithValue("@city_id", city.CityId);

                cmd.ExecuteNonQuery(); //returns # of rows changed, but we're not doing anything with that information here 
            }
        }

        public void DeleteCity(int cityId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM city WHERE city_id = @city_id;", conn);
                cmd.Parameters.AddWithValue("@city_id", cityId);

                cmd.ExecuteNonQuery();
            }
        }


        // Used for get statements - assigns each property of the city object to its corresponding SQL column
        private City CreateCityFromReader(SqlDataReader reader)
        {
            // create a city object
            City city = new City();



            city.CityId = Convert.ToInt32(reader["city_id"]);
            city.CityName = Convert.ToString(reader["city_name"]);
            city.StateAbbreviation = Convert.ToString(reader["state_abbreviation"]);
            city.Population = Convert.ToInt32(reader["population"]);
            city.Area = Convert.ToDecimal(reader["area"]);


            // return the whole city object
            return city;
        }







    }
}
