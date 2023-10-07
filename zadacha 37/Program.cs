// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

int[] GetArraynNew("int minValue, int maxValue, int size = 5")

void NewArray(int[] array)
{
    int sizeNew = array.Length / 2 + array.Length % 2;
    int[] NewArray = new int[sizeNew];
    if (sizeNew % 2 == 1)
    {
        NewArray[sizeNew - 1] = array[sizeNew - 1];
    }

    for (int i = 0; i < NewArray.Length - sizeNew % 2; i++)
    {
        int temp = array[i] * array[array.Length - 1 - i];
        NewArray[i] = temp;
    }

    for (int i = 0; i < NewArray.Length; i++)
    {
        Console.Write($"{NewArray[i]} ");
    }
    Console.WriteLine();

}

Console.Write("Введите минимальный элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = GetArraynNew(minValue, maxValue);
NewArray(array);