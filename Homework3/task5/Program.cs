int cnt = 0;
int a = Convert.ToInt32(Console.ReadLine());
int DigitSum(int a)
{
    if (a == 0)
    return 0;
    else 
    {
        cnt++;
        DigitSum(a / 10);
        return cnt;
    }
}
System.Console.WriteLine(DigitSum(a));