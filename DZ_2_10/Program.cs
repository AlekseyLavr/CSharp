﻿Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n / 10 % 10}");
