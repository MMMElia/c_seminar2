// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите номер дня недели ");
int a = int.Parse(Console.ReadLine());

if (a<1 || a>7) {Console.Write("Вы ввели неверное число, введите число от 1 до 7");
    Console.Write("  ");
}
a = int.Parse(Console.ReadLine());

if (a==6 || a==7) {Console.Write("Ура! Сегодня выходной");}
else {if (a>=1 && a<=5) {
    Console.Write("сегодня будний день");}
    else {Console.Write("Вы снова ввели неверное число, прощайте!");
       
    }
}

