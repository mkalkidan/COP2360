public class Stock
{
    decimal currentPrice;           // The private "backing" field
    public decimal CurrentPrice     // The public property
    {
        get { return currentPrice; } 
        set { currentPrice = value; }
    }

    decimal sharesOwned;           
    public decimal SharesOwned     
    {
        get { return sharesOwned; } 
        set { sharesOwned = value; }
    }

    public decimal Worth
    {
        get { return currentPrice * sharesOwned; }
    }
}
