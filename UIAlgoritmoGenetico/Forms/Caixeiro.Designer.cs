namespace UIAlgoritmoGenetico.Forms
{
    partial class Caixeiro
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
            this.btnIniciarSetup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.lblBestScoreOfPopulation = new System.Windows.Forms.Label();
            this.lblBestScoreEver = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciarSetup
            // 
            this.btnIniciarSetup.Location = new System.Drawing.Point(1208, 24);
            this.btnIniciarSetup.Name = "btnIniciarSetup";
            this.btnIniciarSetup.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarSetup.TabIndex = 0;
            this.btnIniciarSetup.Text = "Setup";
            this.btnIniciarSetup.UseVisualStyleBackColor = true;
            this.btnIniciarSetup.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1236, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(70, 13);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(75, 17);
            this.lblPopulation.TabIndex = 2;
            this.lblPopulation.Text = "Population";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Location = new System.Drawing.Point(927, 13);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(36, 17);
            this.lblBest.TabIndex = 3;
            this.lblBest.Text = "Best";
            // 
            // lblBestScoreOfPopulation
            // 
            this.lblBestScoreOfPopulation.AutoSize = true;
            this.lblBestScoreOfPopulation.Location = new System.Drawing.Point(198, 13);
            this.lblBestScoreOfPopulation.Name = "lblBestScoreOfPopulation";
            this.lblBestScoreOfPopulation.Size = new System.Drawing.Size(123, 17);
            this.lblBestScoreOfPopulation.TabIndex = 4;
            this.lblBestScoreOfPopulation.Text = "Best of Population";
            // 
            // lblBestScoreEver
            // 
            this.lblBestScoreEver.AutoSize = true;
            this.lblBestScoreEver.Location = new System.Drawing.Point(1001, 13);
            this.lblBestScoreEver.Name = "lblBestScoreEver";
            this.lblBestScoreEver.Size = new System.Drawing.Size(123, 17);
            this.lblBestScoreEver.TabIndex = 5;
            this.lblBestScoreEver.Text = "Best of Population";
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(716, 13);
            this.btnEvaluate.Name = "btnMutate";
            this.btnEvaluate.Size = new System.Drawing.Size(105, 23);
            this.btnEvaluate.TabIndex = 6;
            this.btnEvaluate.Text = "Start Mutate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnMutate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Swap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Caixeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 778);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lblBestScoreEver);
            this.Controls.Add(this.lblBestScoreOfPopulation);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIniciarSetup);
            this.Name = "Caixeiro";
            this.Text = "Caixeiro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Caixeiro_FormClosed);
            this.Load += new System.EventHandler(this.Caixeiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSetup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Label lblBestScoreOfPopulation;
        private System.Windows.Forms.Label lblBestScoreEver;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button button1;
    }
}