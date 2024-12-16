namespace Exer012
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblPlacar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl7 = new System.Windows.Forms.Label();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox1.Controls.Add(this.LblPlacar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTempo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(652, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status do Jogo";
            // 
            // LblPlacar
            // 
            this.LblPlacar.AutoSize = true;
            this.LblPlacar.Location = new System.Drawing.Point(158, 108);
            this.LblPlacar.Name = "LblPlacar";
            this.LblPlacar.Size = new System.Drawing.Size(18, 20);
            this.LblPlacar.TabIndex = 3;
            this.LblPlacar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placar:";
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Location = new System.Drawing.Point(158, 44);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(18, 20);
            this.LblTempo.TabIndex = 1;
            this.LblTempo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo:";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Orange;
            this.btnInicio.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInicio.Location = new System.Drawing.Point(652, 336);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(310, 41);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Iniciar Jogo";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNovo.Enabled = false;
            this.btnNovo.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(652, 410);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(310, 45);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo Jogo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DeepPink;
            this.btnSair.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(652, 489);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(310, 39);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 109);
            this.label5.TabIndex = 5;
            this.label5.Text = "JOGO DOS 7 ERROS";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Exer012.Properties.Resources.esqueci;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Lbl7);
            this.panel1.Controls.Add(this.Lbl6);
            this.panel1.Controls.Add(this.Lbl5);
            this.panel1.Controls.Add(this.Lbl3);
            this.panel1.Controls.Add(this.Lbl4);
            this.panel1.Controls.Add(this.Lbl1);
            this.panel1.Controls.Add(this.Lbl2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(30, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 445);
            this.panel1.TabIndex = 0;
            // 
            // Lbl7
            // 
            this.Lbl7.BackColor = System.Drawing.Color.Transparent;
            this.Lbl7.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl7.Location = new System.Drawing.Point(288, 85);
            this.Lbl7.Name = "Lbl7";
            this.Lbl7.Size = new System.Drawing.Size(32, 34);
            this.Lbl7.TabIndex = 6;
            this.Lbl7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Lbl7.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // Lbl6
            // 
            this.Lbl6.BackColor = System.Drawing.Color.Transparent;
            this.Lbl6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.Location = new System.Drawing.Point(409, 204);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(30, 28);
            this.Lbl6.TabIndex = 5;
            this.Lbl6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Lbl6.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // Lbl5
            // 
            this.Lbl5.BackColor = System.Drawing.Color.Transparent;
            this.Lbl5.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.Location = new System.Drawing.Point(317, 256);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(35, 26);
            this.Lbl5.TabIndex = 4;
            this.Lbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl5.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // Lbl3
            // 
            this.Lbl3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(492, 256);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(32, 45);
            this.Lbl3.TabIndex = 3;
            this.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl3.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // Lbl4
            // 
            this.Lbl4.BackColor = System.Drawing.Color.Transparent;
            this.Lbl4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(430, 15);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(32, 34);
            this.Lbl4.TabIndex = 2;
            this.Lbl4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Lbl4.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(569, 350);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(32, 34);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl1.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(455, 390);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(32, 34);
            this.Lbl2.TabIndex = 0;
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl2.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 651);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "       ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblPlacar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl7;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Timer timer1;
    }
}

