﻿
/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом
(НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ.
Используем операторы % и /).
14212 -> нет
12821 -> да
23432 -> да
*/

string PolindromTest(int num)
{
    int resNum = 0;
    int temp = 0;
    int number = num;
    while (number > 0)
    {
        temp = number % 10;
        resNum = resNum * 10 + temp;
        number /= 10;
    }
    if (resNum == num)
        return "палиндром";
    else
        return "НЕ палиндром";
}

Console.WriteLine("Программа проверяет, является ли введённого пятизначное число палиндромом.");
Console.Write("Введите пятизначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if ((number < 10_000) || (99_999 < number))
{
    Console.WriteLine("Введено недопустимое число. Выполнение программы прервано.");
    return;
}
Console.WriteLine($"Введённое число {number} - {PolindromTest(number)}");