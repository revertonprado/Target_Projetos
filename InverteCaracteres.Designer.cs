namespace Target_Projetos
{
    partial class InverteCaracteres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InverteCaracteres));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtInvertido = new System.Windows.Forms.TextBox();
            this.btnInverte = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inverte Caracteres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite um texto";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(197, 135);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(415, 33);
            this.txtTexto.TabIndex = 2;
            // 
            // txtInvertido
            // 
            this.txtInvertido.Enabled = false;
            this.txtInvertido.Location = new System.Drawing.Point(83, 267);
            this.txtInvertido.Name = "txtInvertido";
            this.txtInvertido.Size = new System.Drawing.Size(505, 33);
            this.txtInvertido.TabIndex = 3;
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(60, 190);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(166, 50);
            this.btnInverte.TabIndex = 4;
            this.btnInverte.Text = "Inverter";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.Inverter);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(239, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(166, 50);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Sair);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(422, 190);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 50);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // InverteCaracteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Target_Projetos.Properties.Resources.logo_target;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 414);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.txtInvertido);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InverteCaracteres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inverte Caracteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtInvertido;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}