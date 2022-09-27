using System;
using System.Collections.Generic;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a general auction.
    /// </summary>
    public class Auction
    {
        public Auction()
        {
            Console.WriteLine("Creating Auction...");
        }
        /// <summary>
        /// This is an encapsulated field that holds all placed bids.
        /// </summary>
        private List<Bid> allBids = new List<Bid>();

        /// <summary>
        /// Represents the current high bid.
        /// </summary>
        public Bid CurrentHighBid { get; private set; } = new Bid("", 0);

        /// <summary>
        /// All placed bids returned as an array.
        /// </summary>
        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }

        /// <summary>
        /// Indicates if the auction has ended yet.
        /// </summary>
        public bool HasEnded { get; private set; }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid">The bid to place.</param>
        /// <returns>True if the new bid is the current winning bid</returns>
        public virtual bool PlaceBid(Bid offeredBid)
        {
            bool newHighBid = false;
            // Print out the bid details.
            Console.WriteLine(offeredBid.Bidder + " bid " + offeredBid.BidAmount.ToString("C"));

            // Record it as a bid by adding it to allBids

            if (!HasEnded)
            {
                allBids.Add(offeredBid);

                // Check to see IF the offered bid is higher than the current bid amount
                // if yes, set offered bid as the current high bid

                if (offeredBid.BidAmount > CurrentHighBid.BidAmount)
                {
                    CurrentHighBid = offeredBid;
                    newHighBid = true;
                }
            }
            else
            {
                Console.WriteLine("Bid not accepted - Auction has ended.");
            }
            // Output the current high bid

            Console.WriteLine($"Current highest bid {CurrentHighBid.BidAmount.ToString("C")} by {CurrentHighBid.Bidder}");

            // Return if this is the new highest bid
            return newHighBid;

            }

        
    // End the auction + announce winner
    // TODO - Stop accepting bids once auction ended

        public void EndAuction()
        {
            HasEnded = true;
            Console.WriteLine($"Auction has finished {CurrentHighBid.Bidder} has won with a bid of {CurrentHighBid.BidAmount.ToString("C")}");
           
        }

    }



}
