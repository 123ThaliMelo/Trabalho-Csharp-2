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
    public partial class Trabalho : Form
    {
        public Trabalho()
        {
            InitializeComponent();
        }

        private void Trabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.uNIFUNEC2024DataSet.TRABALHO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tRABALHOBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tRABALHOBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tRABALHOBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tRABALHOBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo Trabalho?", "Inserir Trabalho",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                tRABALHOBindingSource.AddNew();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            tRABALHOBindingSource.EndEdit();
            tRABALHOTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            tRABALHOBindingSource.RemoveCurrent();

            tRABALHOBindingSource.EndEdit();
            tRABALHOTableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
