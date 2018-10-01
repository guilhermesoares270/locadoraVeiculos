namespace ProjetoBruno.Telas
{
    partial class Principal
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
            this.Perfil = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nome2 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.Rua = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.UsuarioFoto = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarFoto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Modelo = new System.Windows.Forms.Label();
            this.Cor = new System.Windows.Forms.Label();
            this.Km = new System.Windows.Forms.Label();
            this.Combustivel = new System.Windows.Forms.Label();
            this.Cambio = new System.Windows.Forms.Label();
            this.Porta = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Perfil.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioFoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Perfil
            // 
            this.Perfil.Controls.Add(this.tabPage1);
            this.Perfil.Controls.Add(this.tabPage2);
            this.Perfil.Controls.Add(this.tabPage3);
            this.Perfil.Controls.Add(this.tabPage4);
            this.Perfil.HotTrack = true;
            this.Perfil.Location = new System.Drawing.Point(-3, -1);
            this.Perfil.Name = "Perfil";
            this.Perfil.SelectedIndex = 0;
            this.Perfil.Size = new System.Drawing.Size(807, 455);
            this.Perfil.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Nome);
            this.tabPage1.Controls.Add(this.UsuarioFoto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Perfil";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nome2);
            this.groupBox1.Controls.Add(this.Bairro);
            this.groupBox1.Controls.Add(this.Cargo);
            this.groupBox1.Controls.Add(this.Numero);
            this.groupBox1.Controls.Add(this.Rua);
            this.groupBox1.Location = new System.Drawing.Point(337, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            // 
            // Nome2
            // 
            this.Nome2.AutoSize = true;
            this.Nome2.Location = new System.Drawing.Point(17, 29);
            this.Nome2.Name = "Nome2";
            this.Nome2.Size = new System.Drawing.Size(35, 13);
            this.Nome2.TabIndex = 3;
            this.Nome2.Text = "Nome";
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.Location = new System.Drawing.Point(17, 129);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(34, 13);
            this.Bairro.TabIndex = 7;
            this.Bairro.Text = "Bairro";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Location = new System.Drawing.Point(17, 56);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(35, 13);
            this.Cargo.TabIndex = 4;
            this.Cargo.Text = "Cargo";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(17, 103);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 6;
            this.Numero.Text = "Numero";
            this.Numero.Click += new System.EventHandler(this.label4_Click);
            // 
            // Rua
            // 
            this.Rua.AutoSize = true;
            this.Rua.Location = new System.Drawing.Point(17, 80);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(27, 13);
            this.Rua.TabIndex = 5;
            this.Rua.Text = "Rua";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(94, 191);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 37);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "label1";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsuarioFoto
            // 
            this.UsuarioFoto.Location = new System.Drawing.Point(26, 18);
            this.UsuarioFoto.Name = "UsuarioFoto";
            this.UsuarioFoto.Size = new System.Drawing.Size(243, 170);
            this.UsuarioFoto.TabIndex = 0;
            this.UsuarioFoto.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Buscar);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.CarFoto);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carros";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(799, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Venda";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(799, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Relatório";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busque pelo nome/renavam";
            // 
            // CarFoto
            // 
            this.CarFoto.Location = new System.Drawing.Point(25, 79);
            this.CarFoto.Name = "CarFoto";
            this.CarFoto.Size = new System.Drawing.Size(350, 185);
            this.CarFoto.TabIndex = 2;
            this.CarFoto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Porta);
            this.groupBox2.Controls.Add(this.Cambio);
            this.groupBox2.Controls.Add(this.Combustivel);
            this.groupBox2.Controls.Add(this.Km);
            this.groupBox2.Controls.Add(this.Cor);
            this.groupBox2.Controls.Add(this.Modelo);
            this.groupBox2.Location = new System.Drawing.Point(435, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(9, 27);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(48, 13);
            this.Modelo.TabIndex = 0;
            this.Modelo.Text = "Modelo: ";
            // 
            // Cor
            // 
            this.Cor.AutoSize = true;
            this.Cor.Location = new System.Drawing.Point(9, 50);
            this.Cor.Name = "Cor";
            this.Cor.Size = new System.Drawing.Size(29, 13);
            this.Cor.TabIndex = 1;
            this.Cor.Text = "Cor: ";
            this.Cor.Click += new System.EventHandler(this.label3_Click);
            // 
            // Km
            // 
            this.Km.AutoSize = true;
            this.Km.Location = new System.Drawing.Point(9, 74);
            this.Km.Name = "Km";
            this.Km.Size = new System.Drawing.Size(28, 13);
            this.Km.TabIndex = 2;
            this.Km.Text = "Km: ";
            this.Km.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Combustivel
            // 
            this.Combustivel.AutoSize = true;
            this.Combustivel.Location = new System.Drawing.Point(7, 96);
            this.Combustivel.Name = "Combustivel";
            this.Combustivel.Size = new System.Drawing.Size(72, 13);
            this.Combustivel.TabIndex = 3;
            this.Combustivel.Text = "Combustível: ";
            // 
            // Cambio
            // 
            this.Cambio.AutoSize = true;
            this.Cambio.Location = new System.Drawing.Point(9, 118);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(48, 13);
            this.Cambio.TabIndex = 4;
            this.Cambio.Text = "Câmbio: ";
            // 
            // Porta
            // 
            this.Porta.AutoSize = true;
            this.Porta.Location = new System.Drawing.Point(9, 141);
            this.Porta.Name = "Porta";
            this.Porta.Size = new System.Drawing.Size(38, 13);
            this.Porta.TabIndex = 5;
            this.Porta.Text = "Porta: ";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(231, 31);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(78, 34);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Perfil);
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Perfil.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioFoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Perfil;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.PictureBox UsuarioFoto;
        private System.Windows.Forms.Label Nome2;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label Rua;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox CarFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label Cor;
        private System.Windows.Forms.Label Km;
        private System.Windows.Forms.Label Combustivel;
        private System.Windows.Forms.Label Porta;
        private System.Windows.Forms.Label Cambio;
        private System.Windows.Forms.Button Buscar;
    }
}