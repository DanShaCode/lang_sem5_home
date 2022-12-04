// Создать массив со случайными положительными трехзначными числами
// Выдать на экран количество четных чисел в массиве

void FillArray (int[] random3)
{
    int length = random3.Length;
    int index = 0;
    for (index = 0; index < random3.Length; index++)
    {
        random3[index] = new Random().Next(100, 1000);
    }
}

void PrintArray (int[] print3)
{
    int length = print3.Length;
    int index = 0;
    string space = " ";
    Console.Write("Полученный массив: ");
    for (index = 0; index < print3.Length; index++)
    {
        Console.Write(print3[index] + space);
    }
}

Console.WriteLine("Данная программа считает количество четных чисел в массиве");
Console.Write("Введите количество элементов в массиве: ");
int numElements = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[numElements];

FillArray(newArray);
PrintArray(newArray);

int i = 0;
int res = 0;
int count = 0;

for (i = 0; i < newArray.Length; i++)
{
    res = newArray[i] % 2;
    if (res == 0)
    {
        count = count + 1;
    }
}

Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве: " + count);