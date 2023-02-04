Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a*a==b) {
    Console.Write($"{b} является квадратом {a}");
    }
else {
    if (b*b==a) {
        Console.Write($"{a} является квадратом {b}");
        }
    else {
        Console.Write("Одно число не является квадратом другого");
        }

}
