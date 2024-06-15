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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void Acesso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.ACESSO'. Você pode movê-la ou removê-la conforme necessário.
            this.aCESSOTableAdapter.Fill(this.uNIFUNEC2024DataSet.ACESSO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aCESSOBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aCESSOBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aCESSOBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aCESSOBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo Acesso?", "Inserir Acesso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                aCESSOBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aCESSOBindingSource.EndEdit();
            aCESSOTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            aCESSOBindingSource.RemoveCurrent();

            aCESSOBindingSource.EndEdit();
            aCESSOTableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
