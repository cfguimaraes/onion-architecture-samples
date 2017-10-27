using System;
using Onion.Entities.Contracts;
using Onion.Entities.Implementations.Promocoes;

namespace Onion.Entities
{
    public class ItemCompra
    {
        private readonly Constants.Promocoes PromocaoConstant = new Constants.Promocoes();

        public ItemCompra(int quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
            Promocao = FactoryPromocao(produto.PromocaoId);
        }
        public int Quantidade { get; }
        public Produto Produto { get; }
        public Promocao Promocao { get; }
        public decimal ValorTotal => Promocao.Calcular(this.Produto, this.Quantidade);


        private Promocao FactoryPromocao(Guid? PromocaoID)
        {
            if (!PromocaoID.HasValue)
            {
                return new PromocaoNaoAplicavel();
            }

            if (PromocaoID == this.PromocaoConstant._3Por10)
                return new _3Por10();


            throw new ArgumentException("Não foi possível identificar uma promoção para o item");
        }


        // Inner Class privada para não permitir instâncias fora do domínio desse objeto
        private class PromocaoNaoAplicavel : Promocao
        {
            public PromocaoNaoAplicavel() : base(Guid.Empty)
            {
            }

            // Como não há promoção a ser aplicada o valor calculado é o produto da quantidade pelo preço do próprio produto
            public override decimal Calcular(Produto produto, int quantidade)
            {
                return produto.Preco * quantidade;
            }
        }
    }

}