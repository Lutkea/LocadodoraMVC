using System.Collections.Generic;
using Models;

namespace Controllers {
    //: é uma interface permite instanciacao de atributos
    public class FilmeController{
        public static List<Filme> filme(){
            return Filme.Filmes();
        }
        public static void addFilme(int id, string nome,string sinopse, string anolanc, int valor){
            new Filme(id, nome, anolanc, sinopse, valor);
        }
    }
}