// Задайте массив вещественных чисел. !! DOUBLE !!
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример: [3 7 22 2 78] -> 76


void FillArray (double[] fill)
{
    int length = fill.Length;
    int index = 0;
    for (index = 0; index < fill.Length; index++)
    {
        fill[index] = new Random().Next(1, 100);
    }
}

void PrintArray (double[] print)
{
    int length = print.Length;
    int i = 0;
    string space = " ";
    for (i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + space);
    }
}

double MaxEl(double[] maximum)
{
    int leng = maximum.Length;
    int index = 0;
    double max = maximum[0];
    for (index = 0; index < maximum.Length; index++)
    {
        if (maximum[index] > max)
        {
            max = maximum[index];
        }
    }
    return max;
}

double MinEl(double[] minimum)
{
    int leng = minimum.Length;
    int index = 0;
    double min = minimum[0];
    for (index = 0; index < minimum.Length; index++)
    {
        if (minimum[index] < min)
        {
            min = minimum[index];
        }
    } 
    return min;
}

Console.WriteLine("Задайте массив вещественных чисел и найдите разницу между максимальным и минимальным элементом массива.");
Console.WriteLine("Сколько будет элементов в вашем массиве?");
Console.Write("Ввод: ");
int userData = Convert.ToInt32(Console.ReadLine());

double[] myArray = new double[userData];

FillArray(myArray);
Console.Write("Случайно сгенерированные элементы массива: ");
PrintArray(myArray);
Console.WriteLine();
MaxEl(myArray);
MinEl(myArray);

double maxNum = MaxEl(myArray);
Console.WriteLine("Максимальный элемент: " + maxNum);
double minNum = MinEl(myArray);
Console.WriteLine("Минимальный элемент: " + minNum);
double res = maxNum - minNum;

Console.WriteLine("Разница между максимальным и минимальным элементом: " + res);

// Протестировано