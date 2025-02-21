namespace _16_11
{
    class Task1Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter array elements separated by space:");
            int[] array = Console.ReadLine()?.Split().Select(int.Parse).ToArray() ?? new int[0];

            int evenCount = array.Count(x => x % 2 == 0);
            int oddCount = array.Count(x => x % 2 != 0);
            int uniqueCount = array.Distinct().Count();

            Console.WriteLine($"Even: {evenCount}, Odd: {oddCount}, Unique: {uniqueCount}");
        }
    }
}