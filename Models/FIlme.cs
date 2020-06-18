using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repositories;
using System.Linq;

namespace Models
{
    public class Filme
    {
            [Key]           
            public int FilmeId { get; set; }
            [Required]
            public String Nome { get; set; }
            [Required]
            public String Sinopse { get; set; }
            public String AnoLancamento { get; set; }
            public int Valor{ get; set; }
        
        public Filme(){

        }
         public Filme(int Id, string nome, String sinopse,string anolanc,  int valor){{
            FilmeId = Id;
            Nome = nome;
            Sinopse = sinopse;
            AnoLancamento = anolanc;
            Valor = valor;

            var db = new Context();
            db.Filmes.Add(this);
            db.SaveChanges();
        }      
        }      
        // Retorna os filmes
                public static List<Filme> Filmes(){
                var db = new Context();
                return db.Filmes.ToList();
                }
        // Retorna na consulta        
                public override string ToString(){
                return $"{FilmeId} - {Nome} - {Sinopse}";
                }
        }
}