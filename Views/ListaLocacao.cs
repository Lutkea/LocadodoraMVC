using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Views{
    public class ListaLocacao : Form {
                   
        ListView ListLocacao;
        Button btCancela;
        Form parent;

        public ListaLocacao (Form parent){

        this.Text = "Lista de Locações";
        this.Size = new Size (400, 500);
        this.parent = parent;

        ListLocacao = new ListView();
        ListLocacao.Location = new Point (15, 20);
        ListLocacao.Size = new Size (350, 350);
        // ListFilme.View = View.Details;
        this.Controls.Add(ListLocacao);
       
       ListLocacao.View = View.Details;
            foreach (Locacao locacao in LocacaoController.locacoes()){
            ListViewItem locacoes = new ListViewItem(locacao.LocacaoId.ToString());
            locacoes.SubItems.Add(locacao.ClienteId.ToString());
            locacoes.SubItems.Add(locacao.FilmeId.ToString());
            locacoes.SubItems.Add(locacao.DataLocacao.ToString());
            ListLocacao.Items.Add(locacoes);
            }

            ListLocacao.Columns.Add("Locação ID: ", -2, HorizontalAlignment.Left);
            ListLocacao.Columns.Add("Cliente ID: ", -2, HorizontalAlignment.Left);
            ListLocacao.Columns.Add("Filme ID: ", -2, HorizontalAlignment.Left);
            ListLocacao.Columns.Add("Data Locação: ", -2, HorizontalAlignment.Left);
            this.Controls.Add(ListLocacao);

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




