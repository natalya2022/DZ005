// Задайте массив вещественных чисел. Найдите разницу между максимальным
//и минимальным элементов массива

double[] ArrayGeneration(int leng, double maxRand = 10, double minRand = 0) //Функция генерации массива по заданным условиям
{
    double[] myArr = new double[leng];
    int i = 0;
    while (i < myArr.Length)
    {
        myArr[i] = new Random().NextDouble() * (maxRand - minRand) + minRand;
        i++;
    }
    return myArr;                                       // Возвращаем массив
}

void ArrayPrint(double[] myArr)                         // Функция печати массива    
{
    for (int j = 0; j < myArr.Length; j++)
    {
        System.Console.WriteLine($"{myArr[j]}  ");
    }
}

double Max(double[] array)                              // Функция нахождения максимального элемента    
{
    double maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum) { maxNum = array[i]; }
    }
    return maxNum;
}

double Min(double[] array)                              // Функция нахождения минимального элемента
{
    double minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNum) { minNum = array[i]; }
    }
    return minNum;
}

double[] array = ArrayGeneration(8, 10, 0);            // Вводим параметры массива
ArrayPrint(array);                                    // Печатаем массив   
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Max(array) - Min(array)}");