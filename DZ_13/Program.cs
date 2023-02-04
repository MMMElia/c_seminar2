// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a<100) {
    Console.Write("Третьей цифры нет");
     }
     else {string b=Convert.ToString(a);

    Console.Write(b[2]);}
    
