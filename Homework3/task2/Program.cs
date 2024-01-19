void Nums(int a)
{
    if (a == 0)
    return;
    System.Console.WriteLine(a);
    Nums(a - 1);
}
int a = Convert.ToInt32(Console.ReadLine());
Nums(a);
