string[] ReadArrayString()
{
    Console.Write("Укажите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
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
        if (arr[i].Length < 4)
        {
            Array.Resize(ref newArr, j+1);
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}


string[] Arr = ReadArrayString();
string[] NewArr = ArrayStringLenght(Arr);
Console.WriteLine($"{string.Join(", ", NewArr)}");
