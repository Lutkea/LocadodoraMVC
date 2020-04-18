using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repositories;
using System.Linq;

namespace Models
{
    public class Locacao
    {      
            [Key]
            public int LocacaoId { get; set; }
            [Required]
            public Cliente Cliente { get; set; }
            public Filme Filme { get; set; }
            public DateTime DataLocacao { get; set; }

            public List<Filme> filmes { get; set;}

            public Locacao(){

        }
    
         public Locacao(int idlocacao, Cliente cliente, Filme filme, DateTime datalocacao) {
            LocacaoId = idlocacao;
            Cliente = cliente;
            Filme = filme;
            DataLocacao = datalocacao;    

            var db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();     
        }

            public static List<Locacao> Locacacoes(){
                var db = new Context();
                return db.Locacoes.ToList();
                }
              
         public override string ToString(){
            return $"{LocacaoId} - {Cliente}- {Filme}- {DataLocacao}";
        }
    }

}