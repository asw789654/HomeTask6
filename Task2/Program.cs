using Task2;

double x, y;
Console.WriteLine("Введите первое значение");
x = NumberCheck.AskForNumber("число");
Console.WriteLine("Введите второе значение");
y = NumberCheck.AskForNumber("число");
bool isWrongCoice = true;
while (isWrongCoice)
{
    Console.WriteLine($"Выберите действие:{Environment.NewLine}" +
    $"1.Сложение{Environment.NewLine}" +
    $"2.Вычитание{Environment.NewLine}" +
    $"3.Умножение{Environment.NewLine}" +
    $"4.Деление");
    string choise = Console.ReadLine();
    switch (choise)
    {
        case "1":
            Task2.Math.Add(x, y);
            isWrongCoice = false;
            break;
        case "2":
            Task2.Math.Subtract(x, y);
            isWrongCoice = false;
            break;
        case "3":
            Task2.Math.Multiply(x, y);
            isWrongCoice = false;
            break;
        case "4":
            Task2.Math.Divide(x, y);
            isWrongCoice = false;
            break;
        default:
            Console.WriteLine("Введён неверный вариант действия");
            break;
    }
}
