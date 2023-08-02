// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

Console.Clear();

int myNumber = GetNumbersFromUser("Введите целое число: ", "Ошибка ввода");
int mySumDigits = SumOfDigits(myNumber);

Console.WriteLine($"{myNumber} -> {mySumDigits}");

int GetNumbersFromUser(string message, string errorMessage)
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

int SumOfDigits(int num)
{
    int sumDigits = 0;
    while (num != 0)
    {
        sumDigits = sumDigits + num % 10;
        num = num / 10;
    }
    return sumDigits;
}