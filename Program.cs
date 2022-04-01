// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] mass = { "1234", "б", "1567", "-2", "computer science", "ап", "djhdejj"};
// int length = mass[3].Length;
// string[] newmass = new String[];
int counter = 0;

for (int i = 0; i < mass.Length; i++) //Считаем сколько элементов будет в новом массиве
{
    int length = mass[i].Length;
    if (length >= 3) counter++;
}
Console.WriteLine(counter);



// for (int i = 0; i < mass.Length; i++)
// {
//     int length = mass[i].Length;
//     if (length >= 3) Console.Write(mass[i] + " ; ");
// }