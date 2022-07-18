string PerevodChisla (int num)
{
    string result = string.Empty;
    while(num >= 1)
    {
        result = num %2 + result; 
        num /= 2;
    }
    return result;
}


Console.WriteLine(PerevodChisla(10));