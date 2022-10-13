int lenStr = 4;
int lenArr = 3;
string[] ReadArrayString()
{
    Console.Write($"Укажите количество строк, которые хотите ввести: ");
    int n;
    try
    {
        n = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        n = lenArr;
        Console.WriteLine($"Вы ввели не число, по умолчанию число строк {n}.");
    }
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        arr[i] = Console.ReadLine();
    }
return arr;
}


string[] ArrayStringLenght(string[] arr)
{
    string[] newArr = new String[0];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < lenStr)
        {
            Array.Resize(ref newArr, j + 1);
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}


string[] Arr = ReadArrayString();
string[] NewArr = ArrayStringLenght(Arr);
Console.WriteLine($"Выборка массива строк с длинной не более {lenStr - 1}");
Console.WriteLine($"{string.Join(", ", NewArr)}");
