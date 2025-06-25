using CalcolatriceLibreria;
namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, "La somma di 2 e 3 dovrebbe essere 5");
        }

        [TestMethod]
        public void TestSommaConZero()
        {
            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(0, 3);
            // sbagliato!!!
            Assert.AreEqual(4, risultato, "La somma di 0 e 3 dovrebbe essere 5");
        }

        [TestMethod]
        public void TestSommaTanteSomme()
        {
            for(int i = 0; i < 100; i++)
            {
                // creo due numeri casuali ed eseguo il test
                Random random = new Random();
                double x = random.NextDouble() * 100; // Numero casuale tra 0 e 100
                double y = random.NextDouble() * 100; // Numero casuale tra 0 e 100
                Calcolatrice calcolatrice = new Calcolatrice();
                double risultato = calcolatrice.Somma(x, y);
                Assert.AreEqual(x + y, risultato, $"La somma di {x} e {y} dovrebbe essere {x + y}");
            }
        }
    }
}
