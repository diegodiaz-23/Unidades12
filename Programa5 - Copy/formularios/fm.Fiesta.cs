using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjModular.formularios
{
    public partial class fm : Form
    {
        int totalPersonas = 0;
        int mayoresEdad = 0;
        int menoresEdad = 0;
        int hombres = 0;
        int mujeres = 0;

        int solteros = 0;
        int casados = 0;
        int viudos = 0;
        int divorciados = 0;

        public fm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstadoCivil_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);

            totalPersonas++;

            if (edad >= 18)
                mayoresEdad++;
            else
                menoresEdad++;

            if (chkMasculino.Checked)
                hombres++;
            else
                mujeres++;

            if (rbSoltero.Checked) solteros++;
            else if (rbCasado.Checked) casados++;
            else if (rbViudo.Checked) viudos++;
            else if (rbDivorciado.Checked) divorciados++;

            double porHombres = (double)hombres / totalPersonas * 100;
            double porMujeres = (double)mujeres / totalPersonas * 100;

            txtR.Text =
                "Total de Asistentes: " + totalPersonas + "\n" +
                "Mayores de edad: " + mayoresEdad + "\n" +
                "Menores de edad: " + menoresEdad + "\n\n" +

                "Hombres: " + hombres + "\n" +
                "Mujeres: " + mujeres + "\n\n" +

                "Solteros: " + solteros + "\n" +
                "Casados: " + casados + "\n" +
                "Viudos: " + viudos + "\n" +
                "Divorciados: " + divorciados + "\n\n" +

                "Porcentaje Hombres: " + porHombres.ToString("0.00") + "%\n" +
                "Porcentaje Mujeres: " + porMujeres.ToString("0.00") + "%";



            //Cambiar datos a string
            string genero = "";
            if (chkMasculino.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Femenino";
            }
            String estado = "";
            if (rbSoltero.Checked) estado="Soltero";
            else if (rbCasado.Checked) estado="Casado";
            else if (rbViudo.Checked) estado="Viudo";
            else if (rbDivorciado.Checked) estado="Divorciado";


            //Guardar datos
            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();

                    string sql = @"INSERT INTO practica4
    (edad,genero,estado,totalasistentes)
    VALUES (@eda, @gen, @est, @totas)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // 🔹 Aquí tomas los valores de tus controles
                    cmd.Parameters.AddWithValue("@eda", edad);
                    cmd.Parameters.AddWithValue("@gen", genero);
                    cmd.Parameters.AddWithValue("@est", estado);
                    cmd.Parameters.AddWithValue("@totas", totalPersonas);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datos guardados correctamente 😎");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }




        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            txtEdad.Text = "";
            chkMasculino.Checked = false;

            rbSoltero.Checked = false;
            rbCasado.Checked = false;
            rbViudo.Checked = false;
            rbDivorciado.Checked = false;

            txtR.Clear();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
