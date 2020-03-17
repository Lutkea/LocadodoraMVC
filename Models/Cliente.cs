using System;
using System.Collections.Generic;
using Repositorios;

namespace Models
{
    public class Cliente
    {      
            public int IdCLiente { get; set; }
            public String Nome { get; set; }
            public String Cpf { get; set; }
            public String DtNasc { get; set; }
            public int DiasDevolucao;
    
         public Cliente(int Id, string nome, string cpf, String dtNasc, int diasDevolucao) {
            IdCLiente = Id;
            Nome = nome;
            Cpf = cpf;
            DtNasc = dtNasc;
            DiasDevolucao = diasDevolucao;

            RepositorioCliente.addCliente(this);     
        }
                public static List<Cliente> Clientes(){
                return RepositorioCliente.Clientes();
                }

         public override string ToString(){
            return $"{IdCLiente} - {Nome}";
        }
    }

}