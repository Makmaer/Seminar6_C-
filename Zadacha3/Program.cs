bool Treugolnik(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}
Console.WriteLine(Treugolnik(4, 2, 3));