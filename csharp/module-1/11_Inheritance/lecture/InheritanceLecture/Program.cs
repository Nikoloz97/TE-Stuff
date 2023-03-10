using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction();

            generalAuction.PlaceBid(new Bid("Josh", 1));
            generalAuction.PlaceBid(new Bid("Fonz", 23));
            generalAuction.PlaceBid(new Bid("Rick Astley", 13));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids

           /* generalAuction.PlaceBid(new Bid("David", 25));
            generalAuction.PlaceBid(new Bid("Ben", 50));*/


            BuyoutAuction buyoutAuction = new BuyoutAuction(1000);
            buyoutAuction.PlaceBid(new Bid("David", 5));
            buyoutAuction.PlaceBid(new Bid("Taylor", 1000));
            Console.WriteLine(buyoutAuction.CurrentHighBid.Bidder);


            ReserveAuction reserveAuction = new ReserveAuction(200);
            reserveAuction.PlaceBid(new Bid("David", 150));
            reserveAuction.PlaceBid(new Bid("Kate", 200));
            reserveAuction.PlaceBid(new Bid("David", 700));


            Console.ReadLine();
        }
    }
}
