using System.Collections.Generic;
using Models;

namespace Controllers {
    //: é uma interface permite instanciacao de atributos
    public class ClienteController{
        public static List<Cliente> cliente(){
            return Cliente.Clientes();
        }
        public static void addCliente(int id, string nome, string cpf, string dtNasc, int diasDevolucao){
            new Cliente (id, nome, cpf, dtNasc,diasDevolucao);
        }
    }
}