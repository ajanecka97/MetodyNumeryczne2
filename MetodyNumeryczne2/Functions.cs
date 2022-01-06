namespace MetodyNumeryczne2
{
    public static class Functions
    {
        public static double Polynomial(double x)
        {
            return 2 * x * x + 5 * x - 6;
        }

        public static double DoubleSin(double x)
        {
            return 2 * Math.Sin(x);
        }

        public static double SinCos(double x)
        {
            return Math.Sin(x) * Math.Cos(x);
        }

        public static double TripleExp(double x)
        {
            return 3 * Math.Exp(x);
        }

        public static double Const(double x)
        {
            return 5;
        }
    }
}
