﻿Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a%b==0) {Console.Write($"{a} кратно {b}");}
else Console.Write($"{a} не кратно {b}, остаток от деления равен {a%b}");


