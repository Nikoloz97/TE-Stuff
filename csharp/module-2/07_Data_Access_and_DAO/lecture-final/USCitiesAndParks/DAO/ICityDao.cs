using System.Collections.Generic;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public interface ICityDao
    {
        City GetCity(int cityId);  //Return a city by its ID

        IList<City> GetCitiesByState(string stateAbbreviation); //Return a list of cities given a state abbreviation

        City CreateCity(City city); //Creates a city given a city (return = a city of type city) 

        void UpdateCity(City city); //Updates a city given a city (return = void)

        void DeleteCity(int cityId); //Deletes a city given a city ID (return = void)
    }
}
