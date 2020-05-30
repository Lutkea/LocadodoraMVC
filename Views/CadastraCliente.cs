using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Views{
    public class CadastraCliente : Form {
        string dtNasc;
        Label label;
        Label lblNome;
        TextBox txtNome;
        Label lb_Dtnasc;
        Label lb_CPF;
        Label lb_Diasdev;
        NumericUpDown numDtNascDia;
        NumericUpDown numDtNascMes;
        NumericUpDown numDtNascAno;
        MaskedTextBox txCPF;
        ComboBox cbDiasdev;
        CheckBox chbAtivo;
        RadioButton rbMasc;
        RadioButton rbFemin;
        RadioButton rbOutro;
        LinkLabel helpLink;
        Button btnConfirma;
        Button btnCancela;

        public CadastraCliente(){
            
            this.Text = "Cadastro de Cliente";
            this.Size = new Size (400, 500);
        
            label = new Label();
            label.Text = "Informações";
            label.Location = new Point(20,5);
            this.Controls.Add(label);

            lblNome = new Label();
            lblNome.Text = "Insira seu nome";
            lblNome.Location = new Point(20,25);
            this.Controls.Add(lblNome);

            lb_Dtnasc = new Label();
            lb_Dtnasc.Text = "Data de Nascimento: ";
            lb_Dtnasc.AutoSize = true;
            lb_Dtnasc.Location = new Point(20, 65);
            this.Controls.Add(lb_Dtnasc);

            lb_CPF = new Label();
            lb_CPF.Text = "CPF: ";
            lb_CPF.Location = new Point(20, 105);
            this.Controls.Add(lb_CPF);

            lb_Diasdev = new Label();
            lb_Diasdev.Text = "Dias de Devolução: ";
            lb_Diasdev.AutoSize = true;
            lb_Diasdev.Location = new Point(20, 145);
            this.Controls.Add(lb_Diasdev);

            // Numeric Up Down 
            numDtNascDia = new NumericUpDown();
            numDtNascDia.Location = new Point(180,60);
            numDtNascDia.Size = new Size (50, 65);
            numDtNascDia.Maximum = 31;
            numDtNascDia.Minimum = 1;
            numDtNascDia.Increment = 1;
            this.Controls.Add(numDtNascDia);

            numDtNascMes = new NumericUpDown();
            numDtNascMes.Location = new Point(240,60);
            numDtNascMes.Size = new Size (50, 65);
            numDtNascMes.Maximum = 12;
            numDtNascMes.Minimum = 1;
            numDtNascMes.Increment = 1;
            this.Controls.Add(numDtNascMes);

            numDtNascAno = new NumericUpDown();
            numDtNascAno.Location = new Point(300,60);
            numDtNascAno.Size = new Size (50, 75);
            numDtNascAno.Maximum = 2002;
            numDtNascAno.Minimum = 1950;
            numDtNascAno.Increment = 10;
            this.Controls.Add(numDtNascAno);

            txtNome = new TextBox();
            txtNome.Location = new Point(180, 30);
            txtNome.Size = new Size(100, 20);
            this.Controls.Add(txtNome);

            // Masked
            txCPF = new MaskedTextBox();
            txCPF.Location = new Point(180, 100);
            txCPF.Size = new Size(100, 18);
            txCPF.Mask = "000,000,000-00";
            this.Controls.Add(txCPF);

            // Combo Box
            cbDiasdev = new ComboBox();
            cbDiasdev.Items.Add("5");
            cbDiasdev.Items.Add("10");
            cbDiasdev.Items.Add("15");
            cbDiasdev.Items.Add("20");
            cbDiasdev.Location = new Point(180, 140);
            cbDiasdev.Size = new Size(100, 18);
            this.Controls.Add(cbDiasdev);

            // Check box
            chbAtivo = new CheckBox();
            chbAtivo.Location = new Point(180, 180);
            chbAtivo.Size = new Size(100, 18);
            chbAtivo.Text = "Ativo?";
            this.Controls.Add(chbAtivo);

            // Radio Button
            rbMasc = new RadioButton();
            rbMasc.Location = new Point(180, 220);
            rbMasc.Size = new Size(100,18);
            rbMasc.Text = "Masculino";
            this.Controls.Add(rbMasc);

            rbFemin = new RadioButton();
            rbFemin.Location = new Point(180, 240);
            rbFemin.Size = new Size(100,18);
            rbFemin.Text = "Feminino";
            this.Controls.Add(rbFemin);

            rbOutro = new RadioButton();
            rbOutro.Location = new Point(180, 260);
            rbOutro.Size = new Size(100,18);
            rbOutro.Text = "Outro";
            this.Controls.Add(rbOutro);

            //Link Label
            helpLink = new LinkLabel();
            helpLink.Location = new Point(20, 165);
            helpLink.Size = new Size (100, 30);
            helpLink.Text = "Precisa de Ajuda?";
            helpLink.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkHelp);
            this.Controls.Add(helpLink);

            btnConfirma = new Button();
            btnConfirma.Text = "OK";
            btnConfirma.Location = new Point(70, 300);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);
            this.Controls.Add(btnConfirma);
        
            btnCancela = new Button();
            btnCancela.Text = "Sair";
            btnCancela.Location = new Point(150, 300);
            btnCancela.Click += new EventHandler(btnCancelaClick);
            this.Controls.Add(btnCancela);

        }
            private void linkHelp(object sender, LinkLabelLinkClickedEventArgs e)
            {
                try{
                    VisitLink();
                }
                catch (Exception err){
                    MessageBox.Show(err.Message);
                }
            }
            private void VisitLink()
            {
                this.helpLink.LinkVisited = true;
                System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe","http://google.com");
            }

                private void btnConfirmaClick (object sender, EventArgs e){
                MessageBox.Show( 
                $"Nome: {txtNome.Text}\n" +
                    $"Data Nascimento: {numDtNascDia.Value + "/" + numDtNascMes.Value + "/" +  numDtNascAno.Value}\n" +
                    $"C.P.F: {txCPF.Text}\n" +
                    $"Dias Devolução: {cbDiasdev.Text}\n" +
                    $"Ativo: {(this.chbAtivo.Checked ? "Ativo" : "Inativo")}\n" +
                    $"Sexo: {(this.rbMasc.Checked ? "Masculino" : this.rbFemin.Checked ? "Feminino" : "Outro" )}\n",
                    "Cliente",
                    MessageBoxButtons.OK
                );

                ClienteController.addCliente(txtNome.Text, txCPF.Text, dtNasc = $"{this.numDtNascDia.Value} + {this.numDtNascMes.Value} + {this.numDtNascAno.Value}", Int32.Parse(cbDiasdev.Text));
                }   
                private void btnCancelaClick(object sender, EventArgs e){
                    this.Close();
                }
    }
}
