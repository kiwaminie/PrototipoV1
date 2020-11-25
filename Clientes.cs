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
    public partial class Clientes : Form
    {
        Conexion con = new Conexion();

        public Clientes()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
            textBox6.Hide();
            textBox7.Hide();
            label5.Hide();
            label8.Hide();
        }

        private void enviar_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos ingresados con éxito.");
        }

        private void regresa_btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void borrar_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Show();
            label5.Show();

            textBox7.Enabled = false;
            label8.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Show();
            label8.Show();

            textBox7.Enabled = true;
            label8.Enabled = true;

            // textBox6.Hide();
            // label5.Hide();
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
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Introduzca el nombre del cliente");
                }
                else
                {
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Introduzca el domicilio del cliente");
                    }
                    else
                    {
                        if (textBox4.Text == "")
                        {
                            MessageBox.Show("Introduzca el telefono del cliente");
                        }
                        else
                        {
                            if (textBox5.Text == "")
                            {
                                MessageBox.Show("Introduzca el correo del cliente");
                            }
                            else
                            {
                                if (textBox6.Text == "" & radioButton1.Checked)
                                {   
                                    
                                    MessageBox.Show("Introduzca el RFC del cliente");
                                }
                                else
                                {
                                    if (textBox7.Text == "")
                                    {
                                        MessageBox.Show("Introduzca la curp del cliente");
                                    }
                                    else
                                    {
                                        if (con.Registrado_cl(Convert.ToInt32(textBox1.Text)) == 0)
                                        {
                                            MessageBox.Show(con.Insertar_Cl(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text,textBox4.Text,textBox5.Text, Convert.ToInt64(textBox6.Text), textBox7.Text));
                                            con.Cargar_Cl(dataGridView1);
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                            textBox3.Text = "";
                                            textBox4.Text = "";
                                            textBox5.Text = "";
                                            textBox6.Text = "";
                                            textBox7.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cliente ya registrado");
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                            textBox3.Text = "";
                                            textBox4.Text = "";
                                            textBox5.Text = "";
                                            textBox6.Text = "";
                                            textBox7.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.el_Pana_MiguelDataSet.clientes);

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
