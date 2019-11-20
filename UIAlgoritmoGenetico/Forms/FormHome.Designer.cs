namespace UIAlgoritmoGenetico.Forms
{
    partial class FormHome
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
            this.buttonShakespeare = new System.Windows.Forms.Button();
            this.buttonNavalha = new System.Windows.Forms.Button();
            this.buttonNavalha2 = new System.Windows.Forms.Button();
            this.buttonShakespeare2 = new System.Windows.Forms.Button();
            this.buttonCaixeiro = new System.Windows.Forms.Button();
            this.gatoJPG = new System.Windows.Forms.Button();
            this.buttonRedeNeural = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShakespeare
            // 
            this.buttonShakespeare.Location = new System.Drawing.Point(12, 12);
            this.buttonShakespeare.Name = "buttonShakespeare";
            this.buttonShakespeare.Size = new System.Drawing.Size(211, 98);
            this.buttonShakespeare.TabIndex = 0;
            this.buttonShakespeare.Text = "Shakespeare";
            this.buttonShakespeare.UseVisualStyleBackColor = true;
            this.buttonShakespeare.Click += new System.EventHandler(this.buttonShakespeare_Click);
            // 
            // buttonNavalha
            // 
            this.buttonNavalha.Location = new System.Drawing.Point(229, 12);
            this.buttonNavalha.Name = "buttonNavalha";
            this.buttonNavalha.Size = new System.Drawing.Size(211, 98);
            this.buttonNavalha.TabIndex = 1;
            this.buttonNavalha.Text = "Navalha";
            this.buttonNavalha.UseVisualStyleBackColor = true;
            this.buttonNavalha.Click += new System.EventHandler(this.buttonNavalha_Click);
            // 
            // buttonNavalha2
            // 
            this.buttonNavalha2.Location = new System.Drawing.Point(446, 12);
            this.buttonNavalha2.Name = "buttonNavalha2";
            this.buttonNavalha2.Size = new System.Drawing.Size(211, 98);
            this.buttonNavalha2.TabIndex = 2;
            this.buttonNavalha2.Text = "Navalha 2.0";
            this.buttonNavalha2.UseVisualStyleBackColor = true;
            this.buttonNavalha2.Click += new System.EventHandler(this.buttonNavalha2_Click);
            // 
            // buttonShakespeare2
            // 
            this.buttonShakespeare2.Location = new System.Drawing.Point(12, 116);
            this.buttonShakespeare2.Name = "buttonShakespeare2";
            this.buttonShakespeare2.Size = new System.Drawing.Size(211, 98);
            this.buttonShakespeare2.TabIndex = 3;
            this.buttonShakespeare2.Text = "Shakespeare 2.0";
            this.buttonShakespeare2.UseVisualStyleBackColor = true;
            this.buttonShakespeare2.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCaixeiro
            // 
            this.buttonCaixeiro.Location = new System.Drawing.Point(12, 220);
            this.buttonCaixeiro.Name = "buttonCaixeiro";
            this.buttonCaixeiro.Size = new System.Drawing.Size(211, 98);
            this.buttonCaixeiro.TabIndex = 4;
            this.buttonCaixeiro.Text = "Caixeiro";
            this.buttonCaixeiro.UseVisualStyleBackColor = true;
            this.buttonCaixeiro.Click += new System.EventHandler(this.button2_Click);
            // 
            // gatoJPG
            // 
            this.gatoJPG.Location = new System.Drawing.Point(12, 324);
            this.gatoJPG.Name = "gatoJPG";
            this.gatoJPG.Size = new System.Drawing.Size(211, 98);
            this.gatoJPG.TabIndex = 5;
            this.gatoJPG.Text = "Gatinho.JPG";
            this.gatoJPG.UseVisualStyleBackColor = true;
            this.gatoJPG.Click += new System.EventHandler(this.gatoJPG_Click);
            // 
            // buttonRedeNeural
            // 
            this.buttonRedeNeural.Location = new System.Drawing.Point(446, 324);
            this.buttonRedeNeural.Name = "buttonRedeNeural";
            this.buttonRedeNeural.Size = new System.Drawing.Size(211, 98);
            this.buttonRedeNeural.TabIndex = 6;
            this.buttonRedeNeural.Text = "Rede Neural";
            this.buttonRedeNeural.UseVisualStyleBackColor = true;
            this.buttonRedeNeural.Click += new System.EventHandler(this.buttonRedeNeural_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRedeNeural);
            this.Controls.Add(this.gatoJPG);
            this.Controls.Add(this.buttonCaixeiro);
            this.Controls.Add(this.buttonShakespeare2);
            this.Controls.Add(this.buttonNavalha2);
            this.Controls.Add(this.buttonNavalha);
            this.Controls.Add(this.buttonShakespeare);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShakespeare;
        private System.Windows.Forms.Button buttonNavalha;
        private System.Windows.Forms.Button buttonNavalha2;
        private System.Windows.Forms.Button buttonShakespeare2;
        private System.Windows.Forms.Button buttonCaixeiro;
        private System.Windows.Forms.Button gatoJPG;
        private System.Windows.Forms.Button buttonRedeNeural;
    }
}