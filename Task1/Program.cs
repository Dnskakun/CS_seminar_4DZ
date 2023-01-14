//Напишите цикл, который принимает на вход два числа и
//возводит первое число в натуральную степень второго числа.

int a = GetNumberFromUser("Введите целое число А", "Ошибка ввода!");
int b = GetNumberFromUser("Введите целое число В", "Ошибка ввода!");
int expResult = GetResult(a, b);

Console.WriteLine($"{a},{b} -> {expResult}");


//Функции, используемые в программе
int GetNumberFromUser(string message, string errormMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
            Console.WriteLine(errormMessage);
    }
}

int GetResult(int numA, int numB)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}