// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GerArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

bool CheckArray(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Math.Abs(array[i]) == Math.Abs(num))
        {
            return true;
        }
        
    }

    return false;
}

void PrintArray(int[] array)
{
    Console.Write(";");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b");
}
Console.Write("GerArray with Length: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = GerArray(Length);
PrintArray(array);
Console.WriteLine(CheckArray(-3, array));

