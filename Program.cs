using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> prod = new List <Produto>()
            {
                new Produto{idproduto = 1, nomeproduto="Lápis", preco=2, idfornecedor=30},
                new Produto{idproduto = 2, nomeproduto="Borracha", preco=5, idfornecedor=41},
                new Produto{idproduto = 3, nomeproduto="Caneta", preco=6, idfornecedor=30},
                new Produto{idproduto = 4, nomeproduto="Caderno", preco=20, idfornecedor=51},
            };

            List<Fornecedor> forn = new List <Fornecedor>()
            {
                new Fornecedor{idfornecedor = 30, RazaoSocial="Faber Castel", telefone="119988"},
                new Fornecedor{idfornecedor = 41, RazaoSocial="Bic", telefone="119977"},
                new Fornecedor{idfornecedor = 51, RazaoSocial="Chameco", telefone="119966"}
            };
            
        }
    }
}
