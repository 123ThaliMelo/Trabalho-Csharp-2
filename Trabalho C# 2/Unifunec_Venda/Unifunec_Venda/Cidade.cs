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
    public partial class Cidade : Form
    {
        public Cidade()
        {
            InitializeComponent();
        }

        private void Cidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.UF'. Você pode movê-la ou removê-la conforme necessário.
            this.uFTableAdapter.Fill(this.uNIFUNEC2024DataSet.UF);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.uNIFUNEC2024DataSet.CIDADE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cIDADEBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cIDADEBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cIDADEBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cIDADEBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Uma Nova Cidade?", "Inserir Cidade",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                cIDADEBindingSource.AddNew();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            cIDADEBindingSource.EndEdit();
            cIDADETableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            cIDADEBindingSource.RemoveCurrent();

            cIDADEBindingSource.EndEdit();
            cIDADETableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
