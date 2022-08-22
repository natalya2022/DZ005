// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayGeneration(int leng, int maxRand = 20, int minRand = -20) //Функция генерации массива по заданным условиям
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

int OddNumberSum(int[] myArr)               // Функция подсчета суммы элементов массива на нечетных позициях (индексы 0, 2, 4 и т.д.)
{
    int sum = myArr[0];
    for (int i = 2; i < myArr.Length; i += 2)
    {
        sum = sum + myArr[i];
    }
    return sum;
}


int[] array = ArrayGeneration(8, 10, -10);            // Вводим параметры массива (8 элементов в диапазоне от 100 до 999)
ArrayPrint(array);                                    // Печатаем массив   
System.Console.WriteLine();
System.Console.WriteLine($"Cумма элементов на нечётных позициях равна {OddNumberSum(array)}");