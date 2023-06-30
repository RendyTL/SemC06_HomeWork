// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Main()
{
    double k1 = ReadInt("Введите значение аргумента для первой прямой: ");
    double b1 = ReadInt("Введите свободный член для первой прямой: ");
    double k2 = ReadInt("Введите значение аргумента для второй прямой: ");
    double b2 = ReadInt("Введите свободный член для второй прямой: ");

    System.Console.WriteLine($"По введённым вами значениям сотавим уравнения: y = {k1}x + {b1} и y = {k2}x + {b2}");

    double[] answer = Solution(k1, k2, b1, b2);

    if (k1 == k2 && b1 == b2)
    {
        Match();
    }
    else if (k1 == k2 && b1 != b2)
    {
        Parallel();
    }
    else if (k1 != k2)
    {
        Solution(k1, k2, b1, b2);
        System.Console.Write($"Прямые пересекутся в точке: ");
        PrintArray(answer);
    }
}


double ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}


void Parallel()
{
    System.Console.WriteLine("Прямые параллельны и решений нет"); ;
}


void Match()
{
    System.Console.WriteLine("Прямые совпадают и имеют множество решений");
}


double[] Solution(double k1, double k2, double b1, double b2)
{
    double[] answer = new double[2];
    answer[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
    answer[1] = Math.Round((k1 * answer[0] + b1), 2);
    return answer;
}


void PrintArray(double[] answer)
{
    System.Console.WriteLine("[" + string.Join(",  ", answer) + "]");
}


Main();