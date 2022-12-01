//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
Console.Clear();

string[] arrayA = new string[5] { "sasha", "45", "hello", ":-)", "yes" };
string[] arrayB = new string[arrayA.Length];
PrintArray(arrayA);
Console.WriteLine();
NewArray(arrayA, arrayB);
PrintArray(arrayB);

void NewArray(string[] arr, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[count] = arr[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
