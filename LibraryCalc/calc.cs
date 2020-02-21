using System;

namespace LibraryCalc
{
    public class calc
    {
        public static double Somma (double a, double b)
        {
            double ris = (a+b);
            return ris;
        }
        
        public static double divisione(double a, double b)
        {
            double ris = 0;
            if (b != 0)
                ris = a / b;
            else ris = double.NaN;
                    return ris;

        }
    }
}
