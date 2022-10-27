using HotelApp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HotelApp.Services
{
    public class HotelApiService
    {
        protected static RestClient client = null;

        public HotelApiService(string apiUrl)
        {
            if (client == null)
            {
                client = new RestClient(apiUrl);
            }
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest("hotels");
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Something went wrong from the server!");
            }

            return response.Data;

        }

        public List<Review> GetReviews()
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotel(int hotelId)
        {
            RestRequest request = new RestRequest($"hotels/{hotelId}");
            IRestResponse<Hotel> response = client.Get<Hotel>(request);
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Something went wrong from the server!");
            }

            return response.Data;


        }

        public List<Review> GetHotelReviews(int hotelId)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetHotelsWithRating(int starRating)
        {
            throw new NotImplementedException();
        }

        public City GetPublicAPIQuery()
        {
            throw new NotImplementedException();
        }
    }
}
