namespace Projecto_NH_CARS
{
    partial class Frm_Gestao_Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gestao_Vendas));
            this.Dgv_Vendas = new System.Windows.Forms.DataGridView();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.btn_Visualizar_Vendas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_visualizar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Vendas
            // 
            this.Dgv_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Vendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_Vendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Dgv_Vendas.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Vendas.Name = "Dgv_Vendas";
            this.Dgv_Vendas.ReadOnly = true;
            this.Dgv_Vendas.RowHeadersVisible = false;
            this.Dgv_Vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Vendas.Size = new System.Drawing.Size(948, 216);
            this.Dgv_Vendas.TabIndex = 1;
            this.Dgv_Vendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Vendas_CellClick);
            // 
            // btn_Vender
            // 
            this.btn_Vender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Vender.Enabled = false;
            this.btn_Vender.FlatAppearance.BorderSize = 0;
            this.btn_Vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vender.ForeColor = System.Drawing.Color.Black;
            this.btn_Vender.Image = ((System.Drawing.Image)(resources.GetObject("btn_Vender.Image")));
            this.btn_Vender.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Vender.Location = new System.Drawing.Point(11, 7);
            this.btn_Vender.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(188, 40);
            this.btn_Vender.TabIndex = 42;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.UseVisualStyleBackColor = true;
            this.btn_Vender.Click += new System.EventHandler(this.btn_Vender_Click);
            // 
            // btn_Visualizar_Vendas
            // 
            this.btn_Visualizar_Vendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Visualizar_Vendas.FlatAppearance.BorderSize = 0;
            this.btn_Visualizar_Vendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Visualizar_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Visualizar_Vendas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Visualizar_Vendas.ForeColor = System.Drawing.Color.Black;
            this.btn_Visualizar_Vendas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Visualizar_Vendas.Location = new System.Drawing.Point(203, 7);
            this.btn_Visualizar_Vendas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Visualizar_Vendas.Name = "btn_Visualizar_Vendas";
            this.btn_Visualizar_Vendas.Size = new System.Drawing.Size(188, 40);
            this.btn_Visualizar_Vendas.TabIndex = 43;
            this.btn_Visualizar_Vendas.Text = "Visualizar Vendas";
            this.btn_Visualizar_Vendas.UseVisualStyleBackColor = true;
            this.btn_Visualizar_Vendas.Click += new System.EventHandler(this.btn_Visualizar_Vendas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Vender);
            this.panel1.Controls.Add(this.btn_Visualizar_Vendas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 53);
            this.panel1.TabIndex = 44;
            // 
            // panel_visualizar
            // 
            this.panel_visualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_visualizar.Location = new System.Drawing.Point(0, 216);
            this.panel_visualizar.Name = "panel_visualizar";
            this.panel_visualizar.Size = new System.Drawing.Size(948, 182);
            this.panel_visualizar.TabIndex = 45;
            // 
            // Frm_Gestao_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 451);
            this.Controls.Add(this.panel_visualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Vendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gestao_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Gestao_Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Vendas;
        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.Button btn_Visualizar_Vendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_visualizar;
    }
}