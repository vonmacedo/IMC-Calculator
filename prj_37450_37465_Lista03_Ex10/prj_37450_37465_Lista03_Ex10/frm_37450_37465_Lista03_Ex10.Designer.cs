namespace prj_37450_37465_Lista03_Ex10
{
    partial class frm_37450_37465_Lista03_Ex10
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bttverifcar = new System.Windows.Forms.Button();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.cmdsexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(83, 200);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(215, 44);
            this.txtresultado.TabIndex = 39;
            this.txtresultado.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(295, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 27);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(29, 274);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 31);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bttverifcar
            // 
            this.bttverifcar.Location = new System.Drawing.Point(159, 276);
            this.bttverifcar.Name = "bttverifcar";
            this.bttverifcar.Size = new System.Drawing.Size(80, 31);
            this.bttverifcar.TabIndex = 34;
            this.bttverifcar.Text = "Verificar";
            this.bttverifcar.UseVisualStyleBackColor = true;
            this.bttverifcar.Click += new System.EventHandler(this.bttverifcar_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(60, 143);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 37;
            this.lblaltura.Text = "Altura";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(60, 103);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(31, 13);
            this.lblpeso.TabIndex = 35;
            this.lblpeso.Text = "Peso";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(60, 58);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 33;
            this.lblsexo.Text = "Sexo";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(126, 136);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(130, 20);
            this.txtaltura.TabIndex = 32;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(126, 96);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(130, 20);
            this.txtpeso.TabIndex = 31;
            // 
            // cmdsexo
            // 
            this.cmdsexo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmdsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdsexo.FormatString = "a";
            this.cmdsexo.FormattingEnabled = true;
            this.cmdsexo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmdsexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmdsexo.Location = new System.Drawing.Point(126, 50);
            this.cmdsexo.Name = "cmdsexo";
            this.cmdsexo.Size = new System.Drawing.Size(131, 21);
            this.cmdsexo.TabIndex = 40;
            this.cmdsexo.SelectedIndexChanged += new System.EventHandler(this.cmdsexo_SelectedIndexChanged);
            // 
            // frm_37450_37465_Lista03_Ex10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 342);
            this.Controls.Add(this.cmdsexo);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.bttverifcar);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_37450_37465_Lista03_Ex10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button bttverifcar;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.ComboBox cmdsexo;
    }
}

