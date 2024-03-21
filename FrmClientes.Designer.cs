namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmClientes
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
            tabclientes = new TabControl();
            tabDadosClientes = new TabPage();
            txtuf = new ComboBox();
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
            label25 = new Label();
            txtrg = new MaskedTextBox();
            label26 = new Label();
            txtemail = new TextBox();
            label27 = new Label();
            txtnome = new TextBox();
            label28 = new Label();
            txtcodigo = new TextBox();
            label29 = new Label();
            tabConsulta = new TabPage();
            tbgCliente = new DataGridView();
            btnpesquisar = new Button();
            txtpesquisa = new TextBox();
            label2 = new Label();
            btnnovo = new Button();
            btneditar = new Button();
            btnexcluir = new Button();
            btnsalvar = new Button();
            panel1.SuspendLayout();
            tabclientes.SuspendLayout();
            tabDadosClientes.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbgCliente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 87);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            label1.Click += label1_Click;
            // 
            // tabclientes
            // 
            tabclientes.Controls.Add(tabDadosClientes);
            tabclientes.Controls.Add(tabConsulta);
            tabclientes.Location = new Point(12, 93);
            tabclientes.Name = "tabclientes";
            tabclientes.SelectedIndex = 0;
            tabclientes.Size = new Size(776, 345);
            tabclientes.TabIndex = 1;
            // 
            // tabDadosClientes
            // 
            tabDadosClientes.Controls.Add(txtuf);
            tabDadosClientes.Controls.Add(label16);
            tabDadosClientes.Controls.Add(txtcidade);
            tabDadosClientes.Controls.Add(label17);
            tabDadosClientes.Controls.Add(txtbairro);
            tabDadosClientes.Controls.Add(label18);
            tabDadosClientes.Controls.Add(txtcomplemento);
            tabDadosClientes.Controls.Add(label19);
            tabDadosClientes.Controls.Add(txtnumero);
            tabDadosClientes.Controls.Add(label20);
            tabDadosClientes.Controls.Add(txtendereco);
            tabDadosClientes.Controls.Add(label21);
            tabDadosClientes.Controls.Add(txtcep);
            tabDadosClientes.Controls.Add(label22);
            tabDadosClientes.Controls.Add(txtcelular);
            tabDadosClientes.Controls.Add(label23);
            tabDadosClientes.Controls.Add(txttelefone);
            tabDadosClientes.Controls.Add(label24);
            tabDadosClientes.Controls.Add(txtcpf);
            tabDadosClientes.Controls.Add(label25);
            tabDadosClientes.Controls.Add(txtrg);
            tabDadosClientes.Controls.Add(label26);
            tabDadosClientes.Controls.Add(txtemail);
            tabDadosClientes.Controls.Add(label27);
            tabDadosClientes.Controls.Add(txtnome);
            tabDadosClientes.Controls.Add(label28);
            tabDadosClientes.Controls.Add(txtcodigo);
            tabDadosClientes.Controls.Add(label29);
            tabDadosClientes.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabDadosClientes.Location = new Point(4, 24);
            tabDadosClientes.Name = "tabDadosClientes";
            tabDadosClientes.Padding = new Padding(3);
            tabDadosClientes.Size = new Size(768, 317);
            tabDadosClientes.TabIndex = 0;
            tabDadosClientes.Text = "Dados Pessoais";
            tabDadosClientes.UseVisualStyleBackColor = true;
            // 
            // txtuf
            // 
            txtuf.FormattingEnabled = true;
            txtuf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txtuf.Location = new Point(384, 118);
            txtuf.Name = "txtuf";
            txtuf.Size = new Size(45, 27);
            txtuf.TabIndex = 58;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Purple;
            label16.Location = new Point(346, 121);
            label16.Name = "label16";
            label16.Size = new Size(32, 19);
            label16.TabIndex = 57;
            label16.Text = "UF:";
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(287, 194);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(167, 26);
            txtcidade.TabIndex = 56;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Purple;
            label17.Location = new Point(224, 197);
            label17.Name = "label17";
            label17.Size = new Size(60, 19);
            label17.TabIndex = 55;
            label17.Text = "Cidade:";
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(71, 194);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(148, 26);
            txtbairro.TabIndex = 54;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Purple;
            label18.Location = new Point(11, 197);
            label18.Name = "label18";
            label18.Size = new Size(58, 19);
            label18.TabIndex = 53;
            label18.Text = "Bairro:";
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(566, 194);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(177, 26);
            txtcomplemento.TabIndex = 52;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Purple;
            label19.Location = new Point(460, 197);
            label19.Name = "label19";
            label19.Size = new Size(109, 19);
            label19.TabIndex = 51;
            label19.Text = "Complemento:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(641, 153);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(64, 26);
            txtnumero.TabIndex = 50;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Purple;
            label20.Location = new Point(575, 156);
            label20.Name = "label20";
            label20.Size = new Size(70, 19);
            label20.TabIndex = 49;
            label20.Text = "Número:";
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(287, 150);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(278, 26);
            txtendereco.TabIndex = 48;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Purple;
            label21.Location = new Point(211, 153);
            label21.Name = "label21";
            label21.Size = new Size(79, 19);
            label21.TabIndex = 47;
            label21.Text = "Endereço:";
            // 
            // txtcep
            // 
            txtcep.Location = new Point(258, 118);
            txtcep.Mask = "00000-999";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(72, 26);
            txtcep.TabIndex = 46;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Purple;
            label22.Location = new Point(215, 121);
            label22.Name = "label22";
            label22.Size = new Size(39, 19);
            label22.TabIndex = 45;
            label22.Text = "Cep:";
            // 
            // txtcelular
            // 
            txtcelular.Location = new Point(86, 147);
            txtcelular.Mask = "(99) 0 0000-0000";
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(123, 26);
            txtcelular.TabIndex = 44;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Purple;
            label23.Location = new Point(8, 150);
            label23.Name = "label23";
            label23.Size = new Size(62, 19);
            label23.TabIndex = 43;
            label23.Text = "Celular:";
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(86, 115);
            txttelefone.Mask = "(99) 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(123, 26);
            txttelefone.TabIndex = 42;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.Purple;
            label24.Location = new Point(8, 118);
            label24.Name = "label24";
            label24.Size = new Size(72, 19);
            label24.TabIndex = 41;
            label24.Text = "Telefone:";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(396, 76);
            txtcpf.Mask = "###.###.###-##";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(169, 26);
            txtcpf.TabIndex = 40;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Purple;
            label25.Location = new Point(360, 83);
            label25.Name = "label25";
            label25.Size = new Size(40, 19);
            label25.TabIndex = 39;
            label25.Text = "CPF:";
            // 
            // txtrg
            // 
            txtrg.Location = new Point(396, 44);
            txtrg.Mask = "##.###.###-##";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(169, 26);
            txtrg.TabIndex = 38;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.Purple;
            label26.Location = new Point(360, 51);
            label26.Name = "label26";
            label26.Size = new Size(33, 19);
            label26.TabIndex = 37;
            label26.Text = "RG:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(71, 83);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(283, 26);
            txtemail.TabIndex = 36;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.Purple;
            label27.Location = new Point(8, 86);
            label27.Name = "label27";
            label27.Size = new Size(56, 19);
            label27.TabIndex = 35;
            label27.Text = "E-mail:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(71, 48);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(283, 26);
            txtnome.TabIndex = 34;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.Purple;
            label28.Location = new Point(8, 51);
            label28.Name = "label28";
            label28.Size = new Size(54, 19);
            label28.TabIndex = 33;
            label28.Text = "Nome:";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(71, 16);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(80, 26);
            txtcodigo.TabIndex = 32;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.Purple;
            label29.Location = new Point(8, 19);
            label29.Name = "label29";
            label29.Size = new Size(61, 19);
            label29.TabIndex = 31;
            label29.Text = "Código:";
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(tbgCliente);
            tabConsulta.Controls.Add(btnpesquisar);
            tabConsulta.Controls.Add(txtpesquisa);
            tabConsulta.Controls.Add(label2);
            tabConsulta.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(768, 317);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tbgCliente
            // 
            tbgCliente.AllowUserToAddRows = false;
            tbgCliente.AllowUserToDeleteRows = false;
            tbgCliente.BackgroundColor = Color.FromArgb(255, 192, 255);
            tbgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbgCliente.GridColor = SystemColors.ActiveBorder;
            tbgCliente.Location = new Point(6, 79);
            tbgCliente.Name = "tbgCliente";
            tbgCliente.ReadOnly = true;
            tbgCliente.RowTemplate.Height = 25;
            tbgCliente.Size = new Size(747, 235);
            tbgCliente.TabIndex = 38;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.Purple;
            btnpesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnpesquisar.ForeColor = SystemColors.ButtonFace;
            btnpesquisar.Location = new Point(360, 22);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(87, 29);
            btnpesquisar.TabIndex = 37;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = false;
            // 
            // txtpesquisa
            // 
            txtpesquisa.Location = new Point(71, 23);
            txtpesquisa.Name = "txtpesquisa";
            txtpesquisa.Size = new Size(283, 26);
            txtpesquisa.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(8, 26);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 35;
            label2.Text = "Nome:";
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.Purple;
            btnnovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnnovo.ForeColor = SystemColors.ButtonFace;
            btnnovo.Location = new Point(190, 471);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(87, 29);
            btnnovo.TabIndex = 2;
            btnnovo.Text = "+ Novo";
            btnnovo.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Purple;
            btneditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btneditar.ForeColor = SystemColors.ButtonFace;
            btneditar.Location = new Point(283, 471);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(87, 29);
            btneditar.TabIndex = 3;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Red;
            btnexcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexcluir.ForeColor = SystemColors.ButtonFace;
            btnexcluir.Location = new Point(376, 471);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(87, 29);
            btnexcluir.TabIndex = 4;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.FromArgb(0, 192, 0);
            btnsalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalvar.ForeColor = SystemColors.ButtonFace;
            btnsalvar.Location = new Point(469, 471);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(87, 29);
            btnsalvar.TabIndex = 5;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(btnsalvar);
            Controls.Add(btnexcluir);
            Controls.Add(btneditar);
            Controls.Add(btnnovo);
            Controls.Add(tabclientes);
            Controls.Add(panel1);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabclientes.ResumeLayout(false);
            tabDadosClientes.ResumeLayout(false);
            tabDadosClientes.PerformLayout();
            tabConsulta.ResumeLayout(false);
            tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbgCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabclientes;
        private TabPage tabDadosClientes;
        private TabPage tabConsulta;
        private Button btnnovo;
        private Button btneditar;
        private Button btnexcluir;
        private Button btnsalvar;
        private ComboBox txtuf;
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
        private Label label25;
        private MaskedTextBox txtrg;
        private Label label26;
        private TextBox txtemail;
        private Label label27;
        private TextBox txtnome;
        private Label label28;
        private TextBox txtcodigo;
        private Label label29;
        private TextBox txtpesquisa;
        private Label label2;
        private DataGridView tbgCliente;
        private Button btnpesquisar;
    }
}