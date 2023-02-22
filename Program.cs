// Написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввесли либо
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивамию

string[] GetArrayFromString(string text)
{
    return text.Split(" ").ToArray();
}

string GetStringFromArray(string[] array)
{
    string newData = String.Empty;

    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i].Length <= 3) newData += $"{array[i]} ";
    }

    if (newData.Length != 0)
        return newData.Remove(newData.Length - 1);
    else
        return newData;
}

Console.WriteLine("Введите текст, для разделения используйте пробелы:");
string text = Console.ReadLine();
var data = GetArrayFromString(text);
string newText = GetStringFromArray(data);
var result = GetArrayFromString(newText);

Console.Write("Получаем из имеющегося массива массив строк,");
Console.WriteLine(" длина которых меньше либо равна 3 символа:");
Console.Write("[" + String.Join(", ", data) + "]");
Console.Write(" -> ");
Console.WriteLine("[" + String.Join(", ", result) + "]");