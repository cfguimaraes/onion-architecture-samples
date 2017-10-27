using System;

namespace Onion.Entities
{
    public class Produto
    {
        public Produto(Guid id, string identificador, string nome, decimal preco, Guid? promocaoId)
        {
            Id = id;
            Identificador = identificador;
            Nome = nome;
            Preco = preco;
            PromocaoId = promocaoId;
        }
        //Esse é o identificador interno, exclusívo
        public Guid Id { get; }    
        //Esse é o identificador que o usuário informa
        public string Identificador {  get; }
        public string Nome { get;}
        public decimal Preco { get;}
        public Guid? PromocaoId { get; }
    }
}