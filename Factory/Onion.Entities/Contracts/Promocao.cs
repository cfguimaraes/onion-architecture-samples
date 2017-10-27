using System;

namespace Onion.Entities.Contracts
{
    public abstract class Promocao
    {
        public Promocao()
        {
            
        }

        public Guid PromocaoId { get;protected set; }
        public abstract decimal Calcular(Produto produto, int quantidade);
    }
}