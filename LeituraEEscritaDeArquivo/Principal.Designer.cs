
namespace LeituraEEscritaDeArquivo
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.txtLocalArquivoEntrada = new System.Windows.Forms.TextBox();
            this.lblArquivoEntrada = new System.Windows.Forms.Label();
            this.btnBuscarArquivoEntrada = new System.Windows.Forms.Button();
            this.txtLocalArquivoSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarAquivoSaida = new System.Windows.Forms.Button();
            this.btnLimparArquivoEntrada = new System.Windows.Forms.Button();
            this.btnLocalArquivoSaida = new System.Windows.Forms.Button();
            this.btnLimparLocalArquivoSaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocalArquivoEntrada
            // 
            this.txtLocalArquivoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalArquivoEntrada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArquivoEntrada.Location = new System.Drawing.Point(199, 16);
            this.txtLocalArquivoEntrada.Name = "txtLocalArquivoEntrada";
            this.txtLocalArquivoEntrada.ReadOnly = true;
            this.txtLocalArquivoEntrada.Size = new System.Drawing.Size(467, 30);
            this.txtLocalArquivoEntrada.TabIndex = 0;
            // 
            // lblArquivoEntrada
            // 
            this.lblArquivoEntrada.AutoSize = true;
            this.lblArquivoEntrada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoEntrada.Location = new System.Drawing.Point(12, 19);
            this.lblArquivoEntrada.Name = "lblArquivoEntrada";
            this.lblArquivoEntrada.Size = new System.Drawing.Size(161, 23);
            this.lblArquivoEntrada.TabIndex = 1;
            this.lblArquivoEntrada.Text = "Arquivo de Entrada:";
            // 
            // btnBuscarArquivoEntrada
            // 
            this.btnBuscarArquivoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArquivoEntrada.FlatAppearance.BorderSize = 0;
            this.btnBuscarArquivoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArquivoEntrada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArquivoEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarArquivoEntrada.Image")));
            this.btnBuscarArquivoEntrada.Location = new System.Drawing.Point(672, 6);
            this.btnBuscarArquivoEntrada.Name = "btnBuscarArquivoEntrada";
            this.btnBuscarArquivoEntrada.Size = new System.Drawing.Size(44, 48);
            this.btnBuscarArquivoEntrada.TabIndex = 2;
            this.btnBuscarArquivoEntrada.UseVisualStyleBackColor = true;
            this.btnBuscarArquivoEntrada.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtLocalArquivoSaida
            // 
            this.txtLocalArquivoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalArquivoSaida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArquivoSaida.Location = new System.Drawing.Point(199, 70);
            this.txtLocalArquivoSaida.Name = "txtLocalArquivoSaida";
            this.txtLocalArquivoSaida.ReadOnly = true;
            this.txtLocalArquivoSaida.Size = new System.Drawing.Size(467, 30);
            this.txtLocalArquivoSaida.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquivo de Saída:";
            // 
            // btnGerarAquivoSaida
            // 
            this.btnGerarAquivoSaida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarAquivoSaida.Location = new System.Drawing.Point(179, 126);
            this.btnGerarAquivoSaida.Name = "btnGerarAquivoSaida";
            this.btnGerarAquivoSaida.Size = new System.Drawing.Size(116, 26);
            this.btnGerarAquivoSaida.TabIndex = 2;
            this.btnGerarAquivoSaida.Text = "Gerar Arquivo";
            this.btnGerarAquivoSaida.UseVisualStyleBackColor = true;
            this.btnGerarAquivoSaida.Click += new System.EventHandler(this.btnGerarAquivoSaida_Click);
            // 
            // btnLimparArquivoEntrada
            // 
            this.btnLimparArquivoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparArquivoEntrada.FlatAppearance.BorderSize = 0;
            this.btnLimparArquivoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparArquivoEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btnLimparArquivoEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparArquivoEntrada.Image")));
            this.btnLimparArquivoEntrada.Location = new System.Drawing.Point(672, 6);
            this.btnLimparArquivoEntrada.Name = "btnLimparArquivoEntrada";
            this.btnLimparArquivoEntrada.Size = new System.Drawing.Size(44, 48);
            this.btnLimparArquivoEntrada.TabIndex = 2;
            this.btnLimparArquivoEntrada.UseVisualStyleBackColor = true;
            this.btnLimparArquivoEntrada.Visible = false;
            this.btnLimparArquivoEntrada.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLocalArquivoSaida
            // 
            this.btnLocalArquivoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalArquivoSaida.FlatAppearance.BorderSize = 0;
            this.btnLocalArquivoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalArquivoSaida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalArquivoSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalArquivoSaida.Image")));
            this.btnLocalArquivoSaida.Location = new System.Drawing.Point(672, 60);
            this.btnLocalArquivoSaida.Name = "btnLocalArquivoSaida";
            this.btnLocalArquivoSaida.Size = new System.Drawing.Size(44, 48);
            this.btnLocalArquivoSaida.TabIndex = 3;
            this.btnLocalArquivoSaida.UseVisualStyleBackColor = true;
            this.btnLocalArquivoSaida.Click += new System.EventHandler(this.btnLocalArquivoSaida_Click);
            // 
            // btnLimparLocalArquivoSaida
            // 
            this.btnLimparLocalArquivoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparLocalArquivoSaida.FlatAppearance.BorderSize = 0;
            this.btnLimparLocalArquivoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparLocalArquivoSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btnLimparLocalArquivoSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparLocalArquivoSaida.Image")));
            this.btnLimparLocalArquivoSaida.Location = new System.Drawing.Point(672, 60);
            this.btnLimparLocalArquivoSaida.Name = "btnLimparLocalArquivoSaida";
            this.btnLimparLocalArquivoSaida.Size = new System.Drawing.Size(44, 48);
            this.btnLimparLocalArquivoSaida.TabIndex = 4;
            this.btnLimparLocalArquivoSaida.UseVisualStyleBackColor = true;
            this.btnLimparLocalArquivoSaida.Visible = false;
            this.btnLimparLocalArquivoSaida.Click += new System.EventHandler(this.btnLimparLocalArquivoSaida_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 189);
            this.Controls.Add(this.btnGerarAquivoSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArquivoEntrada);
            this.Controls.Add(this.txtLocalArquivoSaida);
            this.Controls.Add(this.txtLocalArquivoEntrada);
            this.Controls.Add(this.btnLimparLocalArquivoSaida);
            this.Controls.Add(this.btnLimparArquivoEntrada);
            this.Controls.Add(this.btnBuscarArquivoEntrada);
            this.Controls.Add(this.btnLocalArquivoSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitura e Escrita de Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalArquivoEntrada;
        private System.Windows.Forms.Label lblArquivoEntrada;
        private System.Windows.Forms.Button btnBuscarArquivoEntrada;
        private System.Windows.Forms.TextBox txtLocalArquivoSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerarAquivoSaida;
        private System.Windows.Forms.Button btnLimparArquivoEntrada;
        private System.Windows.Forms.Button btnLocalArquivoSaida;
        private System.Windows.Forms.Button btnLimparLocalArquivoSaida;
    }
}

