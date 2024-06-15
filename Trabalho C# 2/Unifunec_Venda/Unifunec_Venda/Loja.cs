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
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void Loja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.LOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.lOJATableAdapter.Fill(this.uNIFUNEC2024DataSet.LOJA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lOJABindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lOJABindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lOJABindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lOJABindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Nova Loja?", "Inserir Loja",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                lOJABindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lOJABindingSource.EndEdit();
            lOJATableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            lOJABindingSource.RemoveCurrent();

            lOJABindingSource.EndEdit();
            lOJATableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
