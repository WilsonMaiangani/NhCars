namespace Projecto_NH_CARS
{
    partial class Frm_Gestao_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gestao_Usuarios));
            this.Dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.btn_Ver_Usuarios_Logados = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Principal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Usuario
            // 
            this.Dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_Usuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Dgv_Usuario.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Usuario.Name = "Dgv_Usuario";
            this.Dgv_Usuario.ReadOnly = true;
            this.Dgv_Usuario.RowHeadersVisible = false;
            this.Dgv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Usuario.Size = new System.Drawing.Size(948, 209);
            this.Dgv_Usuario.TabIndex = 3;
            this.Dgv_Usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Usuario_CellClick);
            // 
            // btn_Ver_Usuarios_Logados
            // 
            this.btn_Ver_Usuarios_Logados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Ver_Usuarios_Logados.FlatAppearance.BorderSize = 0;
            this.btn_Ver_Usuarios_Logados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Ver_Usuarios_Logados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ver_Usuarios_Logados.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ver_Usuarios_Logados.ForeColor = System.Drawing.Color.Black;
            this.btn_Ver_Usuarios_Logados.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ver_Usuarios_Logados.Image")));
            this.btn_Ver_Usuarios_Logados.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Ver_Usuarios_Logados.Location = new System.Drawing.Point(578, 6);
            this.btn_Ver_Usuarios_Logados.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ver_Usuarios_Logados.Name = "btn_Ver_Usuarios_Logados";
            this.btn_Ver_Usuarios_Logados.Size = new System.Drawing.Size(200, 40);
            this.btn_Ver_Usuarios_Logados.TabIndex = 32;
            this.btn_Ver_Usuarios_Logados.Text = "Visualizar Usuarios Logados";
            this.btn_Ver_Usuarios_Logados.UseVisualStyleBackColor = true;
            this.btn_Ver_Usuarios_Logados.Click += new System.EventHandler(this.btn_Ver_Usuarios_Logados_Click);
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
            this.btn_Cadastrar.Location = new System.Drawing.Point(386, 6);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(188, 40);
            this.btn_Cadastrar.TabIndex = 31;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(194, 6);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(188, 40);
            this.btn_Eliminar.TabIndex = 30;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
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
            this.btn_Editar.Location = new System.Drawing.Point(2, 6);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(188, 40);
            this.btn_Editar.TabIndex = 29;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cadastrar);
            this.panel1.Controls.Add(this.btn_Ver_Usuarios_Logados);
            this.panel1.Controls.Add(this.btn_Editar);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 51);
            this.panel1.TabIndex = 33;
            // 
            // Panel_Principal
            // 
            this.Panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Principal.Location = new System.Drawing.Point(0, 209);
            this.Panel_Principal.Name = "Panel_Principal";
            this.Panel_Principal.Size = new System.Drawing.Size(948, 191);
            this.Panel_Principal.TabIndex = 34;
            // 
            // Frm_Gestao_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 451);
            this.Controls.Add(this.Panel_Principal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gestao_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Gestao_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Usuario;
        private System.Windows.Forms.Button btn_Ver_Usuarios_Logados;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Principal;
    }
}