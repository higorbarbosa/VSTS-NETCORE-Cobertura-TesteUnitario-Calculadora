using System;
using Xunit;

namespace Calculadora.TesteUnitario
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar_Test()
        {
            var _operacao = new Operacoes();
            Assert.Equal(3, _operacao.Somar(1, 2));
        }

        [Fact]
        public void Diminuir_Test()
        {
            var _operacao = new Operacoes();
            Assert.Equal(4, _operacao.Diminuir(6, 2));
        }

        [Fact]
        public void Dividir_Test()
        {
            var _operacao = new Operacoes();
            Assert.Equal(2, _operacao.Dividir(4, 2));
        }

        [Fact]
        public void Multiplicar_Test()
        {
            var _operacao = new Operacoes();
            Assert.Equal(10, _operacao.Multiplicar(5, 2));
        }
    }

}
