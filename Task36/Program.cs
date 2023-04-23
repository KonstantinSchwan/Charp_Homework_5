void FillArray(int[] nums)
{
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

int GetPositiveSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sum += numbers[i];
    }
    return sum;
}

int GetNegativeSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) sum += numbers[i];
    }
    return sum;
}

void Changenumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}

void Findnumbers(int[] numbers, int num)
{
    bool flag = false;
    int index = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == num)
        {
            flag = true;
            index = i;
        }
    }
    if (flag) Console.WriteLine($"Число найдено. Оно стоит на {index + 1} позиции.");
    else Console.WriteLine("Такого числа нет");
}

void FillArraythirty(int[] nums)
{
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(100, 1000);
    }
}

// Задача 36:   Задайте одномерный массив, заполненный случайными числами. 
//              Найдите сумму элементов с нечётными индексами.
//              [3, 7, 23, 12] -> 19
//              [-4, -6, 89, 6] -> 0
void Task36()
{
    Console.WriteLine("Введите размер массива ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    int sum = 0;

    for (int z = 1; z < numbers.Length; z += 2)
        sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");
}
Task36();

