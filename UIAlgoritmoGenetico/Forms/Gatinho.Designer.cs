namespace UIAlgoritmoGenetico.Forms
{
    partial class Gatinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gatinho));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDesenhar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDesenhar
            // 
            this.buttonDesenhar.Location = new System.Drawing.Point(904, 580);
            this.buttonDesenhar.Name = "buttonDesenhar";
            this.buttonDesenhar.Size = new System.Drawing.Size(178, 46);
            this.buttonDesenhar.TabIndex = 1;
            this.buttonDesenhar.Text = "Desenhar";
            this.buttonDesenhar.UseVisualStyleBackColor = true;
            this.buttonDesenhar.Click += new System.EventHandler(this.buttonDesenhar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(939, 632);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1";
            // 
            // Gatinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 664);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDesenhar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Gatinho";
            this.Text = "Gatinho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gatinho_FormClosed);
            this.Load += new System.EventHandler(this.Gatinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDesenhar;
        private System.Windows.Forms.TextBox textBox1;
    }
}