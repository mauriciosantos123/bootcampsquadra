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
            Assert.Equal(30, resultado);
        }

        [Theory]
        [InlineData(1 , 2, 0.5)]
        [InlineData(2, 2, 1)]
        [InlineData(10 ,5, 2)]
        public void Divisao_DeveRetornarValorCorreto(int valor_1 ,int valor_2,int total)
        {
            FuncaoMatematica c = new ();
            var resultado = c.Dividir(valor_1, valor_2);
            Assert.Equal(total, resultado) ;
        }

        [Theory]
        [InlineData(1, 3, 1)]
        [InlineData(2, 2, 0)]
        [InlineData(10, 5, 5)]
        public void Subitracao_TrazerValorCorreto(int valor_1, int valor_2, int total)
        {
            FuncaoMatematica c = new();
            var resultado = c.Subitrair(valor_1, valor_2);
            Assert.Equal(total, resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 2, 0)]
        [InlineData(10, 5, 50)]
        public void Multiplicacao_trazerValorCorreto(int valor_1, int valor_2, int total)
        {
            FuncaoMatematica c = new();
            var resultado = c.Multiplicar(valor_1, valor_2);
            Assert.Equal(total, resultado);
        }
    }
}
