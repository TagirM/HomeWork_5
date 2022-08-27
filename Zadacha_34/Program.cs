/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write("Введите количество элементов в массиве: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] Array(int length)
{
    int[] array = new int[length];
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(100, 1000);
        i++;
    }
    return array;
}

int[] resultArray = Array(lengthArray);

int Amount(int[] array)
{
int j = 0;
int n = 0;
while (j < lengthArray)
{
    if (array[j] % 2 == 0)
    {
        n++;
    }
    j++;
}
return n;
}
System.Console.WriteLine($"Array: [ {String.Join("; ", resultArray)} ]");
System.Console.WriteLine($"Количество четных чисел в массиве: {Amount(resultArray)}");

