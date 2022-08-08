// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void NewArray(string[] array)
{
    string[] newarray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[i] = array[i]; ;
            Console.Write(newarray[i]+ "; ");
        }
    }
    Console.WriteLine();
}

void Print(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + "; ");
    }
    Console.WriteLine();
}

string[] array = { "1234", "1567", "-2", "computer science" }; // можно ввести любой другой исходный массив

Console.WriteLine("Имеющийся массив:");
Print(array);
Console.WriteLine();
Console.WriteLine("Сформированный массив:");
NewArray(array);