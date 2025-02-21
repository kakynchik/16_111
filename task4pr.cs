namespace _16_11
{
    class Task4Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter first array:");
            int[] array1 = Console.ReadLine()?.Split().Select(int.Parse).ToArray() ?? new int[0];

            Console.WriteLine("Enter second array:");
            int[] array2 = Console.ReadLine()?.Split().Select(int.Parse).ToArray() ?? new int[0];

            int[] common = array1.Intersect(array2).Distinct().ToArray();

            Console.WriteLine("Common unique elements: " + string.Join(" ", common));
        }
    }
}