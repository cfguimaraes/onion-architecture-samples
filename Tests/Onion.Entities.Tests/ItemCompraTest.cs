using Microsoft.VisualStudio.TestTools.UnitTesting;
using Onion.Entities;
using Onion.Entities.Implementations.Promocoes;
using System;

namespace Onion.Entities.Tests
{
    [TestClass]
    public class ItemCompraTest
    {

      [TestMethod]  
      public void Deve_Retornar_10_Para_Promocao_3Por10_Com_3_Itens_Inseridos(){
          // Arrange
            var id= Guid.NewGuid();
            var identificador = "A";
            var descricao = "Molho de tomate, 100gr";
            var preco = 1.8M;
            var promocaoId = new Constants.Promocoes()._3Por10;

            var produto = new Produto(
                id,
                identificador,
                descricao,
                preco,
                promocaoId
            );

          var itemCompra = new ItemCompra(3,produto);
          
          // Act

          // Assert
          Assert.AreEqual(3, itemCompra.Quantidade);
          Assert.AreEqual(produto, itemCompra.Produto);
          Assert.AreEqual(10, itemCompra.ValorTotal);
      }

      
    }
}