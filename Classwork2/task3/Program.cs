int Fact(int a)
{
    if (a <= 1)
    return 1;
    else return a * Fact(a - 1);
}
System.Console.WriteLine(Fact(5));
