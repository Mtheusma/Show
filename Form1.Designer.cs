namespace DasafioPizza
{
    partial class Form1
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
            this.txtVerificarnome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pibPizza = new System.Windows.Forms.PictureBox();
            this.lblResultadodetudo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVerificarnome
            // 
            this.txtVerificarnome.BackColor = System.Drawing.Color.Lime;
            this.txtVerificarnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificarnome.ForeColor = System.Drawing.Color.Red;
            this.txtVerificarnome.Location = new System.Drawing.Point(129, 152);
            this.txtVerificarnome.Multiline = true;
            this.txtVerificarnome.Name = "txtVerificarnome";
            this.txtVerificarnome.Size = new System.Drawing.Size(300, 27);
            this.txtVerificarnome.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = global::DasafioPizza.Properties.Resources.Feliz1;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(185, 339);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackgroundImage = global::DasafioPizza.Properties.Resources.fundo1;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Snow;
            this.btnVerificar.Location = new System.Drawing.Point(21, 324);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(130, 59);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::DasafioPizza.Properties.Resources.Pensado3;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(224, 370);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(218, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.Color.Lime;
            this.txtSobrenome.Font = new System.Drawing.Font("Bauhaus 93", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSobrenome.Location = new System.Drawing.Point(129, 226);
            this.txtSobrenome.Multiline = true;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(300, 27);
            this.txtSobrenome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Lime;
            this.lblNome.Location = new System.Drawing.Point(9, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(119, 16);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Verificar Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lblSobrenome.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.ForeColor = System.Drawing.Color.Lime;
            this.lblSobrenome.Location = new System.Drawing.Point(24, 226);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(99, 19);
            this.lblSobrenome.TabIndex = 7;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.Lime;
            this.txtData.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.Maroon;
            this.txtData.Location = new System.Drawing.Point(176, 284);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 28);
            this.txtData.TabIndex = 8;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.Lime;
            this.lblAno.Location = new System.Drawing.Point(51, 284);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(119, 19);
            this.lblAno.TabIndex = 9;
            this.lblAno.Text = "Ano de Nasc";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Symusic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Lime;
            this.lblTitulo.Location = new System.Drawing.Point(106, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 42);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "SHOW DOS HORRORES";
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(18, 61);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(0, 13);
            this.lblDataAtual.TabIndex = 11;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(442, 349);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 12;
            // 
            // pibPizza
            // 
            this.pibPizza.Image = global::DasafioPizza.Properties.Resources.Pensado3;
            this.pibPizza.Location = new System.Drawing.Point(435, 61);
            this.pibPizza.Name = "pibPizza";
            this.pibPizza.Size = new System.Drawing.Size(280, 269);
            this.pibPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibPizza.TabIndex = 1;
            this.pibPizza.TabStop = false;
            // 
            // lblResultadodetudo
            // 
            this.lblResultadodetudo.AutoSize = true;
            this.lblResultadodetudo.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadodetudo.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadodetudo.Location = new System.Drawing.Point(347, 289);
            this.lblResultadodetudo.Name = "lblResultadodetudo";
            this.lblResultadodetudo.Size = new System.Drawing.Size(0, 17);
            this.lblResultadodetudo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DasafioPizza.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(737, 396);
            this.Controls.Add(this.lblResultadodetudo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pibPizza);
            this.Controls.Add(this.txtVerificarnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVerificarnome;
        private System.Windows.Forms.PictureBox pibPizza;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadodetudo;
    }
}

