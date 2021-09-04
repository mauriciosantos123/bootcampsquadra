using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squadra.Bootcamp.DesafioFinal.Controllers;
using Xunit;

namespace Squadra.Bootcamp.teste
{
   public  class FuncoesMatematicaTeste
    {
        [Fact]
        public void Soma_DeveRetornarOValorCorreto()
        {
            FuncaoMatematica c = new();
            var resultado = c.Somar(10, 20);
            //Verifica se o resultado é igual a 30        
            Assert.Equal(30, resultado);
        }

        [Theory]
        [InlineData(1 , 2, 0.5)]
        [InlineData(2, 2, 1)]
        [InlineData(10 ,5, 2)]
        public void RestoDivisao_DeveRetornarZero(int valor_1 ,int valor_2,int total)
        {
            FuncaoMatematica c = new ();
            var resultado = c.Dividir(valor_1, valor_2);
            //Verifica se o resto da divisão é 0
            Assert.Equal(total, resultado) ;
        }
    }
}
