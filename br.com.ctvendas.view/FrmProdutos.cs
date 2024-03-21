using ControleDeVendas.br.com.ctvendas.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeVendas.br.com.ctvendas.view
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedoresDAO f_dao = new FornecedoresDAO();

            cbfornecedor.DataSource = f_dao.listarFornecedores();
            //para aparecer a coluna do bando de dados que quero que o usuário veja na listagem de fornecedores
            cbfornecedor.DisplayMember = "nome";
            //o valor/id do fornecedor
            cbfornecedor.ValueMember = "id";
        }

        private void tbgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor do combobox" + cbfornecedor.SelectedValue);
        }
    }
}
