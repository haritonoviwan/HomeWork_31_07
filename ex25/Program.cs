// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.Clear();
int a = GetNumbersFromUser("Введите целое число A: ", "Ошибка ввода");
int b = GetNumbersFromUser("Введите натуральное число B: ", "Ошибка ввода");
int b_natural = NaturalNumber(b);

int expNumbers = NumbersExponentiation(a, b_natural);
Console.WriteLine($"{a}, {b_natural} -> {expNumbers}");

int NaturalNumber(int num)
{
    if (num < 0)
        num = -num;
        return num;
}

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
    int exp = firstNumber;
    for (int i = 1; i < secondNumber; i++)
    {
        exp = exp * firstNumber;
    }
    return exp;
}