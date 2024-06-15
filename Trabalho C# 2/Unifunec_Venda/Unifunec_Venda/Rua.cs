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
    public partial class Rua : Form
    {
        public Rua()
        {
            InitializeComponent();
        }

        private void Rua_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.uNIFUNEC2024DataSet.RUA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rUABindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rUABindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rUABindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rUABindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Uma Nova Rua?", "Inserir Rua",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                rUABindingSource.AddNew();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            rUABindingSource.EndEdit();
            rUATableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            rUABindingSource.RemoveCurrent();

            rUABindingSource.EndEdit();
            rUATableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
