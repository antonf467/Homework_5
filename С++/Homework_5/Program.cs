﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int size = ReadInt("Введите размер массива: ");
// int [] numbers = new int[size];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         result++;
//     }
// }
// if (result % 10 == 1)
// {
//     Console.WriteLine($"В массиве {result} четное число");
// }
// if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
// {
//     Console.WriteLine($"В массиве {result} четных числа");
// }
// else

//     Console.WriteLine($"В массиве {result} четных чисел");


// void FillArrayRandomNumbers(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(99, 999);
//     }
// }

// void PrintArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int ReadInt(string message) 
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int size = ReadInt("Введите размер массива: ");
// int min = ReadInt("Введите min число массива: ");
// int max = ReadInt("Введите max число массива: ");
// int [] numbers = new int[size];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         result += numbers[i];
//     }
// }
// Console.WriteLine($"Сумма элементов нечетных = {result}");


// void FillArrayRandomNumbers(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
// }

// void PrintArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)  
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] randomArray = new double[a];

// void mas(int a)
// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.NextDouble();
// Console.Write($"{randomArray[i]:F2} ");
// }

// }

// double raz(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
// while (i < randomArray.Length)
// {
// if (max<randomArray[i])
// max = randomArray[i];
// if (min>randomArray[i])
// min = randomArray[i];
// i = i + 1;
// }
// return max-min;
// }

// mas(a);
// Console.Write($"\nРазница между максимальным и минимальным элементов массива: {(randomArray)}");

