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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //Botão salvar
            Funcionario obj = new Funcionario();

            //Receber os dados dos campos

            obj.nome = txtnome.Text;
            obj.cpf = txtcpf.Text;
            obj.rg = txtrg.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.telefone = txttelefone.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = txtnumero.Text;
            obj.bairro = txtbairro.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.celular = txtcelular.Text;

            //2 passo - Criar um objeto da classe ClienteDAO e chamar o método cadastrarCliente
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionarios(obj);

            //recarregar o datagridview
            tabelaFuncionarios.DataSource = dao.listarFuncionarios();



        }

        private void txtnome_TextChanged(object sender, EventArgs e)
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
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.cargo = cbCargo.Text;
            obj.senha = txtsenha.Text;
            obj.nivel_acesso = cbAcesso.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = txtnumero.Text;
            obj.bairro = txtbairro.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.celular = txtcelular.Text;

            obj.codigo = txtcodigo.Text;

            //2 passo - Criar um objeto da classe FuncionarioDAO e chamar o método alterar
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            //recarregar o datagridview
            tabelaFuncionarios.DataSource = dao.listarFuncionarios();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Funcionario obj = new Funcionario();

            //Pegar o código
            obj.codigo = txtcodigo.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.excluirFuncionario(obj);

            //recarregar o datagridview
            tabelaFuncionarios.DataSource = dao.listarFuncionarios();
        }

        private void btnpesquisar_Click(object sender,EventArgs e)
          
        {
            string nome = btnpesquisar.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFuncionarios.DataSource = dao.BuscarFuncionarioPorNome(nome);

            if (tabelaFuncionarios.Rows.Count == 0)
            {
                //recarregar o datagridview
                tabelaFuncionarios.DataSource = dao.listarFuncionarios();
            }
        }
    }
}

