namespace Projecto_NH_CARS
{
    partial class Frm_Pesquisas_Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pesquisas_Carro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rdb_Modelos = new System.Windows.Forms.RadioButton();
            this.Rdb_Carros_Por_Modelos = new System.Windows.Forms.RadioButton();
            this.Rdb_Carros_Por_Marcas = new System.Windows.Forms.RadioButton();
            this.Rdb_Carros_Disponiveis = new System.Windows.Forms.RadioButton();
            this.Rdb_Carros_Vendidos = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgv_Pesquisas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pesquisas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_Texto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 42);
            this.panel2.TabIndex = 12;
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Texto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_Texto.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Texto.Location = new System.Drawing.Point(4, 4);
            this.lbl_Texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(520, 31);
            this.lbl_Texto.TabIndex = 9;
            this.lbl_Texto.Text = "Pesquisas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Pesquisar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Pesquisa);
            this.panel1.Controls.Add(this.Rdb_Modelos);
            this.panel1.Controls.Add(this.Rdb_Carros_Por_Modelos);
            this.panel1.Controls.Add(this.Rdb_Carros_Por_Marcas);
            this.panel1.Controls.Add(this.Rdb_Carros_Disponiveis);
            this.panel1.Controls.Add(this.Rdb_Carros_Vendidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(592, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 279);
            this.panel1.TabIndex = 13;
            // 
            // Rdb_Modelos
            // 
            this.Rdb_Modelos.AutoSize = true;
            this.Rdb_Modelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Modelos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Modelos.Location = new System.Drawing.Point(6, 120);
            this.Rdb_Modelos.Name = "Rdb_Modelos";
            this.Rdb_Modelos.Size = new System.Drawing.Size(138, 24);
            this.Rdb_Modelos.TabIndex = 4;
            this.Rdb_Modelos.TabStop = true;
            this.Rdb_Modelos.Text = "Listar Modelos";
            this.Rdb_Modelos.UseVisualStyleBackColor = true;
            this.Rdb_Modelos.CheckedChanged += new System.EventHandler(this.Rdb_Modelos_CheckedChanged);
            // 
            // Rdb_Carros_Por_Modelos
            // 
            this.Rdb_Carros_Por_Modelos.AutoSize = true;
            this.Rdb_Carros_Por_Modelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Carros_Por_Modelos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Carros_Por_Modelos.Location = new System.Drawing.Point(6, 90);
            this.Rdb_Carros_Por_Modelos.Name = "Rdb_Carros_Por_Modelos";
            this.Rdb_Carros_Por_Modelos.Size = new System.Drawing.Size(225, 24);
            this.Rdb_Carros_Por_Modelos.TabIndex = 3;
            this.Rdb_Carros_Por_Modelos.TabStop = true;
            this.Rdb_Carros_Por_Modelos.Text = "Listar Carros Por Modelos";
            this.Rdb_Carros_Por_Modelos.UseVisualStyleBackColor = true;
            this.Rdb_Carros_Por_Modelos.CheckedChanged += new System.EventHandler(this.Rdb_Carros_Por_Modelos_CheckedChanged);
            // 
            // Rdb_Carros_Por_Marcas
            // 
            this.Rdb_Carros_Por_Marcas.AutoSize = true;
            this.Rdb_Carros_Por_Marcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Carros_Por_Marcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Carros_Por_Marcas.Location = new System.Drawing.Point(6, 60);
            this.Rdb_Carros_Por_Marcas.Name = "Rdb_Carros_Por_Marcas";
            this.Rdb_Carros_Por_Marcas.Size = new System.Drawing.Size(218, 24);
            this.Rdb_Carros_Por_Marcas.TabIndex = 2;
            this.Rdb_Carros_Por_Marcas.TabStop = true;
            this.Rdb_Carros_Por_Marcas.Text = "Listar Carros Por Marcas";
            this.Rdb_Carros_Por_Marcas.UseVisualStyleBackColor = true;
            this.Rdb_Carros_Por_Marcas.CheckedChanged += new System.EventHandler(this.Rdb_Carros_Por_Marcas_CheckedChanged);
            // 
            // Rdb_Carros_Disponiveis
            // 
            this.Rdb_Carros_Disponiveis.AutoSize = true;
            this.Rdb_Carros_Disponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Carros_Disponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Carros_Disponiveis.Location = new System.Drawing.Point(6, 30);
            this.Rdb_Carros_Disponiveis.Name = "Rdb_Carros_Disponiveis";
            this.Rdb_Carros_Disponiveis.Size = new System.Drawing.Size(218, 24);
            this.Rdb_Carros_Disponiveis.TabIndex = 1;
            this.Rdb_Carros_Disponiveis.TabStop = true;
            this.Rdb_Carros_Disponiveis.Text = "Listar Carros Disponiveis";
            this.Rdb_Carros_Disponiveis.UseVisualStyleBackColor = true;
            this.Rdb_Carros_Disponiveis.CheckedChanged += new System.EventHandler(this.Rdb_Carros_Disponiveis_CheckedChanged);
            // 
            // Rdb_Carros_Vendidos
            // 
            this.Rdb_Carros_Vendidos.AutoSize = true;
            this.Rdb_Carros_Vendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Carros_Vendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Carros_Vendidos.Location = new System.Drawing.Point(6, 0);
            this.Rdb_Carros_Vendidos.Name = "Rdb_Carros_Vendidos";
            this.Rdb_Carros_Vendidos.Size = new System.Drawing.Size(200, 24);
            this.Rdb_Carros_Vendidos.TabIndex = 0;
            this.Rdb_Carros_Vendidos.TabStop = true;
            this.Rdb_Carros_Vendidos.Text = "Listar Carros Vendidos";
            this.Rdb_Carros_Vendidos.UseVisualStyleBackColor = true;
            this.Rdb_Carros_Vendidos.CheckedChanged += new System.EventHandler(this.Rdb_Carros_Vendidos_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Dgv_Pesquisas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 279);
            this.panel3.TabIndex = 14;
            // 
            // Dgv_Pesquisas
            // 
            this.Dgv_Pesquisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pesquisas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Pesquisas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Dgv_Pesquisas.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Pesquisas.Name = "Dgv_Pesquisas";
            this.Dgv_Pesquisas.ReadOnly = true;
            this.Dgv_Pesquisas.RowHeadersVisible = false;
            this.Dgv_Pesquisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Pesquisas.Size = new System.Drawing.Size(592, 279);
            this.Dgv_Pesquisas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(55, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Digite";
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pesquisa.Enabled = false;
            this.txt_Pesquisa.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Pesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisa.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisa.HintText = "";
            this.txt_Pesquisa.isPassword = false;
            this.txt_Pesquisa.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisa.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Pesquisa.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisa.LineThickness = 4;
            this.txt_Pesquisa.Location = new System.Drawing.Point(7, 192);
            this.txt_Pesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(169, 34);
            this.txt_Pesquisa.TabIndex = 53;
            this.txt_Pesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisar.Enabled = false;
            this.btn_Pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.Black;
            this.btn_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Image")));
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Pesquisar.Location = new System.Drawing.Point(7, 233);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(169, 40);
            this.btn_Pesquisar.TabIndex = 41;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Frm_Pesquisas_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 321);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Pesquisas_Carro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Pesquisas_Carro_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pesquisas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv_Pesquisas;
        private System.Windows.Forms.RadioButton Rdb_Modelos;
        private System.Windows.Forms.RadioButton Rdb_Carros_Por_Modelos;
        private System.Windows.Forms.RadioButton Rdb_Carros_Por_Marcas;
        private System.Windows.Forms.RadioButton Rdb_Carros_Disponiveis;
        private System.Windows.Forms.RadioButton Rdb_Carros_Vendidos;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pesquisa;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}