using System;
using View;

namespace LocadodoraMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            View.ViewCliente.AddCliente();
            View.ViewFilme.AddFilme();

            int op =0;
            do{
                Console.WriteLine("BlockBuster Ads!");
                Console.WriteLine ("+-----------------------------------------+");
                Console.WriteLine ("|           BlockBuster Ads!              |");
                Console.WriteLine ("|Escolha a opção desejada:                |");
                Console.WriteLine ("| 1 - Consultar Clientes                  |");
                Console.WriteLine ("| 2 - Consultar Filmes                    |");
                Console.WriteLine ("| 3 - Consultar Cliente e Filmes locados  |");
                Console.WriteLine ("| 0 - Sair                                |");
                Console.WriteLine ("+-----------------------------------------+");
                try {
                    op = Convert.ToInt32(Console.ReadLine());
                } catch {
                Console.WriteLine ("Digite uma opção");
                op = 99;
                }
                switch (op)
                {
                    case 1:{
                        Console.WriteLine("Consultar Cliente");
                        View.ViewCliente.Cliente();
                        break;
                    }
                    case 2:{
                        Console.WriteLine("Consultar Filme");
                        View.ViewFilme.Filme();
                        Console.WriteLine("\n");
                        break;
                    }
                    case 3:{
                        Console.WriteLine("Consultar Cliente e Filmes locados ");
                        break;
                    }
                    case 0:{
                        Console.WriteLine("Sair");
                        break;
                    }

                    default:{
                        Console.WriteLine("\nNÚMERO INVÁLIDO\n ");
                        break;
                    }
                }
            }while(op!=0);  
        }
    }
}  