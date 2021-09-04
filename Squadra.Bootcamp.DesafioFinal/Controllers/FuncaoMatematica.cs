using System;

namespace Squadra.Bootcamp.DesafioFinal.Controllers
{
    public class FuncaoMatematica
    {
        public double Somar(double valor_1, double valor_2) => valor_1 + valor_2;
        public double Dividir(double valor_1, double valor_2)
        {
            try
            {
                if (valor_1.Equals(0) || valor_2.Equals(0))
                    throw new NotImplementedException("O valor não pode ser divido por zero !");
                return valor_1 / valor_2;
            }
            catch (System.Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public double Multiplicar(double valor_1, double valor_2) => valor_1 * valor_2;

        public double Subitrair(double valor_1, double valor_2) => valor_1 - valor_2;
    }
}
