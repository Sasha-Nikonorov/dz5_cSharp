Console.WriteLine("Введите размер массива");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double[] createArray()
{
    Random random = new Random();

    double[] result = new double[X];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(1, 100);
    }
    return result;
}

void Sort(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine("MAX " + max);
    Console.WriteLine("min " + min);
    Console.WriteLine();
    double result = max - min;
    Console.WriteLine(result);
}

void printArray(double[] array)
{
    Console.Write("[");
    
    for (long i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

double[] array = createArray();

Sort(array);
printArray(array);