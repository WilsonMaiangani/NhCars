namespace Projecto_NH_CARS
{
    partial class Frm_Visualizar_Usuario_Logados
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_Usuario_Logados = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuario_Logados)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(736, 42);
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
            this.lbl_Texto.Size = new System.Drawing.Size(334, 31);
            this.lbl_Texto.TabIndex = 9;
            this.lbl_Texto.Text = "Usuarios Logados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_Usuario_Logados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 267);
            this.panel1.TabIndex = 13;
            // 
            // Dgv_Usuario_Logados
            // 
            this.Dgv_Usuario_Logados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Usuario_Logados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Usuario_Logados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Dgv_Usuario_Logados.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Usuario_Logados.Name = "Dgv_Usuario_Logados";
            this.Dgv_Usuario_Logados.ReadOnly = true;
            this.Dgv_Usuario_Logados.RowHeadersVisible = false;
            this.Dgv_Usuario_Logados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Usuario_Logados.Size = new System.Drawing.Size(736, 267);
            this.Dgv_Usuario_Logados.TabIndex = 2;
            // 
            // Frm_Visualizar_Usuario_Logados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 309);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Visualizar_Usuario_Logados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Visualizar_Usuario_Logados_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuario_Logados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_Usuario_Logados;
    }
}