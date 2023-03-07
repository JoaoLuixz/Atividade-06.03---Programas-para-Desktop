namespace Atividade_06._03
{
    partial class Salario
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
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbValorHora = new System.Windows.Forms.Label();
            this.lbHorasTrabalhadas = new System.Windows.Forms.Label();
            this.lbSalario = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbArrow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(12, 112);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(49, 22);
            this.lbCPF.TabIndex = 0;
            this.lbCPF.Text = "CPF";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 153);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(61, 22);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbValorHora
            // 
            this.lbValorHora.AutoSize = true;
            this.lbValorHora.Location = new System.Drawing.Point(12, 199);
            this.lbValorHora.Name = "lbValorHora";
            this.lbValorHora.Size = new System.Drawing.Size(98, 22);
            this.lbValorHora.TabIndex = 2;
            this.lbValorHora.Text = "Valor Hora";
            // 
            // lbHorasTrabalhadas
            // 
            this.lbHorasTrabalhadas.AutoSize = true;
            this.lbHorasTrabalhadas.Location = new System.Drawing.Point(12, 247);
            this.lbHorasTrabalhadas.Name = "lbHorasTrabalhadas";
            this.lbHorasTrabalhadas.Size = new System.Drawing.Size(168, 22);
            this.lbHorasTrabalhadas.TabIndex = 3;
            this.lbHorasTrabalhadas.Text = "Horas Trabalhadas";
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(478, 215);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(68, 22);
            this.lbSalario.TabIndex = 4;
            this.lbSalario.Text = "Salário";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(204, 109);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(182, 29);
            this.txtCPF.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(204, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 29);
            this.txtNome.TabIndex = 6;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(204, 192);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(182, 29);
            this.txtValorHora.TabIndex = 7;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(204, 240);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(182, 29);
            this.txtHorasTrabalhadas.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(417, 240);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(182, 29);
            this.txtSalario.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(455, 109);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 66);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(204, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(197, 32);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Calcula Salário";
            // 
            // lbArrow
            // 
            this.lbArrow.AutoSize = true;
            this.lbArrow.Location = new System.Drawing.Point(499, 178);
            this.lbArrow.Name = "lbArrow";
            this.lbArrow.Size = new System.Drawing.Size(27, 22);
            this.lbArrow.TabIndex = 12;
            this.lbArrow.Text = "->";
            // 
            // Salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 346);
            this.Controls.Add(this.lbArrow);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbHorasTrabalhadas);
            this.Controls.Add(this.lbValorHora);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCPF);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Salario";
            this.Text = "Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCPF;
        private Label lbNome;
        private Label lbValorHora;
        private Label lbHorasTrabalhadas;
        private Label lbSalario;
        private TextBox txtCPF;
        private TextBox txtNome;
        private TextBox txtValorHora;
        private TextBox txtHorasTrabalhadas;
        private TextBox txtSalario;
        private Button btnCalcular;
        private Label lbTitulo;
        private Label lbArrow;
    }
}