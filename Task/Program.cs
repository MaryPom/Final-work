// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// объявляем массив
string [] array1 = new string [4];
int newLength = 0;

// инициализируем массив
array1[0] = "1234";
array1[1] = "1567";
array1[2] = "-2";
array1[3] = "computer scince";
Console.WriteLine("Изначальный массив: " + array1[0] + ", " + array1[1] + ", " + array1[2] + ", " + array1[3]);

for (int i = 0; i < array1.Length; i++)
{
if(array1[i].Length <= 3)
newLength++;
}

string [] array2 = new string [newLength];
int counter = 0;
for (int i = 0; i < array1.Length; i++)
{
if(array1[i].Length <= 3)
{
array2[counter] = array1[i];
counter++;
}
}
Console.WriteLine("Сформированный массив: ");
for (int i = 0; i < array2.Length; i++)
{
Console.Write(array2[i] + " ");
}
Console.WriteLine();