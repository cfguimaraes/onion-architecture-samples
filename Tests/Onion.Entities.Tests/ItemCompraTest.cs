using Microsoft.VisualStudio.TestTools.UnitTesting;
using Onion.Entities;
using Onion.Entities.Implementations.Promocoes;
using System;

namespace Onion.Entities.Tests
{
    [TestClass]
    public class ItemCompraTest
    {
private readonly Constants.Promocoes PromocoesConstants =  new Constants.Promocoes();

      [TestMethod]  
      public void Deve_Retornar_10_Para_Promocao_3Por10_Com_3_Itens_Inseridos(){
          // Arrange
            var id= Guid.NewGuid();
            var identificador = "A";
            var descricao = "Molho de tomate, 100gr";
            var preco = 1.8M;
            var promocaoId = this.PromocoesConstants._3Por10;

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

      [TestMethod]  
      public void Deve_Retornar_5_Para_Promocao_Pague1Leve2_Com_2_Itens_Inseridos_E_Valor_Unitario_5(){
          // Arrange
            var id= Guid.NewGuid();
            var identificador = "A";
            var descricao = "Molho de tomate, 100gr";
            var preco = 5M;
            var promocaoId = this.PromocoesConstants.Pague1Leve2;

            var produto = new Produto(
                id,
                identificador,
                descricao,
                preco,
                promocaoId
            );

          var itemCompra = new ItemCompra(2,produto);
          
          // Act

          // Assert
          Assert.AreEqual(2, itemCompra.Quantidade);
          Assert.AreEqual(produto, itemCompra.Produto);
          Assert.AreEqual(5, itemCompra.ValorTotal);
      }
      
      [TestMethod]  
      public void Deve_Retornar_10_Para_Promocao_Pague1Leve2_Com_3_Itens_Inseridos_E_Valor_Unitario_5(){
          // Arrange
            var id= Guid.NewGuid();
            var identificador = "A";
            var descricao = "Molho de tomate, 100gr";
            var preco = 5M;
            var promocaoId = this.PromocoesConstants.Pague1Leve2;

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
          Assert.AreEqual(3, itemCompra.Quantidade, "Quantidade ímpares deveriam adicionar o valor unitário do produto");
          Assert.AreEqual(produto, itemCompra.Produto);
          Assert.AreEqual(10, itemCompra.ValorTotal);
      }
      
      
      [TestMethod]  
      public void Deve_Retornar_10_Para_Produto_Sem_Promocao_Com_2_Itens_Inseridos_E_Valor_Unitario_5(){
          // Arrange
            var id= Guid.NewGuid();
            var identificador = "A";
            var descricao = "Molho de tomate, 100gr";
            var preco = 5M;

            var produto = new Produto(
                id,
                identificador,
                descricao,
                preco,
                null
            );

          var itemCompra = new ItemCompra(2,produto);
          
          // Act

          // Assert
          Assert.AreEqual(2, itemCompra.Quantidade);
          Assert.AreEqual(produto, itemCompra.Produto);
          Assert.AreEqual(10, itemCompra.ValorTotal);
      }
      


    }
}