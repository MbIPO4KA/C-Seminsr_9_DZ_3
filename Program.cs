/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29  */


Console.Write("Введите значение n : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение m : ");
int m = Convert.ToInt32(Console.ReadLine());


int Akkerman(int n, int m)
{
   if( n == 0)     return m + 1;
   else if (m ==0)
     return Akkerman (n - 1, 1);
   else
     return Akkerman(n - 1, Akkerman (n, m - 1));
}
Console.Write($"Функция Аккермана равно {Akkerman(n, m)} ");

// функция взята из википедии