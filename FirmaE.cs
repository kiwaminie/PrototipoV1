using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Prototipo
{
    public partial class FirmaE : Form
    {
        Conexion con = new Conexion();

        public FirmaE()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void enviar_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos ingresados con éxito.");
        }

        private void borrar_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void regresa_btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pik = (PictureBox)sender;
            int width = pik.Size.Width;
            int height = pik.Size.Height;
            int larger = 10;
            pik.Size = new Size(width + larger, height + larger);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pik = (PictureBox)sender;
            int width = pik.Size.Width;
            int height = pik.Size.Height;
            int larger = -10;
            pik.Size = new Size(width + larger, height + larger);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pik = (PictureBox)sender;
            int width = pik.Size.Width;
            int height = pik.Size.Height;
            int larger = 10;
            pik.Size = new Size(width + larger, height + larger);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pik = (PictureBox)sender;
            int width = pik.Size.Width;
            int height = pik.Size.Height;
            int larger = -10;
            pik.Size = new Size(width + larger, height + larger);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          if (textBox1.Text == "")
            {
                MessageBox.Show("Introduzca el id del cliente");
            }
            else
            {
                if (fecha_In.Value > fecha_Fn.Value)
                {
                    MessageBox.Show("Introduzca bien la fecha");
                }
                else
                {
                    if (con.Registrado_Fe(Convert.ToInt32(textBox1.Text)) == 0)
                    {
                        MessageBox.Show(con.Insertar_Fe(Convert.ToInt32(textBox1.Text), fecha_In.Value, fecha_Fn.Value));
                        //con.Cargar_Fe(dataGridView1);
                        textBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cliente ya registrado");
                        textBox1.Text = "";
                    }
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FirmaE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet5.firma_electrónica' Puede moverla o quitarla según sea necesario.
            this.firma_electrónicaTableAdapter1.Fill(this.el_Pana_MiguelDataSet5.firma_electrónica);
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet1.firma_electrónica' Puede moverla o quitarla según sea necesario.
            //this.firma_electrónicaTableAdapter.Fill(this.el_Pana_MiguelDataSet1.firma_electrónica);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void firmaElectrónicaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fecha_In_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


