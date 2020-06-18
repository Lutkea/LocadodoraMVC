using System.Collections.Generic;
using Models;

namespace Controllers {
    //: é uma interface permite instanciacao de atributos
    public class ClienteController{
        public static List<Cliente> cliente(){
            return Cliente.Clientes();
        }
        public static void addCliente(string nome, string cpf, string dtNasc, int diasDevolucao){
            new Cliente (nome, cpf, dtNasc,diasDevolucao);
        }
    }
}