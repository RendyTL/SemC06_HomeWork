
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void Main()
{
    int[] array = ReadInt("Введите через пробел некоторое количество чисел: ");
    PrintArray(array);
    System.Console.WriteLine($"Количество введённых положительных чисел равно: {Counter(array)}");
}

int[] ReadInt(string text)
{
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",  ", array) + "]");
}

int Counter(int[] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
        i += 1;
    }
    return count;
}

Main();