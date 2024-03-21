using ControleDeVendas.br.com.ctvendas.view;

namespace ControleDeVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedores fornecedores = new FrmFornecedores();
            fornecedores.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios funcionarios = new FrmFuncionarios();
            funcionarios.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.Show();
        }

        private void cadastrarNovoForneceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}