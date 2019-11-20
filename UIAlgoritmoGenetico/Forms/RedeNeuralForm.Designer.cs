namespace UIAlgoritmoGenetico.Forms
{
    partial class RedeNeuralForm
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
            this.buttonInicializar = new System.Windows.Forms.Button();
            this.textBoxEntradas = new System.Windows.Forms.TextBox();
            this.textBoxHiddens = new System.Windows.Forms.TextBox();
            this.textBoxSaidas = new System.Windows.Forms.TextBox();
            this.listBoxPesosDeEntrada = new System.Windows.Forms.ListBox();
            this.listBoxHiddenLayer = new System.Windows.Forms.ListBox();
            this.listBoxSaida = new System.Windows.Forms.ListBox();
            this.listBoxEntradas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonInicializar
            // 
            this.buttonInicializar.Location = new System.Drawing.Point(543, 31);
            this.buttonInicializar.Name = "buttonInicializar";
            this.buttonInicializar.Size = new System.Drawing.Size(75, 23);
            this.buttonInicializar.TabIndex = 1;
            this.buttonInicializar.Text = "Inicializar";
            this.buttonInicializar.UseVisualStyleBackColor = true;
            this.buttonInicializar.Click += new System.EventHandler(this.buttonInicializar_Click);
            // 
            // textBoxEntradas
            // 
            this.textBoxEntradas.Location = new System.Drawing.Point(32, 32);
            this.textBoxEntradas.Name = "textBoxEntradas";
            this.textBoxEntradas.Size = new System.Drawing.Size(100, 22);
            this.textBoxEntradas.TabIndex = 2;
            this.textBoxEntradas.Text = "2";
            // 
            // textBoxHiddens
            // 
            this.textBoxHiddens.Location = new System.Drawing.Point(185, 32);
            this.textBoxHiddens.Name = "textBoxHiddens";
            this.textBoxHiddens.Size = new System.Drawing.Size(100, 22);
            this.textBoxHiddens.TabIndex = 3;
            this.textBoxHiddens.Text = "1";
            // 
            // textBoxSaidas
            // 
            this.textBoxSaidas.Location = new System.Drawing.Point(338, 32);
            this.textBoxSaidas.Name = "textBoxSaidas";
            this.textBoxSaidas.Size = new System.Drawing.Size(100, 22);
            this.textBoxSaidas.TabIndex = 4;
            this.textBoxSaidas.Text = "1";
            // 
            // listBoxPesosDeEntrada
            // 
            this.listBoxPesosDeEntrada.FormattingEnabled = true;
            this.listBoxPesosDeEntrada.ItemHeight = 16;
            this.listBoxPesosDeEntrada.Location = new System.Drawing.Point(209, 106);
            this.listBoxPesosDeEntrada.Name = "listBoxPesosDeEntrada";
            this.listBoxPesosDeEntrada.Size = new System.Drawing.Size(213, 196);
            this.listBoxPesosDeEntrada.TabIndex = 5;
            // 
            // listBoxHiddenLayer
            // 
            this.listBoxHiddenLayer.FormattingEnabled = true;
            this.listBoxHiddenLayer.ItemHeight = 16;
            this.listBoxHiddenLayer.Location = new System.Drawing.Point(472, 106);
            this.listBoxHiddenLayer.Name = "listBoxHiddenLayer";
            this.listBoxHiddenLayer.Size = new System.Drawing.Size(125, 196);
            this.listBoxHiddenLayer.TabIndex = 6;
            // 
            // listBoxSaida
            // 
            this.listBoxSaida.FormattingEnabled = true;
            this.listBoxSaida.ItemHeight = 16;
            this.listBoxSaida.Location = new System.Drawing.Point(646, 106);
            this.listBoxSaida.Name = "listBoxSaida";
            this.listBoxSaida.Size = new System.Drawing.Size(125, 196);
            this.listBoxSaida.TabIndex = 7;
            // 
            // listBoxEntradas
            // 
            this.listBoxEntradas.FormattingEnabled = true;
            this.listBoxEntradas.ItemHeight = 16;
            this.listBoxEntradas.Location = new System.Drawing.Point(32, 106);
            this.listBoxEntradas.Name = "listBoxEntradas";
            this.listBoxEntradas.Size = new System.Drawing.Size(125, 196);
            this.listBoxEntradas.TabIndex = 8;
            // 
            // RedeNeuralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxEntradas);
            this.Controls.Add(this.listBoxSaida);
            this.Controls.Add(this.listBoxHiddenLayer);
            this.Controls.Add(this.listBoxPesosDeEntrada);
            this.Controls.Add(this.textBoxSaidas);
            this.Controls.Add(this.textBoxHiddens);
            this.Controls.Add(this.textBoxEntradas);
            this.Controls.Add(this.buttonInicializar);
            this.Name = "RedeNeuralForm";
            this.Text = "RedeNeuralForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RedeNeuralForm_FormClosed);
            this.Load += new System.EventHandler(this.RedeNeuralForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInicializar;
        private System.Windows.Forms.TextBox textBoxEntradas;
        private System.Windows.Forms.TextBox textBoxHiddens;
        private System.Windows.Forms.TextBox textBoxSaidas;
        private System.Windows.Forms.ListBox listBoxPesosDeEntrada;
        private System.Windows.Forms.ListBox listBoxHiddenLayer;
        private System.Windows.Forms.ListBox listBoxSaida;
        private System.Windows.Forms.ListBox listBoxEntradas;
    }
}