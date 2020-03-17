using System.Collections.Generic;
using Models;
using System;

namespace Controllers {
    //: é uma interface permite instanciacao de atributos
    public class LocacaoController
    {
        public static List<Locacao> locacoes(){
            return Locacao.Locacoes();
        }
        public static void addlocacoes(int idlocacao, Cliente cliente, Filme filme, DateTime datalocacao){
            new Locacao(idlocacao, cliente, filme, datalocacao);
        }    
        
    }
}

