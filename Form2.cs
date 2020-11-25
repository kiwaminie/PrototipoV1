﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void clientes_btn_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.Show();
            this.Close();
        }

        /*private void PersonaF_btn_Click(object sender, EventArgs e)
        {
            PersonaF pf = new PersonaF();
            pf.Show();
            this.Close();
        }

        private void PersonaM_btn_Click(object sender, EventArgs e)
        {
            PersonaM pm = new PersonaM();
            pm.Show();
            this.Close();
        }*/

        private void firmae_btn_Click(object sender, EventArgs e)
        {
            FirmaE fe = new FirmaE();
            fe.Show();
            this.Close();
        }

        private void SeguroS_btn_Click(object sender, EventArgs e)
        {
            SeguroS ss = new SeguroS();
            ss.Show();
            this.Close();
        }

        private void SelloD_btn_Click(object sender, EventArgs e)
        {
            SelloD sd = new SelloD();
            sd.Show();
            this.Close();
        }

        private void DeclaracionF_btn_Click(object sender, EventArgs e)
        {
            DeclaracionF df = new DeclaracionF();
            df.Show();
            this.Close();
        }

        //SELLO DIGITAL

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Sello_Btn.Size = new Size(275, 113);
            Sello_Btn.Location = new Point(0, 72);

            this.Sello_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "sello_hover.png");

            Sello_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image= Image.FromFile(Application.StartupPath + "\\" + "sello.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Sello_Btn.Size = new Size(239, 64);
            Sello_Btn.Location = new Point(0, 97);

            this.Sello_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_sellodigital.png");
            Sello_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = null;
        }

        //DECLARACION FISCAL

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Fiscal_Btn.Size = new Size(275, 113);
            Fiscal_Btn.Location = new Point(0, 174);

            this.Fiscal_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "fiscal_hover.png");

           Fiscal_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "fiscal.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Fiscal_Btn.Size = new Size(239, 64);
            Fiscal_Btn.Location = new Point(0, 199);

            this.Fiscal_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_declaracion.png");
            Fiscal_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = null;
        }
        // FIRMA ELECTRONICA

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            firma_btn.Size = new Size(275, 113);
            firma_btn.Location = new Point(0, 278);

            this.firma_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "firma_hover.png");

           firma_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "firma.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            firma_btn.Size = new Size(239, 64);
            firma_btn.Location = new Point(0, 303);

            this.firma_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_firma.png");
            firma_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = null;


        }

        //SEGURO SOCIAL

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            social_btn.Size = new Size(275, 113);
            social_btn.Location = new Point(0, 382);

            this.social_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "social_hover.png");

            social_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "instituto.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            social_btn.Size = new Size(239, 64);
            social_btn.Location = new Point(0, 407);

            this.social_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_social.png");
            social_btn.SizeMode = PictureBoxSizeMode.Zoom;
            Fondo.Image = null;

        }

        //CLIENTES

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            cliente_btn.Size = new Size(275, 113);
            cliente_btn.Location = new Point(0, 492);

            this.cliente_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "cliente_hover.png");

            cliente_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "usuarios.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;



        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            cliente_btn.Size = new Size(239, 64);
            cliente_btn.Location = new Point(0, 517);

            this.cliente_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_cliente.png");
            cliente_btn.SizeMode = PictureBoxSizeMode.Zoom;
            Fondo.Image = null;


        }

        private void Sello_Btn_Click(object sender, EventArgs e)
        {
            SelloD sd = new SelloD();
            sd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DeclaracionF df = new DeclaracionF();
            df.Show();

        }

        private void firma_btn_Click(object sender, EventArgs e)
        {
            FirmaE fe = new FirmaE();
            fe.Show();

        }

        private void social_btn_Click(object sender, EventArgs e)
        {
            SeguroS ss = new SeguroS();
            ss.Show();

        }

        private void cliente_btn_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
