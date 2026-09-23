double[] mas = new double[16];
Random rand = new Random();
double min = 0, max = 1000;
for (int i = 0; i < 16; i++)
{ 
    mas[i] = min + rand.NextDouble() * (max - min);
}
int index_max = 0;
int index_min = 0;
for(int i = 0;i < 16;i++)
{
    if (mas[i] > mas[index_max])
    {
        index_max = i;
    }
    if (mas[i]  < mas[index_min])
    {
        index_min = i;
    }
}
Console.WriteLine($"Максимальное число: {mas[index_max]:F1}\nЕго индекс: {index_max}\nМинимальное число: {mas[index_min]:F1}\nЕго индекс: {index_min}");