namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmVenda
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtnome = new TextBox();
            label28 = new Label();
            txtcpf = new MaskedTextBox();
            label25 = new Label();
            textpreco = new TextBox();
            label3 = new Label();
            txtcodigo = new TextBox();
            label29 = new Label();
            txtdesc = new TextBox();
            label2 = new Label();
            txtqtd = new TextBox();
            label27 = new Label();
            btnnovo = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 117);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(272, 44);
            label1.Name = "label1";
            label1.Size = new Size(423, 44);
            label1.TabIndex = 0;
            label1.Text = "PAINEL DE VENDAS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtcpf);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(txtnome);
            groupBox1.Controls.Add(label28);
            groupBox1.Location = new Point(12, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 162);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnnovo);
            groupBox2.Controls.Add(txtqtd);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(txtdesc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtcodigo);
            groupBox2.Controls.Add(label29);
            groupBox2.Controls.Add(textpreco);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 204);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(66, 91);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(338, 23);
            txtnome.TabIndex = 36;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.Purple;
            label28.Location = new Point(17, 94);
            label28.Name = "label28";
            label28.Size = new Size(43, 15);
            label28.TabIndex = 35;
            label28.Text = "Nome:";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(58, 39);
            txtcpf.Mask = "###.###.###-##";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(143, 23);
            txtcpf.TabIndex = 42;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Purple;
            label25.Location = new Point(16, 45);
            label25.Name = "label25";
            label25.Size = new Size(31, 15);
            label25.TabIndex = 41;
            label25.Text = "CPF:";
            // 
            // textpreco
            // 
            textpreco.Location = new Point(99, 103);
            textpreco.Name = "textpreco";
            textpreco.Size = new Size(120, 23);
            textpreco.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 39;
            label3.Text = "Preço (R$):";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(66, 20);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(91, 23);
            txtcodigo.TabIndex = 42;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.Purple;
            label29.Location = new Point(11, 23);
            label29.Name = "label29";
            label29.Size = new Size(49, 15);
            label29.TabIndex = 41;
            label29.Text = "Código:";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(73, 51);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(323, 23);
            txtdesc.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(9, 54);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 43;
            label2.Text = "Descrição:";
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(270, 103);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(108, 23);
            txtqtd.TabIndex = 46;
            txtqtd.TextChanged += txtqtd_TextChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.Purple;
            label27.Location = new Point(234, 106);
            label27.Name = "label27";
            label27.Size = new Size(30, 15);
            label27.TabIndex = 45;
            label27.Text = "Qtd:";
            label27.Click += label27_Click;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.Purple;
            btnnovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnnovo.ForeColor = SystemColors.ButtonFace;
            btnnovo.Location = new Point(16, 146);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(156, 49);
            btnnovo.TabIndex = 5;
            btnnovo.Text = "Adicionar Produto";
            btnnovo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(234, 146);
            button1.Name = "button1";
            button1.Size = new Size(144, 49);
            button1.TabIndex = 47;
            button1.Text = "Remover Produto";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(527, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(414, 250);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(592, 379);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(287, 71);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(16, 30);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 35;
            label5.Text = "Total (R$): ";
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(527, 481);
            button2.Name = "button2";
            button2.Size = new Size(156, 49);
            button2.TabIndex = 7;
            button2.Text = "Pagamento";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(785, 481);
            button3.Name = "button3";
            button3.Size = new Size(156, 49);
            button3.TabIndex = 8;
            button3.Text = "Cancelar Venda";
            button3.UseVisualStyleBackColor = false;
            // 
            // FrmVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 554);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmVenda";
            Text = "FrmVenda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtnome;
        private Label label28;
        private MaskedTextBox txtcpf;
        private Label label25;
        private TextBox textpreco;
        private Label label3;
        private TextBox txtcodigo;
        private Label label29;
        private TextBox txtdesc;
        private Label label2;
        private TextBox txtqtd;
        private Label label27;
        private Button button1;
        private Button btnnovo;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}