/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Author()
{
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
}

double NewCoordinates(string point, string coordinate)
{
    Console.Write($"Введите координату {coordinate} точки {point}: = ");
    return Convert.ToDouble(Console.ReadLine());
}

double DistanceIn3dSpace(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));
}

Console.WriteLine("Программа находит расстояние между двумя точкам в трёхмерном пространстве.");
double ax, ay, az,
       bx, by, bz;
ax = NewCoordinates("A", "x");
ay = NewCoordinates("A", "y");
az = NewCoordinates("A", "z");
bx = NewCoordinates("B", "x");
by = NewCoordinates("B", "y");
bz = NewCoordinates("B", "z");
Console.WriteLine($"Введены точки A({ax}, {ay}, {az}) и B({bx}, {by}, {bz})");
Console.WriteLine($"Расстояние между точками = {Math.Round(DistanceIn3dSpace(ax, ay, az, bx, by, bz), 2)}");
Console.WriteLine();
Author();