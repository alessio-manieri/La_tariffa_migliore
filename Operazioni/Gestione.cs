using System;

namespace Operazioni
{
    public class Gestione
    {
        public static double tariffaNumero1(int ore, double valoreTariffa)
        {
            double valoreTot = 15;
            return valoreTot;
        }
        
        public static double tariffaNumero2(int ore, double valoreTariffa)
        {
            double valoreTot = ore + valoreTariffa;
            return valoreTot;
        }

        public static double tariffaNumero3(int ore, double valoreTariffa)
        {
            double costoTot = 0;
            if (ore == 0)
            {
                costoTot = 0;
            }
            else
            {
                costoTot = (ore - 1) * valoreTariffa;
            }
            return costoTot;
        }
    }
}
