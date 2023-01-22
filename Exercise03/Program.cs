/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
}

//Вывод таблицы кубов на экран
void PrintTableOfCube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        if (i == num)
            Console.WriteLine(Math.Pow(i, 3));
        else
            Console.Write(Math.Pow(i, 3) + ", ");
    }
}

Console.WriteLine("Программа показывает таблицу кубов от 1 до указанного числа");
Console.Write("Введите число больше 1: ");

//Проверка на положительное значение
int N = Convert.ToInt32(Console.ReadLine());
if ((N < 1))
{
    Console.WriteLine("Введено недопутимое число (меньше 1 или больше 1290), выполнение программы прервано.");
    return;
}

PrintTableOfCube(N);
Console.WriteLine();
Author;