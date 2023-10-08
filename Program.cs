/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

int ReadVal(string msgText)
{
    Console.WriteLine(msgText);
    return Convert.ToInt32(Console.ReadLine());
}

string[] EnterArray(int n)
{
    string[] s = new string[n];

    for (int i = 0; i < s.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент");
        s[i] = Console.ReadLine();
    }

    return s;
}

string PrintArray(string[] a) => "[" + string.Join(", ", a) + "]";


int n = ReadVal("Введите количество элементов массива");
Console.WriteLine();

string[] s = EnterArray(n);
Console.WriteLine();

Console.WriteLine(PrintArray(s));

