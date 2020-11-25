using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Prototipo
{
    class Conexion
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-66DBVQK\YEYOSERVER;Initial Catalog=El Pana Miguel;Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto" + ex.ToString());
            }
        }

        public string Insertar_Cl(int id_clientes, string nombre_cl, string domicilio_cl, string telefono_cl, string correo_cl, Int64 RFC, string curp)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into clientes(id_clientes,nombre_cl,domicilio_cl,telefono_cl,correo_cl,RFC,curp) values(" + id_clientes + ",'" + nombre_cl + "','" + domicilio_cl + "','" + telefono_cl + "','" + correo_cl + "','" + RFC + "','" + curp + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se agrego nada" + ex.ToString();
            }
            return salida;
        }

        public int Registrado_cl (int id_clientes)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from clientes where id_clientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Cl(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from clientes", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        /* public void Modificar_Cl(int id_clientes, TextBox txtNombre, TextBox txtApellidos, TextBox txtEdad, TextBox txtTelefono, ComboBox cmbGenero, TextBox txtCorreo)
        {
            try
            {
                cmd = new SqlCommand("Select * from Clientes where idClientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNombre.Text = dr["Nombre_Clt"].ToString();
                    txtApellidos.Text = dr["Apellido_Clt"].ToString();
                    txtEdad.Text = dr["Edad_Clt"].ToString();
                    txtTelefono.Text = dr["Telefono_Clt"].ToString();
                    cmbGenero.Text = dr["Genero"].ToString();
                    txtCorreo.Text = dr["Correo_Clt"].ToString();

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
        } */

        public string Insertar_Fe(int id_clientes, DateTime fecha_in, DateTime fecha_fn)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into firma_electrónica (id_clientes,fecha_in,fecha_fn) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se agrego nada" + ex.ToString();
            }
            return salida;
        }

        public int Registrado_Fe(int id_clientes)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from firma_electrónica where id_clientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Fe(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from firma electrónica", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public void Modificar_Fe(int id_clientes, DateTimePicker fecha_In, DateTimePicker fecha_Fn)
        {
            try
            {
                cmd = new SqlCommand("Select * from firma electrónica where idClientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    fecha_In.Text = dr["fecha_In"].ToString();
                    fecha_Fn.Text = dr["fecha_Fn"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
        }

        public string Insertar_Sd(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into sello digital(id_clientes,fecha_in,fecha_fn) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se agrego nada" + ex.ToString();
            }
            return salida;
        }

        public int Registrado_Sd(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from sello digital where id_clientes=" + id + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Sd(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from sello digital", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public void Modificar_Sd(int id_clientes, TextBox fecha_In, TextBox fecha_Fn)
        {
            try
            {
                cmd = new SqlCommand("Select * from ssello digital where idClientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fecha_In.Text = dr["fecha_In"].ToString();
                    fecha_Fn.Text = dr["fecha_Fn"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
        }

        public string Insertar_Ss(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into seguro social(id_clientes,fecha_in,fecha_fn) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se agrego nada" + ex.ToString();
            }
            return salida;
        }

        public int Registrado_Ss(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from seguro social where id_clientes=" + id + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Ss(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from seguro social", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public void Modificar_Ss(int id_clientes, TextBox fecha_In, TextBox fecha_Fn)
        {
            try
            {
                cmd = new SqlCommand("Select * from seguro social where idClientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fecha_In.Text = dr["fecha_In"].ToString();
                    fecha_Fn.Text = dr["fecha_Fn"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
        }

        public string Insertar_Df(int id_clientes, string fecha_in, string fecha_fn, string declaracion_f, string seguro_s, string dos_p)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into declaración fiscal(id_clientes,fecha_in,fecha_fn) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "','" + declaracion_f + "','" + seguro_s + "','" + dos_p + "','" + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se agrego nada" + ex.ToString();
            }
            return salida;
        }

        public int Registrado_Df(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from declaración fiscal where id_clientes=" + id + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Df(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from declaración fiscal", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }
    }
}
