string?[] ReadArrayString()
{
    Console.Write("Укажите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string?[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        arr[i] = Console.ReadLine();
    }
    return arr;
}


string?[] Arr = ReadArrayString();
Console.WriteLine($"{string.Join(", ", Arr)}");

