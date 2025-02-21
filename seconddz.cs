namespace _16_11
{
    class Task2
    {
        public void Execute()
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                arr[i, j] = rand.Next(-100, 101);

            Console.WriteLine("Generated 5x5 Matrix:");
            foreach (var row in arr)
                Console.Write(row + " ");
            Console.WriteLine();

            int min = arr.Cast<int>().Min();
            int max = arr.Cast<int>().Max();
            int sum = 0;
            bool counting = false;

            foreach (var num in arr.Cast<int>())
            {
                if (num == min || num == max)
                {
                    if (counting) break;
                    counting = true;
                    continue;
                }

                if (counting) sum += num;
            }

            Console.WriteLine($"Sum of elements between min ({min}) and max ({max}): {sum}");
        }
    }
}