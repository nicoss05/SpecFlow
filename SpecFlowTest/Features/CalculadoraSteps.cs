using Matematica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowTest.Features
{
    [Binding]
    public class CalculadoraSteps
    {
        Calculadora calculadora = new Calculadora();

        [Given(@"que el primer número es (.*)")]
        public void DadoQueElPrimerNumeroEs(float numero)
        {
            calculadora.PrimerNumero = numero;
        }
        
        [Given(@"el segundo número es (.*)")]
        public void DadoElSegundoNumeroEs(int numero)
        {
            calculadora.SegundoNumero = numero;
        }
        
        [When(@"los dos números son sumados")]
        public void CuandoLosDosNumerosSonSumados()
        {
            calculadora.Sumar();
        }

        [When(@"los dos números son restados")]
        public void CuandoLosDosNumerosSonRestados()
        {
            calculadora.Restar();
        }

        [Then(@"el resultado debe ser (.*)")]
        public void EntoncesElResultadoDebeSer(int esperado)
        {
            Assert.AreEqual(esperado, calculadora.Resultado);
        }

        [When(@"se calcula la función escalonada")]
        public void CuandoSeCalculaLaFuncionEscalonada()
        {
            calculadora.Escalonada();
        }

       
    }
}
