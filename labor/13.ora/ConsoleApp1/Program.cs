namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //jagged array <==> tömbök tömbje
            int[][] mat = new int[][]
            {
                new int[] {1,2,3},
                new int[] {1,2},
                new int[] {1}

            };

            foreach (int[] innerArray in mat)
            {
                foreach (int num in innerArray)
                {
                    Console.WriteLine(num + " ");
                }
                Console.WriteLine();
            }


            //többdimenzios tömb

            int[,] mat2 = new int[,] {
                { 1, 2 },
                { 3, 4},
                { 5, 6}
            };

            mat2.GetLength(0); // ?
        }
    }
}
