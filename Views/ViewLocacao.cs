using System;
using Models;
using Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace View{
    public class ViewLocacao {
        public static void Addlocacoes(){
            List<Cliente> clientes = ClienteController.cliente();
            List<Filme> filmes = FilmeController.filme();

            LocacaoController.addlocacoes(1, clientes.Find(cliente => cliente.ClienteId == 1), filmes.Find( filme => filme.FilmeId == 1), new DateTime(2020,03,10) );
            LocacaoController.addlocacoes(2,clientes.Find(cliente => cliente.ClienteId == 2), filmes.Find( filme => filme.FilmeId == 3), new DateTime(2020,02,01) );
            LocacaoController.addlocacoes(3,clientes.Find(cliente => cliente.ClienteId == 3), filmes.Find( filme => filme.FilmeId == 2), new DateTime(2020,01,01) );
            LocacaoController.addlocacoes(4, clientes.Find(cliente => cliente.ClienteId == 4), filmes.Find( filme => filme.FilmeId == 9), new DateTime(2020,01,10) );
            LocacaoController.addlocacoes(5, clientes.Find(cliente => cliente.ClienteId == 5), filmes.Find( filme => filme.FilmeId == 6), new DateTime(2020,01,20) );
            LocacaoController.addlocacoes(6,clientes.Find(cliente => cliente.ClienteId == 6), filmes.Find( filme => filme.FilmeId == 10), new DateTime(2019,12,12) );
            LocacaoController.addlocacoes(7, clientes.Find(cliente => cliente.ClienteId == 7), filmes.Find( filme => filme.FilmeId == 8), new DateTime(2020,02,28) );
            LocacaoController.addlocacoes(8, clientes.Find(cliente => cliente.ClienteId == 8), filmes.Find( filme => filme.FilmeId == 4), new DateTime(2020,02,02) );
            LocacaoController.addlocacoes(9, clientes.Find(cliente => cliente.ClienteId == 9), filmes.Find( filme => filme.FilmeId == 5), new DateTime(2020,03,16) );
            LocacaoController.addlocacoes(10,clientes.Find(cliente => cliente.ClienteId == 10), filmes.Find( filme => filme.FilmeId == 7), new DateTime(2020,02,21) );

            
                IEnumerable LocQuery = 
                from Locacao in LocacaoController.locacoes()
                where Locacao.LocacaoId > 1
                select Locacao;
                   
            foreach (Locacao locacao in LocQuery)
            {
                Console.WriteLine(locacao.LocacaoId);
                Console.WriteLine(locacao.Cliente);
            }
        }
    }
}
