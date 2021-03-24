namespace POO_WF1
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
            this.btnCreateChar = new System.Windows.Forms.Button();
            this.lbDamage = new System.Windows.Forms.Label();
            this.btnCreateChar2 = new System.Windows.Forms.Button();
            this.lbLevelP1 = new System.Windows.Forms.Label();
            this.lbLevelP2 = new System.Windows.Forms.Label();
            this.btnAttackP1 = new System.Windows.Forms.Button();
            this.btnAttackP2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateChar
            // 
            this.btnCreateChar.Location = new System.Drawing.Point(37, 37);
            this.btnCreateChar.Name = "btnCreateChar";
            this.btnCreateChar.Size = new System.Drawing.Size(75, 23);
            this.btnCreateChar.TabIndex = 0;
            this.btnCreateChar.Text = "Criar P1";
            this.btnCreateChar.UseVisualStyleBackColor = true;
            this.btnCreateChar.Click += new System.EventHandler(this.btnCreateChar_Click);
            // 
            // lbDamage
            // 
            this.lbDamage.AutoSize = true;
            this.lbDamage.Location = new System.Drawing.Point(733, 166);
            this.lbDamage.Name = "lbDamage";
            this.lbDamage.Size = new System.Drawing.Size(33, 13);
            this.lbDamage.TabIndex = 1;
            this.lbDamage.Text = "Dano";
            // 
            // btnCreateChar2
            // 
            this.btnCreateChar2.Location = new System.Drawing.Point(37, 80);
            this.btnCreateChar2.Name = "btnCreateChar2";
            this.btnCreateChar2.Size = new System.Drawing.Size(75, 23);
            this.btnCreateChar2.TabIndex = 2;
            this.btnCreateChar2.Text = "Criar P2";
            this.btnCreateChar2.UseVisualStyleBackColor = true;
            this.btnCreateChar2.Click += new System.EventHandler(this.btnCreateChar2_Click);
            // 
            // lbLevelP1
            // 
            this.lbLevelP1.AutoSize = true;
            this.lbLevelP1.Location = new System.Drawing.Point(264, 68);
            this.lbLevelP1.Name = "lbLevelP1";
            this.lbLevelP1.Size = new System.Drawing.Size(29, 13);
            this.lbLevelP1.TabIndex = 3;
            this.lbLevelP1.Text = "level";
            // 
            // lbLevelP2
            // 
            this.lbLevelP2.AutoSize = true;
            this.lbLevelP2.Location = new System.Drawing.Point(551, 68);
            this.lbLevelP2.Name = "lbLevelP2";
            this.lbLevelP2.Size = new System.Drawing.Size(29, 13);
            this.lbLevelP2.TabIndex = 4;
            this.lbLevelP2.Text = "level";
            // 
            // btnAttackP1
            // 
            this.btnAttackP1.Enabled = false;
            this.btnAttackP1.Location = new System.Drawing.Point(233, 368);
            this.btnAttackP1.Name = "btnAttackP1";
            this.btnAttackP1.Size = new System.Drawing.Size(75, 23);
            this.btnAttackP1.TabIndex = 5;
            this.btnAttackP1.Text = "Ataque P1";
            this.btnAttackP1.UseVisualStyleBackColor = true;
            this.btnAttackP1.Click += new System.EventHandler(this.btnAttackP1_Click);
            // 
            // btnAttackP2
            // 
            this.btnAttackP2.Enabled = false;
            this.btnAttackP2.Location = new System.Drawing.Point(520, 368);
            this.btnAttackP2.Name = "btnAttackP2";
            this.btnAttackP2.Size = new System.Drawing.Size(75, 23);
            this.btnAttackP2.TabIndex = 6;
            this.btnAttackP2.Text = "Ataque P2";
            this.btnAttackP2.UseVisualStyleBackColor = true;
            this.btnAttackP2.Click += new System.EventHandler(this.btnAttackP2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAttackP2);
            this.Controls.Add(this.btnAttackP1);
            this.Controls.Add(this.lbLevelP2);
            this.Controls.Add(this.lbLevelP1);
            this.Controls.Add(this.btnCreateChar2);
            this.Controls.Add(this.lbDamage);
            this.Controls.Add(this.btnCreateChar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateChar;
        private System.Windows.Forms.Label lbDamage;
        private System.Windows.Forms.Button btnCreateChar2;
        private System.Windows.Forms.Label lbLevelP1;
        private System.Windows.Forms.Label lbLevelP2;
        private System.Windows.Forms.Button btnAttackP1;
        private System.Windows.Forms.Button btnAttackP2;
    }
}

