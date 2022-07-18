int[] RandomMas(int size, int ot, int doo)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(ot, doo + 1);
    }
    return array;
}

void PrintMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] PerevorotMas(int[] array)
{
    int i = 0; int buf = 0; int j = array.Length - 1;
    while (i < array.Length / 2) { buf = array[i]; array[i] = array[j]; array[j] = buf; i++; j--; }
    return array;
}

int[] mas = RandomMas(10, 0, 10);
PrintMas(mas);
PrintMas(PerevorotMas(mas));