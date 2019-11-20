namespace UIAlgoritmoGenetico.Forms
{
    partial class FormNavalha
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
            this.labelVelocidade = new System.Windows.Forms.Label();
            this.groupBoxLimites = new System.Windows.Forms.GroupBox();
            this.textBoxDistanciaLimiteMaximo = new System.Windows.Forms.TextBox();
            this.textBoxDistanciaLimiteMinimo = new System.Windows.Forms.TextBox();
            this.textBoxPressaoLimiteMaximo = new System.Windows.Forms.TextBox();
            this.textBoxPressaoLimiteMinimo = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadeLimiteMaximo = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadeLimiteMinimo = new System.Windows.Forms.TextBox();
            this.labelMaximo = new System.Windows.Forms.Label();
            this.labelMinimo = new System.Windows.Forms.Label();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.labelPressao = new System.Windows.Forms.Label();
            this.groupBoxVariaveisAG = new System.Windows.Forms.GroupBox();
            this.textBoxTaxaDeMutacao = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.textBoxElitismo = new System.Windows.Forms.TextBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.textBoxTamanhoPopulacao = new System.Windows.Forms.TextBox();
            this.labelTamanhoPopulacao = new System.Windows.Forms.Label();
            this.labelTaxaDeMutacao = new System.Windows.Forms.Label();
            this.labelElitismo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMelhorIndividuo = new System.Windows.Forms.GroupBox();
            this.textBoxMelhorIndividuoFitness = new System.Windows.Forms.TextBox();
            this.labelMelhorIndividuoFitness = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoTarget = new System.Windows.Forms.TextBox();
            this.textBoxMelhorIndividuoDistancia = new System.Windows.Forms.TextBox();
            this.labelMelhorIndividuoTarget = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoPressao = new System.Windows.Forms.TextBox();
            this.textBoxMelhorIndividuoVelocidade = new System.Windows.Forms.TextBox();
            this.labelMelhorIndividuoVelocidade = new System.Windows.Forms.Label();
            this.labelMelhorIndividuoDistancia = new System.Windows.Forms.Label();
            this.labelMelhorIndividuoPressao = new System.Windows.Forms.Label();
            this.textBoxGeracao = new System.Windows.Forms.TextBox();
            this.labelGeracao = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBoxPopulacao = new System.Windows.Forms.ListBox();
            this.textBoxMelhorIndividuoK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxLimites.SuspendLayout();
            this.groupBoxVariaveisAG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMelhorIndividuo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVelocidade
            // 
            this.labelVelocidade.AutoSize = true;
            this.labelVelocidade.Location = new System.Drawing.Point(22, 46);
            this.labelVelocidade.Name = "labelVelocidade";
            this.labelVelocidade.Size = new System.Drawing.Size(78, 17);
            this.labelVelocidade.TabIndex = 0;
            this.labelVelocidade.Text = "Velocidade";
            // 
            // groupBoxLimites
            // 
            this.groupBoxLimites.Controls.Add(this.textBoxDistanciaLimiteMaximo);
            this.groupBoxLimites.Controls.Add(this.textBoxDistanciaLimiteMinimo);
            this.groupBoxLimites.Controls.Add(this.textBoxPressaoLimiteMaximo);
            this.groupBoxLimites.Controls.Add(this.textBoxPressaoLimiteMinimo);
            this.groupBoxLimites.Controls.Add(this.textBoxVelocidadeLimiteMaximo);
            this.groupBoxLimites.Controls.Add(this.textBoxVelocidadeLimiteMinimo);
            this.groupBoxLimites.Controls.Add(this.labelMaximo);
            this.groupBoxLimites.Controls.Add(this.labelMinimo);
            this.groupBoxLimites.Controls.Add(this.labelDistancia);
            this.groupBoxLimites.Controls.Add(this.labelPressao);
            this.groupBoxLimites.Controls.Add(this.labelVelocidade);
            this.groupBoxLimites.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLimites.Name = "groupBoxLimites";
            this.groupBoxLimites.Size = new System.Drawing.Size(352, 134);
            this.groupBoxLimites.TabIndex = 1;
            this.groupBoxLimites.TabStop = false;
            this.groupBoxLimites.Text = "Limites Operacionais";
            // 
            // textBoxDistanciaLimiteMaximo
            // 
            this.textBoxDistanciaLimiteMaximo.Location = new System.Drawing.Point(233, 104);
            this.textBoxDistanciaLimiteMaximo.Name = "textBoxDistanciaLimiteMaximo";
            this.textBoxDistanciaLimiteMaximo.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistanciaLimiteMaximo.TabIndex = 10;
            this.textBoxDistanciaLimiteMaximo.Text = "50";
            this.textBoxDistanciaLimiteMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDistanciaLimiteMinimo
            // 
            this.textBoxDistanciaLimiteMinimo.Location = new System.Drawing.Point(106, 104);
            this.textBoxDistanciaLimiteMinimo.Name = "textBoxDistanciaLimiteMinimo";
            this.textBoxDistanciaLimiteMinimo.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistanciaLimiteMinimo.TabIndex = 9;
            this.textBoxDistanciaLimiteMinimo.Text = "0";
            this.textBoxDistanciaLimiteMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPressaoLimiteMaximo
            // 
            this.textBoxPressaoLimiteMaximo.Location = new System.Drawing.Point(233, 74);
            this.textBoxPressaoLimiteMaximo.Name = "textBoxPressaoLimiteMaximo";
            this.textBoxPressaoLimiteMaximo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPressaoLimiteMaximo.TabIndex = 8;
            this.textBoxPressaoLimiteMaximo.Text = "200";
            this.textBoxPressaoLimiteMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPressaoLimiteMinimo
            // 
            this.textBoxPressaoLimiteMinimo.Location = new System.Drawing.Point(106, 74);
            this.textBoxPressaoLimiteMinimo.Name = "textBoxPressaoLimiteMinimo";
            this.textBoxPressaoLimiteMinimo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPressaoLimiteMinimo.TabIndex = 7;
            this.textBoxPressaoLimiteMinimo.Text = "0";
            this.textBoxPressaoLimiteMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVelocidadeLimiteMaximo
            // 
            this.textBoxVelocidadeLimiteMaximo.Location = new System.Drawing.Point(233, 43);
            this.textBoxVelocidadeLimiteMaximo.Name = "textBoxVelocidadeLimiteMaximo";
            this.textBoxVelocidadeLimiteMaximo.Size = new System.Drawing.Size(100, 22);
            this.textBoxVelocidadeLimiteMaximo.TabIndex = 6;
            this.textBoxVelocidadeLimiteMaximo.Text = "200";
            this.textBoxVelocidadeLimiteMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVelocidadeLimiteMinimo
            // 
            this.textBoxVelocidadeLimiteMinimo.Location = new System.Drawing.Point(106, 43);
            this.textBoxVelocidadeLimiteMinimo.Name = "textBoxVelocidadeLimiteMinimo";
            this.textBoxVelocidadeLimiteMinimo.Size = new System.Drawing.Size(100, 22);
            this.textBoxVelocidadeLimiteMinimo.TabIndex = 5;
            this.textBoxVelocidadeLimiteMinimo.Text = "0";
            this.textBoxVelocidadeLimiteMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaximo
            // 
            this.labelMaximo.AutoSize = true;
            this.labelMaximo.Location = new System.Drawing.Point(250, 18);
            this.labelMaximo.Name = "labelMaximo";
            this.labelMaximo.Size = new System.Drawing.Size(55, 17);
            this.labelMaximo.TabIndex = 4;
            this.labelMaximo.Text = "Máximo";
            // 
            // labelMinimo
            // 
            this.labelMinimo.AutoSize = true;
            this.labelMinimo.Location = new System.Drawing.Point(125, 18);
            this.labelMinimo.Name = "labelMinimo";
            this.labelMinimo.Size = new System.Drawing.Size(52, 17);
            this.labelMinimo.TabIndex = 3;
            this.labelMinimo.Text = "Minímo";
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(22, 104);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(66, 17);
            this.labelDistancia.TabIndex = 2;
            this.labelDistancia.Text = "Distância";
            // 
            // labelPressao
            // 
            this.labelPressao.AutoSize = true;
            this.labelPressao.Location = new System.Drawing.Point(22, 74);
            this.labelPressao.Name = "labelPressao";
            this.labelPressao.Size = new System.Drawing.Size(60, 17);
            this.labelPressao.TabIndex = 1;
            this.labelPressao.Text = "Pressão";
            // 
            // groupBoxVariaveisAG
            // 
            this.groupBoxVariaveisAG.Controls.Add(this.textBoxTaxaDeMutacao);
            this.groupBoxVariaveisAG.Controls.Add(this.textBoxTarget);
            this.groupBoxVariaveisAG.Controls.Add(this.textBoxElitismo);
            this.groupBoxVariaveisAG.Controls.Add(this.labelTarget);
            this.groupBoxVariaveisAG.Controls.Add(this.textBoxTamanhoPopulacao);
            this.groupBoxVariaveisAG.Controls.Add(this.labelTamanhoPopulacao);
            this.groupBoxVariaveisAG.Controls.Add(this.labelTaxaDeMutacao);
            this.groupBoxVariaveisAG.Controls.Add(this.labelElitismo);
            this.groupBoxVariaveisAG.Location = new System.Drawing.Point(370, 12);
            this.groupBoxVariaveisAG.Name = "groupBoxVariaveisAG";
            this.groupBoxVariaveisAG.Size = new System.Drawing.Size(371, 134);
            this.groupBoxVariaveisAG.TabIndex = 11;
            this.groupBoxVariaveisAG.TabStop = false;
            this.groupBoxVariaveisAG.Text = "Entradas AG";
            // 
            // textBoxTaxaDeMutacao
            // 
            this.textBoxTaxaDeMutacao.Location = new System.Drawing.Point(151, 99);
            this.textBoxTaxaDeMutacao.Name = "textBoxTaxaDeMutacao";
            this.textBoxTaxaDeMutacao.Size = new System.Drawing.Size(100, 22);
            this.textBoxTaxaDeMutacao.TabIndex = 16;
            this.textBoxTaxaDeMutacao.Text = "1";
            this.textBoxTaxaDeMutacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(265, 43);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(100, 22);
            this.textBoxTarget.TabIndex = 12;
            this.textBoxTarget.Text = "60";
            this.textBoxTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxElitismo
            // 
            this.textBoxElitismo.Location = new System.Drawing.Point(151, 71);
            this.textBoxElitismo.Name = "textBoxElitismo";
            this.textBoxElitismo.Size = new System.Drawing.Size(100, 22);
            this.textBoxElitismo.TabIndex = 15;
            this.textBoxElitismo.Text = "5";
            this.textBoxElitismo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(286, 23);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(50, 17);
            this.labelTarget.TabIndex = 11;
            this.labelTarget.Text = "Target";
            // 
            // textBoxTamanhoPopulacao
            // 
            this.textBoxTamanhoPopulacao.Location = new System.Drawing.Point(151, 43);
            this.textBoxTamanhoPopulacao.Name = "textBoxTamanhoPopulacao";
            this.textBoxTamanhoPopulacao.Size = new System.Drawing.Size(100, 22);
            this.textBoxTamanhoPopulacao.TabIndex = 14;
            this.textBoxTamanhoPopulacao.Text = "200";
            this.textBoxTamanhoPopulacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTamanhoPopulacao
            // 
            this.labelTamanhoPopulacao.AutoSize = true;
            this.labelTamanhoPopulacao.Location = new System.Drawing.Point(6, 46);
            this.labelTamanhoPopulacao.Name = "labelTamanhoPopulacao";
            this.labelTamanhoPopulacao.Size = new System.Drawing.Size(139, 17);
            this.labelTamanhoPopulacao.TabIndex = 11;
            this.labelTamanhoPopulacao.Text = "Tamanho População";
            // 
            // labelTaxaDeMutacao
            // 
            this.labelTaxaDeMutacao.AutoSize = true;
            this.labelTaxaDeMutacao.Location = new System.Drawing.Point(6, 104);
            this.labelTaxaDeMutacao.Name = "labelTaxaDeMutacao";
            this.labelTaxaDeMutacao.Size = new System.Drawing.Size(143, 17);
            this.labelTaxaDeMutacao.TabIndex = 13;
            this.labelTaxaDeMutacao.Text = "Taxa de Mutação (%)";
            // 
            // labelElitismo
            // 
            this.labelElitismo.AutoSize = true;
            this.labelElitismo.Location = new System.Drawing.Point(6, 74);
            this.labelElitismo.Name = "labelElitismo";
            this.labelElitismo.Size = new System.Drawing.Size(133, 17);
            this.labelElitismo.TabIndex = 12;
            this.labelElitismo.Text = "Elitismo (Indivíduos)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxMelhorIndividuo);
            this.groupBox1.Controls.Add(this.textBoxGeracao);
            this.groupBox1.Controls.Add(this.labelGeracao);
            this.groupBox1.Location = new System.Drawing.Point(370, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 286);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saídas AG";
            // 
            // groupBoxMelhorIndividuo
            // 
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoC);
            this.groupBoxMelhorIndividuo.Controls.Add(this.label3);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoB);
            this.groupBoxMelhorIndividuo.Controls.Add(this.label4);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoA);
            this.groupBoxMelhorIndividuo.Controls.Add(this.label2);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoK);
            this.groupBoxMelhorIndividuo.Controls.Add(this.label1);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoFitness);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelMelhorIndividuoFitness);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoTarget);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoDistancia);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelMelhorIndividuoTarget);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoPressao);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoVelocidade);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelMelhorIndividuoVelocidade);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelMelhorIndividuoDistancia);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelMelhorIndividuoPressao);
            this.groupBoxMelhorIndividuo.Location = new System.Drawing.Point(9, 55);
            this.groupBoxMelhorIndividuo.Name = "groupBoxMelhorIndividuo";
            this.groupBoxMelhorIndividuo.Size = new System.Drawing.Size(356, 225);
            this.groupBoxMelhorIndividuo.TabIndex = 17;
            this.groupBoxMelhorIndividuo.TabStop = false;
            this.groupBoxMelhorIndividuo.Text = "Melhor Individuo";
            // 
            // textBoxMelhorIndividuoFitness
            // 
            this.textBoxMelhorIndividuoFitness.Location = new System.Drawing.Point(256, 78);
            this.textBoxMelhorIndividuoFitness.Name = "textBoxMelhorIndividuoFitness";
            this.textBoxMelhorIndividuoFitness.ReadOnly = true;
            this.textBoxMelhorIndividuoFitness.Size = new System.Drawing.Size(94, 22);
            this.textBoxMelhorIndividuoFitness.TabIndex = 24;
            this.textBoxMelhorIndividuoFitness.Text = "0";
            this.textBoxMelhorIndividuoFitness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMelhorIndividuoFitness
            // 
            this.labelMelhorIndividuoFitness.AutoSize = true;
            this.labelMelhorIndividuoFitness.Location = new System.Drawing.Point(277, 58);
            this.labelMelhorIndividuoFitness.Name = "labelMelhorIndividuoFitness";
            this.labelMelhorIndividuoFitness.Size = new System.Drawing.Size(53, 17);
            this.labelMelhorIndividuoFitness.TabIndex = 23;
            this.labelMelhorIndividuoFitness.Text = "Fitness";
            // 
            // textBoxMelhorIndividuoTarget
            // 
            this.textBoxMelhorIndividuoTarget.Location = new System.Drawing.Point(256, 33);
            this.textBoxMelhorIndividuoTarget.Name = "textBoxMelhorIndividuoTarget";
            this.textBoxMelhorIndividuoTarget.ReadOnly = true;
            this.textBoxMelhorIndividuoTarget.Size = new System.Drawing.Size(94, 22);
            this.textBoxMelhorIndividuoTarget.TabIndex = 18;
            this.textBoxMelhorIndividuoTarget.Text = "60";
            this.textBoxMelhorIndividuoTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMelhorIndividuoDistancia
            // 
            this.textBoxMelhorIndividuoDistancia.Location = new System.Drawing.Point(110, 77);
            this.textBoxMelhorIndividuoDistancia.Name = "textBoxMelhorIndividuoDistancia";
            this.textBoxMelhorIndividuoDistancia.ReadOnly = true;
            this.textBoxMelhorIndividuoDistancia.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoDistancia.TabIndex = 22;
            this.textBoxMelhorIndividuoDistancia.Text = "1";
            this.textBoxMelhorIndividuoDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMelhorIndividuoTarget
            // 
            this.labelMelhorIndividuoTarget.AutoSize = true;
            this.labelMelhorIndividuoTarget.Location = new System.Drawing.Point(277, 13);
            this.labelMelhorIndividuoTarget.Name = "labelMelhorIndividuoTarget";
            this.labelMelhorIndividuoTarget.Size = new System.Drawing.Size(50, 17);
            this.labelMelhorIndividuoTarget.TabIndex = 17;
            this.labelMelhorIndividuoTarget.Text = "Target";
            // 
            // textBoxMelhorIndividuoPressao
            // 
            this.textBoxMelhorIndividuoPressao.Location = new System.Drawing.Point(110, 49);
            this.textBoxMelhorIndividuoPressao.Name = "textBoxMelhorIndividuoPressao";
            this.textBoxMelhorIndividuoPressao.ReadOnly = true;
            this.textBoxMelhorIndividuoPressao.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoPressao.TabIndex = 21;
            this.textBoxMelhorIndividuoPressao.Text = "5";
            this.textBoxMelhorIndividuoPressao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMelhorIndividuoVelocidade
            // 
            this.textBoxMelhorIndividuoVelocidade.Location = new System.Drawing.Point(110, 21);
            this.textBoxMelhorIndividuoVelocidade.Name = "textBoxMelhorIndividuoVelocidade";
            this.textBoxMelhorIndividuoVelocidade.ReadOnly = true;
            this.textBoxMelhorIndividuoVelocidade.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoVelocidade.TabIndex = 20;
            this.textBoxMelhorIndividuoVelocidade.Text = "200";
            this.textBoxMelhorIndividuoVelocidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMelhorIndividuoVelocidade
            // 
            this.labelMelhorIndividuoVelocidade.AutoSize = true;
            this.labelMelhorIndividuoVelocidade.Location = new System.Drawing.Point(22, 21);
            this.labelMelhorIndividuoVelocidade.Name = "labelMelhorIndividuoVelocidade";
            this.labelMelhorIndividuoVelocidade.Size = new System.Drawing.Size(78, 17);
            this.labelMelhorIndividuoVelocidade.TabIndex = 17;
            this.labelMelhorIndividuoVelocidade.Text = "Velocidade";
            // 
            // labelMelhorIndividuoDistancia
            // 
            this.labelMelhorIndividuoDistancia.AutoSize = true;
            this.labelMelhorIndividuoDistancia.Location = new System.Drawing.Point(22, 79);
            this.labelMelhorIndividuoDistancia.Name = "labelMelhorIndividuoDistancia";
            this.labelMelhorIndividuoDistancia.Size = new System.Drawing.Size(66, 17);
            this.labelMelhorIndividuoDistancia.TabIndex = 19;
            this.labelMelhorIndividuoDistancia.Text = "Distância";
            // 
            // labelMelhorIndividuoPressao
            // 
            this.labelMelhorIndividuoPressao.AutoSize = true;
            this.labelMelhorIndividuoPressao.Location = new System.Drawing.Point(22, 49);
            this.labelMelhorIndividuoPressao.Name = "labelMelhorIndividuoPressao";
            this.labelMelhorIndividuoPressao.Size = new System.Drawing.Size(60, 17);
            this.labelMelhorIndividuoPressao.TabIndex = 18;
            this.labelMelhorIndividuoPressao.Text = "Pressão";
            // 
            // textBoxGeracao
            // 
            this.textBoxGeracao.Location = new System.Drawing.Point(86, 27);
            this.textBoxGeracao.Name = "textBoxGeracao";
            this.textBoxGeracao.ReadOnly = true;
            this.textBoxGeracao.Size = new System.Drawing.Size(100, 22);
            this.textBoxGeracao.TabIndex = 12;
            this.textBoxGeracao.Text = "1";
            this.textBoxGeracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGeracao
            // 
            this.labelGeracao.AutoSize = true;
            this.labelGeracao.Location = new System.Drawing.Point(17, 27);
            this.labelGeracao.Name = "labelGeracao";
            this.labelGeracao.Size = new System.Drawing.Size(63, 17);
            this.labelGeracao.TabIndex = 11;
            this.labelGeracao.Text = "Geração";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 153);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 18;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxPopulacao
            // 
            this.listBoxPopulacao.FormattingEnabled = true;
            this.listBoxPopulacao.ItemHeight = 16;
            this.listBoxPopulacao.Location = new System.Drawing.Point(13, 183);
            this.listBoxPopulacao.Name = "listBoxPopulacao";
            this.listBoxPopulacao.Size = new System.Drawing.Size(332, 228);
            this.listBoxPopulacao.TabIndex = 19;
            // 
            // textBoxMelhorIndividuoK
            // 
            this.textBoxMelhorIndividuoK.Location = new System.Drawing.Point(110, 105);
            this.textBoxMelhorIndividuoK.Name = "textBoxMelhorIndividuoK";
            this.textBoxMelhorIndividuoK.ReadOnly = true;
            this.textBoxMelhorIndividuoK.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoK.TabIndex = 26;
            this.textBoxMelhorIndividuoK.Text = "1";
            this.textBoxMelhorIndividuoK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "K";
            // 
            // textBoxMelhorIndividuoA
            // 
            this.textBoxMelhorIndividuoA.Location = new System.Drawing.Point(110, 133);
            this.textBoxMelhorIndividuoA.Name = "textBoxMelhorIndividuoA";
            this.textBoxMelhorIndividuoA.ReadOnly = true;
            this.textBoxMelhorIndividuoA.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoA.TabIndex = 28;
            this.textBoxMelhorIndividuoA.Text = "1";
            this.textBoxMelhorIndividuoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "a";
            // 
            // textBoxMelhorIndividuoC
            // 
            this.textBoxMelhorIndividuoC.Location = new System.Drawing.Point(110, 189);
            this.textBoxMelhorIndividuoC.Name = "textBoxMelhorIndividuoC";
            this.textBoxMelhorIndividuoC.ReadOnly = true;
            this.textBoxMelhorIndividuoC.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoC.TabIndex = 32;
            this.textBoxMelhorIndividuoC.Text = "1";
            this.textBoxMelhorIndividuoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "c";
            // 
            // textBoxMelhorIndividuoB
            // 
            this.textBoxMelhorIndividuoB.Location = new System.Drawing.Point(110, 161);
            this.textBoxMelhorIndividuoB.Name = "textBoxMelhorIndividuoB";
            this.textBoxMelhorIndividuoB.ReadOnly = true;
            this.textBoxMelhorIndividuoB.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoB.TabIndex = 30;
            this.textBoxMelhorIndividuoB.Text = "1";
            this.textBoxMelhorIndividuoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "b";
            // 
            // FormNavalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.listBoxPopulacao);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxVariaveisAG);
            this.Controls.Add(this.groupBoxLimites);
            this.Name = "FormNavalha";
            this.Text = "FormNavalha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavalha_FormClosed);
            this.Load += new System.EventHandler(this.FormNavalha_Load);
            this.groupBoxLimites.ResumeLayout(false);
            this.groupBoxLimites.PerformLayout();
            this.groupBoxVariaveisAG.ResumeLayout(false);
            this.groupBoxVariaveisAG.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMelhorIndividuo.ResumeLayout(false);
            this.groupBoxMelhorIndividuo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVelocidade;
        private System.Windows.Forms.GroupBox groupBoxLimites;
        private System.Windows.Forms.TextBox textBoxDistanciaLimiteMaximo;
        private System.Windows.Forms.TextBox textBoxDistanciaLimiteMinimo;
        private System.Windows.Forms.TextBox textBoxPressaoLimiteMaximo;
        private System.Windows.Forms.TextBox textBoxPressaoLimiteMinimo;
        private System.Windows.Forms.TextBox textBoxVelocidadeLimiteMaximo;
        private System.Windows.Forms.TextBox textBoxVelocidadeLimiteMinimo;
        private System.Windows.Forms.Label labelMaximo;
        private System.Windows.Forms.Label labelMinimo;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Label labelPressao;
        private System.Windows.Forms.GroupBox groupBoxVariaveisAG;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.TextBox textBoxTaxaDeMutacao;
        private System.Windows.Forms.TextBox textBoxElitismo;
        private System.Windows.Forms.TextBox textBoxTamanhoPopulacao;
        private System.Windows.Forms.Label labelTamanhoPopulacao;
        private System.Windows.Forms.Label labelTaxaDeMutacao;
        private System.Windows.Forms.Label labelElitismo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxMelhorIndividuo;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoFitness;
        private System.Windows.Forms.Label labelMelhorIndividuoFitness;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoTarget;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoDistancia;
        private System.Windows.Forms.Label labelMelhorIndividuoTarget;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoPressao;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoVelocidade;
        private System.Windows.Forms.Label labelMelhorIndividuoVelocidade;
        private System.Windows.Forms.Label labelMelhorIndividuoDistancia;
        private System.Windows.Forms.Label labelMelhorIndividuoPressao;
        private System.Windows.Forms.TextBox textBoxGeracao;
        private System.Windows.Forms.Label labelGeracao;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBoxPopulacao;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoK;
        private System.Windows.Forms.Label label1;
    }
}