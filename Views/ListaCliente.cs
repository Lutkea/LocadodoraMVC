using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Views{
    public class ListaCliente : Form {
        
        ListView listaCliente;
        Button btCancela;
        Form parent;

        public ListaCliente (Form parent){

        this.Text = "Lista de Clientes";
        this.Size = new Size (400, 500);
        this.parent = parent;

        listaCliente = new ListView();
        listaCliente.Location = new Point (15, 20);
        listaCliente.Size = new Size (350, 350);
        
        listaCliente.View = View.Details;
        foreach (Cliente clientes in ClienteController.cliente()){
            ListViewItem cliente = new ListViewItem(clientes.Nome);
            cliente.SubItems.Add(clientes.DtNasc);
            cliente.SubItems.Add(clientes.Cpf);
            listaCliente.Items.Add(cliente);
        }

        listaCliente.Columns.Add("Nome: ", -2, HorizontalAlignment.Left);
        listaCliente.Columns.Add("CPF: ", -2, HorizontalAlignment.Left);
        listaCliente.Columns.Add("Data de Nascimento: ", -2, HorizontalAlignment.Left);
        this.Controls.Add(listaCliente);
        btCancela = new Button();
        btCancela.Text = "Sair";
        btCancela.Location = new Point(15, 370);
        btCancela.Click += new EventHandler(btCancelaClick);
        this.Controls.Add(btCancela);

        }
            private void btCancelaClick(object sender, EventArgs e){
                this.Close();
                this.parent.Show();
            }
    }
}

