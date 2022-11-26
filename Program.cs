// Задание:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// 
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите длину массива:");
int n = int.Parse(Console.ReadLine());
string[] array = new string[n];
array = FillArrayString(array);
Console.WriteLine("Введенный массив:");
PrintArray(array);
string[] threeChar = StringThreeCharFromArray(array);
Console.WriteLine("Массив из строк, длина которых либо меньше либо равна 3 символа:");
PrintArray(threeChar);

string[] FillArrayString(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.WriteLine($"Введите элемент № {i + 1}");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] StringThreeCharFromArray(string[] array)
{
    string[] result = new string[array.Length];
    int length = 3;
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i].Length <= length) 
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}