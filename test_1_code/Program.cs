// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] newArray(string[] array)
{
    int count = 0, j = 0;
    foreach (string e in array)
    {
        if (e.Length <=3)
        count++;
    }
    string[] newarray = new string[count];
    foreach (string e in array)
    {
        if (e.Length <= 3)
        {
            newarray[j] = e;
            j++;
        }
    }
    return newarray;
}

Console.Clear();
Console.Write("Заполните массив строк через пробел: ");
string str = Console.ReadLine()!;
string[] array = str.Split(' ');
Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Новый массив: [{string.Join(", ", newArray(array))}]");
