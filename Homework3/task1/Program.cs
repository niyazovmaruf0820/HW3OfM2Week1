void Nums(int a)
{
    if (a == 0)
    return;
    Nums(a - 1);
    System.Console.WriteLine(a);
}
int a = Convert.ToInt32(Console.ReadLine());
Nums(a);