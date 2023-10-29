namespace Task2
{
    public class Math
    {
        public static double Add(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"Результат: {result}");
            return result;
        }
        public static double Subtract(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"Результат: {result}");
            return result;
        }
        public static double Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"Результат: {result}");
            return result;
        }
        public static double Divide(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"Результат: {result}");
            return result;
        }
    }
}
