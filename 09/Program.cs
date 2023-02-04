Console.Clear();

int n = new Random().Next(10,100);

Console.Write(n);

int n1=n/10;
int n2=n%10;
int max=n2;
if (n1>n2) {max = n1;} 

Console.Write(" ");
Console.Write(max);



