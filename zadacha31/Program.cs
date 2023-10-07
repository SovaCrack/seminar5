// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] GerArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine();
    return res;
}

Console.Write("Введите число элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива");
int maxArr = Convert.ToInt32(Console.ReadLine());

int[] arr = GerArray(n, minArr, maxArr);

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) sumPos += arr[i];
    else sumNeg += arr[i];
}

Console.WriteLine($"Сумма положительных элементов массива равна {sumPos}");
Console.WriteLine($"Сумма положительных элементов массива равна {sumNeg}");