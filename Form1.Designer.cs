namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.blimpa = new System.Windows.Forms.Button();
            this.binverte = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bvirgula = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bmais = new System.Windows.Forms.Button();
            this.bmenos = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bdividir = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bvezes = new System.Windows.Forms.Button();
            this.bresultado = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Label();
            this.historico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blimpa
            // 
            this.blimpa.CausesValidation = false;
            this.blimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blimpa.Location = new System.Drawing.Point(12, 111);
            this.blimpa.Name = "blimpa";
            this.blimpa.Size = new System.Drawing.Size(65, 50);
            this.blimpa.TabIndex = 21;
            this.blimpa.TabStop = false;
            this.blimpa.Text = "C";
            this.blimpa.UseVisualStyleBackColor = true;
            this.blimpa.Click += new System.EventHandler(this.blimpar_Click);
            // 
            // binverte
            // 
            this.binverte.CausesValidation = false;
            this.binverte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.binverte.Location = new System.Drawing.Point(83, 111);
            this.binverte.Name = "binverte";
            this.binverte.Size = new System.Drawing.Size(65, 50);
            this.binverte.TabIndex = 22;
            this.binverte.TabStop = false;
            this.binverte.Text = "+-";
            this.binverte.UseVisualStyleBackColor = true;
            this.binverte.Click += new System.EventHandler(this.binverte_Click);
            // 
            // bdelete
            // 
            this.bdelete.CausesValidation = false;
            this.bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdelete.Location = new System.Drawing.Point(154, 111);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(65, 50);
            this.bdelete.TabIndex = 23;
            this.bdelete.TabStop = false;
            this.bdelete.Text = "DEL";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // b7
            // 
            this.b7.CausesValidation = false;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(12, 167);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(65, 50);
            this.b7.TabIndex = 23;
            this.b7.TabStop = false;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b4
            // 
            this.b4.CausesValidation = false;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b4.Location = new System.Drawing.Point(12, 223);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(65, 50);
            this.b4.TabIndex = 24;
            this.b4.TabStop = false;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b8
            // 
            this.b8.CausesValidation = false;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b8.Location = new System.Drawing.Point(83, 167);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(65, 50);
            this.b8.TabIndex = 25;
            this.b8.TabStop = false;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b1
            // 
            this.b1.CausesValidation = false;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b1.Location = new System.Drawing.Point(12, 279);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(65, 50);
            this.b1.TabIndex = 25;
            this.b1.TabStop = false;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // bvirgula
            // 
            this.bvirgula.CausesValidation = false;
            this.bvirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvirgula.Location = new System.Drawing.Point(12, 335);
            this.bvirgula.Name = "bvirgula";
            this.bvirgula.Size = new System.Drawing.Size(65, 50);
            this.bvirgula.TabIndex = 26;
            this.bvirgula.TabStop = false;
            this.bvirgula.Text = ",";
            this.bvirgula.UseVisualStyleBackColor = true;
            this.bvirgula.Click += new System.EventHandler(this.bvirgula_Click);
            // 
            // b9
            // 
            this.b9.CausesValidation = false;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b9.Location = new System.Drawing.Point(154, 167);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(65, 50);
            this.b9.TabIndex = 27;
            this.b9.TabStop = false;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bmais
            // 
            this.bmais.CausesValidation = false;
            this.bmais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmais.Location = new System.Drawing.Point(225, 111);
            this.bmais.Name = "bmais";
            this.bmais.Size = new System.Drawing.Size(65, 50);
            this.bmais.TabIndex = 28;
            this.bmais.TabStop = false;
            this.bmais.Text = "+";
            this.bmais.UseVisualStyleBackColor = true;
            this.bmais.Click += new System.EventHandler(this.bmais_Click);
            // 
            // bmenos
            // 
            this.bmenos.CausesValidation = false;
            this.bmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmenos.Location = new System.Drawing.Point(225, 167);
            this.bmenos.Name = "bmenos";
            this.bmenos.Size = new System.Drawing.Size(65, 50);
            this.bmenos.TabIndex = 29;
            this.bmenos.TabStop = false;
            this.bmenos.Text = "-";
            this.bmenos.UseVisualStyleBackColor = true;
            this.bmenos.Click += new System.EventHandler(this.bmenos_Click);
            // 
            // b5
            // 
            this.b5.CausesValidation = false;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b5.Location = new System.Drawing.Point(83, 223);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(65, 50);
            this.b5.TabIndex = 30;
            this.b5.TabStop = false;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.CausesValidation = false;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b6.Location = new System.Drawing.Point(154, 223);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(65, 50);
            this.b6.TabIndex = 31;
            this.b6.TabStop = false;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b2
            // 
            this.b2.CausesValidation = false;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b2.Location = new System.Drawing.Point(83, 279);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(65, 50);
            this.b2.TabIndex = 31;
            this.b2.TabStop = false;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b0
            // 
            this.b0.CausesValidation = false;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b0.Location = new System.Drawing.Point(83, 335);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(65, 50);
            this.b0.TabIndex = 32;
            this.b0.TabStop = false;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bdividir
            // 
            this.bdividir.CausesValidation = false;
            this.bdividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.bdividir.Location = new System.Drawing.Point(225, 223);
            this.bdividir.Name = "bdividir";
            this.bdividir.Size = new System.Drawing.Size(65, 50);
            this.bdividir.TabIndex = 33;
            this.bdividir.TabStop = false;
            this.bdividir.Text = "/";
            this.bdividir.UseVisualStyleBackColor = true;
            this.bdividir.Click += new System.EventHandler(this.bdividir_Click);
            // 
            // b3
            // 
            this.b3.CausesValidation = false;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.b3.Location = new System.Drawing.Point(154, 279);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(65, 50);
            this.b3.TabIndex = 34;
            this.b3.TabStop = false;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bvezes
            // 
            this.bvezes.CausesValidation = false;
            this.bvezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.bvezes.Location = new System.Drawing.Point(225, 279);
            this.bvezes.Name = "bvezes";
            this.bvezes.Size = new System.Drawing.Size(65, 50);
            this.bvezes.TabIndex = 36;
            this.bvezes.TabStop = false;
            this.bvezes.Text = "x";
            this.bvezes.UseVisualStyleBackColor = true;
            this.bvezes.Click += new System.EventHandler(this.bvezes_Click);
            // 
            // bresultado
            // 
            this.bresultado.CausesValidation = false;
            this.bresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bresultado.Location = new System.Drawing.Point(154, 335);
            this.bresultado.Name = "bresultado";
            this.bresultado.Size = new System.Drawing.Size(136, 50);
            this.bresultado.TabIndex = 37;
            this.bresultado.TabStop = false;
            this.bresultado.Text = "=";
            this.bresultado.UseVisualStyleBackColor = true;
            this.bresultado.Click += new System.EventHandler(this.bresultado_Click);
            // 
            // tela
            // 
            this.tela.AutoSize = true;
            this.tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tela.Location = new System.Drawing.Point(12, 71);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(0, 37);
            this.tela.TabIndex = 38;
            // 
            // historico
            // 
            this.historico.AutoSize = true;
            this.historico.Location = new System.Drawing.Point(15, 13);
            this.historico.Name = "historico";
            this.historico.Size = new System.Drawing.Size(0, 13);
            this.historico.TabIndex = 39;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 402);
            this.Controls.Add(this.historico);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.bresultado);
            this.Controls.Add(this.bvezes);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.bdividir);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.bmenos);
            this.Controls.Add(this.bmais);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.bvirgula);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.binverte);
            this.Controls.Add(this.blimpa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button blimpa;
        private System.Windows.Forms.Button binverte;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bvirgula;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bmais;
        private System.Windows.Forms.Button bmenos;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bdividir;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bvezes;
        private System.Windows.Forms.Button bresultado;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Label historico;
    }
}

