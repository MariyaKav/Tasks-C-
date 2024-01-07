Console.Write("Введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % 7 == 0 && firstNumber % 23 == 0)
{
    Console.WriteLine("делится");
}
else
{
    Console.WriteLine("не делится");
}
