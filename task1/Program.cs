// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArrayRandom(int leng)           // Создает массив из случайных положительных трехзначных чисел
{
    int[] array = new int[leng];
    for (int i = 0; i < leng; i ++)
    {
       array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetEvenNum(int[] arr)                // Находит количество четных элементов массива
{
    int evenCount = 0;
    for (int i = 0; i < arr.Length; i ++)
    if (arr[i] % 2 == 0) evenCount += 1;

    return evenCount;
}

void PrintArray(int[] array, int evCount)  // Выводит на экран массив и количество четных элементов в нем
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    Console.Write(array[i] + ", ");

    Console.Write($"{array[array.Length -1]}] -> {evCount}");
}

Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = new int[length];
arrayRandom = GetArrayRandom(length);
PrintArray(arrayRandom, GetEvenNum(arrayRandom));
