using System;
using Week7.NuovoProject.Test.Core;

namespace Week7.NuovoProject.Test.Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            double risultato =0;
            Console.WriteLine("Calcolatrice!");
            Console.WriteLine("Inserisci due numeri");
            Console.Write("Primo Numero=");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Secondo Numero=");
            double numero2 = double.Parse(Console.ReadLine());
            Console.Write("Scegli l'operazione da svolgere:");

            char choice;

            do
            {
                Console.WriteLine("Premi 1 per addizione");
                Console.WriteLine("Premi 2 per sottrazione");
                Console.WriteLine("Premi 3 per moltiplicazione");
                Console.WriteLine("Premi 4 per divisione");
                
                Console.WriteLine("Premi Q per uscire");

                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        Addizione();
                        Console.WriteLine($"L'addizione da risolvere è: {numero1} + {numero2} = {risultato}");
                        break;
                    case '2':
                        Sottrazione();
                        Console.WriteLine();
                        break;
                    case '3':
                        Moltiplicazione();
                        Console.WriteLine();
                        break;
                    case '4':
                        Divisione();
                        Console.WriteLine();
                        break;
                   
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile");
                        break;
                }
            }
            while (!(choice == 'Q'));


            Calcolatrice calcoloAddizione = new Calcolatrice();
            double risultatoAddizione = calcoloAddizione.RisolviAddizione(numero1, numero2);


            Calcolatrice calcoloSottrazione = new Calcolatrice();
            double risultatoSottrazione = calcoloAddizione.RisolviSottrazione(numero1, numero2);

            

            Calcolatrice calcoloMoltiplicazione = new Calcolatrice();
            double risultatoMoltiplicazione = calcoloMoltiplicazione.RisolviMoltiplicazione(numero1, numero2);

            Calcolatrice calcoloDivione = new Calcolatrice();
            double risultatoDivisione = calcoloAddizione.RisolviDivisione(numero1, numero2);

        }





        private static void Divisione()
        {
            throw new NotImplementedException();
        }

        private static void Moltiplicazione()
        {
            throw new NotImplementedException();
        }

        private static void Sottrazione()
        {
            throw new NotImplementedException();
        }

        private static void Addizione()
        {
            
            
        }
    }
}
