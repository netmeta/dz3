// Напишите программу, которая принимает на вход числоN () и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
// 3 -> [1, 8, 27].
// 5 -> [1, 8, 27, 64, 125]
// Указание: Вывод массива вынести в отдельную функцию.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateQubeArray(N));


int[] CreateQubeArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}

void PrintArray(int[] array) // Ф-я вывести массив на экран.
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write($"]");
}

