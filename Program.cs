// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] mass = { "1234", "б", "1567", "-2", "computer science", "ап", "djhdejj", "приветик" };
int counter = 0;

for (int i = 0; i < mass.Length; i++) //Считаем сколько элементов будет в новом массиве
{
    int length = mass[i].Length;
    if (length >= 3) counter++;
}

string[] newmass = new string[counter]; //Объявляем новый массив посчитанной длины

for (int i = 0; i < mass.Length; i++) //Перебором складываем подходящие значения из первого массива во второй и сразу выводим 
{
    int j = 0;
    int length = mass[i].Length;
    if (length >= 3)
    {
        newmass[j] = mass[i];
        Console.Write(newmass[j] + " ; ");
        j++;
    }
}