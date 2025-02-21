namespace _16_11
{
    class Task1
    {
        public void Execute()
        {
            int[] a = new int[5];
            double[,] b = new double[3, 4];
            Random rand = new Random();

            Console.WriteLine("Enter 5 elements for array A:");
            for (int i = 0; i < 5; i++)
                if (!int.TryParse(Console.ReadLine(), out a[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--;
                }

            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                b[i, j] = rand.NextDouble() * 100;

            Console.WriteLine("Array A: " + string.Join(" ", a));
            Console.WriteLine("Matrix B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(b[i, j].ToString("F2") + " ");
                Console.WriteLine();
            }
        }
    }
}