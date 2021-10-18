namespace Projecto_NH_CARS
{
    partial class Frm_Cadastrar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastrar_Usuario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.comboBox_Funcionarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Senha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Rdb_Muito_Alto = new System.Windows.Forms.RadioButton();
            this.Rdb_Alto = new System.Windows.Forms.RadioButton();
            this.Rdb_Medio = new System.Windows.Forms.RadioButton();
            this.Rdb_Baixo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(748, 42);
            this.panel2.TabIndex = 13;
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
            this.lbl_Texto.Size = new System.Drawing.Size(334, 31);
            this.lbl_Texto.TabIndex = 9;
            this.lbl_Texto.Text = "Cadastrar Usuario";
            // 
            // comboBox_Funcionarios
            // 
            this.comboBox_Funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Funcionarios.FormattingEnabled = true;
            this.comboBox_Funcionarios.Location = new System.Drawing.Point(500, 69);
            this.comboBox_Funcionarios.Name = "comboBox_Funcionarios";
            this.comboBox_Funcionarios.Size = new System.Drawing.Size(236, 28);
            this.comboBox_Funcionarios.TabIndex = 14;
            this.comboBox_Funcionarios.SelectedIndexChanged += new System.EventHandler(this.comboBox_Funcionarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome Do Usuario";
            // 
            // txt_Nome_Usuario
            // 
            this.txt_Nome_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nome_Usuario.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Nome_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.HintText = "";
            this.txt_Nome_Usuario.isPassword = false;
            this.txt_Nome_Usuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Nome_Usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.LineThickness = 4;
            this.txt_Nome_Usuario.Location = new System.Drawing.Point(11, 78);
            this.txt_Nome_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nome_Usuario.Name = "txt_Nome_Usuario";
            this.txt_Nome_Usuario.Size = new System.Drawing.Size(304, 34);
            this.txt_Nome_Usuario.TabIndex = 22;
            this.txt_Nome_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Nome_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_Usuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Senha.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha.HintText = "";
            this.txt_Senha.isPassword = false;
            this.txt_Senha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Senha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha.LineThickness = 4;
            this.txt_Senha.Location = new System.Drawing.Point(11, 154);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(304, 34);
            this.txt_Senha.TabIndex = 24;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Rdb_Muito_Alto
            // 
            this.Rdb_Muito_Alto.AutoSize = true;
            this.Rdb_Muito_Alto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Muito_Alto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Muito_Alto.Location = new System.Drawing.Point(16, 238);
            this.Rdb_Muito_Alto.Name = "Rdb_Muito_Alto";
            this.Rdb_Muito_Alto.Size = new System.Drawing.Size(102, 24);
            this.Rdb_Muito_Alto.TabIndex = 26;
            this.Rdb_Muito_Alto.TabStop = true;
            this.Rdb_Muito_Alto.Text = "Muito Alto";
            this.Rdb_Muito_Alto.UseVisualStyleBackColor = true;
            this.Rdb_Muito_Alto.CheckedChanged += new System.EventHandler(this.Rdb_Muito_Alto_CheckedChanged);
            // 
            // Rdb_Alto
            // 
            this.Rdb_Alto.AutoSize = true;
            this.Rdb_Alto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Alto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Alto.Location = new System.Drawing.Point(124, 238);
            this.Rdb_Alto.Name = "Rdb_Alto";
            this.Rdb_Alto.Size = new System.Drawing.Size(56, 24);
            this.Rdb_Alto.TabIndex = 27;
            this.Rdb_Alto.TabStop = true;
            this.Rdb_Alto.Text = "Alto";
            this.Rdb_Alto.UseVisualStyleBackColor = true;
            this.Rdb_Alto.CheckedChanged += new System.EventHandler(this.Rdb_Alto_CheckedChanged);
            // 
            // Rdb_Medio
            // 
            this.Rdb_Medio.AutoSize = true;
            this.Rdb_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Medio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Medio.Location = new System.Drawing.Point(206, 238);
            this.Rdb_Medio.Name = "Rdb_Medio";
            this.Rdb_Medio.Size = new System.Drawing.Size(72, 24);
            this.Rdb_Medio.TabIndex = 28;
            this.Rdb_Medio.TabStop = true;
            this.Rdb_Medio.Text = "Médio";
            this.Rdb_Medio.UseVisualStyleBackColor = true;
            this.Rdb_Medio.CheckedChanged += new System.EventHandler(this.Rdb_Medio_CheckedChanged);
            // 
            // Rdb_Baixo
            // 
            this.Rdb_Baixo.AutoSize = true;
            this.Rdb_Baixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Rdb_Baixo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Rdb_Baixo.Location = new System.Drawing.Point(284, 238);
            this.Rdb_Baixo.Name = "Rdb_Baixo";
            this.Rdb_Baixo.Size = new System.Drawing.Size(69, 24);
            this.Rdb_Baixo.TabIndex = 29;
            this.Rdb_Baixo.TabStop = true;
            this.Rdb_Baixo.Text = "Baixo";
            this.Rdb_Baixo.UseVisualStyleBackColor = true;
            this.Rdb_Baixo.CheckedChanged += new System.EventHandler(this.Rdb_Baixo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Niveis De Acesso";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cadastrar.Image")));
            this.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Cadastrar.Location = new System.Drawing.Point(548, 230);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(188, 40);
            this.btn_Cadastrar.TabIndex = 72;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(596, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Funcionario/s";
            // 
            // Frm_Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rdb_Baixo);
            this.Controls.Add(this.Rdb_Medio);
            this.Controls.Add(this.Rdb_Alto);
            this.Controls.Add(this.Rdb_Muito_Alto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome_Usuario);
            this.Controls.Add(this.comboBox_Funcionarios);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastrar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Cadastrar_Usuario_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.ComboBox comboBox_Funcionarios;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nome_Usuario;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Senha;
        private System.Windows.Forms.RadioButton Rdb_Muito_Alto;
        private System.Windows.Forms.RadioButton Rdb_Alto;
        private System.Windows.Forms.RadioButton Rdb_Medio;
        private System.Windows.Forms.RadioButton Rdb_Baixo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label label4;
    }
}