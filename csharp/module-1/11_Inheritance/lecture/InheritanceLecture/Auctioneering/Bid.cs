namespace InheritanceLecture.Auctioneering
{
    public class Bid
    {
        public string Bidder { get; }

        
        public int BidAmount { get; }
        
        public Bid(string bidder, int bidAmount)
        {
            this.Bidder = bidder;
            this.BidAmount = bidAmount;
        }
    }
}
