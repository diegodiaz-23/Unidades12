namespace pjModular.formularios
{
    partial class fm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.EstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbDivorciado = new System.Windows.Forms.RadioButton();
            this.rbViudo = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.txtR = new System.Windows.Forms.RichTextBox();
            this.EstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PARTICIPANTES A LA FIESTA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese edad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 83);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.Controls.Add(this.rbDivorciado);
            this.EstadoCivil.Controls.Add(this.rbViudo);
            this.EstadoCivil.Controls.Add(this.rbCasado);
            this.EstadoCivil.Controls.Add(this.rbSoltero);
            this.EstadoCivil.Location = new System.Drawing.Point(122, 183);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(200, 117);
            this.EstadoCivil.TabIndex = 4;
            this.EstadoCivil.TabStop = false;
            this.EstadoCivil.Text = "Estado Civil";
            this.EstadoCivil.Enter += new System.EventHandler(this.EstadoCivil_Enter);
            // 
            // rbDivorciado
            // 
            this.rbDivorciado.AutoSize = true;
            this.rbDivorciado.Location = new System.Drawing.Point(6, 88);
            this.rbDivorciado.Name = "rbDivorciado";
            this.rbDivorciado.Size = new System.Drawing.Size(92, 17);
            this.rbDivorciado.TabIndex = 3;
            this.rbDivorciado.TabStop = true;
            this.rbDivorciado.Text = "DIVORCIADO";
            this.rbDivorciado.UseVisualStyleBackColor = true;
            this.rbDivorciado.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbViudo
            // 
            this.rbViudo.AutoSize = true;
            this.rbViudo.Location = new System.Drawing.Point(6, 65);
            this.rbViudo.Name = "rbViudo";
            this.rbViudo.Size = new System.Drawing.Size(59, 17);
            this.rbViudo.TabIndex = 2;
            this.rbViudo.TabStop = true;
            this.rbViudo.Text = "VIUDO";
            this.rbViudo.UseVisualStyleBackColor = true;
            this.rbViudo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(6, 42);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(69, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "CASADO";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(6, 19);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(76, 17);
            this.rbSoltero.TabIndex = 0;
            this.rbSoltero.TabStop = true;
            this.rbSoltero.Text = "SOLTERO";
            this.rbSoltero.UseVisualStyleBackColor = true;
            this.rbSoltero.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(382, 83);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(157, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(561, 83);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(454, 131);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(195, 23);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkMasculino
            // 
            this.chkMasculino.BackColor = System.Drawing.Color.Transparent;
            this.chkMasculino.Location = new System.Drawing.Point(122, 131);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(100, 17);
            this.chkMasculino.TabIndex = 0;
            this.chkMasculino.Text = "MASCULINO";
            this.chkMasculino.UseVisualStyleBackColor = false;
            this.chkMasculino.CheckedChanged += new System.EventHandler(this.chkMasculino_CheckedChanged);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(382, 183);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(333, 244);
            this.txtR.TabIndex = 8;
            this.txtR.Text = "";
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.chkMasculino);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.EstadoCivil);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fm";
            this.Text = "fm";
            this.EstadoCivil.ResumeLayout(false);
            this.EstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.GroupBox EstadoCivil;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbViudo;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbDivorciado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.RichTextBox txtR;
    }
}