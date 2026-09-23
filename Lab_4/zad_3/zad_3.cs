double min = 0;
double max = 100;
Random rand = new Random();
double[,] A = new double[4, 4];
for(int i = 0;  i < 4; i++)
{
    for(int j = 0; j < 4; j++)
    {
        A[i, j] = Math.Round(min + rand.NextDouble() * (max - min),1);
    }
}
double[] min_mat = new double[4];
for(int j = 0; j < 4; j++)
{
    double line_min = A[0,j];
    for (int i = 0; i < 4; i++)
    {
        if (A[i,j] < line_min)
        {
            line_min = A[i,j];
        }
    }
    min_mat[j] = line_min;
}
double all_min_prov = 1;
for(int i = 0; i < 4; i++)
{
    all_min_prov *= min_mat[i];
}
all_min_prov = Math.Round(all_min_prov, 2);
for(int i = 0; i < 4; i++)
{
    for(int j = 0;j < 4; j++)
    {
        Console.Write($"{A[i,j]}\t");
    }
    Console.WriteLine('\n');
}
Console.WriteLine($"Произведение наименьших элементов каждого столбца: {all_min_prov}");