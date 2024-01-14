/*
// 1 ЗАДАНИЕ
// Без применения функции
int num=Convert.ToInt32(Console.ReadLine());
if (num%7==0 && num%23==0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");

// С применением функции
void check(int num)
{
if (num%7==0 && num%23==0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");
}
int num=Convert.ToInt32(Console.ReadLine());
check(num);

// 2 ЗАДАНИЕ
// Без применения функции
int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0) Console.WriteLine("1 четверть");
else if (x<0 && y>0) Console.WriteLine("2 четверть");
else if (x<0 && y<0) Console.WriteLine("3 четверть");
else if (x>0 && y<0) Console.WriteLine("4 четверть");

// С применением функции
using System.Security.Cryptography.X509Certificates;

void check(int x, int y)
{
if (x>0 && y>0) Console.WriteLine("1 четверть");
else if (x<0 && y>0) Console.WriteLine("2 четверть");
else if (x<0 && y<0) Console.WriteLine("3 четверть");
else if (x>0 && y<0) Console.WriteLine("4 четверть");
}
int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
check(x,y);

// 3 ЗАДАНИЕ
// Без применения функции
int num=Convert.ToInt32(Console.ReadLine());
if (num%10>num/10) Console.WriteLine(num%10);
else Console.WriteLine(num/10);

// С применением функции
void check(int num)
{
if (num%10>num/10) Console.WriteLine(num%10);
else Console.WriteLine(num/10);
}
int num=Convert.ToInt32(Console.ReadLine());
check(num);

// 4 ЗАДАНИЕ
// Без применения функции
int num=Convert.ToInt32(Console.ReadLine());
while(num > 0){Console.Write($"{num%10}, ");num = num/10;}
*/
// С применением функции
void check(int num)
{
while(num > 0){Console.Write($"{num%10}, ");num = num/10;}
}
int num=Convert.ToInt32(Console.ReadLine());
check(num);
