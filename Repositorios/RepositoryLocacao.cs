using System;
using System.Collections.Generic;

//simular banco de dados
namespace Repositorios{
    public class RepositoryLocacao{
//lista tipo model.locacao que chama locacao
        private static List<Models.Locacao> locacoes = new List<Models.Locacao>();
//metodo que retorna a lista locacoes
        public static List<Models.Locacao> Locacoes(){
            return locacoes;
        }
//metodo que adiciona locacao na lista
        public static void addlocacoes(Models.Locacao locacao){
            locacoes.Add(locacao);
        }
    }
}