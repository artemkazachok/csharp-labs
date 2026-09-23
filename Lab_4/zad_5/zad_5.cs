int[,] mas = new int[3, 3];
Random rand = new Random();
for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        mas[i, j] = rand.Next(1,100);
    }
}
int sum_strok = 999999999, sum = 0;
for(int i = 0; i < 3; i++)
{
    sum = 0;
    for(int j = 0; j < 3; j++)
    {
        sum += mas[i, j];
    }
    if(sum < sum_strok)
    {
        sum_strok = sum;
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine('\n');
}
for(int i = 0; i < 3;i++)
{
    for(int j = 0; j < 3; j++)
    {
        mas[i, j] *= sum_strok;
    }
}
Console.WriteLine($"Минимальная сумма одной строки: {sum_strok}");
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine('\n');
}
