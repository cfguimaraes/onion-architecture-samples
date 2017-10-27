using Microsoft.VisualStudio.TestTools.UnitTesting;
using Onion.Entities;
using System;

namespace Onion.Entities.Tests
{
    [TestClass]
    public class  ProdutoTest
    {
        [TestMethod]
        public void DeveInicializarProdutoAtravesDoCTOR()
        {
            // Arrange
            var id= Guid.NewGuid();
            var identificador = "A";
            var descricao = "Molho de tomate, 100gr";
            var preco = 1.8M;
            var promocaoId = Guid.NewGuid();

            // Act
            var produto = new Produto(
                id,
                identificador,
                descricao,
                preco,
                promocaoId
            );

            // Assert
            Assert.AreEqual(id, produto.Id);
            Assert.AreEqual(identificador, produto.Identificador);
            Assert.AreEqual(descricao, produto.Nome);
            Assert.AreEqual(preco, produto.Preco);
            Assert.AreEqual(promocaoId, produto.PromocaoId);
        }
    }
}
