using System;
using Onion.Entities.Contracts;

namespace Onion.Entities.Implementations.Promocoes
{
    public class _3Por10 : Promocao
    {
        public _3Por10() : base(new Constants.Promocoes()._3Por10)
        {
        }

        public override decimal Calcular(Produto produto, int quantidade)
        {
            var resultadoDaDivisao = quantidade / 3;
            var restoDaDivisao = quantidade % 3;

            var valorTotal = 10M * resultadoDaDivisao;
            valorTotal += restoDaDivisao * produto.Preco;
            return valorTotal;
        }
    }
}