using System;

namespace Onion.Entities
{
    public class Produto
    {
        public Produto(Guid id, string identificador, string nome, decimal preco)
        {
            Id = id;
            Identificador = identificador;
            Nome = nome;
            Preco = preco;
        }
        //Esse é o identificador interno, exclusívo
        public Guid Id { get;private set; }    
        //Esse é o identificador que o usuário informa
        public string Identificador {  get;private set; }
        public string Nome { get;private set; }
        public decimal Preco { get;private set; }
    }
}