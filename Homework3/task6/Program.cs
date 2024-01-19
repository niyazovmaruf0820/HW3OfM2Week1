void EvenNumber(int a, int b)
{
    if (a % 2 == 0)
    {
        if (a > b) return;
        else
        {
            System.Console.Write(a + " ");
            EvenNumber(a + 2, b);
        }
    }
    else
    {
        if (a > b) return;
        else EvenNumber(a + 1, b);
    }

}
void OddNumber(int a, int b)
{
    if (a % 2 != 0)
    {
        if (a > b) return; 
        else
        {
            System.Console.Write(a + " ");
            OddNumber(a + 2, b);
        }
    }
    else
    {
        if (a > b) return;

        else OddNumber(a + 1, b);
    }
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"All even numbers from {a} to {b} are :");
EvenNumber(a, b);
System.Console.WriteLine();
System.Console.WriteLine($"All odd numbers from {a} to {b} are :");
OddNumber(a, b);