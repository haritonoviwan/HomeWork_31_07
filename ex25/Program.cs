// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.Clear();
int a = GetNumbersFromUser("Введите целое число A: ", "Ошибка ввода");
int b = GetNumbersFromUser("Введите целое число B: ", "Ошибка ввода");
int expNumbers = NumbersExponentiation(a, b);
Console.WriteLine($"{a}, {b} -> {expNumbers}");

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

int NumbersExponentiation(int firstNumber, int secondNumber)
{
    int exp = a;
    for (int i = 1; i < b; i++)
    {
        exp = exp * a;
    }
    return exp;
}