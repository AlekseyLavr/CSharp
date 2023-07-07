Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");