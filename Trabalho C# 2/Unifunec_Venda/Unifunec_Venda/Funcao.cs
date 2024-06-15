using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unifunec_Venda.UNIFUNEC2024DataSetTableAdapters;

namespace Unifunec_Venda
{
    public partial class Funcao : Form
    {
        public Funcao()
        {
            InitializeComponent();
        }

        private void Funcao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.FUNCAO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCAOTableAdapter.Fill(this.uNIFUNEC2024DataSet.FUNCAO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fUNCAOBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fUNCAOBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fUNCAOBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fUNCAOBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Nova Função?", "Inserir Função",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                fUNCAOBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fUNCAOBindingSource.EndEdit();
            fUNCAOTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            fUNCAOBindingSource.RemoveCurrent();

            fUNCAOBindingSource.EndEdit();
            fUNCAOTableAdapter.Update(uNIFUNEC2024DataSet);
        }

      
    }
}
