Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result; 
}
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else Console.WriteLine(ThirdDigit(number));