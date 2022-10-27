using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet()]
        public List<Auction> ListAuctions(string title_like = "", double currentBid_lte = 0.00)
        {
            if ((dao.SearchByTitle(title_like) != null) && currentBid_lte != 0.00)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }

            if (dao.SearchByTitle(title_like) != null && currentBid_lte == 0.00)
            {
                return dao.SearchByTitle(title_like);
            }

            if (dao.SearchByTitle(title_like) == null && currentBid_lte != 0.00)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else
            {
         
                return dao.List();
            }
            

        }


        [HttpGet("{id}")]
        public ActionResult<Auction> GetAuctionByID(int id)
        {
            Auction auction = dao.Get(id);

            return auction;
        }

        [HttpPost()]
        public ActionResult<Auction> CreateAuction(Auction newAuctionName)
        {
            Auction addedAuction = dao.Create(newAuctionName);


            if (addedAuction != null)
            {
                return Created($"/auctions/{addedAuction.Id}", addedAuction);
            }
            else
            {
                return Problem("Can't create this auction");
            }
        }

        






    }
    
}
