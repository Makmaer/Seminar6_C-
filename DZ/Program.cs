
int[] VvodMas(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите число № {i + 1} ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double[] VvodUravnenia(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите число № {i + 1} ");
        array[i] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
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

void PrintUravn(double[] array)
{
      
    Console.Write("y = " + array [0]+ " * x + "+ array[1] );
    Console.WriteLine("y = " + array [2]+ " * x + "+ array[3] );
}

int KolPositivChisel(int[] array)
{
    int schetchik = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) schetchik++;
    }
    return schetchik;
}

//Задача 41: 
//Пользователь вводит с клавиатуры n чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*Console.WriteLine("Введите кол-во чисел для ввода:");
int kol = Convert.ToInt32(Console.ReadLine());
int[] mas = VvodMas(kol);
PrintMas(mas);
Console.WriteLine("Кол-во положительных чисел = " + KolPositivChisel(mas));
*/

//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] mas = VvodUravnenia(4);
PrintUravn(mas);


