using System;
using System.Collections.Generic;
using Models;
using View;

//simular banco de dados
namespace Repositorios{
    public class RepositoryFilme{
//lista tipo model.filme que chama filme
        private static List<Models.Filme> filmes = new List<Models.Filme>();
//metodo que retorna a lista filmes
        public static List<Models.Filme> Filmes(){
            return filmes;
        }
//metodo que adiciona filme na lista
        public static void addFilme(Models.Filme filme){
            filmes.Add(filme);
        }
    }
}