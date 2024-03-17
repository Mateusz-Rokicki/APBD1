// See https://aka.ms/new-console-template for more information

int[] tab = { 1, 2, 3, 4, 5 };
Console.WriteLine("Average:"+Average(tab));



static double Average(int[] tab)
{
    double sum = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sum+=tab[i];
    }
    return sum/tab.Length;
}