Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"max= {a}");
else if (b == a)
    Console.WriteLine("Числа равны");
else
    Console.WriteLine($"max= {b}");