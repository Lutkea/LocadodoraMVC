using System;
using System.Collections.Generic;
using Models;
using View;

//simular banco de dados
namespace Repositorios{
    public class RepositorioCliente{
//lista tipo model.funcionarios que chama funcionario
        private static List<Models.Cliente> clientes = new List<Models.Cliente>();
//metodo que retorna a lista funcionarios
        public static List<Models.Cliente> Clientes(){
            return clientes;
        }
//metodo que adiciona funcionario na lista
        public static void addCliente(Models.Cliente cliente){
            clientes.Add(cliente);
        }
    }
}