using ControleDeVendas.br.com.ctvendas.dao;
using ControleDeVendas.br.com.ctvendas.model;
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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txtbairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Botão Buscar/Consultar Cep
            try
            {

                String cep = txtcep.Text;
                String xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");

            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //1 passo - receber os dados dentro do objeto modelo de cliente
            Fornecedores obj = new Fornecedores();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = txtnumero.Text;
            obj.bairro = txtbairro.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.celular = txtcelular.Text;

            obj.codigo = txtcodigo.Text;

            //2 passo - Criar um objeto da classe FornecedoresDAO e chamar o método alterar
            FornecedoresDAO dao = new FornecedoresDAO();
            dao.alterarFornecedores(obj);

            //recarregar o datagridview
            tabelaFornecedores.DataSource = dao.listarFornecedores();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Fornecedores obj = new Fornecedores();

            //Pegar o código
            obj.codigo = txtcodigo.Text;

            FornecedoresDAO dao = new FornecedoresDAO();
            dao.excluirFornecedor(obj);

            //recarregar o datagridview
            tabelaFornecedores.DataSource = dao.listarFornecedores();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //1 passo - receber os dados dentro do objeto modelo de cliente
            Fornecedores obj = new Fornecedores();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = txtnumero.Text;
            obj.bairro = txtbairro.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.celular = txtcelular.Text;

            //2 passo - Criar um objeto da classe ClienteDAO e chamar o método cadastrarCliente
            FornecedoresDAO dao = new FornecedoresDAO();
            dao.cadastrarFornecedores(obj);

            //recarregar o datagridview
            tabelaFornecedores.DataSource = dao.listarFornecedores();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}

