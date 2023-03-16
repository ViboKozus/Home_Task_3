#pragma warning disable

Console.Clear();
Console.WriteLine("Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");

int Ax, Ay, Az, Bx, By, Bz;
//double D;

Console.WriteLine("Введите координату X первой точки ");
int.TryParse(Console.ReadLine ()!, out Ax);
Console.WriteLine("Введите координату Y первой точки ");
int.TryParse(Console.ReadLine ()!, out Ay);
Console.WriteLine("Введите координату Z первой точки ");
int.TryParse(Console.ReadLine ()!, out Az);

Console.WriteLine("Введите координату X второй точки ");
int.TryParse(Console.ReadLine ()!, out Bx);
Console.WriteLine("Введите координату Y второй точки ");
int.TryParse(Console.ReadLine ()!, out By);
Console.WriteLine("Введите координату Z второй точки ");
int.TryParse(Console.ReadLine ()!, out Bz);

//double X = (Ax - Bx) * (Ax - Bx); 
//double Y = (Ay - By) * (Ay - By);
//double Z = (Az - Bz) * (Az - Bz);
//D = Math.Round((Math.Sqrt( X + Y + Z)), 3);
Console.WriteLine ($"{Math.Round((Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) + (Az - Bz) * (Az - Bz))), 2)}");