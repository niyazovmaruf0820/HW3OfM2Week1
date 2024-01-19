int Fibonachi(int a)
{
    if (a == 0) return 0;
    else if (a == 1 || a == 2)
    return 1;
    else return Fibonachi(a - 1) + Fibonachi(a - 2);
}
System.Console.WriteLine(Fibonachi(6));