namespace MetodyNumeryczne2
{
    public static class Integral
    {
        public static double Rectangle(double x1, double x2, double n, Func<double, double> fun)
        {
            double res = 0;
            double h = Math.Abs(x1 - x2) / n;
            double x = Math.Min(x1, x2);
            for (int i = 0; i < n; i++)
            {
                res += fun(x) * h;
                x += h;
            }
            return res;
        }

        public static double Trapezium(double x1, double x2, double n, Func<double, double> fun)
        {
            double res = 0;
            double h = Math.Abs(x1 - x2) / n;
            double x = Math.Min(x1, x2);
            for(int i = 0; i < n; i++)
            {
                res += (fun(x) + fun(x + h)) / 2 * h;
                x += h;
            }
            return res;
        }

        public static double Simpson(double x1, double x2, double n, Func<double, double> fun)
        {
            double res = 0;
            double h = Math.Abs(x1 - x2) / n;
            double x = Math.Min(x1, x2);
            for (int i = 0; i < n; i++)
            {
                res += (1.0/6)*h*(fun(x) + 4*fun(0.5 * x + h) + fun(x + h));
                x += h;
            }
            return res;
        }
    }
}
