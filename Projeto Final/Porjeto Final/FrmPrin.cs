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
    public partial class FrmPrin : Form
    {      

        List<Jogador> listaJogador = null;       
        Jogador j = null;

        int t;
        int ponto = 1;
        string nomeaux;
        public FrmPrin(int temp, List<Jogador> listaJogador, string nomeaux)
        {
            InitializeComponent();
            t = temp;
            this.listaJogador = listaJogador;
            this.nomeaux = nomeaux;
        }

        Random gerar = new Random();

        int soma1, soma2,
            sub1, sub2,
            mult1, mult2,
            div1, div2,
            tempo;

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRanking fr = new FrmRanking(listaJogador);
            fr.ShowDialog();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (VerificaResposta())
            {
                timer1.Stop();
                MessageBox.Show("Você acertou todas!", "Parabéns");
                cmdComecar.Enabled = true;
                foreach (Jogador item in listaJogador)
                {
                    if (item.Nome == nomeaux)
                    {
                       item.Pontos = ponto++;
                    }
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Errou! ");
                cmdComecar.Enabled = true;
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void FrmPrin_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nudSoma.Value = 0;
            nudSub.Value = 0;
            nudMult.Value = 0;
            nudDiv.Value = 0;
        }

        private void começarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comecar();
            cmdComecar.Enabled = false;
        }

        public void Comecar()
        {

            soma1 = gerar.Next(51);
            soma2 = gerar.Next(51);
            lblSoma1.Text = soma1.ToString();
            lblSoma2.Text = soma2.ToString();
            nudSoma.Value = 0;

            sub1 = gerar.Next(1, 101);
            sub2 = gerar.Next(1, sub1);
            lblSub1.Text = sub1.ToString();
            lblSub2.Text = sub2.ToString();
            nudSub.Value = 0;

            mult1 = gerar.Next(2, 11);
            mult2 = gerar.Next(2, 11);
            lblMult1.Text = mult1.ToString();
            lblMult2.Text = mult2.ToString();
            nudMult.Value = 0;

            div2 = gerar.Next(2, 11);
            int qt = gerar.Next(2, 11);
            div1 = div2 * qt;
            lblDiv1.Text = div1.ToString();
            lblDiv2.Text = div2.ToString();
            nudDiv.Value = 0;


            tempo = t;
            lblTempo.Text = tempo + " segundos";
            lblTempo.BackColor = Color.Black;
            timer1.Start();
        }

        private bool VerificaResposta()
        {
            return ((soma1 + soma2 == nudSoma.Value)
                && (sub1 - sub2 == nudSub.Value)
                && (mult1 * mult2 == nudMult.Value)
                && (div1 / div2 == nudDiv.Value)) ? true : false;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (tempo > 0)
            {
                tempo = tempo - 1;
                lblTempo.Text = tempo + " segundos";
                if (tempo <= 5)
                {
                    lblTempo.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                lblTempo.Text = "Acabou!";
                MessageBox.Show("Você não terminou a tempo", "Perdeu!");
                nudSoma.Value = soma1 + soma2;
                nudSub.Value = sub1 - sub2;
                nudMult.Value = mult1 * mult2;
                nudDiv.Value = div1 / div2;
                cmdComecar.Enabled = true;
            }
        }

        private void cmdComecar_Click(object sender, EventArgs e)
        {
            Comecar();
            cmdComecar.Enabled = false;
            cmdOk.Enabled = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
    }
}
