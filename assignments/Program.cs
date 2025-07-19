using System;

class Program
{
<<<<<<< HEAD
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
    }
}
=======
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
>>>>>>> 6b62e1300a0a8916efc06ea1d373515d434757e1
