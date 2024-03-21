namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmFornecedores
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
            txtcnpj = new MaskedTextBox();
            label25 = new Label();
            txtemail = new TextBox();
            label27 = new Label();
            txtnome = new TextBox();
            label28 = new Label();
            txtcodigo = new TextBox();
            label29 = new Label();
            tabPage2 = new TabPage();
            tabelaFornecedores = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)tabelaFornecedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 81);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(267, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Fornecedores";
            // 
            // tabFuncionarios
            // 
            tabFuncionarios.Controls.Add(tabPage1);
            tabFuncionarios.Controls.Add(tabPage2);
            tabFuncionarios.Location = new Point(4, 104);
            tabFuncionarios.Name = "tabFuncionarios";
            tabFuncionarios.SelectedIndex = 0;
            tabFuncionarios.Size = new Size(926, 422);
            tabFuncionarios.TabIndex = 3;
            // 
            // tabPage1
            // 
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
            tabPage1.Controls.Add(txtcnpj);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(txtemail);
            tabPage1.Controls.Add(label27);
            tabPage1.Controls.Add(txtnome);
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(txtcodigo);
            tabPage1.Controls.Add(label29);
            tabPage1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Purple;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(141, 188);
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
            cbuf.Location = new Point(539, 268);
            cbuf.Name = "cbuf";
            cbuf.Size = new Size(51, 27);
            cbuf.TabIndex = 58;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Purple;
            label16.Location = new Point(501, 272);
            label16.Name = "label16";
            label16.Size = new Size(32, 19);
            label16.TabIndex = 57;
            label16.Text = "UF:";
            label16.Click += label16_Click;
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(81, 260);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(190, 26);
            txtcidade.TabIndex = 56;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Purple;
            label17.Location = new Point(15, 263);
            label17.Name = "label17";
            label17.Size = new Size(60, 19);
            label17.TabIndex = 55;
            label17.Text = "Cidade:";
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(81, 224);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(169, 26);
            txtbairro.TabIndex = 54;
            txtbairro.TextChanged += txtbairro_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Purple;
            label18.Location = new Point(17, 227);
            label18.Name = "label18";
            label18.Size = new Size(58, 19);
            label18.TabIndex = 53;
            label18.Text = "Bairro:";
            label18.Click += label18_Click;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(401, 227);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(176, 26);
            txtcomplemento.TabIndex = 52;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Purple;
            label19.Location = new Point(286, 231);
            label19.Name = "label19";
            label19.Size = new Size(109, 19);
            label19.TabIndex = 51;
            label19.Text = "Complemento:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(401, 263);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(63, 26);
            txtnumero.TabIndex = 50;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Purple;
            label20.Location = new Point(325, 268);
            label20.Name = "label20";
            label20.Size = new Size(70, 19);
            label20.TabIndex = 49;
            label20.Text = "Número:";
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(301, 185);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(317, 26);
            txtendereco.TabIndex = 48;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Purple;
            label21.Location = new Point(220, 194);
            label21.Name = "label21";
            label21.Size = new Size(79, 19);
            label21.TabIndex = 47;
            label21.Text = "Endereço:";
            // 
            // txtcep
            // 
            txtcep.Location = new Point(57, 187);
            txtcep.Mask = "00000-999";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(82, 26);
            txtcep.TabIndex = 46;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Purple;
            label22.Location = new Point(14, 196);
            label22.Name = "label22";
            label22.Size = new Size(39, 19);
            label22.TabIndex = 45;
            label22.Text = "Cep:";
            // 
            // txtcelular
            // 
            txtcelular.Location = new Point(301, 120);
            txtcelular.Mask = "(99) 0 0000-0000";
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(140, 26);
            txtcelular.TabIndex = 44;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Purple;
            label23.Location = new Point(236, 126);
            label23.Name = "label23";
            label23.Size = new Size(62, 19);
            label23.TabIndex = 43;
            label23.Text = "Celular:";
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(81, 120);
            txttelefone.Mask = "(99) 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(140, 26);
            txttelefone.TabIndex = 42;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.Purple;
            label24.Location = new Point(8, 126);
            label24.Name = "label24";
            label24.Size = new Size(72, 19);
            label24.TabIndex = 41;
            label24.Text = "Telefone:";
            // 
            // txtcnpj
            // 
            txtcnpj.Location = new Point(513, 47);
            txtcnpj.Mask = "##.###.###.####/##";
            txtcnpj.Name = "txtcnpj";
            txtcnpj.Size = new Size(149, 26);
            txtcnpj.TabIndex = 40;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Purple;
            label25.Location = new Point(465, 53);
            label25.Name = "label25";
            label25.Size = new Size(47, 19);
            label25.TabIndex = 39;
            label25.Text = "CNPJ:";
            label25.Click += label25_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(77, 85);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(254, 26);
            txtemail.TabIndex = 36;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.Purple;
            label27.Location = new Point(15, 88);
            label27.Name = "label27";
            label27.Size = new Size(56, 19);
            label27.TabIndex = 35;
            label27.Text = "E-mail:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(127, 47);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(323, 26);
            txtnome.TabIndex = 34;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.Purple;
            label28.Location = new Point(10, 52);
            label28.Name = "label28";
            label28.Size = new Size(115, 19);
            label28.TabIndex = 33;
            label28.Text = "Nome Fantasia:";
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
            label29.ForeColor = Color.Purple;
            label29.Location = new Point(15, 24);
            label29.Name = "label29";
            label29.Size = new Size(61, 19);
            label29.TabIndex = 31;
            label29.Text = "Código:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabelaFornecedores);
            tabPage2.Controls.Add(btnpesquisar);
            tabPage2.Controls.Add(txtpesquisa);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(918, 394);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaFornecedores
            // 
            tabelaFornecedores.AllowUserToAddRows = false;
            tabelaFornecedores.AllowUserToDeleteRows = false;
            tabelaFornecedores.BackgroundColor = Color.Purple;
            tabelaFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFornecedores.GridColor = SystemColors.ActiveBorder;
            tabelaFornecedores.Location = new Point(13, 71);
            tabelaFornecedores.Name = "tabelaFornecedores";
            tabelaFornecedores.ReadOnly = true;
            tabelaFornecedores.RowTemplate.Height = 25;
            tabelaFornecedores.Size = new Size(854, 219);
            tabelaFornecedores.TabIndex = 38;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.Purple;
            btnpesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnpesquisar.ForeColor = SystemColors.ButtonFace;
            btnpesquisar.Location = new Point(411, 21);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(99, 27);
            btnpesquisar.TabIndex = 37;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = false;
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
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(15, 30);
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
            btnsalvar.Location = new Point(536, 442);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(99, 27);
            btnsalvar.TabIndex = 13;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Red;
            btnexcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexcluir.ForeColor = SystemColors.ButtonFace;
            btnexcluir.Location = new Point(430, 442);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(99, 27);
            btnexcluir.TabIndex = 12;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Purple;
            btneditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btneditar.ForeColor = SystemColors.ButtonFace;
            btneditar.Location = new Point(323, 442);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(99, 27);
            btneditar.TabIndex = 11;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.Purple;
            btnnovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnnovo.ForeColor = SystemColors.ButtonFace;
            btnnovo.Location = new Point(217, 442);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(99, 27);
            btnnovo.TabIndex = 10;
            btnnovo.Text = "+ Novo";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 591);
            Controls.Add(btnsalvar);
            Controls.Add(btnexcluir);
            Controls.Add(btneditar);
            Controls.Add(btnnovo);
            Controls.Add(tabFuncionarios);
            Controls.Add(panel1);
            Name = "FrmFornecedores";
            Text = "FrmFornecedores";
            Load += FrmFornecedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabFuncionarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFornecedores).EndInit();
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
        private MaskedTextBox txtcnpj;
        private Label label25;
        private TextBox txtemail;
        private Label label27;
        private TextBox txtnome;
        private Label label28;
        private TextBox txtcodigo;
        private Label label29;
        private TabPage tabPage2;
        private DataGridView tabelaFornecedores;
        private Button btnpesquisar;
        private TextBox txtpesquisa;
        private Label label2;
        private Button btnsalvar;
        private Button btnexcluir;
        private Button btneditar;
        private Button btnnovo;
    }
}