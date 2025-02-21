class Task1
{
    public void Execute()
    {
        int[] A = new int[5];
        double[,] B = new double[3, 4];
        Random rand = new Random();
        
        Console.WriteLine("Enter 5 elements for array A:");
        for (int i = 0; i < 5; i++)
            A[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        for (int j = 0; j < 4; j++)
            B[i, j] = rand.NextDouble() * 100;
        
        Console.WriteLine("Array A: " + string.Join(" ", A));
        Console.WriteLine("Matrix B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write(B[i, j].ToString("F2") + " ");
            Console.WriteLine();
        }
    }
}