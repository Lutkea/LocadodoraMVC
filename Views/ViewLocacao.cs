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

            LocacaoController.addlocacoes(1, clientes.Find(cliente => cliente.IdCLiente == 1), filmes.Find( filme => filme.IdFilme == 1), new DateTime(2020,03,10) );
            LocacaoController.addlocacoes(2,clientes.Find(cliente => cliente.IdCLiente == 2), filmes.Find( filme => filme.IdFilme == 3), new DateTime(2020,02,01) );
            LocacaoController.addlocacoes(3,clientes.Find(cliente => cliente.IdCLiente == 3), filmes.Find( filme => filme.IdFilme == 2), new DateTime(2020,01,01) );
            LocacaoController.addlocacoes(4, clientes.Find(cliente => cliente.IdCLiente == 4), filmes.Find( filme => filme.IdFilme == 9), new DateTime(2020,01,10) );
            LocacaoController.addlocacoes(5, clientes.Find(cliente => cliente.IdCLiente == 5), filmes.Find( filme => filme.IdFilme == 6), new DateTime(2020,01,20) );
            LocacaoController.addlocacoes(6,clientes.Find(cliente => cliente.IdCLiente == 6), filmes.Find( filme => filme.IdFilme == 10), new DateTime(2019,12,12) );
            LocacaoController.addlocacoes(7, clientes.Find(cliente => cliente.IdCLiente == 7), filmes.Find( filme => filme.IdFilme == 8), new DateTime(2020,02,28) );
            LocacaoController.addlocacoes(8, clientes.Find(cliente => cliente.IdCLiente == 8), filmes.Find( filme => filme.IdFilme == 4), new DateTime(2020,02,02) );
            LocacaoController.addlocacoes(9, clientes.Find(cliente => cliente.IdCLiente == 9), filmes.Find( filme => filme.IdFilme == 5), new DateTime(2020,03,16) );
            LocacaoController.addlocacoes(10,clientes.Find(cliente => cliente.IdCLiente == 10), filmes.Find( filme => filme.IdFilme == 7), new DateTime(2020,02,21) );

            
                IEnumerable LocQuery = 
                from Locacao in LocacaoController.locacoes()
                where Locacao.IdLocacao > 1
                select Locacao;
                   
            foreach (Locacao locacao in LocQuery)
            {
                Console.WriteLine(locacao.IdLocacao);
                Console.WriteLine(locacao.Cliente);
            }
        }
    }
}
