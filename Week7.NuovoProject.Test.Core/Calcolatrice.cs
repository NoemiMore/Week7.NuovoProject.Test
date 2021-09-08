using System;

namespace Week7.NuovoProject.Test.Core
{
    public class Calcolatrice
    {
        public double RisolviAddizione(double numero1, double numero2)
        { double risAddizione = numero1 + numero2;
            
                return risAddizione; }

        public double RisolviSottrazione(double numero1, double numero2)
        {
            double risSottrazione = numero1 - numero2;
            
            return risSottrazione;

        }


        public double RisolviMoltiplicazione(double numero1, double numero2)
        {
            double risMoltiplicazione = numero1 * numero2;
            
            return risMoltiplicazione;
        }

        public double RisolviDivisione (double numero1, double numero2)
        {
            double? risDivisione = numero1 / numero2;

            return risDivisione;

            
        }

        public double VerificaSeAMaggioreDiB(double numero1, double numero2)
        {
            double verificaMagB = numero1 > numero2;
            double risultato;

            if (numero1 > numero2)
            { Console.WriteLine("La moltiplicazione è uguale a 0"); }
            risultato = verificaMagB;
            return risultato;
        }

        public double VerificaSeAMaggioreDiB2 (double numero1, double numero2)
        {
            double verificaMagB = numero1 > numero2;
            double risultato;

            if (numero1 > numero2)
            { Console.WriteLine("La moltiplicazione è uguale a 0"); }
            risultato = verificaMagB;
            return risultato;
        }
    }
}
