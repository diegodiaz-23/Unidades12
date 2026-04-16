using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistroLibrosGUI3
{
    public partial class Form1 : Form
    {

        List<string> nombres = new List<string>();
        List<string> editoriales = new List<string>();
        List<string> tipos = new List<string>();
        List<int> anios = new List<int>();
        List<int> paginasList = new List<int>();
        List<double> costos = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cboEditorial.Items.Add("A");
            cboEditorial.Items.Add("B");
            cboEditorial.Items.Add("C");

            cboLibro.Items.Add("Programación");
            cboLibro.Items.Add("Análisis");
            cboLibro.Items.Add("Diseño");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtLibro.Text;
            string editorial = cboEditorial.Text;
            string tipo = cboLibro.Text;
            int anio = int.Parse(txtAnio.Text);
            int paginas = int.Parse(txtPaginas.Text);
            double costo = double.Parse(txtCosto.Text);

            nombres.Add(nombre);
            editoriales.Add(editorial);
            tipos.Add(tipo);
            anios.Add(anio);
            paginasList.Add(paginas);
            costos.Add(costo);

            lstLibro.Items.Add(nombre);
            lstEditorial.Items.Add(editorial);
            lstClase.Items.Add(tipo);
            lstAnio.Items.Add(anio);
            lstPaginas.Items.Add(paginas);
            lstCosto.Items.Add(costo);

            MessageBox.Show("Libro registrado");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLibro.Clear();
            txtAnio.Clear();
            txtPaginas.Clear();
            txtCosto.Clear();

            cboEditorial.SelectedIndex = -1;
            cboLibro.SelectedIndex = -1;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int anioReciente = 0;
            string nombreReciente = "";
            int menorPaginas = int.MaxValue;
            string editorialMenor = "";
            double mayorCosto = 0;
            string nombreMayorCosto = "";

            for (int i = 0; i < nombres.Count; i++)
            {
                if (tipos[i] == "Análisis" && editoriales[i] == "B")
                    contador++;

                if (anios[i] > anioReciente)
                {
                    anioReciente = anios[i];
                    nombreReciente = nombres[i];
                }

                if (paginasList[i] < menorPaginas)
                {
                    menorPaginas = paginasList[i];
                    editorialMenor = editoriales[i];
                }

                if (costos[i] > mayorCosto)
                {
                    mayorCosto = costos[i];
                    nombreMayorCosto = nombres[i];
                }
            }

            lstEstadisticas.Items.Clear();

            lstEstadisticas.Items.Add("Libros de Análisis de editorial B: " + contador);
            lstEstadisticas.Items.Add("Más reciente: " + nombreReciente);
            lstEstadisticas.Items.Add("Editorial con menos páginas: " + editorialMenor);
            lstEstadisticas.Items.Add("Libro con mayor costo: " + nombreMayorCosto);
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtLibro.Text;
            string editorial = cboEditorial.Text;
            string clase = cboLibro.Text;
            string año = txtAnio.Text;
            string paginas = txtPaginas.Text;
            string costo = txtCosto.Text;

            lstLibro.Items.Add(nombre);
            lstEditorial.Items.Add(editorial);
            lstClase.Items.Add(clase);
            lstAnio.Items.Add(año);
            lstPaginas.Items.Add(paginas);
            lstCosto.Items.Add(costo);

            lstEstadisticas.Items.Clear();
            lstEstadisticas.Items.Add("Total de libros: " + lstLibro.Items.Count);

            //guardar datos en la base de datos
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    conn.Open();

                    string sql = @"INSERT INTO practica5
    (nombre,editorial, fechaed, paginas, costos)
    VALUES (@nom, @edi, @fec, @pag, @cos)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // 🔹 Aquí tomas los valores de tus controles
                    cmd.Parameters.AddWithValue("@nom", nombre);
                    cmd.Parameters.AddWithValue("@edi", editorial);
                    cmd.Parameters.AddWithValue("@fec", año);
                    cmd.Parameters.AddWithValue("@pag", paginas);
                    cmd.Parameters.AddWithValue("@cos", costo);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datos guardados correctamente 😎");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtLibro.Clear();
            txtAnio.Clear();
            txtPaginas.Clear();
            txtCosto.Clear();

            cboEditorial.SelectedIndex = -1;
            cboLibro.SelectedIndex = -1;

            txtLibro.Focus();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboEditorial.Items.Add("A");
            cboEditorial.Items.Add("B");
            cboEditorial.Items.Add("C");

            cboLibro.Items.Add("Programación");
            cboLibro.Items.Add("Análisis");
            cboLibro.Items.Add("Diseño");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = lstLibro.Items.Count;

            double sumaCostos = 0;

            for (int i = 0; i < lstCosto.Items.Count; i++)
            {
                sumaCostos += Convert.ToDouble(lstCosto.Items[i]);
            }

            double promedio = 0;

            if (total > 0)
            {
                promedio = sumaCostos / total;
            }

            lstEstadisticas.Items.Clear();
            lstEstadisticas.Items.Add("Total de libros: " + total);
            lstEstadisticas.Items.Add("Promedio de costos: " + promedio);
        }

        private void btnSalir_Click(object sender, EventArgs e ) {
        DialogResult resultado = MessageBox.Show(
        "¿Seguro que deseas salir?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (resultado == DialogResult.Yes)
    {
        Application.Exit();
    }
  }
 }
}
