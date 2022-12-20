// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Для определения расстояния между точками - введите последовательно по 3 координаты для первой и второй точки.");
Console.WriteLine ("I. Введите координаты для первой точки.");
Console.WriteLine("1). По оси oХ: ");
int point_1_X = int.Parse(Console.ReadLine());
Console.WriteLine("2). По оси oY: ");
int point_1_Y = int.Parse(Console.ReadLine());
Console.WriteLine("3). По оси oZ: ");
int point_1_Z = int.Parse(Console.ReadLine());
Console.WriteLine ("II. Введите координаты для второй точки.");
Console.WriteLine("1). По оси oХ: ");
int point_2_X = int.Parse(Console.ReadLine());
Console.WriteLine("2). По оси oY: ");
int point_2_Y = int.Parse(Console.ReadLine());
Console.WriteLine("3). По оси oZ: ");
int point_2_Z = int.Parse(Console.ReadLine());
Console.WriteLine($" Точка №1: ({point_1_X};{point_1_Y};{point_1_Z}).");
Console.WriteLine($" Точка №2: ({point_2_X};{point_2_Y};{point_2_Z}).");
int result_midle = ((point_2_X - point_1_X) * (point_2_X - point_1_X)) + ((point_2_Y - point_1_Y) * (point_2_Y - point_1_Y)) + ((point_2_Z - point_1_Z) * (point_2_Z - point_1_Z));
double result = Math.Sqrt(result_midle);
result = (result / 1) + ((result % 1) / 100);
Console.WriteLine($"Расстояние между точками составляет: {result:f2}.");