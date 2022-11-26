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
string [] array = new string [n]; // {"Hello", "06569yigtog", ":-)", "Hi", "xxx", ""};
array = FillArrayString (array);
PrintArray(array);


string[] FillArrayString (string [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.WriteLine($"Введите элемент № {i+1}");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}