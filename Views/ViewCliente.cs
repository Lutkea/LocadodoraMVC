using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View{
    public class ViewCliente {
        public static void AddCliente(){
            ClienteController.addCliente(1,"Amanda Amandinha", "19/10/2001", "123.456.789.00", 3);
            ClienteController.addCliente(2,"Julia Juliana", "12/01/1998", "997.544.541-85", 1);
            ClienteController.addCliente(3,"Roberta Justas", "15/02/1985", "124.845.985-54", 2);
            ClienteController.addCliente(4,"Rosalia Malía", "02/08/1970", "654.842.943-00", 3);
            ClienteController.addCliente(5,"Maria José", "03/08/1988", "452.874.523-03", 4);

            IEnumerable ClienteQuery = 
                from Cliente in ClienteController.cliente()
                where Cliente.ClienteId > 1
                select Cliente;
            
            foreach (Cliente cliente in ClienteQuery)
            {
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.Cpf);
            }
        }
    }
}