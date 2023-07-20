// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int GetNum(string message)                         // запрашивает число у пользователя
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] GetRandomArray(int size)                     // Выводит массив случайных элементов заданной длины
{
    int[] randomArray = new int[size];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(100);
    }
    return randomArray;
}

void PrintArray(int[] arr)                         // Выводит на экран массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    Console.Write(arr[i] + ", ");

    Console.Write($"{arr[arr.Length -1]}]");
}

int[] ArrayOppositeElementsMultiplic(int[] ar)     // Перемножает противоположные элементы массива и записывает в новый массив
{
    if (ar.Length % 2 == 0)
    {
        int[] res = new int[ar.Length / 2];
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = ar[i] * ar[ar.Length - 1 - i];
        }
        return res;
    }
    else
    {
        int[] res = new int[ar.Length / 2 + 1];
        for (int i = 0; i < res.Length - 1; i++)
        {
            res[i] = ar[i] * ar[ar.Length - 1 - i];
        }
        res[res.Length - 1] = ar[res.Length - 1];
        return res;
    }
}

int sizeArray = GetNum("Введите длину массива: ");
int[] array = GetRandomArray(sizeArray);
int[] array2 = ArrayOppositeElementsMultiplic(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(array2);
