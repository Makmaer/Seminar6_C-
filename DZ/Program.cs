
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
    string[] peremennay = {"k1", "b1", "k2", "b2"};
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите  { peremennay[i] } : ");
        array[i] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
    }
    return array;
}

double[] IntersectionPoints( double[] array)
{
    double[] rezult = new double[2];
    rezult[0] = (array[3]-array[1])/(array[0]-array[2]);
    rezult[1] = (array[0]*rezult[0]+array[1]);
    return rezult;
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
    Console.WriteLine("Первая прямая: y = " + array [0]+ " * x + "+ array[1] );
    Console.WriteLine("Вторая прямая: y = " + array [2]+ " * x + "+ array[3] );
}

void PrintTochkiPeresech(double[] array)
{
    Console.WriteLine("Координаты точки пересечения прямых : " );
    Console.WriteLine(" y = " + array[0] );
    Console.WriteLine(" х = " + array[1] );
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

Console.WriteLine("Даны две прямые, заданные уравнениями:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
double[] mas = VvodUravnenia(4);
PrintUravn(mas);
if(mas[0] == mas[2] && mas[1] == mas[3]) System.Console.WriteLine("Все точки обеих прямых совпадают");
else if(mas[0] == mas[2]) System.Console.WriteLine("Прямые параллельны, а значит не имеют общих точек");
else PrintTochkiPeresech(IntersectionPoints(mas));

