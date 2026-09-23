Console.WriteLine("¬ведите пор€док матрицы: ");
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
int[,] mat = new int[n, n];
int number = 1;
int up = 0, down = n - 1, left = 0, right = n - 1;
while (number <= n * n)
{
    for(int i = left; i <= right; i++)
    {
        mat[up,i] = number++;
    }
    up++;
    for(int i = up; i <= down; i++)
    {
        mat[i,right] = number++;
    }
    right--;
    for(int i = right; i >= left; i--)
    {
        mat[down, i] = number++;
    }
    down--;
    for(int i = down; i >= up; i--)
    {
        mat[i, left] = number++;
    }
    left++;
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{mat[i, j]}\t");
    }
    Console.WriteLine('\n');
}