// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.



void AllNaturalNumbers(int M, int N)
{
    if (N < M) return;
    AllNaturalNumbers(M, N - 1);
    Console.Write(N + " ");
}

//----------------

Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
AllNaturalNumbers(M, N);
