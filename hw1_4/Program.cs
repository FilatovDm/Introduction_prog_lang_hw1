﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());

if (number_1 > number_2 && number_1 > number_3)
{
    Console.WriteLine($"Максимальное число: {number_1}");
}

else if (number_2 > number_1 && number_2 > number_3)
{
    Console.WriteLine($"Максимальное число: {number_2}");
}

else if (number_3 > number_1 && number_3 > number_2)
{
    Console.WriteLine($"Максимальное число: {number_3}");
}

else
{
    Console.WriteLine("Введенные числа равны");
}
