﻿// Однострочный комментарий 

/*
    Это
    многострочный
    комментарий
*/

//  Напишите программу, которая на вход 
//  принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
//  4 -> 16 
//  -3 -> 9 
//  -7 -> 49
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = number * number;
// Console.WriteLine("Квадрат числа " + number + " = " + result);

// 3. Напишите программу, которая 
// будет выдавать название дня недели 
// по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница
// Console.Write("Введите номер дня недели: ");
// int numberOfDay = Convert.ToInt32(Console.ReadLine());

// if(numberOfDay == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(numberOfDay == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(numberOfDay == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if(numberOfDay == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(numberOfDay == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(numberOfDay == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(numberOfDay == 7)
// {
//     Console.WriteLine("Воскресение");
// }
// else
// {
//     Console.WriteLine("Такого дня здесь нет!");
// }

// 5. Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N *= -1; // N = N * -1
    Console.WriteLine("Вы ввели отрц. число N, я умножил его на -1 :)");
}
int negativeN = N * -1; // -N

while (negativeN <= N)
{
    Console.Write(negativeN + "   "); 
    negativeN += 1; // negativeN = negativeN + 1
}