namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmDetalhesDaVenda
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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            txtnome = new TextBox();
            label2 = new Label();
            label28 = new Label();
            dataGridView1 = new DataGridView();
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
            panel1.Size = new Size(946, 117);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(297, 37);
            label1.Name = "label1";
            label1.Size = new Size(363, 44);
            label1.TabIndex = 0;
            label1.Text = "Detalhes da Venda";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtnome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label28);
            groupBox1.Location = new Point(12, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(929, 219);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(68, 111);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(806, 82);
            textBox3.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(21, 111);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 44;
            label4.Text = "Obs:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 43;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(546, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(437, 30);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 41;
            label3.Text = "Total da venda:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(80, 28);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(338, 23);
            txtnome.TabIndex = 40;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(21, 69);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 37;
            label2.Text = "Data:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.FromArgb(0, 0, 64);
            label28.Location = new Point(21, 26);
            label28.Name = "label28";
            label28.Size = new Size(65, 21);
            label28.TabIndex = 36;
            label28.Text = "Cliente: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(927, 173);
            dataGridView1.TabIndex = 6;
            // 
            // FrmDetalhesDaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 534);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmDetalhesDaVenda";
            Text = "FrmDetalhesDaVenda";
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
        private Label label2;
        private Label label28;
        private TextBox txtnome;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private DataGridView dataGridView1;
    }
}