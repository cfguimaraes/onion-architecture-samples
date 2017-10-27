using System;

namespace Onion.Entities.Contracts
{
    public abstract class Promocao
    {
        public Promocao(Guid promocaoId)
        {
            PromocaoId = promocaoId;
        }

        public Guid PromocaoId { get; }
        public abstract decimal Calcular(Produto produto, int quantidade);
    }
}