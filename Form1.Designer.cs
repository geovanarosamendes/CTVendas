namespace ControleDeVendas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoClienteToolStripMenuItem = new ToolStripMenuItem();
            visualizarClientesToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoForneceToolStripMenuItem = new ToolStripMenuItem();
            visualizarFornecedoresToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            cadasToolStripMenuItem = new ToolStripMenuItem();
            meusVendedoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            adicionarProdutoToolStripMenuItem = new ToolStripMenuItem();
            visualizarProdutosToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            novaVendaToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(505, 32);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(247, 35);
            label1.TabIndex = 0;
            label1.Text = "GM SALES CONTROL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 97);
            panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 0, 64);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, fornecedorToolStripMenuItem, vendedorToolStripMenuItem, produtosToolStripMenuItem, vendaToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(277, 82);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.White;
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoClienteToolStripMenuItem, visualizarClientesToolStripMenuItem });
            clientesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(84, 29);
            clientesToolStripMenuItem.Text = "Cliente";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // cadastrarNovoClienteToolStripMenuItem
            // 
            cadastrarNovoClienteToolStripMenuItem.Name = "cadastrarNovoClienteToolStripMenuItem";
            cadastrarNovoClienteToolStripMenuItem.Size = new Size(283, 30);
            cadastrarNovoClienteToolStripMenuItem.Text = "Cadastrar Novo Cliente";
            // 
            // visualizarClientesToolStripMenuItem
            // 
            visualizarClientesToolStripMenuItem.Name = "visualizarClientesToolStripMenuItem";
            visualizarClientesToolStripMenuItem.Size = new Size(283, 30);
            visualizarClientesToolStripMenuItem.Text = "Visualizar Clientes";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.BackColor = Color.White;
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoForneceToolStripMenuItem, visualizarFornecedoresToolStripMenuItem });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(139, 29);
            fornecedorToolStripMenuItem.Text = "Fornecedores";
            fornecedorToolStripMenuItem.Click += fornecedorToolStripMenuItem_Click;
            // 
            // cadastrarNovoForneceToolStripMenuItem
            // 
            cadastrarNovoForneceToolStripMenuItem.Name = "cadastrarNovoForneceToolStripMenuItem";
            cadastrarNovoForneceToolStripMenuItem.Size = new Size(286, 30);
            cadastrarNovoForneceToolStripMenuItem.Text = "Cadastrar Fornecedor";
            cadastrarNovoForneceToolStripMenuItem.Click += cadastrarNovoForneceToolStripMenuItem_Click;
            // 
            // visualizarFornecedoresToolStripMenuItem
            // 
            visualizarFornecedoresToolStripMenuItem.Name = "visualizarFornecedoresToolStripMenuItem";
            visualizarFornecedoresToolStripMenuItem.Size = new Size(286, 30);
            visualizarFornecedoresToolStripMenuItem.Text = "Visualizar Fornecedores";
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.BackColor = Color.White;
            vendedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadasToolStripMenuItem, meusVendedoresToolStripMenuItem });
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(106, 29);
            vendedorToolStripMenuItem.Text = "Vendedor";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
            // 
            // cadasToolStripMenuItem
            // 
            cadasToolStripMenuItem.Name = "cadasToolStripMenuItem";
            cadasToolStripMenuItem.Size = new Size(253, 30);
            cadasToolStripMenuItem.Text = "Cadastrar Vendedor";
            // 
            // meusVendedoresToolStripMenuItem
            // 
            meusVendedoresToolStripMenuItem.Name = "meusVendedoresToolStripMenuItem";
            meusVendedoresToolStripMenuItem.Size = new Size(253, 30);
            meusVendedoresToolStripMenuItem.Text = "Meus Vendedores";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.BackColor = Color.White;
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarProdutoToolStripMenuItem, visualizarProdutosToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(101, 29);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // adicionarProdutoToolStripMenuItem
            // 
            adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
            adicionarProdutoToolStripMenuItem.Size = new Size(248, 30);
            adicionarProdutoToolStripMenuItem.Text = "Adicionar Produto";
            // 
            // visualizarProdutosToolStripMenuItem
            // 
            visualizarProdutosToolStripMenuItem.Name = "visualizarProdutosToolStripMenuItem";
            visualizarProdutosToolStripMenuItem.Size = new Size(248, 30);
            visualizarProdutosToolStripMenuItem.Text = "Visualizar Produtos";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.BackColor = Color.White;
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaVendaToolStripMenuItem });
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(77, 29);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // novaVendaToolStripMenuItem
            // 
            novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            novaVendaToolStripMenuItem.Size = new Size(188, 30);
            novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.BackColor = Color.White;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(147, 29);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = Color.White;
            toolStripContainer1.ContentPanel.Controls.Add(menuStrip1);
            toolStripContainer1.ContentPanel.Size = new Size(1235, 442);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 97);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1235, 442);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(1235, 539);
            Controls.Add(toolStripContainer1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "GM SALES CONTROL";
            TransparencyKey = Color.Crimson;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem cadastrarNovoClienteToolStripMenuItem;
        private ToolStripMenuItem visualizarClientesToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem cadastrarNovoForneceToolStripMenuItem;
        private ToolStripMenuItem visualizarFornecedoresToolStripMenuItem;
        private ToolStripMenuItem cadasToolStripMenuItem;
        private ToolStripMenuItem meusVendedoresToolStripMenuItem;
        private ToolStripMenuItem adicionarProdutoToolStripMenuItem;
        private ToolStripMenuItem visualizarProdutosToolStripMenuItem;
        private ToolStripMenuItem novaVendaToolStripMenuItem;
    }
}