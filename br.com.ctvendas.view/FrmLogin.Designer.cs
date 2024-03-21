namespace ControleDeVendas.br.com.ctvendas.view
{
    partial class FrmLogin
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
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 117);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 64);
            label3.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(176, 39);
            label3.Name = "label3";
            label3.Size = new Size(451, 44);
            label3.TabIndex = 54;
            label3.Text = "GM Controle de Vendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(176, 177);
            label1.Name = "label1";
            label1.Size = new Size(466, 44);
            label1.TabIndex = 0;
            label1.Text = "Autenticação do Sistema";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(230, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 33);
            textBox1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(164, 305);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 39;
            label5.Text = "E-mail:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(230, 354);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(272, 33);
            textBox2.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(164, 354);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 41;
            label2.Text = "Senha:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(269, 493);
            button1.Name = "button1";
            button1.Size = new Size(173, 55);
            button1.TabIndex = 53;
            button1.Text = "Acessar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 589);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}