/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементом массива.

[3 7 22 2 78] -> 76*/

Console.Write("Введите количество элементов в массиве: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

double[] Array(int length)
{
    double[] array = new double[length];
    int j = 0;
    while (j < length)
    {
        array[j] = 100 * Math.Round(new Random().NextDouble(), 2);
        j++;
    }
    return array;
}
double[] resultArray = Array(lengthArray);

double DifferenceElement(double[] array)
{
    int i = 0;
    double min = array[0];
    double max = array[0];
    double difference = 0;
    while (i < lengthArray)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
        i++;
    }
    difference = max - min;
    return difference;
}

System.Console.WriteLine($"Array: [ {String.Join("; ", resultArray)} ]");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет: {DifferenceElement(resultArray)}");
