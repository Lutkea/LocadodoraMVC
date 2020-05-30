using System;
using System.Collections.Generic;

//simular banco de dados
namespace Repositorios{
    public class RepositorioCliente{
//lista tipo model.cliente que chama cliente
        private static List<Models.Cliente> clientes = new List<Models.Cliente>();
//metodo que retorna a lista cliente
        public static List<Models.Cliente> Clientes(){
            return clientes;
        }
//metodo que adiciona cliente na lista
        public static void addCliente(Models.Cliente cliente){
            clientes.Add(cliente);
        }
    }
}