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


//Задача 34:    Задайте массив заполненный случайными положительными трёхзначными числами. 
//              Напишите программу, которая покажет количество чётных чисел в массиве.
//              [345, 897, 568, 234] -> 2
void Task34()
{Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
}
Task34();
