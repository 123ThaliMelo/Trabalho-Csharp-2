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
    public partial class Operadora : Form
    {
        public Operadora()
        {
            InitializeComponent();
        }

        private void Operadora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.OPERADORA'. Você pode movê-la ou removê-la conforme necessário.
            this.oPERADORATableAdapter.Fill(this.uNIFUNEC2024DataSet.OPERADORA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oPERADORABindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oPERADORABindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oPERADORABindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oPERADORABindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Nova Operadora?", "Inserir Operadora",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                oPERADORABindingSource.AddNew();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            oPERADORABindingSource.EndEdit();
            oPERADORATableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            oPERADORABindingSource.RemoveCurrent();

            oPERADORABindingSource.EndEdit();
            oPERADORATableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
