Console.Clear();

int n = new Random().Next(100,1000);

Console.Write(n);

int n1=n/100;
// int n2=n/10;
int n3=n % 10;
int x=n1*10+n3;

Console.Write(" ");
Console.Write($"Ответ {x}");