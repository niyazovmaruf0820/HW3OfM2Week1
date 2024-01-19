int Sum(int a)
{
    if (a == 1)
    return 1;
    else return a + Sum(a - 1);
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(a));