using System;
using Views;
using System.Windows.Forms;
using System.Drawing;

namespace LocadodoraMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());
        
        }
    }
        public class Formulario : Form {
        
        Label lbConsulta;
        Label lbCadastra;
        Button btnListaCliente;
        Button btnListaFilmes;
        Button btnListaLocacao;
        Button btCadastraCliente;
        Button btSair;

        public Formulario(){

            this.Text = "Blockbuster Ads!";
            this.Size = new Size (270, 370);

            lbConsulta = new Label();
            lbConsulta.Text = "Consulta";
            lbConsulta.Location = new Point(95,5);
            this.Controls.Add(lbConsulta);

            btnListaCliente = new Button();
            btnListaCliente.Text = "Listar Clientes";
            btnListaCliente.Location = new Point(95, 45);
            btnListaCliente.Size = new Size (100,20);
            btnListaCliente.Click += new EventHandler (btnListaClienteClick);
            this.Controls.Add(btnListaCliente);

            btnListaFilmes = new Button();
            btnListaFilmes.Text = "Listar Filmes";
            btnListaFilmes.Location = new Point(95, 65);
            btnListaFilmes.Size = new Size (100,20);
            btnListaFilmes.Click += new EventHandler (btnListaFilmesClick);
            this.Controls.Add(btnListaFilmes);

            btnListaLocacao = new Button();
            btnListaLocacao.Text = "Listar Locações";
            btnListaLocacao.Location = new Point(95, 84);
            btnListaLocacao.Size = new Size (100,20);
            btnListaLocacao.Click += new EventHandler (btnListaLocacaoClick);
            this.Controls.Add(btnListaLocacao);

            lbCadastra = new Label();
            lbCadastra.Text = "Cadastro";
            lbCadastra.Location = new Point(95,130);
            this.Controls.Add(lbCadastra);

            btCadastraCliente = new Button();
            btCadastraCliente.Text = "Cadastrar Cliente";
            btCadastraCliente.Location = new Point(95, 180);
            btCadastraCliente.Size = new Size(130, 20);
            btCadastraCliente.Click += new EventHandler (btCadastraClienteClick);
            this.Controls.Add(btCadastraCliente);

            btSair = new Button();
            btSair.Text = "Sair";
            btSair.Location = new Point(130, 300);
            btSair.Click += new EventHandler(btSairClick);
            this.Controls.Add(btSair);
        } 

            private void btCadastraClienteClick(object sender, EventArgs e)
            {
                CadastraCliente cadastrarCliente = new CadastraCliente(this);
                cadastrarCliente.Show();
                this.Hide();
            }
            private void btnListaClienteClick(object sender, EventArgs e)
            {
                ListaCliente listaCliente = new ListaCliente(this);
                listaCliente.Show();
                this.Hide();
            }
            private void btnListaFilmesClick(object sender, EventArgs e)
            {
                ListaFilme listaFilme = new ListaFilme(this);
                listaFilme.Show();
                this.Hide();
            }
            private void btnListaLocacaoClick(object sender, EventArgs e)
            {
                ListaLocacao listaLocacao = new ListaLocacao(this);
                listaLocacao.Show();
                this.Hide();
            }
            
            private void btSairClick(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
