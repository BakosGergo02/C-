namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Dictionary<string, int>  dict = new Dictionary<string, int>();
            
            var dict2 = new Dictionary<string, int>();
            Dictionary<string, int> dict3 = new();

            dict2.Add("a", 1);
            dict2.Add("b", 2);
            dict2["c"] = 5;
            dict2["d"] = 6;

            Dictionary<string, int> dict4 = new Dictionary<string, int>
            {
                { "a", 5 },
                { "b", 6 }
            };

            Dictionary<string, int> dict6 = new()
            {
                ["c"] = 5,
                ["d"] = 7,
            };

            Console.WriteLine(dict6["c"]);

            // kivetelt dob, ha kulcs mér létezik a dic-ben
            // dict.add("c",3 );

            dict6.TryAdd("a", 1);
        }
    }
}
