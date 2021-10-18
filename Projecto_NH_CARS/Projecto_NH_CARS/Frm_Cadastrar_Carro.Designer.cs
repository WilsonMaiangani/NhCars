namespace Projecto_NH_CARS
{
    partial class Frm_Cadastrar_Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastrar_Carro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.comboBox_Modelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.Dtp_Data_Fabrico = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_N_Seri = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Referencia_Pneu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Preco = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.radioButton_Estado = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Cor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel2.Size = new System.Drawing.Size(746, 42);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Texto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_Texto.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Texto.Location = new System.Drawing.Point(2, 4);
            this.lbl_Texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(334, 31);
            this.lbl_Texto.TabIndex = 9;
            this.lbl_Texto.Text = "Cadastro De Carro";
            // 
            // comboBox_Modelo
            // 
            this.comboBox_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Modelo.FormattingEnabled = true;
            this.comboBox_Modelo.Location = new System.Drawing.Point(16, 79);
            this.comboBox_Modelo.Name = "comboBox_Modelo";
            this.comboBox_Modelo.Size = new System.Drawing.Size(184, 28);
            this.comboBox_Modelo.TabIndex = 13;
            this.comboBox_Modelo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Modelo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(202, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Modelo";
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.Enabled = false;
            this.comboBox_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(206, 79);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(184, 28);
            this.comboBox_Marca.TabIndex = 15;
            // 
            // Dtp_Data_Fabrico
            // 
            this.Dtp_Data_Fabrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Dtp_Data_Fabrico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Data_Fabrico.Location = new System.Drawing.Point(597, 88);
            this.Dtp_Data_Fabrico.Name = "Dtp_Data_Fabrico";
            this.Dtp_Data_Fabrico.Size = new System.Drawing.Size(137, 26);
            this.Dtp_Data_Fabrico.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(593, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data De Fabrico";
            // 
            // txt_N_Seri
            // 
            this.txt_N_Seri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_N_Seri.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_N_Seri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_Seri.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_Seri.HintText = "";
            this.txt_N_Seri.isPassword = false;
            this.txt_N_Seri.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_Seri.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_N_Seri.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_Seri.LineThickness = 4;
            this.txt_N_Seri.Location = new System.Drawing.Point(16, 177);
            this.txt_N_Seri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_N_Seri.Name = "txt_N_Seri";
            this.txt_N_Seri.Size = new System.Drawing.Size(169, 34);
            this.txt_N_Seri.TabIndex = 47;
            this.txt_N_Seri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nº Seri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(202, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Referencia Do Pneu";
            // 
            // txt_Referencia_Pneu
            // 
            this.txt_Referencia_Pneu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Referencia_Pneu.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Referencia_Pneu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Referencia_Pneu.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Referencia_Pneu.HintText = "";
            this.txt_Referencia_Pneu.isPassword = false;
            this.txt_Referencia_Pneu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Referencia_Pneu.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Referencia_Pneu.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Referencia_Pneu.LineThickness = 4;
            this.txt_Referencia_Pneu.Location = new System.Drawing.Point(206, 177);
            this.txt_Referencia_Pneu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Referencia_Pneu.Name = "txt_Referencia_Pneu";
            this.txt_Referencia_Pneu.Size = new System.Drawing.Size(169, 34);
            this.txt_Referencia_Pneu.TabIndex = 49;
            this.txt_Referencia_Pneu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(407, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 52;
            this.label6.Text = "Preço";
            // 
            // txt_Preco
            // 
            this.txt_Preco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Preco.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Preco.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Preco.HintText = "";
            this.txt_Preco.isPassword = false;
            this.txt_Preco.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Preco.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Preco.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Preco.LineThickness = 4;
            this.txt_Preco.Location = new System.Drawing.Point(411, 177);
            this.txt_Preco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(169, 34);
            this.txt_Preco.TabIndex = 51;
            this.txt_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_Cadastrar.Location = new System.Drawing.Point(9, 279);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(188, 40);
            this.btn_Cadastrar.TabIndex = 53;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // radioButton_Estado
            // 
            this.radioButton_Estado.AutoSize = true;
            this.radioButton_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Estado.Location = new System.Drawing.Point(597, 187);
            this.radioButton_Estado.Name = "radioButton_Estado";
            this.radioButton_Estado.Size = new System.Drawing.Size(105, 24);
            this.radioButton_Estado.TabIndex = 54;
            this.radioButton_Estado.TabStop = true;
            this.radioButton_Estado.Text = "Disponivel";
            this.radioButton_Estado.UseVisualStyleBackColor = true;
            this.radioButton_Estado.CheckedChanged += new System.EventHandler(this.radioButton_Estado_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label7.Location = new System.Drawing.Point(607, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 55;
            this.label7.Text = "Estado";
            // 
            // comboBox_Cor
            // 
            this.comboBox_Cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Cor.FormattingEnabled = true;
            this.comboBox_Cor.Location = new System.Drawing.Point(396, 79);
            this.comboBox_Cor.Name = "comboBox_Cor";
            this.comboBox_Cor.Size = new System.Drawing.Size(184, 28);
            this.comboBox_Cor.TabIndex = 57;
            this.comboBox_Cor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label8.Location = new System.Drawing.Point(392, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 22);
            this.label8.TabIndex = 56;
            this.label8.Text = "Cor";
            // 
            // Frm_Cadastrar_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 330);
            this.Controls.Add(this.comboBox_Cor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton_Estado);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Referencia_Pneu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_N_Seri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtp_Data_Fabrico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Marca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Modelo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastrar_Carro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Cadastrar_Carro_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_Modelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Marca;
        private System.Windows.Forms.DateTimePicker Dtp_Data_Fabrico;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_N_Seri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Referencia_Pneu;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Preco;
        private System.Windows.Forms.RadioButton radioButton_Estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Cor;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_Texto;
        public System.Windows.Forms.Button btn_Cadastrar;
    }
}