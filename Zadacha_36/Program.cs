/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Write("Введите количество элементов в массиве: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] Array(int length)
{
    int[] array = new int[length];
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(11);
        i++;
    }
    return array;
}

int[] resultArray = Array(lengthArray);

int SumElement(int[] array)
{
    int j = 0;
    int sum = 0;
    while (j < lengthArray)
    {
        if (j % 2 != 0)
        {
            sum += array[j];
        }
        j++;
    }
    return sum;
}
System.Console.WriteLine($"Array: [ {String.Join("; ", resultArray)} ]");
System.Console.WriteLine($"Сумма элементов на нечетных позициях равна: {SumElement(resultArray)}");