using System;
using System.Collections.Generic;
using Repositories;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models
{
    public class Cliente
    {      
            [Key]
            public int ClienteId { get; set; }
            [Required]
            public String Nome { get; set; }
            [Required]
            public String Cpf { get; set; }
            [Required]
            public String DtNasc { get; set; }
            public int DiasDevolucao;

            public Cliente(){

            }

         public Cliente (string nome, string cpf, String dtNasc, int diasDevolucao){{
            Nome = nome;
            Cpf = cpf;
            DtNasc = dtNasc;
            DiasDevolucao = diasDevolucao;

            var db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        }
        }
                public static List<Cliente> Clientes(){
                var db = new Context();
                return db.Clientes.ToList();
                }

         public override string ToString(){
            return $"{ClienteId} - {Nome}";
        }
    }
}