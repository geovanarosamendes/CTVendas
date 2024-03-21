namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmProdutos
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
            tabClientes = new TabControl();
            tabPage1 = new TabPage();
            cbfornecedor = new ComboBox();
            label4 = new Label();
            textpreco = new TextBox();
            label3 = new Label();
            txtqtd = new TextBox();
            label27 = new Label();
            txtdesc = new TextBox();
            label28 = new Label();
            txtcodigo = new TextBox();
            label29 = new Label();
            tabProdutos = new TabPage();
            tbgProdutos = new DataGridView();
            btnpesquisar = new Button();
            txtpesquisa = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabClientes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbgProdutos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 81);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(364, 25);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            label1.Click += label1_Click;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(tabPage1);
            tabClientes.Controls.Add(tabProdutos);
            tabClientes.Location = new Point(10, 110);
            tabClientes.Name = "tabClientes";
            tabClientes.SelectedIndex = 0;
            tabClientes.Size = new Size(887, 322);
            tabClientes.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbfornecedor);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textpreco);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtqtd);
            tabPage1.Controls.Add(label27);
            tabPage1.Controls.Add(txtdesc);
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(txtcodigo);
            tabPage1.Controls.Add(label29);
            tabPage1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(879, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbfornecedor
            // 
            cbfornecedor.FormattingEnabled = true;
            cbfornecedor.Location = new Point(115, 137);
            cbfornecedor.Name = "cbfornecedor";
            cbfornecedor.Size = new Size(342, 27);
            cbfornecedor.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(14, 140);
            label4.Name = "label4";
            label4.Size = new Size(94, 19);
            label4.TabIndex = 39;
            label4.Text = "Fornecedor:";
            // 
            // textpreco
            // 
            textpreco.Location = new Point(619, 51);
            textpreco.Name = "textpreco";
            textpreco.Size = new Size(120, 26);
            textpreco.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(526, 54);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 37;
            label3.Text = "Preço (R$):";
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(115, 89);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(126, 26);
            txtqtd.TabIndex = 36;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.FromArgb(0, 0, 64);
            label27.Location = new Point(12, 89);
            label27.Name = "label27";
            label27.Size = new Size(97, 19);
            label27.TabIndex = 35;
            label27.Text = "Qtd Estoque:";
            label27.Click += label27_Click;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(99, 51);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(323, 26);
            txtdesc.TabIndex = 34;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.FromArgb(0, 0, 64);
            label28.Location = new Point(12, 51);
            label28.Name = "label28";
            label28.Size = new Size(81, 19);
            label28.TabIndex = 33;
            label28.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(81, 15);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(91, 26);
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
            // tabProdutos
            // 
            tabProdutos.Controls.Add(tbgProdutos);
            tabProdutos.Controls.Add(btnpesquisar);
            tabProdutos.Controls.Add(txtpesquisa);
            tabProdutos.Controls.Add(label2);
            tabProdutos.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabProdutos.Location = new Point(4, 24);
            tabProdutos.Name = "tabProdutos";
            tabProdutos.Padding = new Padding(3);
            tabProdutos.Size = new Size(879, 294);
            tabProdutos.TabIndex = 1;
            tabProdutos.Text = "Consulta";
            tabProdutos.UseVisualStyleBackColor = true;
            // 
            // tbgProdutos
            // 
            tbgProdutos.AllowUserToAddRows = false;
            tbgProdutos.AllowUserToDeleteRows = false;
            tbgProdutos.BackgroundColor = Color.FromArgb(192, 192, 255);
            tbgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbgProdutos.GridColor = SystemColors.ActiveBorder;
            tbgProdutos.Location = new Point(13, 71);
            tbgProdutos.Name = "tbgProdutos";
            tbgProdutos.ReadOnly = true;
            tbgProdutos.RowTemplate.Height = 25;
            tbgProdutos.Size = new Size(854, 219);
            tbgProdutos.TabIndex = 38;
            tbgProdutos.CellContentClick += tbgProdutos_CellContentClick;
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
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 499);
            Controls.Add(tabClientes);
            Controls.Add(panel1);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            Load += FrmProdutos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabClientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabProdutos.ResumeLayout(false);
            tabProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbgProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabClientes;
        private TabPage tabPage1;
        private TextBox txtqtd;
        private Label label27;
        private TextBox txtdesc;
        private Label label28;
        private TextBox txtcodigo;
        private Label label29;
        private TabPage tabProdutos;
        private DataGridView tbgProdutos;
        private Button btnpesquisar;
        private TextBox txtpesquisa;
        private Label label2;
        private TextBox textpreco;
        private Label label3;
        private ComboBox cbfornecedor;
        private Label label4;
    }
}