using HotelReservations.DAO;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelReservations.Controllers
{
    [Route("reservations")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private static IReservationDao reservationDao;
        private static IHotelDao hotelDao;
        public ReservationsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
            if (reservationDao == null)
            {
                reservationDao = new ReservationMemoryDao();
            }
        }
            // getting all reservations
            [HttpGet()]
            public List<Reservation> GetAllReservations()
            {
                return reservationDao.List();
            }


            // getting reservation by reservation id
            [HttpGet("{id}")]
            public ActionResult<Reservation> GetReservationbyId(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            if(reservation != null)
            {
                return reservation;
            }
            else
            {
                return NotFound();
            }
        }

       
        // getting reservation list by hotel id

        [HttpGet("/hotels/{hotelId}/reservations")]
        public ActionResult<List<Reservation>> GetReservationbyHotel(int hotelId)
        {
            Hotel hotel = hotelDao.Get(hotelId);

            if (hotel != null)
            {
                return reservationDao.FindByHotel(hotelId);
            }
            else
            {
                return NotFound();
            }
        }


        // creating a reservation
        [HttpPost()]
        public ActionResult<Reservation> AddReservation(Reservation newReservation)
        {
            Reservation AddedReservation = reservationDao.Create(newReservation);

            if (AddedReservation != null)
            {
                return Created($"/reservations/{AddedReservation.Id}", AddedReservation);
            }
            else
            {
                return Problem("Can't create this reservation");
            }

        }

        //update reservation

        [HttpPut("{id}")]
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            Reservation existingReservation = reservationDao.Get(id);
            if (existingReservation != null)
            {
                Reservation updatedReservation = reservationDao.Update(id, reservation);

                return updatedReservation;
            }
            else
            {
                return NotFound();


            }
        }





            //delete reservation

            [HttpDelete("{id}")]
            public ActionResult DeleteReservation(int id)
            {
                Reservation existingReservation = reservationDao.Get(id);
                if (existingReservation != null)
                {
                    bool result = reservationDao.Delete(id);

                    if (result)
                    {
                    return NoContent();
                }
                    else
                    {
                    return StatusCode(500);
                    }
                    }
                else
                {
                    return NotFound();

                }
            }

}


}
