// Написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввесли либо
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивамию

Console.WriteLine("Введите текст, для разделения используйте пробелы:");
string text = Console.ReadLine();

var data = text.Split(" ").ToArray();
string newData = String.Empty;

for (int i = 0; i < data.Length; i++)
{    
    if (data[i].Length <= 3) newData += $"{data[i]} ";
}

newData = newData.Remove(newData.Length - 1);
var result = newData.Split(" ").ToArray();

Console.WriteLine("Получаем из имеющегося массива массив строк, длина которых меньше либо равна 3 символа:");
Console.Write("[" + String.Join(", ", data) + "]");
Console.Write(" -> ");
Console.WriteLine("[" + String.Join(", ", result) + "]");