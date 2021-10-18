namespace Projecto_NH_CARS
{
    partial class Frm_Cadastrar_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastrar_Funcionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_N_BI = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CbB_Cargos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Telefone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.radioButton_Masculino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_Femenino = new System.Windows.Forms.RadioButton();
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome Completo";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nome.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome.HintText = "";
            this.txt_Nome.isPassword = false;
            this.txt_Nome.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Nome.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome.LineThickness = 4;
            this.txt_Nome.Location = new System.Drawing.Point(10, 70);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(304, 34);
            this.txt_Nome.TabIndex = 20;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(11, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "BI";
            // 
            // txt_N_BI
            // 
            this.txt_N_BI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_N_BI.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_N_BI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_BI.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_BI.HintText = "";
            this.txt_N_BI.isPassword = false;
            this.txt_N_BI.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_BI.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_N_BI.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_N_BI.LineThickness = 4;
            this.txt_N_BI.Location = new System.Drawing.Point(10, 138);
            this.txt_N_BI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_N_BI.Name = "txt_N_BI";
            this.txt_N_BI.Size = new System.Drawing.Size(304, 34);
            this.txt_N_BI.TabIndex = 22;
            this.txt_N_BI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CbB_Cargos
            // 
            this.CbB_Cargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CbB_Cargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CbB_Cargos.FormattingEnabled = true;
            this.CbB_Cargos.Location = new System.Drawing.Point(427, 76);
            this.CbB_Cargos.Name = "CbB_Cargos";
            this.CbB_Cargos.Size = new System.Drawing.Size(240, 28);
            this.CbB_Cargos.TabIndex = 24;
            this.CbB_Cargos.SelectedIndexChanged += new System.EventHandler(this.CbB_Cargos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(603, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cargos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefone";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Telefone.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Telefone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Telefone.HintText = "";
            this.txt_Telefone.isPassword = false;
            this.txt_Telefone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Telefone.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Telefone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Telefone.LineThickness = 4;
            this.txt_Telefone.Location = new System.Drawing.Point(10, 198);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(304, 34);
            this.txt_Telefone.TabIndex = 26;
            this.txt_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefone_KeyPress);
            // 
            // radioButton_Masculino
            // 
            this.radioButton_Masculino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Masculino.AutoSize = true;
            this.radioButton_Masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Masculino.Location = new System.Drawing.Point(21, 272);
            this.radioButton_Masculino.Name = "radioButton_Masculino";
            this.radioButton_Masculino.Size = new System.Drawing.Size(103, 24);
            this.radioButton_Masculino.TabIndex = 30;
            this.radioButton_Masculino.TabStop = true;
            this.radioButton_Masculino.Text = "Masculino";
            this.radioButton_Masculino.UseVisualStyleBackColor = true;
            this.radioButton_Masculino.CheckedChanged += new System.EventHandler(this.radioButton_Masculino_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(11, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Genero";
            // 
            // radioButton_Femenino
            // 
            this.radioButton_Femenino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Femenino.AutoSize = true;
            this.radioButton_Femenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_Femenino.Location = new System.Drawing.Point(129, 272);
            this.radioButton_Femenino.Name = "radioButton_Femenino";
            this.radioButton_Femenino.Size = new System.Drawing.Size(109, 24);
            this.radioButton_Femenino.TabIndex = 32;
            this.radioButton_Femenino.TabStop = true;
            this.radioButton_Femenino.Text = "Femeninos";
            this.radioButton_Femenino.UseVisualStyleBackColor = true;
            this.radioButton_Femenino.CheckedChanged += new System.EventHandler(this.radioButton_Femenino_CheckedChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.ActiveBorderThickness = 1;
            this.btn_Guardar.ActiveCornerRadius = 20;
            this.btn_Guardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Guardar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Guardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Guardar.BackColor = System.Drawing.Color.White;
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.ButtonText = "Guardar";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.IdleBorderThickness = 1;
            this.btn_Guardar.IdleCornerRadius = 20;
            this.btn_Guardar.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btn_Guardar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Guardar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Guardar.Location = new System.Drawing.Point(10, 321);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(160, 41);
            this.btn_Guardar.TabIndex = 34;
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(166, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cadastro De Funcionários";
            // 
            // Frm_Cadastrar_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 377);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.radioButton_Femenino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_Masculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbB_Cargos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_N_BI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastrar_Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Cadastrar_Funcionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nome;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_N_BI;
        private System.Windows.Forms.ComboBox CbB_Cargos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Telefone;
        private System.Windows.Forms.RadioButton radioButton_Masculino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Femenino;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Guardar;
        private System.Windows.Forms.Label label6;
    }
}