using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class FrmFornecedor : Form
    {
        //Definir a Collection
        ICollection<Fornecedor> lista;
        public FrmFornecedor()
        {
            InitializeComponent();
            //Carregar a grade
            lista = new List<Fornecedor>();
            dataGridFornecedor.DataSource = lista;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();
            fornecedor.Id = int.Parse(txtId.Text);
            fornecedor.Nome = txtNome.Text;
            fornecedor.Email = txtEmail.Text;
            lista.Add(fornecedor);
            dataGridFornecedor.DataSource = null;
            dataGridFornecedor.DataSource = lista;
            //Ação para Limpar a tela
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox texto = (TextBox)item;
                    texto.Text = "";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
