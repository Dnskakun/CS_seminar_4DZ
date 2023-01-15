//Программа, которая задает массив из 8 элементов и
//выводит их на экран

int[] array = new int[8];

FillArray(array);
PrintArray(array);

//Функции, используемые в программе
void FillArray(int[] collection)
{
    int lengthArray = collection.Length;
    for (int i = 0; i < lengthArray; i++)
    {
        while (true)
        {
            Console.Write($"Введите {i}-й элемент массива: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if (isCorrect)
                {
                collection[i] = num;
                break;
                }
            else Console.WriteLine("Ошибка ввода!");
        }
    }
}

void PrintArray(int [] printArray)
{
    int lengthArray = printArray.Length;
    Console.Write("[");
    for (int i = 0; i < lengthArray; i++)
    {
        Console.Write(printArray[i]);
        if (i < lengthArray - 1) Console.Write(", ");
    }
    Console.Write("]");
}
