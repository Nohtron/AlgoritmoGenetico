namespace UIAlgoritmoGenetico.Forms
{
    partial class Navalha2
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
            this.listBoxPopulacao = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
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
            this.groupBoxVariaveisAG = new System.Windows.Forms.GroupBox();
            this.textBoxTaxaDeMutacao = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.textBoxElitismo = new System.Windows.Forms.TextBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.textBoxTamanhoPopulacao = new System.Windows.Forms.TextBox();
            this.labelTamanhoPopulacao = new System.Windows.Forms.Label();
            this.labelTaxaDeMutacao = new System.Windows.Forms.Label();
            this.labelElitismo = new System.Windows.Forms.Label();
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
            this.labelVelocidade = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonProximaGeracao = new System.Windows.Forms.Button();
            this.buttonEvoluir = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxMelhorIndividuoC = new System.Windows.Forms.TextBox();
            this.labelBestC = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoB = new System.Windows.Forms.TextBox();
            this.labelBestB = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoA = new System.Windows.Forms.TextBox();
            this.labelBestA = new System.Windows.Forms.Label();
            this.textBoxMelhorIndividuoK = new System.Windows.Forms.TextBox();
            this.labelBestK = new System.Windows.Forms.Label();
            this.textBoxPresetPressaoCalc = new System.Windows.Forms.TextBox();
            this.labelPresetPressaoCalc = new System.Windows.Forms.Label();
            this.textBoxLimiteMaximoB = new System.Windows.Forms.TextBox();
            this.textBoxLimiteMinimoB = new System.Windows.Forms.TextBox();
            this.textBoxLimiteMaximoA = new System.Windows.Forms.TextBox();
            this.textBoxLimiteMinimoA = new System.Windows.Forms.TextBox();
            this.textBoxLimiteMaximoK = new System.Windows.Forms.TextBox();
            this.textBoxLimiteMinimoK = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.textBoxLimiteMaximoC = new System.Windows.Forms.TextBox();
            this.textBoxLimiteMinimoC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxMelhorIndividuo.SuspendLayout();
            this.groupBoxVariaveisAG.SuspendLayout();
            this.groupBoxLimites.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPopulacao
            // 
            this.listBoxPopulacao.FormattingEnabled = true;
            this.listBoxPopulacao.ItemHeight = 16;
            this.listBoxPopulacao.Location = new System.Drawing.Point(13, 314);
            this.listBoxPopulacao.Name = "listBoxPopulacao";
            this.listBoxPopulacao.Size = new System.Drawing.Size(332, 228);
            this.listBoxPopulacao.TabIndex = 24;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 284);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 23;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxMelhorIndividuo);
            this.groupBox1.Controls.Add(this.textBoxGeracao);
            this.groupBox1.Controls.Add(this.labelGeracao);
            this.groupBox1.Location = new System.Drawing.Point(370, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 286);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saídas AG";
            // 
            // groupBoxMelhorIndividuo
            // 
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxPresetPressaoCalc);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelPresetPressaoCalc);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoC);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelBestC);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoFitness);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoB);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelMelhorIndividuoFitness);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelBestB);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoTarget);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoA);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoDistancia);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelBestA);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelMelhorIndividuoTarget);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoK);
            this.groupBoxMelhorIndividuo.Controls.Add(this.textBoxMelhorIndividuoPressao);
            this.groupBoxMelhorIndividuo.Controls.Add(this.labelBestK);
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
            this.textBoxGeracao.Text = "0";
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
            this.groupBoxVariaveisAG.TabIndex = 21;
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
            // groupBoxLimites
            // 
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMaximoC);
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMinimoC);
            this.groupBoxLimites.Controls.Add(this.labelC);
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMaximoB);
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMinimoB);
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMaximoA);
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMinimoA);
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMaximoK);
            this.groupBoxLimites.Controls.Add(this.textBoxLimiteMinimoK);
            this.groupBoxLimites.Controls.Add(this.labelB);
            this.groupBoxLimites.Controls.Add(this.labelA);
            this.groupBoxLimites.Controls.Add(this.labelK);
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
            this.groupBoxLimites.Size = new System.Drawing.Size(352, 261);
            this.groupBoxLimites.TabIndex = 20;
            this.groupBoxLimites.TabStop = false;
            this.groupBoxLimites.Text = "Limites Operacionais";
            // 
            // textBoxDistanciaLimiteMaximo
            // 
            this.textBoxDistanciaLimiteMaximo.Location = new System.Drawing.Point(233, 103);
            this.textBoxDistanciaLimiteMaximo.Name = "textBoxDistanciaLimiteMaximo";
            this.textBoxDistanciaLimiteMaximo.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistanciaLimiteMaximo.TabIndex = 10;
            this.textBoxDistanciaLimiteMaximo.Text = "100";
            this.textBoxDistanciaLimiteMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDistanciaLimiteMinimo
            // 
            this.textBoxDistanciaLimiteMinimo.Location = new System.Drawing.Point(106, 103);
            this.textBoxDistanciaLimiteMinimo.Name = "textBoxDistanciaLimiteMinimo";
            this.textBoxDistanciaLimiteMinimo.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistanciaLimiteMinimo.TabIndex = 9;
            this.textBoxDistanciaLimiteMinimo.Text = "8";
            this.textBoxDistanciaLimiteMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPressaoLimiteMaximo
            // 
            this.textBoxPressaoLimiteMaximo.Location = new System.Drawing.Point(233, 73);
            this.textBoxPressaoLimiteMaximo.Name = "textBoxPressaoLimiteMaximo";
            this.textBoxPressaoLimiteMaximo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPressaoLimiteMaximo.TabIndex = 8;
            this.textBoxPressaoLimiteMaximo.Text = "1600";
            this.textBoxPressaoLimiteMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPressaoLimiteMinimo
            // 
            this.textBoxPressaoLimiteMinimo.Location = new System.Drawing.Point(106, 73);
            this.textBoxPressaoLimiteMinimo.Name = "textBoxPressaoLimiteMinimo";
            this.textBoxPressaoLimiteMinimo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPressaoLimiteMinimo.TabIndex = 7;
            this.textBoxPressaoLimiteMinimo.Text = "100";
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
            this.textBoxVelocidadeLimiteMinimo.Text = "30";
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
            this.labelDistancia.Location = new System.Drawing.Point(16, 104);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(66, 17);
            this.labelDistancia.TabIndex = 2;
            this.labelDistancia.Text = "Distância";
            // 
            // labelPressao
            // 
            this.labelPressao.AutoSize = true;
            this.labelPressao.Location = new System.Drawing.Point(16, 74);
            this.labelPressao.Name = "labelPressao";
            this.labelPressao.Size = new System.Drawing.Size(60, 17);
            this.labelPressao.TabIndex = 1;
            this.labelPressao.Text = "Pressão";
            // 
            // labelVelocidade
            // 
            this.labelVelocidade.AutoSize = true;
            this.labelVelocidade.Location = new System.Drawing.Point(16, 44);
            this.labelVelocidade.Name = "labelVelocidade";
            this.labelVelocidade.Size = new System.Drawing.Size(78, 17);
            this.labelVelocidade.TabIndex = 0;
            this.labelVelocidade.Text = "Velocidade";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonProximaGeracao
            // 
            this.buttonProximaGeracao.Location = new System.Drawing.Point(268, 284);
            this.buttonProximaGeracao.Name = "buttonProximaGeracao";
            this.buttonProximaGeracao.Size = new System.Drawing.Size(75, 23);
            this.buttonProximaGeracao.TabIndex = 25;
            this.buttonProximaGeracao.Text = "+ 1 Geração";
            this.buttonProximaGeracao.UseVisualStyleBackColor = true;
            this.buttonProximaGeracao.Click += new System.EventHandler(this.buttonProximaGeracao_Click);
            // 
            // buttonEvoluir
            // 
            this.buttonEvoluir.Location = new System.Drawing.Point(98, 284);
            this.buttonEvoluir.Name = "buttonEvoluir";
            this.buttonEvoluir.Size = new System.Drawing.Size(75, 23);
            this.buttonEvoluir.TabIndex = 26;
            this.buttonEvoluir.Text = "Evoluir";
            this.buttonEvoluir.UseVisualStyleBackColor = true;
            this.buttonEvoluir.Click += new System.EventHandler(this.buttonEvoluir_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(183, 284);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 27;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxMelhorIndividuoC
            // 
            this.textBoxMelhorIndividuoC.Location = new System.Drawing.Point(110, 189);
            this.textBoxMelhorIndividuoC.Name = "textBoxMelhorIndividuoC";
            this.textBoxMelhorIndividuoC.ReadOnly = true;
            this.textBoxMelhorIndividuoC.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoC.TabIndex = 40;
            this.textBoxMelhorIndividuoC.Text = "1";
            this.textBoxMelhorIndividuoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBestC
            // 
            this.labelBestC.AutoSize = true;
            this.labelBestC.Location = new System.Drawing.Point(22, 191);
            this.labelBestC.Name = "labelBestC";
            this.labelBestC.Size = new System.Drawing.Size(15, 17);
            this.labelBestC.TabIndex = 39;
            this.labelBestC.Text = "c";
            // 
            // textBoxMelhorIndividuoB
            // 
            this.textBoxMelhorIndividuoB.Location = new System.Drawing.Point(110, 161);
            this.textBoxMelhorIndividuoB.Name = "textBoxMelhorIndividuoB";
            this.textBoxMelhorIndividuoB.ReadOnly = true;
            this.textBoxMelhorIndividuoB.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoB.TabIndex = 38;
            this.textBoxMelhorIndividuoB.Text = "1";
            this.textBoxMelhorIndividuoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBestB
            // 
            this.labelBestB.AutoSize = true;
            this.labelBestB.Location = new System.Drawing.Point(22, 163);
            this.labelBestB.Name = "labelBestB";
            this.labelBestB.Size = new System.Drawing.Size(16, 17);
            this.labelBestB.TabIndex = 37;
            this.labelBestB.Text = "b";
            // 
            // textBoxMelhorIndividuoA
            // 
            this.textBoxMelhorIndividuoA.Location = new System.Drawing.Point(110, 133);
            this.textBoxMelhorIndividuoA.Name = "textBoxMelhorIndividuoA";
            this.textBoxMelhorIndividuoA.ReadOnly = true;
            this.textBoxMelhorIndividuoA.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoA.TabIndex = 36;
            this.textBoxMelhorIndividuoA.Text = "1";
            this.textBoxMelhorIndividuoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBestA
            // 
            this.labelBestA.AutoSize = true;
            this.labelBestA.Location = new System.Drawing.Point(22, 135);
            this.labelBestA.Name = "labelBestA";
            this.labelBestA.Size = new System.Drawing.Size(16, 17);
            this.labelBestA.TabIndex = 35;
            this.labelBestA.Text = "a";
            // 
            // textBoxMelhorIndividuoK
            // 
            this.textBoxMelhorIndividuoK.Location = new System.Drawing.Point(110, 105);
            this.textBoxMelhorIndividuoK.Name = "textBoxMelhorIndividuoK";
            this.textBoxMelhorIndividuoK.ReadOnly = true;
            this.textBoxMelhorIndividuoK.Size = new System.Drawing.Size(75, 22);
            this.textBoxMelhorIndividuoK.TabIndex = 34;
            this.textBoxMelhorIndividuoK.Text = "1";
            this.textBoxMelhorIndividuoK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBestK
            // 
            this.labelBestK.AutoSize = true;
            this.labelBestK.Location = new System.Drawing.Point(22, 107);
            this.labelBestK.Name = "labelBestK";
            this.labelBestK.Size = new System.Drawing.Size(17, 17);
            this.labelBestK.TabIndex = 33;
            this.labelBestK.Text = "K";
            // 
            // textBoxPresetPressaoCalc
            // 
            this.textBoxPresetPressaoCalc.Location = new System.Drawing.Point(256, 189);
            this.textBoxPresetPressaoCalc.Name = "textBoxPresetPressaoCalc";
            this.textBoxPresetPressaoCalc.ReadOnly = true;
            this.textBoxPresetPressaoCalc.Size = new System.Drawing.Size(94, 22);
            this.textBoxPresetPressaoCalc.TabIndex = 42;
            this.textBoxPresetPressaoCalc.Text = "0";
            this.textBoxPresetPressaoCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPresetPressaoCalc
            // 
            this.labelPresetPressaoCalc.AutoSize = true;
            this.labelPresetPressaoCalc.Location = new System.Drawing.Point(214, 169);
            this.labelPresetPressaoCalc.Name = "labelPresetPressaoCalc";
            this.labelPresetPressaoCalc.Size = new System.Drawing.Size(136, 17);
            this.labelPresetPressaoCalc.TabIndex = 41;
            this.labelPresetPressaoCalc.Text = "Preset Pressao Calc";
            // 
            // textBoxLimiteMaximoB
            // 
            this.textBoxLimiteMaximoB.Location = new System.Drawing.Point(233, 193);
            this.textBoxLimiteMaximoB.Name = "textBoxLimiteMaximoB";
            this.textBoxLimiteMaximoB.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMaximoB.TabIndex = 19;
            this.textBoxLimiteMaximoB.Text = "1,5";
            this.textBoxLimiteMaximoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLimiteMinimoB
            // 
            this.textBoxLimiteMinimoB.Location = new System.Drawing.Point(106, 193);
            this.textBoxLimiteMinimoB.Name = "textBoxLimiteMinimoB";
            this.textBoxLimiteMinimoB.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMinimoB.TabIndex = 18;
            this.textBoxLimiteMinimoB.Text = "0,5";
            this.textBoxLimiteMinimoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLimiteMaximoA
            // 
            this.textBoxLimiteMaximoA.Location = new System.Drawing.Point(233, 163);
            this.textBoxLimiteMaximoA.Name = "textBoxLimiteMaximoA";
            this.textBoxLimiteMaximoA.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMaximoA.TabIndex = 17;
            this.textBoxLimiteMaximoA.Text = "1,5";
            this.textBoxLimiteMaximoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLimiteMinimoA
            // 
            this.textBoxLimiteMinimoA.Location = new System.Drawing.Point(106, 163);
            this.textBoxLimiteMinimoA.Name = "textBoxLimiteMinimoA";
            this.textBoxLimiteMinimoA.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMinimoA.TabIndex = 16;
            this.textBoxLimiteMinimoA.Text = "0,5";
            this.textBoxLimiteMinimoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLimiteMaximoK
            // 
            this.textBoxLimiteMaximoK.Location = new System.Drawing.Point(233, 133);
            this.textBoxLimiteMaximoK.Name = "textBoxLimiteMaximoK";
            this.textBoxLimiteMaximoK.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMaximoK.TabIndex = 15;
            this.textBoxLimiteMaximoK.Text = "50";
            this.textBoxLimiteMaximoK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLimiteMinimoK
            // 
            this.textBoxLimiteMinimoK.Location = new System.Drawing.Point(106, 133);
            this.textBoxLimiteMinimoK.Name = "textBoxLimiteMinimoK";
            this.textBoxLimiteMinimoK.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMinimoK.TabIndex = 14;
            this.textBoxLimiteMinimoK.Text = "0";
            this.textBoxLimiteMinimoK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(16, 194);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(16, 17);
            this.labelB.TabIndex = 13;
            this.labelB.Text = "b";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(16, 164);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(16, 17);
            this.labelA.TabIndex = 12;
            this.labelA.Text = "a";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(16, 134);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(17, 17);
            this.labelK.TabIndex = 11;
            this.labelK.Text = "K";
            // 
            // textBoxLimiteMaximoC
            // 
            this.textBoxLimiteMaximoC.Location = new System.Drawing.Point(233, 223);
            this.textBoxLimiteMaximoC.Name = "textBoxLimiteMaximoC";
            this.textBoxLimiteMaximoC.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMaximoC.TabIndex = 22;
            this.textBoxLimiteMaximoC.Text = "-0,5";
            this.textBoxLimiteMaximoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLimiteMinimoC
            // 
            this.textBoxLimiteMinimoC.Location = new System.Drawing.Point(106, 223);
            this.textBoxLimiteMinimoC.Name = "textBoxLimiteMinimoC";
            this.textBoxLimiteMinimoC.Size = new System.Drawing.Size(100, 22);
            this.textBoxLimiteMinimoC.TabIndex = 21;
            this.textBoxLimiteMinimoC.Text = "-1,5";
            this.textBoxLimiteMinimoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(16, 224);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(15, 17);
            this.labelC.TabIndex = 20;
            this.labelC.Text = "c";
            // 
            // Navalha2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonEvoluir);
            this.Controls.Add(this.buttonProximaGeracao);
            this.Controls.Add(this.listBoxPopulacao);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxVariaveisAG);
            this.Controls.Add(this.groupBoxLimites);
            this.Name = "Navalha2";
            this.Text = "Navalha2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Navalha2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMelhorIndividuo.ResumeLayout(false);
            this.groupBoxMelhorIndividuo.PerformLayout();
            this.groupBoxVariaveisAG.ResumeLayout(false);
            this.groupBoxVariaveisAG.PerformLayout();
            this.groupBoxLimites.ResumeLayout(false);
            this.groupBoxLimites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPopulacao;
        private System.Windows.Forms.Button buttonStart;
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
        private System.Windows.Forms.GroupBox groupBoxVariaveisAG;
        private System.Windows.Forms.TextBox textBoxTaxaDeMutacao;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.TextBox textBoxElitismo;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.TextBox textBoxTamanhoPopulacao;
        private System.Windows.Forms.Label labelTamanhoPopulacao;
        private System.Windows.Forms.Label labelTaxaDeMutacao;
        private System.Windows.Forms.Label labelElitismo;
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
        private System.Windows.Forms.Label labelVelocidade;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonProximaGeracao;
        private System.Windows.Forms.Button buttonEvoluir;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoC;
        private System.Windows.Forms.Label labelBestC;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoB;
        private System.Windows.Forms.Label labelBestB;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoA;
        private System.Windows.Forms.Label labelBestA;
        private System.Windows.Forms.TextBox textBoxMelhorIndividuoK;
        private System.Windows.Forms.Label labelBestK;
        private System.Windows.Forms.TextBox textBoxPresetPressaoCalc;
        private System.Windows.Forms.Label labelPresetPressaoCalc;
        private System.Windows.Forms.TextBox textBoxLimiteMaximoC;
        private System.Windows.Forms.TextBox textBoxLimiteMinimoC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxLimiteMaximoB;
        private System.Windows.Forms.TextBox textBoxLimiteMinimoB;
        private System.Windows.Forms.TextBox textBoxLimiteMaximoA;
        private System.Windows.Forms.TextBox textBoxLimiteMinimoA;
        private System.Windows.Forms.TextBox textBoxLimiteMaximoK;
        private System.Windows.Forms.TextBox textBoxLimiteMinimoK;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelK;
    }
}