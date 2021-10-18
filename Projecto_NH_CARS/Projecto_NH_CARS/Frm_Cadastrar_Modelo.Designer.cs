namespace Projecto_NH_CARS
{
    partial class Frm_Cadastrar_Modelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastrar_Modelo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txt_Modelo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Marcas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.lbl_Texto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 43);
            this.panel1.TabIndex = 0;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(519, 10);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(33, 27);
            this.btn_Fechar.TabIndex = 11;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Texto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_Texto.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Texto.Location = new System.Drawing.Point(115, 6);
            this.lbl_Texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(334, 31);
            this.lbl_Texto.TabIndex = 10;
            this.lbl_Texto.Text = "Cadastrar Modelos";
            this.lbl_Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Cadastrar.Location = new System.Drawing.Point(11, 230);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(188, 40);
            this.btn_Cadastrar.TabIndex = 28;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Modelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Modelo.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Modelo.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Modelo.HintText = "";
            this.txt_Modelo.isPassword = false;
            this.txt_Modelo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Modelo.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Modelo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Modelo.LineThickness = 4;
            this.txt_Modelo.Location = new System.Drawing.Point(13, 95);
            this.txt_Modelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(242, 34);
            this.txt_Modelo.TabIndex = 29;
            this.txt_Modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Modelo";
            // 
            // comboBox_Marcas
            // 
            this.comboBox_Marcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Marcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboBox_Marcas.FormattingEnabled = true;
            this.comboBox_Marcas.Location = new System.Drawing.Point(329, 73);
            this.comboBox_Marcas.Name = "comboBox_Marcas";
            this.comboBox_Marcas.Size = new System.Drawing.Size(223, 28);
            this.comboBox_Marcas.TabIndex = 31;
            this.comboBox_Marcas.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marcas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(482, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Marcas";
            // 
            // Frm_Cadastrar_Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 281);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Marcas);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastrar_Modelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Cadastrar_Modelo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Button btn_Cadastrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Modelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Marcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Fechar;
    }
}