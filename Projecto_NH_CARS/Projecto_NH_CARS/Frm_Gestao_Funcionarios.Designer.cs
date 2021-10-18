namespace Projecto_NH_CARS
{
    partial class Frm_Gestao_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gestao_Funcionarios));
            this.txt_Texto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Masculinos = new System.Windows.Forms.RadioButton();
            this.radioButton_Femeninos = new System.Windows.Forms.RadioButton();
            this.radioButton_Ver_Todos = new System.Windows.Forms.RadioButton();
            this.Dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cargos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Texto
            // 
            this.txt_Texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Texto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Texto.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Texto.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Texto.HintText = "";
            this.txt_Texto.isPassword = false;
            this.txt_Texto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Texto.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Texto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Texto.LineThickness = 4;
            this.txt_Texto.Location = new System.Drawing.Point(760, 246);
            this.txt_Texto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(188, 34);
            this.txt_Texto.TabIndex = 18;
            this.txt_Texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(828, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Funcionario";
            // 
            // radioButton_Masculinos
            // 
            this.radioButton_Masculinos.AutoSize = true;
            this.radioButton_Masculinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Masculinos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_Masculinos.Location = new System.Drawing.Point(12, 267);
            this.radioButton_Masculinos.Name = "radioButton_Masculinos";
            this.radioButton_Masculinos.Size = new System.Drawing.Size(112, 24);
            this.radioButton_Masculinos.TabIndex = 28;
            this.radioButton_Masculinos.TabStop = true;
            this.radioButton_Masculinos.Text = "Masculinos";
            this.radioButton_Masculinos.UseVisualStyleBackColor = true;
            this.radioButton_Masculinos.CheckedChanged += new System.EventHandler(this.radioButton_Masculinos_CheckedChanged);
            // 
            // radioButton_Femeninos
            // 
            this.radioButton_Femeninos.AutoSize = true;
            this.radioButton_Femeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Femeninos.Location = new System.Drawing.Point(12, 240);
            this.radioButton_Femeninos.Name = "radioButton_Femeninos";
            this.radioButton_Femeninos.Size = new System.Drawing.Size(109, 24);
            this.radioButton_Femeninos.TabIndex = 29;
            this.radioButton_Femeninos.TabStop = true;
            this.radioButton_Femeninos.Text = "Femeninos";
            this.radioButton_Femeninos.UseVisualStyleBackColor = true;
            this.radioButton_Femeninos.CheckedChanged += new System.EventHandler(this.radioButton_Femeninos_CheckedChanged);
            // 
            // radioButton_Ver_Todos
            // 
            this.radioButton_Ver_Todos.AutoSize = true;
            this.radioButton_Ver_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Ver_Todos.Location = new System.Drawing.Point(12, 295);
            this.radioButton_Ver_Todos.Name = "radioButton_Ver_Todos";
            this.radioButton_Ver_Todos.Size = new System.Drawing.Size(104, 24);
            this.radioButton_Ver_Todos.TabIndex = 30;
            this.radioButton_Ver_Todos.TabStop = true;
            this.radioButton_Ver_Todos.Text = "Ver Todos";
            this.radioButton_Ver_Todos.UseVisualStyleBackColor = true;
            this.radioButton_Ver_Todos.CheckedChanged += new System.EventHandler(this.radioButton_Ver_Todos_CheckedChanged);
            // 
            // Dgv_Funcionarios
            // 
            this.Dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Funcionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_Funcionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Dgv_Funcionarios.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Funcionarios.Name = "Dgv_Funcionarios";
            this.Dgv_Funcionarios.ReadOnly = true;
            this.Dgv_Funcionarios.RowHeadersVisible = false;
            this.Dgv_Funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Funcionarios.Size = new System.Drawing.Size(948, 216);
            this.Dgv_Funcionarios.TabIndex = 0;
            this.Dgv_Funcionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Funcionarios_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(10, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ver Funcionario/a";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.Black;
            this.btn_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Image")));
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Pesquisar.Location = new System.Drawing.Point(760, 287);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(188, 40);
            this.btn_Pesquisar.TabIndex = 40;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cadastrar.Image")));
            this.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Cadastrar.Location = new System.Drawing.Point(392, 405);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(188, 40);
            this.btn_Cadastrar.TabIndex = 39;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(200, 405);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(188, 40);
            this.btn_Eliminar.TabIndex = 38;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Editar.Enabled = false;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Image")));
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Editar.Location = new System.Drawing.Point(8, 405);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(188, 40);
            this.btn_Editar.TabIndex = 37;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cargos
            // 
            this.btn_Cargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cargos.FlatAppearance.BorderSize = 0;
            this.btn_Cargos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Cargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cargos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cargos.ForeColor = System.Drawing.Color.Black;
            this.btn_Cargos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cargos.Image")));
            this.btn_Cargos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Cargos.Location = new System.Drawing.Point(584, 405);
            this.btn_Cargos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cargos.Name = "btn_Cargos";
            this.btn_Cargos.Size = new System.Drawing.Size(188, 40);
            this.btn_Cargos.TabIndex = 41;
            this.btn_Cargos.Text = "Cargos";
            this.btn_Cargos.UseVisualStyleBackColor = true;
            this.btn_Cargos.Click += new System.EventHandler(this.btn_Cargos_Click);
            // 
            // Frm_Gestao_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 451);
            this.Controls.Add(this.btn_Cargos);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.Dgv_Funcionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.radioButton_Ver_Todos);
            this.Controls.Add(this.radioButton_Masculinos);
            this.Controls.Add(this.radioButton_Femeninos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gestao_Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Gestao_Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Masculinos;
        private System.Windows.Forms.RadioButton radioButton_Femeninos;
        private System.Windows.Forms.RadioButton radioButton_Ver_Todos;
        private System.Windows.Forms.DataGridView Dgv_Funcionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Cargos;
    }
}