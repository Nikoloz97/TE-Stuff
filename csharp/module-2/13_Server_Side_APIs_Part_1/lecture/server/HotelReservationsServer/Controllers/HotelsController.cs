using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    [Route("hotels")] // left = shortcut path for: "localhost: 44322/hotels" (with ISS express)...
                      // ...or if starting manually  "localhost:5001/hotels" (w/out ISS express)
    // alternative: Route([controller])
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao hotelDao;

        public HotelsController() // our constructor
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
        }

        [HttpGet()]
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("{id}")] // gets us: hotels/:{id}
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound();
            }
        }


    }
}
