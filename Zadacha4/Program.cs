int[] Fibonachi (int n, int n1, int n2)
{
    int[] array = new int [n];
    int i = 2;
    array[0] = n1;
    array[1] = n2;
    while(i < n) {array[i]= array[i - 1] + array [i - 2]; i++;}
    return array;
}

void PrintMas (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


PrintMas(Fibonachi(10, 3, 2));