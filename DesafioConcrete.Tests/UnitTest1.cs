using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DesafioConcrete.Core;

namespace DesafioConcrete.Tests
{
    /// <summary>
    /// Métodos de teste da Fábrica
    /// </summary>
    [TestClass]
    public class ObjectFactoryTests
    {
        /// <summary>
        /// Testa a Fábrica de Usuário (teste sem muita sofisticação)
        /// </summary>
        [TestMethod]
        public void FactoryTest()
        {
            var random = new Bogus.Randomizer();
            var person = new Bogus.Person(locale: "pt_BR");

            var usuarioNovo = ObjectFactory.CriarUsuario(Guid.NewGuid(), person.FirstName, person.Email, 123456.ToString());
            usuarioNovo.AdicionarTelefone("21", person.Phone);

            Assert.AreEqual(person.FirstName, usuarioNovo.nome);
            Assert.AreEqual(person.Email, usuarioNovo.email);
            Assert.AreEqual(person.Phone, usuarioNovo.Telefones[0].numero);
            Assert.AreEqual("21", usuarioNovo.Telefones[0].ddd);

        }
    }
}
