using ControleDeVendas.br.com.ctvendas.conexao;
using ControleDeVendas.br.com.ctvendas.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.br.com.ctvendas.dao
{
    public class ClienteDAO
    {

        //Cria conexão com atributo do tipo MySqlConnection
        private MySqlConnection conexao;

        //construtor responsável pela conexão
        public ClienteDAO()
        {
            this.conexao = new ConnectFactory().getconnection();
        }



        //Cadastrar Cliente
        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                            values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2 passo - organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 passo - Abrir a conexao e executar o cmd Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Cliente cadastrado com sucesso!");

                //Fechar a conexão com o banco de dados
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
            //Forçar fechar conexão
            finally
            {
                conexao.Close();
            }

        }
        #endregion
       
        //método Alterar Cliente
        #region Alterar Cliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                                    where id=@id";

                //2 passo - organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - Abrir a conexao e executar o cmd Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Cliente alterado com sucesso!");
               
                //Fechar a conexão com o banco de dados
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
            //Fechar a conexão com o banco de dados
            finally
            {
                conexao.Close();
            }

        }

        #endregion
       
        //método Excluir Cliente
        #region Excluir Cliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"delete from tb_clientes where id = @id";

                //2 passo - organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
              

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - Abrir a conexao e executar o cmd Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Cliente Excluído com sucesso!");

                //Fechar a conexão com o banco de dados
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                
            }
            //Fechar a conexão com o banco de dados
            finally
            {
                conexao.Close();
            }

        }

        #endregion

        //Listar Cliente
        #region Listar Cliente
        public DataTable listarClientes() 
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "Select * from tb_clientes";

                //2 passo - Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);  
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySqlAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                return tabelacliente;

                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);
                return null;

            }
            //Fechar a conexão com o banco de dados
            finally
            {
                conexao.Close();
            }

            

        }
        #endregion

        //método buscar Cliente por Nome
        #region Buscar Cliente por Nome

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "Select * from tb_clientes where nome like @nome";

                //2 passo - Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.Parameters.AddWithValue("@nome", nome + "%");

                //3 passo - Criar o MySqlAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                return tabelacliente;
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);
                return null;

            }
            finally
            {
                conexao.Close();
            }

        }

        #endregion

        //Listar Cliente Por Nome
        #region Listar Cliente por Nome

        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "Select * from tb_clientes where nome like @nome";

                //2 passo - Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.Parameters.AddWithValue("@nome", nome + "%");

                //3 passo - Criar o MySqlAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                return tabelacliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);
                return null;

            }
            finally
            {
                conexao.Close();
            }

        }

        #endregion
    }
}
