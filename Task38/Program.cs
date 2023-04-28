void Fill_numbers(double[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round((Math.Round(rnd.NextDouble(), 3) * rnd.Next(-100, 101)), 3);
    }
}


void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

double MaxNumbers(double[] numbers)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}


double MinNumbers(double[] numbers)
{
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}


void SumNumbers(double max, double min)
{
    double result = Math.Round((min + max), 3);
    Console.WriteLine(result);
}

// Задача 38:   Задайте массив вещественных чисел. 
//              Найдите разницу между максимальным и минимальным элементами массива.



void Task38()
{
    Console.Write($"Введите количество случайных чисел: ");
    int size = int.Parse(Console.ReadLine());
    double[] numbers = new double[size];

    Console.Write($"Имеющиеся числа: ");
    Fill_numbers(numbers);
    PrintArray(numbers);
    Console.Write($"Сумма минимального и максимального числа: ");
    SumNumbers(MinNumbers(numbers), MaxNumbers(numbers));
}


Task38();
