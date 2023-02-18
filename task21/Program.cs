// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату точки A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по оси z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
Console.WriteLine($"Расстояние между точками {result}");