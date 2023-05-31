int Start(string messege)
{
    System.Console.WriteLine(messege);
    // string value = System.Console.ReadLine();
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FillArray(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Start($"Введите {i + 1}-й элемент массива");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"элемент[{i}] = {arr[i]}");
    }
}

int SearchPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int lenght = Start("Введите количество элементов в массиве: ");
int[] arr;
arr = FillArray(lenght);
PrintArray(arr);
System.Console.WriteLine($"Колличество элементов > 0: {SearchPositiveNumbers(arr)}");

