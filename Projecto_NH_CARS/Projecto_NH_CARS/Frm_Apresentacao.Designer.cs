namespace Projecto_NH_CARS
{
    partial class Frm_Apresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Apresentacao));
            this.Ptb_Carro = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tmr_Tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // Ptb_Carro
            // 
            this.Ptb_Carro.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Carro.Image")));
            this.Ptb_Carro.Location = new System.Drawing.Point(1, 156);
            this.Ptb_Carro.Name = "Ptb_Carro";
            this.Ptb_Carro.Size = new System.Drawing.Size(134, 108);
            this.Ptb_Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_Carro.TabIndex = 0;
            this.Ptb_Carro.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(135, -8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 112);
            this.label3.TabIndex = 6;
            this.label3.Text = "NH CARS";
            // 
            // Tmr_Tempo
            // 
            this.Tmr_Tempo.Enabled = true;
            this.Tmr_Tempo.Tick += new System.EventHandler(this.Tmr_Tempo_Tick);
            // 
            // Frm_Apresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(678, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ptb_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Apresentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apresentação";
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ptb_Carro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Tmr_Tempo;





    }
}

