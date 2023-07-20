// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetNum(string message)                    // запрашивает число у пользователя
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double[] GetRandomArray(int size)             // Выводит массив случайных элементов заданной длины
{
    double[] randomArray = new double[size];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().NextDouble() * 100;
    }
    return randomArray;
}

void PrintArray(double[] arr)                 // Выводит на экран массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    Console.Write(arr[i] + ", ");

    Console.Write($"{arr[arr.Length -1]}]");
}

double GetMaxMinDiff(double[] ar)             // Находит разницу между максимальным и минимальным элементом массива
{
    return ar.Max() - ar.Min();
}

int sizeArray = GetNum("Введите длину массива: ");
double[] array = GetRandomArray(sizeArray);
PrintArray(array);
Console.WriteLine(" -> " + GetMaxMinDiff(array));
