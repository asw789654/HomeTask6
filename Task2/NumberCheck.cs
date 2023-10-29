namespace Task2
{
    public class NumberCheck
    {
        public static double AskForNumber(string numberName)
        {
            double number;
            while (true)
            {
                var input = Console.ReadLine();
                if (IsDouble(input))
                {
                    number = Convert.ToInt32(input);
                    break;
                }
                else
                {
                    Console.Write($"Неверный формат числа.\nВведите {numberName} снова: ");
                }
            }
            return number;
        }
        private static bool IsDouble(string input)
        {
            bool isNumber = false;
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (double.TryParse(input, out double number))
                {
                    isNumber = true;
                }
            }
            return isNumber;
        }
    }
}
