namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tabFuncionarios = new TabControl();
            tabPage1 = new TabPage();
            cbAcesso = new ComboBox();
            cbCargo = new ComboBox();
            txtsenha = new TextBox();
            senha = new Label();
            label6 = new Label();
            label5 = new Label();
            btnBuscar = new Button();
            cbuf = new ComboBox();
            label16 = new Label();
            txtcidade = new TextBox();
            label17 = new Label();
            txtbairro = new TextBox();
            label18 = new Label();
            txtcomplemento = new TextBox();
            label19 = new Label();
            txtnumero = new TextBox();
            label20 = new Label();
            txtendereco = new TextBox();
            label21 = new Label();
            txtcep = new MaskedTextBox();
            label22 = new Label();
            txtcelular = new MaskedTextBox();
            label23 = new Label();
            txttelefone = new MaskedTextBox();
            label24 = new Label();
            txtcpf = new MaskedTextBox();
            cpf = new Label();
            txtrg = new MaskedTextBox();
            rg = new Label();
            txtemail = new TextBox();
            email = new Label();
            txtnome = new TextBox();
            nome = new Label();
            txtcodigo = new TextBox();
            label29 = new Label();
            tabPage2 = new TabPage();
            tabelaFuncionarios = new DataGridView();
            btnpesquisar = new Button();
            txtpesquisa = new TextBox();
            label2 = new Label();
            btnsalvar = new Button();
            btnexcluir = new Button();
            btneditar = new Button();
            btnnovo = new Button();
            panel1.SuspendLayout();
            tabFuncionarios.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 81);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(321, 27);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionários";
            label1.Click += label1_Click;
            // 
            // tabFuncionarios
            // 
            tabFuncionarios.Controls.Add(tabPage1);
            tabFuncionarios.Controls.Add(tabPage2);
            tabFuncionarios.Location = new Point(12, 87);
            tabFuncionarios.Name = "tabFuncionarios";
            tabFuncionarios.SelectedIndex = 0;
            tabFuncionarios.Size = new Size(887, 331);
            tabFuncionarios.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbAcesso);
            tabPage1.Controls.Add(cbCargo);
            tabPage1.Controls.Add(txtsenha);
            tabPage1.Controls.Add(senha);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(cbuf);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(txtcidade);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(txtbairro);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(txtcomplemento);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(txtnumero);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(txtendereco);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(txtcep);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(txtcelular);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(txttelefone);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(txtcpf);
            tabPage1.Controls.Add(cpf);
            tabPage1.Controls.Add(txtrg);
            tabPage1.Controls.Add(rg);
            tabPage1.Controls.Add(txtemail);
            tabPage1.Controls.Add(email);
            tabPage1.Controls.Add(txtnome);
            tabPage1.Controls.Add(nome);
            tabPage1.Controls.Add(txtcodigo);
            tabPage1.Controls.Add(label29);
            tabPage1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 23);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(879, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbAcesso
            // 
            cbAcesso.FormattingEnabled = true;
            cbAcesso.Items.AddRange(new object[] { "Administrador ", "Usuário" });
            cbAcesso.Location = new Point(492, 121);
            cbAcesso.Name = "cbAcesso";
            cbAcesso.Size = new Size(172, 27);
            cbAcesso.TabIndex = 69;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Gerente", "Vendedor", "Estagiário" });
            cbCargo.Location = new Point(72, 121);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(139, 27);
            cbCargo.TabIndex = 68;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(72, 83);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(187, 26);
            txtsenha.TabIndex = 67;
            // 
            // senha
            // 
            senha.AutoSize = true;
            senha.ForeColor = Color.FromArgb(0, 0, 64);
            senha.Location = new Point(11, 86);
            senha.Name = "senha";
            senha.Size = new Size(55, 19);
            senha.TabIndex = 64;
            senha.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(11, 124);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 63;
            label6.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(374, 124);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 62;
            label5.Text = "Nível de Acesso:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 0, 64);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(141, 237);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(70, 23);
            btnBuscar.TabIndex = 59;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbuf
            // 
            cbuf.FormattingEnabled = true;
            cbuf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbuf.Location = new Point(268, 233);
            cbuf.Name = "cbuf";
            cbuf.Size = new Size(51, 27);
            cbuf.TabIndex = 58;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(0, 0, 64);
            label16.Location = new Point(227, 240);
            label16.Name = "label16";
            label16.Size = new Size(32, 19);
            label16.TabIndex = 57;
            label16.Text = "UF:";
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(487, 272);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(190, 26);
            txtcidade.TabIndex = 56;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(0, 0, 64);
            label17.Location = new Point(418, 278);
            label17.Name = "label17";
            label17.Size = new Size(60, 19);
            label17.TabIndex = 55;
            label17.Text = "Cidade:";
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(401, 233);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(169, 26);
            txtbairro.TabIndex = 54;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(0, 0, 64);
            label18.Location = new Point(336, 239);
            label18.Name = "label18";
            label18.Size = new Size(58, 19);
            label18.TabIndex = 53;
            label18.Text = "Bairro:";
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(697, 232);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(176, 26);
            txtcomplemento.TabIndex = 52;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.FromArgb(0, 0, 64);
            label19.Location = new Point(579, 238);
            label19.Name = "label19";
            label19.Size = new Size(109, 19);
            label19.TabIndex = 51;
            label19.Text = "Complemento:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(759, 276);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(63, 26);
            txtnumero.TabIndex = 50;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.FromArgb(0, 0, 64);
            label20.Location = new Point(683, 279);
            label20.Name = "label20";
            label20.Size = new Size(70, 19);
            label20.TabIndex = 49;
            label20.Text = "Número:";
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(89, 272);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(317, 26);
            txtendereco.TabIndex = 48;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.FromArgb(0, 0, 64);
            label21.Location = new Point(5, 278);
            label21.Name = "label21";
            label21.Size = new Size(79, 19);
            label21.TabIndex = 47;
            label21.Text = "Endereço:";
            // 
            // txtcep
            // 
            txtcep.Location = new Point(57, 236);
            txtcep.Mask = "00000-999";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(82, 26);
            txtcep.TabIndex = 46;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.FromArgb(0, 0, 64);
            label22.Location = new Point(11, 242);
            label22.Name = "label22";
            label22.Size = new Size(39, 19);
            label22.TabIndex = 45;
            label22.Text = "Cep:";
            // 
            // txtcelular
            // 
            txtcelular.Location = new Point(259, 180);
            txtcelular.Mask = "(99) 0 0000-0000";
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(140, 26);
            txtcelular.TabIndex = 44;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.FromArgb(0, 0, 64);
            label23.Location = new Point(191, 183);
            label23.Name = "label23";
            label23.Size = new Size(62, 19);
            label23.TabIndex = 43;
            label23.Text = "Celular:";
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(548, 180);
            txttelefone.Mask = "(99) 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(140, 26);
            txttelefone.TabIndex = 42;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.FromArgb(0, 0, 64);
            label24.Location = new Point(472, 183);
            label24.Name = "label24";
            label24.Size = new Size(72, 19);
            label24.TabIndex = 41;
            label24.Text = "Telefone:";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(669, 16);
            txtcpf.Mask = "###.###.###-##";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(193, 26);
            txtcpf.TabIndex = 40;
            // 
            // cpf
            // 
            cpf.AutoSize = true;
            cpf.ForeColor = Color.FromArgb(0, 0, 64);
            cpf.Location = new Point(630, 25);
            cpf.Name = "cpf";
            cpf.Size = new Size(40, 19);
            cpf.TabIndex = 39;
            cpf.Text = "CPF:";
            // 
            // txtrg
            // 
            txtrg.Location = new Point(669, 50);
            txtrg.Mask = "##.###.###-##";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(133, 26);
            txtrg.TabIndex = 38;
            // 
            // rg
            // 
            rg.AutoSize = true;
            rg.ForeColor = Color.FromArgb(0, 0, 64);
            rg.Location = new Point(632, 53);
            rg.Name = "rg";
            rg.Size = new Size(33, 19);
            rg.TabIndex = 37;
            rg.Text = "RG:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(81, 47);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(254, 26);
            txtemail.TabIndex = 36;
            // 
            // email
            // 
            email.AutoSize = true;
            email.ForeColor = Color.FromArgb(0, 0, 64);
            email.Location = new Point(12, 53);
            email.Name = "email";
            email.Size = new Size(56, 19);
            email.TabIndex = 35;
            email.Text = "E-mail:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(234, 15);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(323, 26);
            txtnome.TabIndex = 34;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.ForeColor = Color.FromArgb(0, 0, 64);
            nome.Location = new Point(161, 19);
            nome.Name = "nome";
            nome.Size = new Size(54, 19);
            nome.TabIndex = 33;
            nome.Text = "Nome:";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(81, 15);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(58, 26);
            txtcodigo.TabIndex = 32;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.FromArgb(0, 0, 64);
            label29.Location = new Point(12, 21);
            label29.Name = "label29";
            label29.Size = new Size(61, 19);
            label29.TabIndex = 31;
            label29.Text = "Código:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabelaFuncionarios);
            tabPage2.Controls.Add(btnpesquisar);
            tabPage2.Controls.Add(txtpesquisa);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 23);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(879, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaFuncionarios
            // 
            tabelaFuncionarios.AllowUserToAddRows = false;
            tabelaFuncionarios.AllowUserToDeleteRows = false;
            tabelaFuncionarios.BackgroundColor = Color.FromArgb(192, 192, 255);
            tabelaFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFuncionarios.GridColor = SystemColors.ActiveBorder;
            tabelaFuncionarios.Location = new Point(13, 71);
            tabelaFuncionarios.Name = "tabelaFuncionarios";
            tabelaFuncionarios.ReadOnly = true;
            tabelaFuncionarios.RowTemplate.Height = 25;
            tabelaFuncionarios.Size = new Size(854, 219);
            tabelaFuncionarios.TabIndex = 38;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.FromArgb(0, 0, 64);
            btnpesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnpesquisar.ForeColor = SystemColors.ButtonFace;
            btnpesquisar.Location = new Point(411, 21);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(99, 27);
            btnpesquisar.TabIndex = 37;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // txtpesquisa
            // 
            txtpesquisa.Location = new Point(81, 21);
            txtpesquisa.Name = "txtpesquisa";
            txtpesquisa.Size = new Size(323, 26);
            txtpesquisa.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 35;
            label2.Text = "Nome:";
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.FromArgb(0, 192, 0);
            btnsalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalvar.ForeColor = SystemColors.ButtonFace;
            btnsalvar.Location = new Point(685, 451);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(99, 27);
            btnsalvar.TabIndex = 9;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.FromArgb(0, 0, 64);
            btnexcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexcluir.ForeColor = SystemColors.ButtonFace;
            btnexcluir.Location = new Point(488, 451);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(99, 27);
            btnexcluir.TabIndex = 8;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.FromArgb(0, 0, 64);
            btneditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btneditar.ForeColor = SystemColors.ButtonFace;
            btneditar.Location = new Point(381, 451);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(99, 27);
            btneditar.TabIndex = 7;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.FromArgb(0, 0, 64);
            btnnovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnnovo.ForeColor = SystemColors.ButtonFace;
            btnnovo.Location = new Point(275, 451);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(99, 27);
            btnnovo.TabIndex = 6;
            btnnovo.Text = "+ Novo";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click;
            // 
            // FrmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 490);
            Controls.Add(btnsalvar);
            Controls.Add(btnexcluir);
            Controls.Add(btneditar);
            Controls.Add(btnnovo);
            Controls.Add(tabFuncionarios);
            Controls.Add(panel1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmFuncionarios";
            Text = "Cadastro de Funcionarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabFuncionarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabFuncionarios;
        private TabPage tabPage1;
        private Button btnBuscar;
        private ComboBox cbuf;
        private Label label16;
        private TextBox txtcidade;
        private Label label17;
        private TextBox txtbairro;
        private Label label18;
        private TextBox txtcomplemento;
        private Label label19;
        private TextBox txtnumero;
        private Label label20;
        private TextBox txtendereco;
        private Label label21;
        private MaskedTextBox txtcep;
        private Label label22;
        private MaskedTextBox txtcelular;
        private Label label23;
        private MaskedTextBox txttelefone;
        private Label label24;
        private MaskedTextBox txtcpf;
        private Label cpf;
        private MaskedTextBox txtrg;
        private Label rg;
        private TextBox txtemail;
        private Label email;
        private TextBox txtnome;
        private Label nome;
        private TextBox txtcodigo;
        private Label label29;
        private TabPage tabPage2;
        private DataGridView tabelaFuncionarios;
        private Button btnpesquisar;
        private TextBox txtpesquisa;
        private Label label2;
        private Button btnsalvar;
        private Button btnexcluir;
        private Button btneditar;
        private Button btnnovo;
        private Label senha;
        private Label label6;
        private Label label5;
        private TextBox txtsenha;
        private ComboBox cbCargo;
        private ComboBox cbAcesso;
    }
}