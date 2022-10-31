namespace USCitiesAndParks.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string StateAbbreviation { get; set; }
        public int Population { get; set; }
        public decimal Area { get; set; }


        // For the string types, throw them into a "ToString" method - which just returns a concatenation of the string type properties
        // You also need to finish off the concatentaion with the key value too (here, cityID)
        // Used for the reader method (See very last method in CitySqlDao)
        public override string ToString()
        {
            return $"{CityName}, {StateAbbreviation}, (ID: {CityId})";
        }
    }
}
