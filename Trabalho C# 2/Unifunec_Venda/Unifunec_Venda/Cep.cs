﻿using System;
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
    public partial class Cep : Form
    {
        public Cep()
        {
            InitializeComponent();
        }

        private void Cep_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uNIFUNEC2024DataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.uNIFUNEC2024DataSet.CEP);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEPBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cEPBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cEPBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cEPBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir Novo Cep?", "Inserir Cep",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                cEPBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cEPBindingSource.EndEdit();
            cEPTableAdapter.Update(uNIFUNEC2024DataSet);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            cEPBindingSource.RemoveCurrent();

            cEPBindingSource.EndEdit();
            cEPTableAdapter.Update(uNIFUNEC2024DataSet);
        }
    }
}
