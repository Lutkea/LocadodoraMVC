using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View{
    public class ViewFilme {
        public static void AddFilme(){
            FilmeController.addFilme(1,"Peixe Grande e Suas Histórias Maravilhosas", "2019", "Contar Histórias", 5);
            FilmeController.addFilme(2,"Olhos Grandes", "2019", "Mulher artista, resista", 10);
            FilmeController.addFilme(3,"Star Wars", "1990", "Uns loucos no espaço arrumando briga", 21);
            FilmeController.addFilme(4, "Bacurau", "2019", "Filme brasileiro maravilhoso", 30);
            FilmeController.addFilme(5, "A orfã", "2002", "História sobre uma suposta criança bem maluca", 3);
            FilmeController.addFilme(6, "Coringa", "2019", "Assim que nasce o coronga", 10);
            FilmeController.addFilme(7, "Anabelle", "2018", "Boneca possuída", 5);
            FilmeController.addFilme(8, "Parasita", "2019", "Ganhou o oscar", 10);
            FilmeController.addFilme(9, "O grito", "1999", "Muita gente gritando", 1);
            FilmeController.addFilme(10, "Frozen", "2020", "Imagem do fim da terra, paredão de gelo", 15);

                IEnumerable FilmeQuery = 
                from Filme in FilmeController.filme()
                where Filme.FilmeId > 5
                select Filme;
             
            foreach (Filme filme in FilmeQuery)
            {
                Console.WriteLine(filme.Nome);
                Console.WriteLine(filme.Sinopse);
            }
        }
    }
}
