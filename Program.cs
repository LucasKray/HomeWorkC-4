// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] numbers = new []{789, 456, 123, 742};
int a = 0;
foreach(var i in numbers)
{
    if (i % 2 == 0)
    a++;
}

Console.WriteLine(a);
*/

//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] numbers = new []{789, 456, 123, 742, 258};
int a = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i %2 == 0)
    a += numbers[i];
}
Console.WriteLine(a);
*/

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] numbers = new []{789, 456, 123, 742, 258};
Console.WriteLine(numbers.Max() - numbers.Min());

