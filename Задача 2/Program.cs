// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else
    return Akkerman(m - 1, Akkerman(m, n - 1));
}


//----------------
System.Console.WriteLine("Вычесление функции Аккермана");
System.Console.WriteLine("____________________________");
int m = ReadInt("Введите переменную m: ");
int n = ReadInt("Введите переменную n: ");
Akkerman(m,n);
Console.WriteLine(Akkerman(m, n));
