namespace _16_11
{
    class Task5Pr
    {
        public void Execute()
        {
            Random rand = new Random();
            int[,] matrix = new int[3, 4];

            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                matrix[i, j] = rand.Next(1, 100);

            int min = matrix.Cast<int>().Min();
            int max = matrix.Cast<int>().Max();

            Console.WriteLine($"Min: {min}, Max: {max}");
        }
    }
}