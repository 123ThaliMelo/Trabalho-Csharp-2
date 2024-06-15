using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unifunec_Venda
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void uFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UF uF = new UF();   
            uF.ShowDialog();
        }

        private void cIDADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade();   
            cidade.ShowDialog();
        }

        private void rUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rua rua = new Rua();
            rua.ShowDialog();

        }

        private void bAIRROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bairro bairro = new Bairro();
            bairro.ShowDialog();
        }

        private void tRABALHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabalho trbalho = new Trabalho();
            trbalho.ShowDialog();
        }

        private void oPERADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operadora operadora = new Operadora();
            operadora.ShowDialog();
        }

        private void fUNÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcao funcao = new Funcao();
            funcao.ShowDialog();
        }

        private void lOJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Loja loja = new Loja();
           loja.ShowDialog();
        }

        private void aCESSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();   
            acesso.ShowDialog();
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cep cep = new Cep();
            cep.ShowDialog();
        }

        private void sEXOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sexo sexo = new Sexo(); 
            sexo.ShowDialog();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void fUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.ShowDialog();
        }
    }
}
