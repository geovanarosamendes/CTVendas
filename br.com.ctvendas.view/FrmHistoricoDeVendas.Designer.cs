namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmHistoricoDeVendas
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
            button3 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label28 = new Label();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            DataVenda = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 117);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(294, 33);
            label1.Name = "label1";
            label1.Size = new Size(374, 44);
            label1.TabIndex = 0;
            label1.Text = " Vendas Realizadas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label28);
            groupBox1.Location = new Point(12, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 131);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(692, 45);
            button3.Name = "button3";
            button3.Size = new Size(156, 49);
            button3.TabIndex = 9;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(124, 69);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(124, 29);
            dateTimePicker2.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(124, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 29);
            dateTimePicker1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(36, 73);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 37;
            label2.Text = "Data Final:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.FromArgb(0, 0, 64);
            label28.Location = new Point(32, 26);
            label28.Name = "label28";
            label28.Size = new Size(86, 21);
            label28.TabIndex = 36;
            label28.Text = "Data início:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, DataVenda, Cliente, Total, Obs });
            dataGridView1.Location = new Point(12, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(900, 220);
            dataGridView1.TabIndex = 5;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            codigo.Frozen = true;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 71;
            // 
            // DataVenda
            // 
            DataVenda.HeaderText = "Data da Venda";
            DataVenda.Name = "DataVenda";
            DataVenda.Width = 150;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.Width = 250;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 150;
            // 
            // Obs
            // 
            Obs.HeaderText = "Observação";
            Obs.Name = "Obs";
            Obs.Width = 250;
            // 
            // FrmHistoricoDeVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 490);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmHistoricoDeVendas";
            Text = "FrmHistoricoDeVendas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label28;
        private DateTimePicker dateTimePicker2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn DataVenda;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Obs;
    }
}