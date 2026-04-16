namespace RegistroLibrosGUI3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtLibro = new TextBox();
            label2 = new Label();
            cboEditorial = new ComboBox();
            label3 = new Label();
            cboLibro = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAnio = new TextBox();
            txtPaginas = new TextBox();
            txtCosto = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            lstLibro = new ListBox();
            lstEditorial = new ListBox();
            lstClase = new ListBox();
            lstAnio = new ListBox();
            lstPaginas = new ListBox();
            lstCosto = new ListBox();
            button1 = new Button();
            lstEstadisticas = new ListBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Libro";
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(10, 49);
            txtLibro.Margin = new Padding(3, 2, 3, 2);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(342, 23);
            txtLibro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 32);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Editorial";
            // 
            // cboEditorial
            // 
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(366, 48);
            cboEditorial.Margin = new Padding(3, 2, 3, 2);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(156, 23);
            cboEditorial.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 31);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Clase de Libro";
            // 
            // cboLibro
            // 
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(534, 48);
            cboLibro.Margin = new Padding(3, 2, 3, 2);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(156, 23);
            cboLibro.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 7);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "REGISTRO DE LIBRO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 78);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 7;
            label5.Text = "Año de Edicion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 78);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 8;
            label6.Text = "Paginas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 78);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 9;
            label7.Text = "Costos";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(12, 95);
            txtAnio.Margin = new Padding(3, 2, 3, 2);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(118, 23);
            txtAnio.TabIndex = 10;
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(144, 95);
            txtPaginas.Margin = new Padding(3, 2, 3, 2);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(100, 23);
            txtPaginas.TabIndex = 11;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(259, 95);
            txtCosto.Margin = new Padding(3, 2, 3, 2);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(93, 23);
            txtCosto.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(366, 78);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(156, 38);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(534, 78);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RightToLeft = RightToLeft.No;
            btnLimpiar.Size = new Size(156, 38);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // lstLibro
            // 
            lstLibro.FormattingEnabled = true;
            lstLibro.Location = new Point(12, 125);
            lstLibro.Margin = new Padding(3, 2, 3, 2);
            lstLibro.Name = "lstLibro";
            lstLibro.Size = new Size(195, 94);
            lstLibro.TabIndex = 15;
            // 
            // lstEditorial
            // 
            lstEditorial.FormattingEnabled = true;
            lstEditorial.Location = new Point(212, 125);
            lstEditorial.Margin = new Padding(3, 2, 3, 2);
            lstEditorial.Name = "lstEditorial";
            lstEditorial.Size = new Size(64, 94);
            lstEditorial.TabIndex = 16;
            // 
            // lstClase
            // 
            lstClase.FormattingEnabled = true;
            lstClase.Location = new Point(281, 125);
            lstClase.Margin = new Padding(3, 2, 3, 2);
            lstClase.Name = "lstClase";
            lstClase.Size = new Size(108, 94);
            lstClase.TabIndex = 17;
            // 
            // lstAnio
            // 
            lstAnio.FormattingEnabled = true;
            lstAnio.Location = new Point(395, 125);
            lstAnio.Margin = new Padding(3, 2, 3, 2);
            lstAnio.Name = "lstAnio";
            lstAnio.Size = new Size(99, 94);
            lstAnio.TabIndex = 18;
            // 
            // lstPaginas
            // 
            lstPaginas.FormattingEnabled = true;
            lstPaginas.Location = new Point(499, 125);
            lstPaginas.Margin = new Padding(3, 2, 3, 2);
            lstPaginas.Name = "lstPaginas";
            lstPaginas.Size = new Size(80, 94);
            lstPaginas.TabIndex = 19;
            // 
            // lstCosto
            // 
            lstCosto.FormattingEnabled = true;
            lstCosto.Location = new Point(584, 125);
            lstCosto.Margin = new Padding(3, 2, 3, 2);
            lstCosto.Name = "lstCosto";
            lstCosto.Size = new Size(106, 94);
            lstCosto.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(10, 230);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(678, 22);
            button1.TabIndex = 21;
            button1.Text = "ESTADISTICAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lstEstadisticas
            // 
            lstEstadisticas.FormattingEnabled = true;
            lstEstadisticas.Location = new Point(13, 256);
            lstEstadisticas.Margin = new Padding(3, 2, 3, 2);
            lstEstadisticas.Name = "lstEstadisticas";
            lstEstadisticas.Size = new Size(677, 64);
            lstEstadisticas.TabIndex = 22;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(10, 336);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(156, 38);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 396);
            Controls.Add(btnSalir);
            Controls.Add(lstEstadisticas);
            Controls.Add(button1);
            Controls.Add(lstCosto);
            Controls.Add(lstPaginas);
            Controls.Add(lstAnio);
            Controls.Add(lstClase);
            Controls.Add(lstEditorial);
            Controls.Add(lstLibro);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCosto);
            Controls.Add(txtPaginas);
            Controls.Add(txtAnio);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboLibro);
            Controls.Add(label3);
            Controls.Add(cboEditorial);
            Controls.Add(label2);
            Controls.Add(txtLibro);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLibro;
        private Label label2;
        private ComboBox cboEditorial;
        private Label label3;
        private ComboBox cboLibro;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAnio;
        private TextBox txtPaginas;
        private TextBox txtCosto;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private ListBox lstLibro;
        private ListBox lstEditorial;
        private ListBox lstClase;
        private ListBox lstAnio;
        private ListBox lstPaginas;
        private ListBox lstCosto;
        private Button button1;
        private ListBox lstEstadisticas;
        private Button btnSalir;
    }
}
