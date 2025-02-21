namespace _16_11
{
    class Task5
    {
        public void Execute()
        {
            Console.Write("Enter an arithmetic expression (only + and -): ");
            string expression = Console.ReadLine() ?? string.Empty;
            int result = ArithmeticExpression.Evaluate(expression);
            Console.WriteLine($"Result of expression: {result}");
        }
    }

    class ArithmeticExpression
    {
        public static int Evaluate(string expression)
        {
            string[] tokens = expression.Split(new[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int result = int.Parse(tokens[0]);

            for (int i = 1; i < tokens.Length; i++)
            {
                if (expression[i - 1] == '+')
                    result += int.Parse(tokens[i]);
                else if (expression[i - 1] == '-')
                    result -= int.Parse(tokens[i]);
            }

            return result;
        }
    }
}