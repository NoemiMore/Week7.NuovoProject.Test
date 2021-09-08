using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week7.NuovoProject.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomma()
        { // test x ogni metodo: somma/sottrazione ecc..


            //arrange
            Calcolatrice testCalcoloAddizione = new Calcolatrice();



            Addizione addizione = new Addizione();

            double  risultato= addizione.RisolviAddizione( numero1, numero2)
        }
    }
}
