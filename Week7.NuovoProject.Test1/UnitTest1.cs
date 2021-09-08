using System;
using Week7.NuovoProject.Test.Core;
using Xunit;

namespace Week7.NuovoProject.Test1
{
    public class UnitTest1
    { // test x ogni metodo: somma/sottrazione ecc..
        
        
        
        [Fact]
        public void Testaddizione()
        {
            //arrange
            Calcolatrice testCalcoloAddizione = new Calcolatrice();


            //ACT
            double risultato = testCalcoloAddizione.RisolviAddizione(1, 3);


            //ASSERT
           
            Assert.True(risultato == 4);


        }

        [Fact]
        public void TestSottrazione()
        {
            //arrange
            Calcolatrice testCalcoloSottrazione = new Calcolatrice();


            //ACT

            double risultato = testCalcoloSottrazione.RisolviSottrazione(6, 3);

            //ASSERT
            Assert.True(risultato == 3 );

        }


        [Fact]
        public void TestMoltiplicazione()
        {
            //arrange
            Calcolatrice testCalcoloAddizione = new Calcolatrice();


            //ACT



            //ASSERT


        }

        [Fact]
        public void TestDivisione()
        {
            //arrange
            Calcolatrice testCalcoloAddizione = new Calcolatrice();


            //ACT



            //ASSERT


        }

        //[Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            Calcolatrice testMaggioreDiB = new Calcolatrice(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                        //ACT: chiamata alla funzionalità da testare
            bool risultato = testMaggioreDiB.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            Calcolatrice testMaggioreDiB2 = new Calcolatrice(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                               //ACT: chiamata alla funzionalità da testare
            bool risultato = testMaggioreDiB2.VerificaSeAMaggioreDiB2(3.2, 3.2);
            
            
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

    }



   
}
