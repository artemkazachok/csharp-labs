Double K;
do
{
    Console.Write("¬ведите K: ");
    K = Double.Parse(Console.ReadLine());
    if (K < -1)
    {
        Console.WriteLine("K должен быть больше -1");
    }
} while (K < -1);
Double P = 1.0;
for (int j = -1; j <= K; j++)
{
    Double Prov = 0;
    if(j == 4)
    {
        continue;
    }
    for (int i = j; i <= K + 2; i++)
    {
        if(i == 7)
        {
            continue;
        }
        Prov += Math.Cbrt(Math.Abs(i - 5)) / (Math.Abs(i - 7));
    }
    Double sum = (((j - Math.Pow(j, 2)) * K) / (j - 4)) * Prov;
    P *= sum;
}
Console.WriteLine($"P = {P}");
