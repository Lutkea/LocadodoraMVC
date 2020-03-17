using System;
using System.Collections.Generic;
using Repositorios;

namespace Models
{
    public class Filme
    {      
            public int IdFilme { get; set; }
            public String Nome { get; set; }
            public String Sinopse { get; set; }
            public String AnoLancamento { get; set; }
            public int Valor{ get; set; }
    
         public Filme(int Id, string nome, String sinopse,string anolanc,  int valor) {
            IdFilme = Id;
            Nome = nome;
            Sinopse = sinopse;
            AnoLancamento = anolanc;
            Valor = valor;

            RepositoryFilme.addFilme(this);     
        }
        // Retorna os filmes
                public static List<Filme> Filmes(){
                return RepositoryFilme.Filmes();
                }
        // Retorna na consulta        
                public override string ToString(){
                return $"{IdFilme} - {Nome} - {Sinopse}";
                }
        }
}