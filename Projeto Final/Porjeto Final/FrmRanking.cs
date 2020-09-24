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
    public partial class FrmRanking : Form
    {
        List<Jogador> listaJogador = null;


        public FrmRanking(List<Jogador> listaJogador)
        {
            InitializeComponent();
            this.listaJogador = listaJogador;
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {
            foreach (Jogador item in listaJogador)
            {
                listBox1.Items.Add(item.mostraResultado());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdVoltarJogo_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }
    }
}
