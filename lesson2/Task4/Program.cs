﻿// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите число: ");
        int N = int.Parse(Console.ReadLine());


int a = 0;  // a хранит последнюю цифру числа N 
while (N>0)
{
    a = N % 10;
    N = N/10;
    Console.Write($"{a},  ");
}