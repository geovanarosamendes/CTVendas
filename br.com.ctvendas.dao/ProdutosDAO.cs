using ControleDeVendas.br.com.ctvendas.conexao;
using ControleDeVendas.br.com.ctvendas.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.br.com.ctvendas.dao
{
    public class ProdutosDAO
    {
        private MySqlConnection conexao;

        public ProdutosDAO()
        {
            this.conexao = new ConnectFactory().getconnection();
        }


        //Cadastrar produto
        #region Cadastrar Produto

        public void cadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"insert int tb_produtos (descricao, preco, qtd_estoque) values (@descricao, @preco, @qtd_estoque)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro" + erro);
              
            }
            finally
            { 
                conexao.Close(); 
            }    
        }

        #endregion
        //Alterar produto
        #region Alterar Produto

        #endregion
        //Excluir Produto
        #region Excluir Produto

        #endregion
        //Listar produto
        #region

        #endregion
        //Buscar produto por nome
        #region

        #endregion
        //Listar produto por nome
        #region

        #endregion
    }
}
