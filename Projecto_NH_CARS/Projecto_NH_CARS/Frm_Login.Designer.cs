namespace Projecto_NH_CARS
{
    partial class Frm_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ptb_Carro = new System.Windows.Forms.PictureBox();
            this.txt_Nome_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Senha_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Tmr_Tempo = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btn_MiniMizar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Ptb_Carro);
            this.panel1.Controls.Add(this.txt_Nome_Usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Senha_Usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Logar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(329, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 537);
            this.panel1.TabIndex = 0;
            // 
            // Ptb_Carro
            // 
            this.Ptb_Carro.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Carro.Image")));
            this.Ptb_Carro.Location = new System.Drawing.Point(-187, 26);
            this.Ptb_Carro.Name = "Ptb_Carro";
            this.Ptb_Carro.Size = new System.Drawing.Size(192, 157);
            this.Ptb_Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_Carro.TabIndex = 5;
            this.Ptb_Carro.TabStop = false;
            // 
            // txt_Nome_Usuario
            // 
            this.txt_Nome_Usuario.AutoSize = true;
            this.txt_Nome_Usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Nome_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nome_Usuario.Enabled = false;
            this.txt_Nome_Usuario.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Nome_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.HintText = "";
            this.txt_Nome_Usuario.isPassword = false;
            this.txt_Nome_Usuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Nome_Usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Nome_Usuario.LineThickness = 3;
            this.txt_Nome_Usuario.Location = new System.Drawing.Point(33, 263);
            this.txt_Nome_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nome_Usuario.Name = "txt_Nome_Usuario";
            this.txt_Nome_Usuario.Size = new System.Drawing.Size(247, 39);
            this.txt_Nome_Usuario.TabIndex = 1;
            this.txt_Nome_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Nome_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_Usuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(30, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // txt_Senha_Usuario
            // 
            this.txt_Senha_Usuario.AutoSize = true;
            this.txt_Senha_Usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Senha_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Senha_Usuario.Enabled = false;
            this.txt_Senha_Usuario.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Senha_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha_Usuario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha_Usuario.HintText = "";
            this.txt_Senha_Usuario.isPassword = false;
            this.txt_Senha_Usuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha_Usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Senha_Usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Senha_Usuario.LineThickness = 3;
            this.txt_Senha_Usuario.Location = new System.Drawing.Point(33, 360);
            this.txt_Senha_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Senha_Usuario.Name = "txt_Senha_Usuario";
            this.txt_Senha_Usuario.Size = new System.Drawing.Size(247, 39);
            this.txt_Senha_Usuario.TabIndex = 2;
            this.txt_Senha_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(30, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // btn_Logar
            // 
            this.btn_Logar.ActiveBorderThickness = 1;
            this.btn_Logar.ActiveCornerRadius = 20;
            this.btn_Logar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Logar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Logar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Logar.BackColor = System.Drawing.Color.White;
            this.btn_Logar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Logar.BackgroundImage")));
            this.btn_Logar.ButtonText = "Entrar";
            this.btn_Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Logar.IdleBorderThickness = 1;
            this.btn_Logar.IdleCornerRadius = 20;
            this.btn_Logar.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btn_Logar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Logar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Logar.Location = new System.Drawing.Point(60, 482);
            this.btn_Logar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(240, 46);
            this.btn_Logar.TabIndex = 3;
            this.btn_Logar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btn_Logar, "Logar");
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "NH CARS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 75);
            this.label4.TabIndex = 9;
            this.label4.Text = "SISTEMA PARA GESTÃO \r\n                DE \r\n VENDA DE CARROS ";
            // 
            // Tmr_Tempo
            // 
            this.Tmr_Tempo.Enabled = true;
            this.Tmr_Tempo.Tick += new System.EventHandler(this.Tmr_Tempo_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(716, 34);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "Barra";
            this.statusStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statusStrip1_MouseDown);
            // 
            // btn_MiniMizar
            // 
            this.btn_MiniMizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MiniMizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MiniMizar.FlatAppearance.BorderSize = 0;
            this.btn_MiniMizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_MiniMizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MiniMizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_MiniMizar.Image")));
            this.btn_MiniMizar.Location = new System.Drawing.Point(644, 2);
            this.btn_MiniMizar.Name = "btn_MiniMizar";
            this.btn_MiniMizar.Size = new System.Drawing.Size(30, 26);
            this.btn_MiniMizar.TabIndex = 6;
            this.btn_MiniMizar.UseVisualStyleBackColor = true;
            this.btn_MiniMizar.Click += new System.EventHandler(this.btn_MiniMizar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(680, 2);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(33, 27);
            this.btn_Fechar.TabIndex = 8;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(716, 571);
            this.Controls.Add(this.btn_MiniMizar);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nome_Usuario;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Senha_Usuario;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Logar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Ptb_Carro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer Tmr_Tempo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_MiniMizar;
        private System.Windows.Forms.Button btn_Fechar;


    }
}