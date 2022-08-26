// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Please enter X coordinate of A");
int XA= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Y coordinate of A");
int YA= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Z coordinate of A");
int ZA= int.Parse(Console.ReadLine());

Console.WriteLine("Please enter X coordinate of B");
int XB= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Y coordinate of B");
int YB= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Z coordinate of B");
int ZB= int.Parse(Console.ReadLine());
double distance=Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA)+(ZB-ZA)*(ZB-ZA));
Console.WriteLine($"Distance between A and B is {distance:f3}");
