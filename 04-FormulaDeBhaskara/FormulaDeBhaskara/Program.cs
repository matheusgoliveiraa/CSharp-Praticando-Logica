﻿using System.Globalization;

double a, b, c, delta, r1, r2;

a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

delta = Math.Pow(b, 2.0) - 4 * a * c;

if (a == 0 || delta < 0.0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    {
        r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
        r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
        Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
        Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
    }

    Console.ReadLine();
}
