// Задать одномерный массив, заполненный случайными числами. 
// Найти сумму элементов на нечётных позициях.

void FillArray (int[] random)
{
    int length = random.Length;
    int index = 0;
    for (index = 0; index < random.Length; index++)
    {
        random[index] = new Random().Next(1,100);
    }
}

void PrintArray (int[] print)
{
    int length = print.Length;
    int i = 0;
    string space = " ";
    Console.Write("Случайно сгенерированные числа: ");
    for (i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + space);
    }
}

void arrSum (int[] array)
{
    int leng = array.Length;
    int index = 0;
    int res = 0;
    for (index = 0; index < array.Length; index++)
    {
        if (index % 2 != 0)
        {
            continue;
        }
        else
        {
            res = res + array[index];
        }
    }
    Console.WriteLine();
    Console.Write("Сумма элементов массива на нечетных позициях: " + res);
}

Console.Write("Введите, пожалуйста, длинну массива: ");
int userInput = Convert.ToInt32(Console.ReadLine());

int[] myArr = new int[userInput];

FillArray(myArr);
PrintArray(myArr);
arrSum(myArr);