static class zad3
{
    public static void Run()
    {
        Double x = -2.235*Math.Pow(10,-2);
        Double y = 2.23;
        Double z = 15.221;
        Double q = (Math.Exp(Math.Abs(x-y)) * Math.Pow(Math.Abs(x - y),x+y)) / (Math.Atan(x) + Math.Atan(z)) + Math.Pow(Math.Pow(x,6)+Math.Pow(Math.Log(y),2),1.0/3.0);
        Console.WriteLine($"q={q}");
    }
}