using System.Collections.Generic;
using TestesUnitarios.Desafio.Console.Services;
using Xunit;

namespace TestesUnitarios.Lista.Tests
{
    // Testes de Lista
    public class ValidacoesListaTests
    {
        private readonly ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void Deve_RemoverNumerosNegativos_DeUmaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Deve_ConterONumero9_NaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 9;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeve_ConterONumero10_NaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Deve_MultiplicarOsElementosDaLista_Por2()
        {
            // Arrange
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

            // Act
            var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Deve_Retornar9_ComoMaiorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void Deve_RetornarOitoNegativo_ComoMenorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-8, resultado);
        }
    }
}
