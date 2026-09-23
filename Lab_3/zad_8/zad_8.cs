
for(double x = -1; x <= 3; x+=0.2)
{
    double y = 0;
    if(x > 1.5)
    {
        y = x;
    }
    else if(0 <= x && x <= 1.5)
    {
        y = 2 * Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(2 * x)));
    }
    else if(x < 0)
    {
        y = Math.Exp(-Math.Cos(3 * x));
    }
    Console.WriteLine($"Y при X {x:F2} равен: {y:F2}");
}