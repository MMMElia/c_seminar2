Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a%7==0 && a%23==0) {Console.Write($"Число {a} кратно 7 и 23.");}
else {Console.Write($"Число {a} не кратно 7 и 23 одновременно.");}

