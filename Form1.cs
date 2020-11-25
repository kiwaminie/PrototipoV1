using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Form1 : Form
    {
        Conexion con = new Conexion();

        private void pictureBox1_Click_1(object sender, EventArgs e)
        { /*
            String UssMiguel = "Miguel";
            String PassMiguel = "Miguel";
            if (textBox1.Text == UssMiguel & textBox2.Text == PassMiguel)
            {
                 

            }
            else
            {
                if (textBox1.Text == "" & textBox2.Text == "")
                {
                    MessageBox.Show("Introduzca los datos");
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }*/
            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
            Show();
        }

        public Form1()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

          // this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(188,80);
            pictureBox1.Location = new Point(592, 376);

            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "entrar_hover.png");

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {      
            pictureBox1.Size = new Size(157, 57);
            pictureBox1.Location = new Point(609, 382);

            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_entrar_idle.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {


        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {



        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {


        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}