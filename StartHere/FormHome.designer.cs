namespace StartHere
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
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNavalha);
            this.Controls.Add(this.buttonShakespeare);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShakespeare;
        private System.Windows.Forms.Button buttonNavalha;
    }
}