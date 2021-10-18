namespace Projecto_NH_CARS
{
    partial class Frm_Gestao_Marcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gestao_Marcas));
            this.Dgv_Marca = new System.Windows.Forms.DataGridView();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Editar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Marca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Pesquisar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_cadastrar = new System.Windows.Forms.RadioButton();
            this.radioButton_Pesquisar = new System.Windows.Forms.RadioButton();
            this.radioButton_Todos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Marca)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Marca
            // 
            this.Dgv_Marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Marca.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_Marca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Dgv_Marca.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Marca.Name = "Dgv_Marca";
            this.Dgv_Marca.ReadOnly = true;
            this.Dgv_Marca.RowHeadersVisible = false;
            this.Dgv_Marca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Marca.Size = new System.Drawing.Size(948, 209);
            this.Dgv_Marca.TabIndex = 1;
            this.Dgv_Marca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Marca_CellClick);
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
            this.btn_Editar.Location = new System.Drawing.Point(9, 400);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(188, 40);
            this.btn_Editar.TabIndex = 6;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(201, 400);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(188, 40);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cadastrar.Enabled = false;
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cadastrar.Image")));
            this.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Cadastrar.Location = new System.Drawing.Point(393, 400);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(188, 40);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Editar";
            // 
            // txt_Editar
            // 
            this.txt_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Editar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Editar.Enabled = false;
            this.txt_Editar.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Editar.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Editar.HintText = "";
            this.txt_Editar.isPassword = false;
            this.txt_Editar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Editar.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Editar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Editar.LineThickness = 4;
            this.txt_Editar.Location = new System.Drawing.Point(4, 29);
            this.txt_Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Editar.Name = "txt_Editar";
            this.txt_Editar.Size = new System.Drawing.Size(242, 34);
            this.txt_Editar.TabIndex = 20;
            this.txt_Editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cadastrar";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Marca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Marca.Enabled = false;
            this.txt_Marca.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Marca.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Marca.HintText = "";
            this.txt_Marca.isPassword = false;
            this.txt_Marca.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Marca.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Marca.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Marca.LineThickness = 4;
            this.txt_Marca.Location = new System.Drawing.Point(4, 23);
            this.txt_Marca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(242, 34);
            this.txt_Marca.TabIndex = 22;
            this.txt_Marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Pesquisar.Enabled = false;
            this.btn_Pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.Black;
            this.btn_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Image")));
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Pesquisar.Location = new System.Drawing.Point(585, 400);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(188, 40);
            this.btn_Pesquisar.TabIndex = 24;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(678, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 242);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Editar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 68);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Marca);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 62);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_Pesquisar);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 74);
            this.panel4.TabIndex = 26;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Pesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pesquisar.Enabled = false;
            this.txt_Pesquisar.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisar.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisar.HintText = "";
            this.txt_Pesquisar.isPassword = false;
            this.txt_Pesquisar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisar.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Pesquisar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Pesquisar.LineThickness = 4;
            this.txt_Pesquisar.Location = new System.Drawing.Point(4, 35);
            this.txt_Pesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(242, 34);
            this.txt_Pesquisar.TabIndex = 22;
            this.txt_Pesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(2, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pesquisar";
            // 
            // radioButton_cadastrar
            // 
            this.radioButton_cadastrar.AutoSize = true;
            this.radioButton_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_cadastrar.Location = new System.Drawing.Point(12, 218);
            this.radioButton_cadastrar.Name = "radioButton_cadastrar";
            this.radioButton_cadastrar.Size = new System.Drawing.Size(101, 24);
            this.radioButton_cadastrar.TabIndex = 26;
            this.radioButton_cadastrar.TabStop = true;
            this.radioButton_cadastrar.Text = "Cadastrar";
            this.radioButton_cadastrar.UseVisualStyleBackColor = true;
            this.radioButton_cadastrar.CheckedChanged += new System.EventHandler(this.radioButton_cadastrar_CheckedChanged);
            // 
            // radioButton_Pesquisar
            // 
            this.radioButton_Pesquisar.AutoSize = true;
            this.radioButton_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Pesquisar.Location = new System.Drawing.Point(12, 248);
            this.radioButton_Pesquisar.Name = "radioButton_Pesquisar";
            this.radioButton_Pesquisar.Size = new System.Drawing.Size(102, 24);
            this.radioButton_Pesquisar.TabIndex = 27;
            this.radioButton_Pesquisar.TabStop = true;
            this.radioButton_Pesquisar.Text = "Pesquisar";
            this.radioButton_Pesquisar.UseVisualStyleBackColor = true;
            this.radioButton_Pesquisar.CheckedChanged += new System.EventHandler(this.radioButton_Pesquisar_CheckedChanged);
            // 
            // radioButton_Todos
            // 
            this.radioButton_Todos.AutoSize = true;
            this.radioButton_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Todos.Location = new System.Drawing.Point(12, 278);
            this.radioButton_Todos.Name = "radioButton_Todos";
            this.radioButton_Todos.Size = new System.Drawing.Size(104, 24);
            this.radioButton_Todos.TabIndex = 28;
            this.radioButton_Todos.TabStop = true;
            this.radioButton_Todos.Text = "Ver Todos";
            this.radioButton_Todos.UseVisualStyleBackColor = true;
            this.radioButton_Todos.CheckedChanged += new System.EventHandler(this.radioButton_Todos_CheckedChanged);
            // 
            // Frm_Gestao_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 451);
            this.Controls.Add(this.radioButton_Todos);
            this.Controls.Add(this.radioButton_Pesquisar);
            this.Controls.Add(this.radioButton_cadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.Dgv_Marca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gestao_Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Gestao_Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Marca)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Marca;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Editar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Marca;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_cadastrar;
        private System.Windows.Forms.RadioButton radioButton_Pesquisar;
        private System.Windows.Forms.RadioButton radioButton_Todos;

    }
}