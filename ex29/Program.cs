// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

Console.Clear();

int[] ArrayInputFromUser()
{
    int[] arr = new int[8];
    for (int index = 0; index < arr.Length; index++)
    {

        Console.Write($"Введите {index + 1} элемент массива: ");
        arr[index] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length; index++)
    {
        if (index < array.Length - 1)
        {
            Console.Write($"{array[index]}, ");
        }
        else
        {
            Console.Write(array[index]);
        }
    }
    Console.Write("]");
}

int[] array = ArrayInputFromUser();
ArrayPrint(array);