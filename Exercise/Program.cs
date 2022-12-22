Console.WriteLine("Введите что-нибудь: ");
string x = Console.ReadLine();
string[] rows = x.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

int[] NewArray(string[] arr)
{
    int[] ammoutOfSymbols = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        ammoutOfSymbols[i] = arr[i].Length;
    }
    return ammoutOfSymbols;
}

void PrintNewArray(int[] arr, string[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= 3)
        {
            Console.Write($"{arr1[i]} ");
        }
    }
    Console.WriteLine();
}

NewArray(rows);
Console.WriteLine("Массив из элементов, длина которых меньше или равна 3 символам:");
PrintNewArray(NewArray(rows), rows);