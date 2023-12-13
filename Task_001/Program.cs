// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int m = ReadInt("Введите число М: ");
int n = ReadInt("Введите число N: ");
PrintNaturalNumbers(m, n);

//-------------------------------------------------------

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

static void PrintNaturalNumbers(int current, int end)
{
    if (current > end)
    {
        Console.Write("Ошибка! Число M не может быть больше числа N"); 
        return;
    }
    Console.Write(current + " ");
    PrintNaturalNumbers(current + 1, end);
}



