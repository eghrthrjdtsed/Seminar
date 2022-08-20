Console.WriteLine(" Введите два числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int max = a; int min = b;

if (a > b) max=a;
if (b > a) max=b;

else 
max=b;
min=a;

Console.Write(" max ");
Console.WriteLine(max);
Console.Write(" min ");
Console.WriteLine(min);

задача 2

Console.WriteLine(" Введите три числа ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA; 

if (numA > max) max = numA; if (numB > max) max = numB; if (numC > max) max = numC;  


Console.Write(" max ");
Console.WriteLine(max);


задача 3


Console.WriteLine(" Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)

Console.WriteLine(" чётное число ");

else 

Console.WriteLine(" нечётное число ");


// задача 4

Console.WriteLine(" Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=num; i++)

if (i % 2 ==0)

Console.WriteLine(i);


