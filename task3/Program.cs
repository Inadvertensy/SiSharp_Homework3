﻿// Задача 23: Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Please enter N");
int N= int.Parse(Console.ReadLine());


Console.WriteLine($"{N} third degree table is below");
for (int c=1;c<=N;c++)
{
    double result=Math.Pow(c,3);
    Console.WriteLine(result);
}
