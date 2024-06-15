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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.uNIFUNEC2024DataSet.TRABALHO);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.uNIFUNEC2024DataSet.CIDADE);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.uNIFUNEC2024DataSet.CEP);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.uNIFUNEC2024DataSet.BAIRRO);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.uNIFUNEC2024DataSet.RUA);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.SEXO'. Você pode movê-la ou removê-la conforme necessário.
            this.sEXOTableAdapter.Fill(this.uNIFUNEC2024DataSet.SEXO);
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.uNIFUNEC2024DataSet.CLIENTE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cLIENTEBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cLIENTEBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cLIENTEBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cLIENTEBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo Cliente?", "Inserir Cliente",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        cLIENTEBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cLIENTEBindingSource.EndEdit();
            cLIENTETableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            cLIENTEBindingSource.RemoveCurrent();

            cLIENTEBindingSource.EndEdit();
            cLIENTETableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
