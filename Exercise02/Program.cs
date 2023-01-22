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

Console.WriteLine("Программа находит расстояние между двумя точкам в трёхмерном пространстве.");
double ax, ay, az,
    bx, by, bz;
ax = NewCoordinates("A", "x");
ay = NewCoordinates("A", "y");
az = NewCoordinates("A", "z");
bx = NewCoordinates("B", "x");
by = NewCoordinates("B", "y");
bz = NewCoordinates("B", "z");
