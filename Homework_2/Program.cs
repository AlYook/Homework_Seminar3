// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine ("Enter X1 : ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Y1 : ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Z1 : ");
int Za = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter X2 : ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Y2 : ");
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Z2 : ");
int Zb = int.Parse(Console.ReadLine());

double Dist = Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2);

double result = Math.Sqrt(Dist);

Console.WriteLine(result);
