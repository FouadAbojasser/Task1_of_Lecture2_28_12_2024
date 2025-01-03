namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double smallCarpetPrice = 25;
            Double largeCarpetPrice = 35;
            Double tax = (6);

            DateTime offerStartingDate = new DateTime(2025, 1, 1);
            DateTime offerEndDate = offerStartingDate.AddDays(30);

            Console.WriteLine("=== Welcome to Islam Carpet Cleaner ===");
            Console.WriteLine("============================================");
            Console.WriteLine($"Price for cleaning small carpet = {smallCarpetPrice}$ ");
            Console.WriteLine($"Price for cleaning large carpet = {largeCarpetPrice}$ ");
            Console.WriteLine($"Added Taxes = {tax}% ");
            Console.WriteLine("============================================");

            Console.Write("Please enter number of small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter number of large carpets: ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("============================================");
            Console.WriteLine($"Cost for cleaning your small carpet(s) = {smallCarpets * smallCarpetPrice}$ ");
            Console.WriteLine($"Cost for cleaning your large carpet(s) = {largeCarpets * largeCarpetPrice}$ ");
            Double totalCost = (smallCarpets * smallCarpetPrice) + (largeCarpets* largeCarpetPrice);
            Console.WriteLine("----------");
            Console.WriteLine($"Cleaning cost = {totalCost}$");
            Console.WriteLine("----------");
            Console.WriteLine($"Taxes = {(totalCost * tax)/100}$");
            Console.WriteLine("----------");
            Console.WriteLine($"Total order Cost = {totalCost + ((totalCost * tax) / 100)}$");
            Console.WriteLine("============================================");
            Console.WriteLine($"The offer is valid for {(offerEndDate - DateTime.Now).Days} more days.");
            Console.WriteLine("============================================");





        }
    }
}
