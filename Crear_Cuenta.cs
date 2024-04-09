using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Trabajo_Final___Desarrollo_de_Proyectos_con_Software_Libre
{
    public partial class Crear_Cuenta : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion;

        public Crear_Cuenta()
        {
            InitializeComponent();
            cadenaConexion = "Server = 127.0.0.1; Port = 5432; Database = Proyecto;";
            cadenaConexion += "User id = postgres";
            cadenaConexion += "; Password = 12345";
            conexion.ConnectionString = cadenaConexion;
            try

            {
                conexion.Open();
            }
            catch
            {
                conexion.Close();
            }
            if (conexion.State.ToString() == "Open")
            {
            }
        }

        private void btnparaMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnparaCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }

        private void Crear_Cuenta_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Escribe tu usuario...")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
                txtusuario.Font = new Font(txtusuario.Font, FontStyle.Regular);

            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Escribe tu usuario...";
                txtusuario.ForeColor = Color.CornflowerBlue;
                txtusuario.Font = new Font(txtusuario.Font, FontStyle.Italic);

            }
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Escribe tu nombre...")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
                txtnombre.Font = new Font(txtnombre.Font, FontStyle.Regular);

            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "Escribe tu nombre...";
                txtnombre.ForeColor = Color.CornflowerBlue;
                txtnombre.Font = new Font(txtnombre.Font, FontStyle.Italic);

            }
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "Escribe tu apellido...")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.Black;
                txtapellido.Font = new Font(txtapellido.Font, FontStyle.Regular);

            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "Escribe tu apellido...";
                txtapellido.ForeColor = Color.CornflowerBlue;
                txtapellido.Font = new Font(txtapellido.Font, FontStyle.Italic);

            }
        }

        private void txtcontrasena_Enter(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "Escribe tu contraseña...")
            {
                txtcontrasena.Text = "";
                txtcontrasena.ForeColor = Color.Black;
                txtcontrasena.Font = new Font(txtcontrasena.Font, FontStyle.Regular);

            }
        }

        private void txtcontrasena_Leave(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                txtcontrasena.Text = "Escribe tu contraseña...";
                txtcontrasena.ForeColor = Color.CornflowerBlue;
                txtcontrasena.Font = new Font(txtcontrasena.Font, FontStyle.Italic);

            }
        }

        private void txtconfirmcontrasena_Enter(object sender, EventArgs e)
        {
            if (txtconfirmcontrasena.Text == "Repite tu contraseña...")
            {
                txtconfirmcontrasena.Text = "";
                txtconfirmcontrasena.ForeColor = Color.Black;
                txtconfirmcontrasena.Font = new Font(txtconfirmcontrasena.Font, FontStyle.Regular);

            }
        }

        private void txtconfirmcontrasena_Leave(object sender, EventArgs e)
        {
            if (txtconfirmcontrasena.Text == "")
            {
                txtconfirmcontrasena.Text = "Repite tu contraseña...";
                txtconfirmcontrasena.ForeColor = Color.CornflowerBlue;
                txtconfirmcontrasena.Font = new Font(txtconfirmcontrasena.Font, FontStyle.Italic);

            }
        }

        private void txttelefono_Enter(object sender, EventArgs e)
        {
            if (txttelefono.Text == "Número telefónico...")
            {
                txttelefono.Text = "";
                txttelefono.ForeColor = Color.Black;
                txttelefono.Font = new Font(txttelefono.Font, FontStyle.Regular);

            }
        }

        private void txttelefono_Leave(object sender, EventArgs e)
        {
            if (txttelefono.Text == "")
            {
                txttelefono.Text = "Número telefónico...";
                txttelefono.ForeColor = Color.CornflowerBlue;
                txttelefono.Font = new Font(txttelefono.Font, FontStyle.Italic);

            }
        }

        private void txtdia_Enter(object sender, EventArgs e)
        {
            if (txtdia.Text == "Día...")
            {
                txtdia.Text = "";
                txtdia.ForeColor = Color.Black;
                txtdia.Font = new Font(txtdia.Font, FontStyle.Regular);

            }
        }

        private void txtdia_Leave(object sender, EventArgs e)
        {
            if (txtdia.Text == "")
            {
                txtdia.Text = "Día...";
                txtdia.ForeColor = Color.CornflowerBlue;
                txtdia.Font = new Font(txtdia.Font, FontStyle.Italic);

            }
        }

        private void txtano_Enter(object sender, EventArgs e)
        {
            if (txtano.Text == "Año...")
            {
                txtano.Text = "";
                txtano.ForeColor = Color.Black;
                txtano.Font = new Font(txtano.Font, FontStyle.Regular);

            }
        }

        private void txtano_Leave(object sender, EventArgs e)
        {
            if (txtano.Text == "")
            {
                txtano.Text = "Año...";
                txtano.ForeColor = Color.CornflowerBlue;
                txtano.Font = new Font(txtano.Font, FontStyle.Italic);

            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                // Verificar si la conexión está cerrada
                if (conexion.State == ConnectionState.Closed)
                {
                    try
                    {
                        // Abrir la conexión
                        conexion.Open();

                        // Crear y configurar el comando SQL
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conexion;
                        string cadenaComando = "INSERT INTO usuario (nombre_usuario, nombre, apellido, dia_nacimiento, mes_nacimiento, ano_nacimiento, contrasena, confirmacion_contrasena, sexo, telefono, pais) ";
                        cadenaComando += "VALUES (@nombre_usuario, @nombre, @apellido, @dia_nacimiento, @mes_nacimiento, @ano_nacimiento, @contrasena, @confirmacion_contrasena, @sexo, @telefono, @pais);";
                        cmd.CommandText = cadenaComando;

                        // Agregar parámetros al comando SQL
                        cmd.Parameters.AddWithValue("@nombre_usuario", NpgsqlDbType.Varchar, 15).Value = txtusuario.Text;
                        cmd.Parameters.AddWithValue("@nombre", NpgsqlDbType.Varchar, 15).Value = txtnombre.Text;
                        cmd.Parameters.AddWithValue("@apellido", NpgsqlDbType.Varchar, 20).Value = txtapellido.Text;
                        cmd.Parameters.AddWithValue("@dia_nacimiento", NpgsqlDbType.Integer).Value = Convert.ToInt32(txtdia.Text);
                        cmd.Parameters.AddWithValue("@mes_nacimiento", NpgsqlDbType.Varchar, 20).Value = cmbmes.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@ano_nacimiento", NpgsqlDbType.Integer).Value = Convert.ToInt32(txtano.Text);
                        cmd.Parameters.AddWithValue("@contrasena", NpgsqlDbType.Varchar, 25).Value = txtcontrasena.Text;
                        cmd.Parameters.AddWithValue("@confirmacion_contrasena", NpgsqlDbType.Varchar, 25).Value = txtconfirmcontrasena.Text;
                        cmd.Parameters.AddWithValue("@sexo", NpgsqlDbType.Varchar, 10).Value = cmbsexo.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@telefono", NpgsqlDbType.Varchar, 20).Value = txttelefono.Text;
                        cmd.Parameters.AddWithValue("@pais", NpgsqlDbType.Varchar, 100).Value = cmbpais.SelectedItem.ToString();

                        // Ejecutar el comando SQL
                        int res = cmd.ExecuteNonQuery();

                        if (res > 0)
                        {
                            MessageBox.Show("Registro insertado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el registro.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar o insertar datos: " + ex.Message);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtusuario.Focus();

            txtnombre.Text = "Escribe tu nombre...";
            txtnombre.ForeColor = Color.CornflowerBlue;
            txtnombre.Font = new Font(txtnombre.Font, FontStyle.Italic);

            txtapellido.Text = "Escribe tu apellido...";
            txtapellido.ForeColor = Color.CornflowerBlue;
            txtapellido.Font = new Font(txtapellido.Font, FontStyle.Italic);

            txtcontrasena.Text = "Escribe tu contraseña...";
            txtcontrasena.ForeColor = Color.CornflowerBlue;
            txtcontrasena.Font = new Font(txtcontrasena.Font, FontStyle.Italic);

            txtconfirmcontrasena.Text = "Repite tu contraseña...";
            txtconfirmcontrasena.ForeColor = Color.CornflowerBlue;
            txtconfirmcontrasena.Font = new Font(txtconfirmcontrasena.Font, FontStyle.Italic);

            txttelefono.Text = "Número telefónico...";
            txttelefono.ForeColor = Color.CornflowerBlue;
            txttelefono.Font = new Font(txttelefono.Font, FontStyle.Italic);

            txtdia.Text = "Día...";
            txtdia.ForeColor = Color.CornflowerBlue;
            txtdia.Font = new Font(txtdia.Font, FontStyle.Italic);

            txtano.Text = "Año...";
            txtano.ForeColor = Color.CornflowerBlue;
            txtano.Font = new Font(txtano.Font, FontStyle.Italic);

            cmbmes.Text = "Mes...";
            cmbsexo.Text = "Selecciona";
            cmbpais.Text = "Elige tu país...";
        }
    }
}
