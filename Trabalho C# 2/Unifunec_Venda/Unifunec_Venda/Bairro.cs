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
    public partial class Bairro : Form
    {
        public Bairro()
        {
            InitializeComponent();
        }

        private void Bairro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.uNIFUNEC2024DataSet.BAIRRO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bAIRROBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bAIRROBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bAIRROBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bAIRROBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo Bairro?", "Inserir Bairro",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bAIRROBindingSource.AddNew();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            bAIRROBindingSource.EndEdit();
            bAIRROTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            bAIRROBindingSource.RemoveCurrent();

            bAIRROBindingSource.EndEdit();
            bAIRROTableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
