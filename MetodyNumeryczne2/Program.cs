// See https://aka.ms/new-console-template for more information

using MetodyNumeryczne2;

const double ARG = 3;
const double ARG2 = 8;

Console.WriteLine("RÓŻNICZKOWANIE: ");
Console.WriteLine("Stała: ");
for (double i = 1; i > 0; i -= 0.05)
{
    Console.WriteLine("Krok: {0:0.000}\t R: {1:0.000}\t L: {2:0.000}\t C: {3:0.000}",
        i,
        Differential.DiffR(ARG, i, Functions.Const),
        Differential.DiffL(ARG, i, Functions.Const),
        Differential.DiffC(ARG, i, Functions.Const));
}
Console.WriteLine(" --- ");
Console.WriteLine("Wielomian: ");
for (double i = 1; i > 0; i -= 0.05)
{
    Console.WriteLine("Krok: {0:0.000}\t R: {1:0.000}\t L: {2:0.000}\t C: {3:0.000}",
        i,
        Differential.DiffR(ARG, i, Functions.Polynomial),
        Differential.DiffL(ARG, i, Functions.Polynomial),
        Differential.DiffC(ARG, i, Functions.Polynomial));
}
Console.WriteLine(" --- ");
Console.WriteLine("Funkcja trygonometryczna: ");
for (double i = 1; i > 0; i -= 0.05)
{
    Console.WriteLine("Krok: {0:0.000}\t R: {1:0.000}\t L: {2:0.000}\t C: {3:0.000}",
        i,
        Differential.DiffR(ARG, i, Functions.DoubleSin),
        Differential.DiffL(ARG, i, Functions.DoubleSin),
        Differential.DiffC(ARG, i, Functions.DoubleSin));
}
Console.WriteLine(" --- ");
Console.WriteLine("Splot funkcji trygonometrycznych: ");
for (double i = 1; i > 0; i -= 0.05)
{
    Console.WriteLine("Krok: {0:0.000}\t R: {1:0.000}\t L: {2:0.000}\t C: {3:0.000}",
        i,
        Differential.DiffR(ARG, i, Functions.SinCos),
        Differential.DiffL(ARG, i, Functions.SinCos),
        Differential.DiffC(ARG, i, Functions.SinCos));
}
Console.WriteLine(" --- ");
Console.WriteLine("Funkcja wykładnicza: ");
for (double i = 1; i > 0; i -= 0.05)
{
    Console.WriteLine("Krok: {0:0.000}\t R: {1:0.000}\t L: {2:0.000}\t C: {3:0.000}",
        i,
        Differential.DiffR(ARG, i, Functions.TripleExp),
        Differential.DiffL(ARG, i, Functions.TripleExp),
        Differential.DiffC(ARG, i, Functions.TripleExp));
}
Console.WriteLine(" --- \n\n ");



Console.WriteLine("Całkowanie: ");
Console.WriteLine("Stała (25): ");
for (double i = 5; i < 100; i++)
{
    Console.WriteLine("Krok: {0}\t R: {1:0.000}\t T: {2:0.000}\t S: {3:0.000}",
        i,
        Integral.Rectangle(ARG, ARG2, i, Functions.Const),
        Integral.Trapezium(ARG, ARG2, i, Functions.Const),
        Integral.Simpson(ARG, ARG2, i, Functions.Const));
}
Console.WriteLine(" --- ");
Console.WriteLine("Wielomian (~430.83): ");
for (double i = 5; i < 100; i++)
{
    Console.WriteLine("Krok: {0}\t R: {1:0.000}\t T: {2:0.000}\t S: {3:0.000}",
        i,
        Integral.Rectangle(ARG, ARG2, i, Functions.Polynomial),
        Integral.Trapezium(ARG, ARG2, i, Functions.Polynomial),
        Integral.Simpson(ARG, ARG2, i, Functions.Polynomial));
}
Console.WriteLine(" --- ");
Console.WriteLine("Funkcja trygonometryczna (-1.689): ");
for (double i = 5; i < 100; i++)
{
    Console.WriteLine("Krok: {0}\t R: {1:0.000}\t T: {2:0.000}\t S: {3:0.000}",
        i,
        Integral.Rectangle(ARG, ARG2, i, Functions.DoubleSin),
        Integral.Trapezium(ARG, ARG2, i, Functions.DoubleSin),
        Integral.Simpson(ARG, ARG2, i, Functions.DoubleSin));
}
Console.WriteLine(" --- ");
Console.WriteLine("Splot funkcji trygonometrycznych (0.479): ");
for (double i = 5; i < 100; i++)
{
    Console.WriteLine("Krok: {0}\t R: {1:0.000}\t T: {2:0.000}\t S: {3:0.000}",
        i,
        Integral.Rectangle(ARG, ARG2, i, Functions.SinCos),
        Integral.Trapezium(ARG, ARG2, i, Functions.SinCos),
        Integral.Simpson(ARG, ARG2, i, Functions.SinCos));
}
Console.WriteLine(" --- ");
Console.WriteLine("Funkcja wykładnicza (8882.617): ");
for (double i = 5; i < 100; i++)
{
    Console.WriteLine("Krok: {0}\t R: {1:0.000}\t T: {2:0.000}\t S: {3:0.000}",
        i,
        Integral.Rectangle(ARG, ARG2, i, Functions.TripleExp),
        Integral.Trapezium(ARG, ARG2, i, Functions.TripleExp),
        Integral.Simpson(ARG, ARG2, i, Functions.TripleExp));
}
Console.WriteLine(" --- \n\n ");