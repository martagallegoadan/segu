using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CrudWindowsForm.Datos;
using LamarCodeGeneration.Util;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Datos;
using WindowsFormsApp1.Modelo;
using WindowsFormsApp1.Persistencia;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Google.Protobuf.Reflection.FieldDescriptorProto.Types;
using System.Text.RegularExpressions;
using TextBox = System.Windows.Forms.TextBox;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataTable tabla;
        UsuariosAdmin admin = new UsuariosAdmin();

       
       

        private void Inicializar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("email");
            tabla.Columns.Add("password");
            dgusuario.DataSource = tabla;
        }
        public Form1()
        {
            InitializeComponent();

            Consultar();
        }
        private void Consultar()
        {
            Inicializar();
            List<users> lista = admin.ConsultarUsu();
            foreach (var item in lista)
            {
                DataRow row = tabla.NewRow();
                row["email"] = item.email;
                row["password"] = item.password;
                tabla.Rows.Add(row);

            }

        }

        private void Guardar()
        {
            users modelo = new users()
            {

                email = txttEma.Text,
                password = txtPass.Text,

            };
            admin.GuardarUsu(modelo);
        }
        public void Limpiar()
        {

            txtPass.Text = "";
            txttEma.Text = "";
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Guardar();
            Consultar();
            Limpiar();

            MessageBox.Show("Insertado correctamente");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            festejosform Festejos = new festejosform();
            Festejos.ShowDialog();
            Inicializar();




            /*
            if (ComprobarUsuario(this.textEmail.Text, this.txtPa.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
               
                // Permitir varios intentos
                veces = veces + 1;
                if (veces < NumeroIntentos)
                {
                   Texto.Text = "Quedan " + (NumeroIntentos - veces) + " intentos";
                    return;
                }
                this.DialogResult = DialogResult.No;
            }

            Hide();
            */
        }
        /*
        private bool ComprobarUsuario(string email, string password)
        {
            // Conectar a la base de datos
            SqlConnection cnn = null;
            //
            try
            {
                // Conectar a la base de datos de SQL Server
                // (la cadena debe estar inicializada previamente)
                SqlConnection Conn = Database;
                cnn.Open();
                // Definir la cadena que vamos a usar para comprobar
                // si el usuario y el password son correctos.
                // Utilizo parámetros para evitar inyección de código.
                System.Text.StringBuilder sel = new System.Text.StringBuilder();
                // Usando COUNT(*) nos devuelve el total que coincide
                // con lo indicado en el WHERE,
                // por tanto, si la clave y el usuario son correctos,
                // devolverá 1, sino, devolverá 0
                sel.Append("SELECT COUNT(*) FROM users ");
                sel.Append("WHERE email = @Email AND password = @Password");
                // Definir el comando que vamos a ejecutar
                SqlCommand cmd = new SqlCommand(sel.ToString(), cnn);
                // Creamos los parámetros
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 40);
                //
                // Asignamos los valores recibidos como parámetro
                cmd.Parameters["@Email"].Value = email;
                cmd.Parameters["@password"].Value = password;
                //
                // Ejecutamos la consulta
                // ExecuteScalar devuelve la primera columna de la primera fila
                // por tanto, devolverá el número de coincidencias halladas,
                // que si es 1, quiere decir que el usuario y el password son correctos.
                int t = Convert.ToInt32(cmd.ExecuteScalar());
                // Cerramos la conexión
                cnn.Close();
                //
                // Si el valor devuelto es cero
                // es que no es correcto.
                if (t == 0)
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al conectar a la base de datos: \n" +
                    ex.Message, "Comprobar usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Dispose();
                }
            }
            //
            // Si llega aquí es que todo ha ido bien
            return true;
        }
    */

        private void linkuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar users = new Registrar();
            users.ShowDialog();
            Inicializar();
        }

        ErrorProvider errorP = new ErrorProvider();
        private void textEmail_TextChanged(object sender, KeyPressEventArgs e)
        {
            /*
            if (Char.IsNumber(e.KeyChar))
            
    
            {
                e.Handled = false;


            }else if(Char.IsSeparator(e.KeyChar))
                {
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
            */

            textEmail.MaxLength = 20;
            if (textVacios(textEmail))
                errorP.SetError(textEmail, "No puede ser vacio");
            else
                errorP.Clear();
            if (!validarEmail(textEmail.Text))
                errorP.SetError(textEmail, "correo no valido");
            else
                errorP.Clear();
        }
      
        public static bool textVacios ( TextBox pTxt)
        {
            if (pTxt.Text == string.Empty)
            {
                pTxt.Focus();
                return true;
            }
            else
                return false;
        }
        public static bool validarEmail(string pCorre)
        {
            return pCorre != null && Regex.IsMatch(pCorre,
               @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPa_TextChanged(object sender, EventArgs e)
        {
            if (textVacios(txtPa))
                errorP.SetError(txtPa, "No puede ser vacio");
            else
                errorP.Clear();

            if (txtPa.MaxLength >14)
            {
                MessageBox.Show("Solo se permiten 14 caracteres");
                txtPa.MaxLength = 15;

            }
               

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambioCon users = new CambioCon();
            users.ShowDialog();
            Inicializar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                users modelo = new users();
                if (textEmail.Text != modelo.email || txtPa.Text != modelo.password)
                {
                    MessageBox.Show("No validado correctamente");

                }
                else
                {
                    MessageBox.Show("Validado correctamente");
                }
            }
        }
    }
}






