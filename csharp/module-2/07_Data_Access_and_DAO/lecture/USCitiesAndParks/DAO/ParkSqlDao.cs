using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public class ParkSqlDao : IParkDao
    {
        private readonly string connectionString;

        public ParkSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Park GetPark(int parkId)
        {
            throw new NotImplementedException();
        }

        public IList<Park> GetParksByState(string stateAbbreviation)
        {
            IList<Park> ParksList = new List<Park>();

            using (SqlConnection parkconn = new SqlConnection(connectionString))
            {
                parkconn.Open();
                SqlCommand cmd = new SqlCommand("Select * from park join park_state on park_state.park_id = park.park_id where state_abbreviation = @stateAbbreviation;", parkconn);
                cmd.Parameters.AddWithValue("@stateAbbreviation", stateAbbreviation);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ParksList = CreateParkFromReader(reader); 
                }

            }
            return ParksList;

        }

        public Park CreatePark(Park park)
        {
            throw new NotImplementedException();
        }

        public void UpdatePark(Park park)
        {
            throw new NotImplementedException();
        }

        public void DeletePark(int parkId)
        {
            throw new NotImplementedException();
        }

        public void AddParkToState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        public void RemoveParkFromState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        private Park CreateParkFromReader(SqlDataReader reader)
        {
            Park park = new Park();
            park.ParkId = Convert.ToInt32(reader["park_id"]);
            park.ParkName = Convert.ToString(reader["park_name"]);
            park.DateEstablished = Convert.ToDateTime(reader["date_established"]);
            park.Area = Convert.ToDecimal(reader["Area"]);
            park.HasCamping = Convert.ToBoolean(reader["HasCamping"]);

            return park;
        }


    }
}
