// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GerArray(int minValue, int maxValue)
{
    int[] res = new int[12];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue,maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine();
    return res;
}
int ArrayCheck(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <=99)
        {
            count++;
        }
    }
    return count;
}


Console.Write("Введите минимальный элемент массива");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива");
int maxArr = Convert.ToInt32(Console.ReadLine());

int[] arr = GerArray(minArr, maxArr);
Console.WriteLine(ArrayCheck(arr));