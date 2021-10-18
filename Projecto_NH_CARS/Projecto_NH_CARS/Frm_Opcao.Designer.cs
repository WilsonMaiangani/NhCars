namespace Projecto_NH_CARS
{
    partial class Frm_Opcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Opcao));
            this.btn_sim = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Nao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Frase = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sim
            // 
            this.btn_sim.ActiveBorderThickness = 1;
            this.btn_sim.ActiveCornerRadius = 20;
            this.btn_sim.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_sim.ActiveForecolor = System.Drawing.Color.White;
            this.btn_sim.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_sim.BackColor = System.Drawing.Color.White;
            this.btn_sim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sim.BackgroundImage")));
            this.btn_sim.ButtonText = "Sim";
            this.btn_sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sim.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sim.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_sim.IdleBorderThickness = 1;
            this.btn_sim.IdleCornerRadius = 20;
            this.btn_sim.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btn_sim.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_sim.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_sim.Location = new System.Drawing.Point(332, 150);
            this.btn_sim.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(124, 54);
            this.btn_sim.TabIndex = 4;
            this.btn_sim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // btn_Nao
            // 
            this.btn_Nao.ActiveBorderThickness = 1;
            this.btn_Nao.ActiveCornerRadius = 20;
            this.btn_Nao.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Nao.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Nao.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Nao.BackColor = System.Drawing.Color.White;
            this.btn_Nao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Nao.BackgroundImage")));
            this.btn_Nao.ButtonText = "Não";
            this.btn_Nao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nao.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nao.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Nao.IdleBorderThickness = 1;
            this.btn_Nao.IdleCornerRadius = 20;
            this.btn_Nao.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btn_Nao.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Nao.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Nao.Location = new System.Drawing.Point(1, 150);
            this.btn_Nao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Nao.Name = "btn_Nao";
            this.btn_Nao.Size = new System.Drawing.Size(124, 54);
            this.btn_Nao.TabIndex = 5;
            this.btn_Nao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Nao.Click += new System.EventHandler(this.btn_Nao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 44);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(158, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "NH CARS";
            // 
            // lbl_Frase
            // 
            this.lbl_Frase.AutoSize = true;
            this.lbl_Frase.BackColor = System.Drawing.Color.White;
            this.lbl_Frase.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Frase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lbl_Frase.Location = new System.Drawing.Point(24, 71);
            this.lbl_Frase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Frase.Name = "lbl_Frase";
            this.lbl_Frase.Size = new System.Drawing.Size(375, 32);
            this.lbl_Frase.TabIndex = 7;
            this.lbl_Frase.Text = "Desejas Fechar Aplicação";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Opcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 201);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Frase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Nao);
            this.Controls.Add(this.btn_sim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Opcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Opcao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_sim;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Nao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Frase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}