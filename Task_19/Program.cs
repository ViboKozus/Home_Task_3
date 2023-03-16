#pragma warning disable
Console.Clear();
Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

Console.WriteLine ("Введите пятизначное число N");

string N = Console.ReadLine();
int a = N.Length;
if (a == 5)
{
    if ( N [0] == N [4] && N[1] == N[3])
    {
        Console.WriteLine($"{N} Это число палиндром");
    }
    else
    {
        Console.WriteLine($"{N} Это число НЕ палиндром");
    }
}

else 
{
    Console.WriteLine ("Вы ввели не пятизначное число");
}