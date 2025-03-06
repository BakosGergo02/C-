namespace Egyebek
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Random random = new Random();
            Console.WriteLine($"Random 32 bites szám: {random.Next()}");

            Console.WriteLine($"Random szám a [0 , 100) intervallumból: {random.Next(100 + 1)}");
            Console.WriteLine($"Random szám a [50 , 100) intervallumból: {random.Next(50,100 + 1)}");

            Console.WriteLine($"Random szám a [0.0, 1.0) intervallumból: {random.NextDouble()}");


            Console.WriteLine(string.Format("Név {0}, Életkor: {1}", "Bob", 43));

            Console.WriteLine($"Név: {"Bob"}, életkor: {43}");
            //N -> Number
            Console.WriteLine("Osztás eredeménye: {0:N2}", 1.0/3.0);
            Console.WriteLine("Osztás eredeménye: {1.0 / 3.0:N2}");
            //P -> percent

            Console.WriteLine($"Osztás eredménye: {0.1:P2}");
            //C -> Currency
            Console.WriteLine($"Osztás eredménye: {50:C2}");


            Console.WriteLine( string.Join(", ", args) );
            Console.WriteLine(args[1].Equals("43"));

            List<int> list = new List<int>() { 1,2,3,4,5,6};

            List<int> list2 = new() { 1, 2, 3, 4, 5, 6 };
            var list3 = new List<int>() { 1, 2,3, 4, 5,6 };
            List<int> l = [1, 2, 3, 4, 5];

            l.ForEach(x => Console.WriteLine(x));
        }
    }
}
