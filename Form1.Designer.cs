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
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoClienteToolStripMenuItem = new ToolStripMenuItem();
            visualizarClientesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoForneceToolStripMenuItem = new ToolStripMenuItem();
            visualizarFornecedoresToolStripMenuItem = new ToolStripMenuItem();
            cadasToolStripMenuItem = new ToolStripMenuItem();
            meusVendedoresToolStripMenuItem = new ToolStripMenuItem();
            adicionarProdutoToolStripMenuItem = new ToolStripMenuItem();
            visualizarProdutosToolStripMenuItem = new ToolStripMenuItem();
            novaVendaToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(486, 31);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(249, 37);
            label1.TabIndex = 0;
            label1.Text = "GM SALES CONTROL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 97);
            panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, fornecedorToolStripMenuItem, vendedorToolStripMenuItem, produtosToolStripMenuItem, vendaToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(443, 14);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(561, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoClienteToolStripMenuItem, visualizarClientesToolStripMenuItem });
            clientesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(56, 20);
            clientesToolStripMenuItem.Text = "Cliente";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoForneceToolStripMenuItem, visualizarFornecedoresToolStripMenuItem });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(90, 20);
            fornecedorToolStripMenuItem.Text = "Fornecedores";
            fornecedorToolStripMenuItem.Click += fornecedorToolStripMenuItem_Click;
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadasToolStripMenuItem, meusVendedoresToolStripMenuItem });
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(69, 20);
            vendedorToolStripMenuItem.Text = "Vendedor";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarProdutoToolStripMenuItem, visualizarProdutosToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaVendaToolStripMenuItem });
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(51, 20);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
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
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // cadastrarNovoClienteToolStripMenuItem
            // 
            cadastrarNovoClienteToolStripMenuItem.Name = "cadastrarNovoClienteToolStripMenuItem";
            cadastrarNovoClienteToolStripMenuItem.Size = new Size(196, 22);
            cadastrarNovoClienteToolStripMenuItem.Text = "Cadastrar Novo Cliente";
            // 
            // visualizarClientesToolStripMenuItem
            // 
            visualizarClientesToolStripMenuItem.Name = "visualizarClientesToolStripMenuItem";
            visualizarClientesToolStripMenuItem.Size = new Size(196, 22);
            visualizarClientesToolStripMenuItem.Text = "Visualizar Clientes";
            // 
            // cadastrarNovoForneceToolStripMenuItem
            // 
            cadastrarNovoForneceToolStripMenuItem.Name = "cadastrarNovoForneceToolStripMenuItem";
            cadastrarNovoForneceToolStripMenuItem.Size = new Size(197, 22);
            cadastrarNovoForneceToolStripMenuItem.Text = "Cadastrar Fornecedor";
            cadastrarNovoForneceToolStripMenuItem.Click += cadastrarNovoForneceToolStripMenuItem_Click;
            // 
            // visualizarFornecedoresToolStripMenuItem
            // 
            visualizarFornecedoresToolStripMenuItem.Name = "visualizarFornecedoresToolStripMenuItem";
            visualizarFornecedoresToolStripMenuItem.Size = new Size(197, 22);
            visualizarFornecedoresToolStripMenuItem.Text = "Visualizar Fornecedores";
            // 
            // cadasToolStripMenuItem
            // 
            cadasToolStripMenuItem.Name = "cadasToolStripMenuItem";
            cadasToolStripMenuItem.Size = new Size(180, 22);
            cadasToolStripMenuItem.Text = "Cadastrar Vendedor";
            // 
            // meusVendedoresToolStripMenuItem
            // 
            meusVendedoresToolStripMenuItem.Name = "meusVendedoresToolStripMenuItem";
            meusVendedoresToolStripMenuItem.Size = new Size(180, 22);
            meusVendedoresToolStripMenuItem.Text = "Meus Vendedores";
            // 
            // adicionarProdutoToolStripMenuItem
            // 
            adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
            adicionarProdutoToolStripMenuItem.Size = new Size(180, 22);
            adicionarProdutoToolStripMenuItem.Text = "Adicionar Produto";
            // 
            // visualizarProdutosToolStripMenuItem
            // 
            visualizarProdutosToolStripMenuItem.Name = "visualizarProdutosToolStripMenuItem";
            visualizarProdutosToolStripMenuItem.Size = new Size(180, 22);
            visualizarProdutosToolStripMenuItem.Text = "Visualizar Produtos";
            // 
            // novaVendaToolStripMenuItem
            // 
            novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            novaVendaToolStripMenuItem.Size = new Size(180, 22);
            novaVendaToolStripMenuItem.Text = "Nova Venda";
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