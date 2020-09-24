using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porjeto_Final
{
    public partial class FrmLogin : Form
    {
        List<Jogador> listaJogador = new List<Jogador>();     
        int temp;
        string nomeaux;

        internal List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        public FrmLogin()
        {
            InitializeComponent();
        }


        private void cmdIr_Click(object sender, EventArgs e)
        {       
            if (txtSenha.Text == "123quiz")
            {               

                if (rbFacil.Checked == true)
                {
                    temp = 25;
                }
                else if (rbMedio.Checked == true)
                {
                    temp = 20;
                }
                else if(rbDificil.Checked == true)
                {
                    temp = 15;
                }
                else
                {
                    MessageBox.Show("Escolha uma dificuldade");
                }
                nomeaux = txtUsuario.Text;
                Jogador j = new Jogador();
                j.Pontos = 0;
                j.Nome = txtUsuario.Text;
                listaJogador.Add(j);
                MessageBox.Show("Senha Correta. Vamos lá!");
                FrmPrin fp = new FrmPrin(temp, listaJogador, nomeaux);
                fp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.tabuada.org/";
            linkLabel1.Links.Add(link);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
    }
}
