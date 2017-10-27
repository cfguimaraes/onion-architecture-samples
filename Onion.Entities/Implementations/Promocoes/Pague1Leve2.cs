using System;
using Onion.Entities.Contracts;

namespace Onion.Entities.Implementations.Promocoes
{
    public class Pague1Leve2 : Promocao
    {
        public Pague1Leve2()
        {
            this.PromocaoId = new Constants.Promocoes().Pague1Leve2;
        }

        public override decimal Calcular(Produto produto, int quantidade)
        {
            int paraCada2ProdutosCobrar1 = (quantidade / 2);
            var valorTotal = produto.Preco * paraCada2ProdutosCobrar1;

            if (quantidade % 2 == 1)
            {
                // Não há especificação se deve ou não alertar o cliente sobre a promoção,
                // portanto não será aplicada nenhuma regra.
                valorTotal += produto.Preco;
            }
            return valorTotal;
        }
    }
}