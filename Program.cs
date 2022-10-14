/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine()!);
int[] array34 = GetArray(N, 100, 1000);
Console.WriteLine($"Массив из трехзначных чисел: [{String.Join(", ", array34)}]");
Console.WriteLine($"Колличество четных элементов в массиве равно {CountEvens(array34)}");

int CountEvens(int[] array){
    int counter = 0;
    foreach(var item in array){
        if(item % 2 == 0){
            counter++;
        }
    }
    return counter;
}


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}