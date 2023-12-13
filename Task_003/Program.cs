// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int arraySize = ReadInt("Введите колличество элементов в массиве: ");
int[] array = RandomArray(arraySize);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("\nМассив, начиная с конца:");
ArrayReversed(array, array.Length - 1);

//-------------------------------------

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

static int[] RandomArray(int size)
{
    Random rand = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(1, 100);
    }

    return array;
}

static void PrintArray(int[] array)
{
    foreach (var element in array)
    {
        Console.Write(element + " ");
    }
}

static void ArrayReversed(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    ArrayReversed(array, index - 1);
}


