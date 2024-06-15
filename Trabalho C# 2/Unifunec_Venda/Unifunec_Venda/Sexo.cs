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
    public partial class Sexo : Form
    {
        public Sexo()
        {
            InitializeComponent();
        }

        private void Sexo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.SEXO'. Você pode movê-la ou removê-la conforme necessário.
            this.sEXOTableAdapter.Fill(this.uNIFUNEC2024DataSet.SEXO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sEXOBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sEXOBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sEXOBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sEXOBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo Sexo?", "Inserir Sexo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                sEXOBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sEXOBindingSource.EndEdit();
            sEXOTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            sEXOBindingSource.RemoveCurrent();

            sEXOBindingSource.EndEdit();
            sEXOTableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
