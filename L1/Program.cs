// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] ArrayGeneration(int leng, int maxRand = 1000, int minRand = 0) //Функция генерации массива по заданным условиям
{
    int[] myArr = new int[leng];
    int i = 0;
    while (i < myArr.Length)
    {
        myArr[i] = new Random().Next(minRand, maxRand);
        i++;
    }
    return myArr;                                       // Возвращаем массив
}

void ArrayPrint(int[] myArr)                            // Функция печати массива    
{
    for (int j = 0; j < myArr.Length; j++)
    {
        System.Console.Write($"{myArr[j]}  ");
    }
}

int EvenNumbers(int[] myArr)                // Функция подсчета четных значений в массиве
{
    int count = 0;
    for (int i = 0; i < myArr.Length; i++)
    {
        count += myArr[i] % 2 == 0 ? 1 : 0;
    }
    return count;
}

int[] array = ArrayGeneration(8, 999, 100);            // Вводим параметры массива 
ArrayPrint(array);                           // Печатаем массив   
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел равно {EvenNumbers(array)}");