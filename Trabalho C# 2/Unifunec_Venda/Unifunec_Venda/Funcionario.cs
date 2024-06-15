using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unifunec_Venda
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.LOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.lOJATableAdapter.Fill(this.uNIFUNEC2024DataSet.LOJA);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.FUNCAO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCAOTableAdapter.Fill(this.uNIFUNEC2024DataSet.FUNCAO);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.uNIFUNEC2024DataSet.CIDADE);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.uNIFUNEC2024DataSet.CEP);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.uNIFUNEC2024DataSet.BAIRRO);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.uNIFUNEC2024DataSet.RUA);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet1.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.uNIFUNEC2024DataSet1.FUNCIONARIOS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fUNCIONARIOSBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fUNCIONARIOSBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fUNCIONARIOSBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fUNCIONARIOSBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo Cliente?", "Inserir Cliente",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                fUNCIONARIOSBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fUNCIONARIOSBindingSource.EndEdit();
            fUNCIONARIOSTableAdapter.Update(uNIFUNEC2024DataSet1);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            fUNCIONARIOSBindingSource.RemoveCurrent();

            fUNCIONARIOSBindingSource.EndEdit();
            fUNCIONARIOSTableAdapter.Update(uNIFUNEC2024DataSet1);
        }
    }
}
