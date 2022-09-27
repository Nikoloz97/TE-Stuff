using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction
    {

        public BuyoutAuction(int buyoutPrice) : base()
        {

            
            //Buyout price - backing field 
            _buyoutPrice = buyoutPrice;
        }

        private int _buyoutPrice;

        // Readonly get;
        public int BuyoutPrice
        {
            get
            {
                return _buyoutPrice;
            }
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool newHighBid = base.PlaceBid(offeredBid);
            if (newHighBid && offeredBid.BidAmount >= BuyoutPrice)
            {
                Console.WriteLine("Buyout met by" + offeredBid.Bidder);
                base.EndAuction();
            }
            return newHighBid;
        }

    }
}
