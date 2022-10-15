/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();

int ArraySize = GetNumberFromUser("Введите число элементов массива: ", "Ошибка ввода!");
double[] array = GetArray(ArraySize);
double MaxNum = GetMaxElement(array); // в этом моменте преподаватель в разборе ДЗ на семинаре предложил создать 2 метода на нахождение Max и Min элементов.
double MinNum = GetMinElement(array);
double subtractionNums = GetSubtraction(MaxNum, MinNum);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {subtractionNums}");

////////// Определение методов///////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = ((new Random().NextDouble()) * 10);
    }

    return res;
}

double GetMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double GetMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

void PrintArray(double[] array)
{
    Console.WriteLine("Массив вещественных чисел из " + array.Length + " элементов: ");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

double GetSubtraction(double Num1, double Num2)
{
    double subtraction = Num1 - Num2;
    return subtraction;
}