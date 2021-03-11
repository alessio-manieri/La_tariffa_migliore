using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace IlParcheggio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TariffaNumero1()
        {
            int tempo = 5;
            double tariffa = 15;
            double risposta_aspettata = 15;
            double risposta_effettiva = Gestione.tariffaNumero1(tempo, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }

        [TestMethod]
        public void TariffaNumero2()
        {
            int tempo = 5;
            double tariffa = 1;
            double risposta_aspettata = 5;
            double risposta_effettiva = Gestione.tariffaNumero2(tempo, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }

        [TestMethod]
        public void TariffaNumero3()
        {
            int tempo = 2;
            double tariffa = 1.20;
            double risposta_aspettata = 1.20;
            double risposta_effettiva = Gestione.tariffaNumero3(tempo, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }
    }
}
