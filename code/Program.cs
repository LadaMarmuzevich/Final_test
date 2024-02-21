Console.WriteLine("Введите элементы массива через запятую:");
string[] inputArray  = Console.ReadLine().Split(',');

Console.WriteLine($"Конечный массив: [{string.Join(", ", FilterArray(inputArray))}]");

static string[] FilterArray(string[] inputArray)
{
    int count = 0;
    foreach (string item in inputArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int index = 0;
    foreach (string item in inputArray)
    {
        if (item.Length <= 3)
        {
            newArray[index] = item;
            index++;
        }
    }

    return newArray;
}
