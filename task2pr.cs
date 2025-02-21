namespace _16_11
{
    class Task2Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter array elements separated by space:");
            int[] array = Console.ReadLine()?.Split().Select(int.Parse).ToArray() ?? new int[0];

            Console.WriteLine("Enter threshold value:");
            int threshold = int.Parse(Console.ReadLine() ?? "0");

            int count = array.Count(x => x < threshold);
            Console.WriteLine($"Count of elements less than {threshold}: {count}");
        }
    }
}