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
            public int ClienteId { get; set; }
            [Required]
            public int FilmeId { get; set; }
            public Cliente Cliente { get; set; }
            public Filme Filme { get; set; }
            public DateTime DataLocacao { get; set; }

            public List<Filme> filmes { get; set;}

            public Locacao(){

        }
    
         public Locacao(int idlocacao, Cliente cliente, Filme filme, DateTime datalocacao) {
            LocacaoId = idlocacao;
            ClienteId = cliente.ClienteId;
            FilmeId = filme.FilmeId;
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