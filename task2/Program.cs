// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetNum(string message)                    // запрашивает число у пользователя
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetRandomArray(int size)                // Выводит массив случайных элементов заданной длины
{
    int[] randomArray = new int[size];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1000);
    }
    return randomArray;
}

void PrintArray(int[] arr)                  // Выводит на экран массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    Console.Write(arr[i] + ", ");

    Console.Write($"{arr[arr.Length -1]}]");
}

int GetSumOdd(int[] ar)                    // Находит сумму нечетных элементов массива
{
    int sum = 0;
    for (int i = 1; i < ar.Length; i += 2)
    {
        sum += ar[i];
    }
    return sum;
}

int sizeArray = GetNum("Введите длину массива: ");
int[] array = GetRandomArray(sizeArray);
PrintArray(array);
Console.WriteLine(" -> " + GetSumOdd(array));