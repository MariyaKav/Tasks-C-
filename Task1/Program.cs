// Console.Write("Введите число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber % 7 == 0 && firstNumber % 23 == 0)
// {
//     Console.WriteLine("делится");
// }
// else
// {
//     Console.WriteLine("не делится");
// }

// Console.Write("Введите координату x, не равную 0: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y, не равную 0: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else if (x == 0 && y == 0)
// {
//     Console.WriteLine("Начало координат");
// }
// else 
// {
//     Console.WriteLine("Одна из координат = 0");
// }

Console.Write("Введите число из отрезка [10,99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}