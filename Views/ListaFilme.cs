using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Views{
    public class ListaFilme : Form {
                   
        ListView ListFilme;
        Button btCancela;
        Form parent;

        public ListaFilme (Form parent){

            this.Text = "Lista de Filmes";
            this.Size = new Size (400, 500);
            this.parent = parent;

            ListFilme = new ListView();
            ListFilme.Location = new Point (15, 20);
            ListFilme.Size = new Size (350, 350);
            // ListFilme.View = View.Details;
            this.Controls.Add(ListFilme);
        
            ListFilme.View = View.Details;
            foreach (Filme filmes in FilmeController.filme()){
            ListViewItem filme = new ListViewItem(filmes.Nome);
            filme.SubItems.Add(filmes.Sinopse);
            filme.SubItems.Add(filmes.AnoLancamento);
            ListFilme.Items.Add(filme);
        }

            ListFilme.Columns.Add("Filmes: ", -2, HorizontalAlignment.Left);
            ListFilme.Columns.Add("Sinopse: ", -2, HorizontalAlignment.Left);
            ListFilme.Columns.Add("Ano de Lançamento: ", -2, HorizontalAlignment.Left);
            this.Controls.Add(ListFilme);
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
