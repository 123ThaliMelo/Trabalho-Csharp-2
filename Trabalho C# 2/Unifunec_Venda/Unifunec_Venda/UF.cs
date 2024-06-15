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
    public partial class UF : Form
    {
        public UF()
        {
            InitializeComponent();
        }

        private void UF_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.UF'. Você pode movê-la ou removê-la conforme necessário.
            this.uFTableAdapter.Fill(this.uNIFUNEC2024DataSet.UF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uFBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uFBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uFBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uFBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo UF?", "Inserir UF",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                uFBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uFBindingSource.EndEdit();
            uFTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            uFBindingSource.RemoveCurrent();

            uFBindingSource.EndEdit();
            uFTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
