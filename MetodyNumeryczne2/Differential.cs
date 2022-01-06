namespace MetodyNumeryczne2
{
    public static class Differential
    {
        public static double DiffR(double x, double h, Func<double, double> fun)
        {
            return (fun(x + h) - fun(x)) / h;
        }

        public static double DiffL(double x, double h, Func<double, double> fun)
        {
            return (fun(x) - fun(x - h)) / h;
        }

        public static double DiffC(double x, double h, Func<double, double> fun)
        {
            return (fun(x + h) - fun(x - h)) / (2 * h);
        }

    }
}
