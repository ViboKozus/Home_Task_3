﻿Console.Clear();
Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

int N;

Console.WriteLine ("Введите число N");
int.TryParse(Console.ReadLine ()!, out N);

for ( int i = 1; i <= N; i++)
{
    Console.Write ($"{i * i * i}, ");
}