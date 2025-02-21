namespace _16_11
{
    class Task3Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter array elements separated by space:");
            int[] array = Console.ReadLine()?.Split().Select(int.Parse).ToArray() ?? new int[0];

            Console.WriteLine("Enter three numbers:");
            int[] sequence = Console.ReadLine()?.Split().Select(int.Parse).ToArray() ?? new int[0];

            if (sequence.Length != 3)
            {
                Console.WriteLine("You must enter exactly three numbers.");
                return;
            }

            int count = 0;
            for (int i = 0; i <= array.Length - 3; i++)
            {
                if (array[i] == sequence[0] && array[i + 1] == sequence[1] && array[i + 2] == sequence[2])
                    count++;
            }

            Console.WriteLine($"Sequence found {count} times.");
        }
    }
}