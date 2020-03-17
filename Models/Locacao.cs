using System;
using System.Collections.Generic;
using Repositorios;

namespace Models
{
    public class Locacao
    {      
            public int IdLocacao { get; set; }
            public Cliente Cliente { get; set; }
            public Filme Filme { get; set; }
            public DateTime DataLocacao { get; set; }

            public List<Filme> filmes { get; set;}
    
         public Locacao(int idlocacao, Cliente cliente, Filme filme, DateTime datalocacao) {
            IdLocacao = idlocacao;
            Cliente = cliente;
            Filme = filme;
            DataLocacao = datalocacao;    

            RepositoryLocacao.addlocacoes(this);     
        }
                public static List<Locacao> Locacoes(){
                return RepositoryLocacao.Locacoes();
                }

         public override string ToString(){
            return $"{IdLocacao} - {Cliente}- {Filme}- {DataLocacao}";
        }
    }

}