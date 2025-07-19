using System;

class Program
{
    static void Main()
    {
        Stock myStock = new Stock();             // Create an object
        myStock.CurrentPrice = 20.5m;            // Set price
        myStock.SharesOwned = 10;                // Set shares

        Console.WriteLine("Current Price: " + myStock.CurrentPrice);
        Console.WriteLine("Shares Owned: " + myStock.SharesOwned);
        Console.WriteLine("Total Worth: " + myStock.Worth);
    }
}
