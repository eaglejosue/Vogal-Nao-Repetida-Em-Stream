using Microsoft.VisualStudio.TestTools.UnitTesting;
using VogalNaoRepetidaEmStream;

namespace Testes
{
    [TestClass]
    public class VogalNaoRepetidaEmStreamTeste
    {
        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida1()
        {
            var streamInput = "aAbBABacfe";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual('e', vogal);
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida2()
        {
            var streamInput = "bBaBcidroswufe";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual('a', vogal);
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida3()
        {
            var streamInput = "bHunUjiMIkolpexOdr";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual('e', vogal);
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida4()
        {
            var streamInput = "aAbBABiacfe";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual('i', vogal);
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida5()
        {
            var streamInput = "aAbBABaocfe";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual('o', vogal);
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida6()
        {
            var streamInput = "aAbBABaucfe";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual('u', vogal);
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida7()
        {
            var streamInput = "sderEtDIvAgBiHju";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual("A", vogal.ToString().ToUpper());
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida8()
        {
            var streamInput = "rabumEnbsdAjhkUjsf";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual("E", vogal.ToString().ToUpper());
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida9()
        {
            var streamInput = "qwehEjkladsIfBnAeRweu";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual("I", vogal.ToString().ToUpper());
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida10()
        {
            var streamInput = "aBcDhAjYiOQwErtIy";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual("O", vogal.ToString().ToUpper());
        }

        [TestMethod]
        public void EncontraPrimeiraVogalNaoRepetida11()
        {
            var streamInput = "aBcDhAjYUoiOQwErty";
            var vogal = new EncontraPrimeiraVogalNaoRepetida().Encontra(new PrimeiroCaracterNaoRepetido(streamInput));

            Assert.AreEqual("U", vogal.ToString().ToUpper());
        }
    }
}
