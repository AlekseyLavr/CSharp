Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
    Console.WriteLine("Ура, выходной!");
else if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("На работу.");
}
else
{
    Console.WriteLine("Такого дня не существует");
}