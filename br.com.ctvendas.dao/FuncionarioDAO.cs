using ControleDeVendas.br.com.ctvendas.conexao;
using ControleDeVendas.br.com.ctvendas.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.br.com.ctvendas.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;


        public FuncionarioDAO()
        {
            this.conexao = new ConnectFactory().getconnection();
        }

        //Método Cadastrar Funcionário
        #region Cadastrar Funcionario

        public void cadastrarFuncionarios(Funcionario obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                            values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2 passo - organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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
                MessageBox.Show("Funcionário cadastrado com sucesso!");

                //Fechar a conexão com o banco de dados
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
            finally 
            { 
                conexao.Close(); 
            }

        }

        #endregion
        //Método Alterar 
        #region Alterar
        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, cargo=@cargo, senha=@senha, nivel_acesso=@nivel_acesso, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                                    where id=@id";

                //2 passo - organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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


                MessageBox.Show("Funcionario alterado com sucesso!");

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
        //Método Excluir
        #region Excluir
        public void excluirFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"delete from tb_Funcionarios where id = @id";

                //2 passo - organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);


                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - Abrir a conexao e executar o cmd Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Funcionário Excluído com sucesso!");

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

        //Método Listar
        #region Listar
        public DataTable listarFuncionarios()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelaFuncionarios = new DataTable();
                string sql = "Select * from tb_funcionarios";

                //2 passo - Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySqlAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionarios);

                return tabelaFuncionarios;


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
        //Método Buscar
        #region Buscar Por Nome
        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelaFuncionarios = new DataTable();
                string sql = "Select * from tb_funcionarios where nome like @nome";

                //2 passo - Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.Parameters.AddWithValue("@nome", nome + "%");

                //3 passo - Criar o MySqlAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionarios);

                return tabelaFuncionarios;

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
        //Método Listar por Nome
        #region Listar por Nome
        public DataTable ListarFuncionarioPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelaFuncionarios = new DataTable();
                string sql = "Select * from tb_funcionarios where nome like @nome";

                //2 passo - Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.Parameters.AddWithValue("@nome", nome + "%");

                //3 passo - Criar o MySqlAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionarios);

                return tabelaFuncionarios;

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
