namespace SplashLoja
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.Versao = new System.Windows.Forms.Label();
            this.Carregando = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(90, 142);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Piratas da Informática";
            // 
            // Versao
            // 
            this.Versao.AutoSize = true;
            this.Versao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Versao.Location = new System.Drawing.Point(106, 155);
            this.Versao.Name = "Versao";
            this.Versao.Size = new System.Drawing.Size(75, 13);
            this.Versao.TabIndex = 2;
            this.Versao.Text = "Version 7.1.21";
            // 
            // Carregando
            // 
            this.Carregando.AutoSize = true;
            this.Carregando.ForeColor = System.Drawing.SystemColors.Control;
            this.Carregando.Location = new System.Drawing.Point(106, 197);
            this.Carregando.Name = "Carregando";
            this.Carregando.Size = new System.Drawing.Size(71, 13);
            this.Carregando.TabIndex = 3;
            this.Carregando.Text = "Carregando...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(65, 213);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 23);
            this.progressBar.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Carregando);
            this.Controls.Add(this.Versao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label Versao;
        private System.Windows.Forms.Label Carregando;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}

