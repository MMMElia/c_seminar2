// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

 
if (a>999 || a<100) {
    Console.Write("Неправильный ввод. Введите трехзначное число: ");
    a = int.Parse(Console.ReadLine());
    
}
int a1=a/10;
int a2=a1%10;

Console.Write($"Ответ: {a2}");