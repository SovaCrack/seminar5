// Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
for (int i = 0; i < arr.Length; i++)
    {
       arr[i]*=-1;
       Console.Write($"{arr[i]} ");
    }