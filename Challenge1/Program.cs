namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            List<int> myList = new List<int>();
            Console.WriteLine("Please Enter Any Value ... ");
            myList.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"myList Count = {myList.Count}");
            Console.WriteLine($"myList Capacity = {myList.Capacity}");

            Console.WriteLine("Please Enter Any Value ... ");
            myList.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"myList Count = {myList.Count}");
            Console.WriteLine($"myList Capacity = {myList.Capacity}");


            Console.WriteLine("Please Enter Any Value ... ");
            myList.Append(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"myList Count = {myList.Count}");
            Console.WriteLine($"myList Capacity = {myList.Capacity}");


        }
    }
}
