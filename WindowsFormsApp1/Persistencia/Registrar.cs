using DryIoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Datos;
using WindowsFormsApp1.Modelo;
using WindowsFormsApp1.Persistencia;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApp1.Persistencia
{
    
    public partial class Registrar : Form
    {
        private DataTable tabla;
        UsuariosAdmin admin = new UsuariosAdmin();
        private void Inicializar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("nombre");
            tabla.Columns.Add("email");
            tabla.Columns.Add("password");
            tabla.Columns.Add("Rol");
            dataGridView1.DataSource = tabla;
        }
        public Registrar()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }
        private void Consultar()
        {
            Inicializar();
            List<users> lista = admin.ConsultarUsu();
            foreach (var item in lista)
            {
                DataRow row = tabla.NewRow();
                row["Id"] = item.Id;
                row["nombre"] = item.nombre;
                row["email"] = item.email;
                row["password"] = item.password;
                row["Rol"] = item.Rol;
                tabla.Rows.Add(row);
            }

        }
        private void Guardar()
        {
            users modelo = new users()
            {
                nombre = txtNombre.Text,
                email = txtemail.Text,
                password = txtpass.Text,
                Rol=txtRol.Text

            };
            admin.GuardarUsu(modelo);
        }
        public void Limpiar()
        {
            txtdn.Text = "";
            txtNombre.Text = "";
            txtpass.Text = "";
            txtemail.Text = "";
            txtRol.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
                Guardar();
                Consultar();
                Limpiar();

            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (textVacios(txtpass))
                errorP.SetError(txtpass, "No puede ser vacio, ingrese contraseña");
            else
                errorP.Clear();

            if (txtpass.MaxLength > 14)
            {
                MessageBox.Show("Acuerdate, solo se permiten 14 caracteres");
                txtpass.MaxLength = 15;

            }

            txtpass.MaxLength = 14;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            festejosform festejos = new festejosform();
            festejos.ShowDialog();
            Inicializar();
        }


        ErrorProvider errorP = new ErrorProvider();
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            txtemail.MaxLength = 14;
            if (textVacios(txtemail))
                errorP.SetError(txtemail, "No puede ser vacio, ingrese Email");
            else
                errorP.Clear();
            if (!validarEmail(txtemail.Text))
                errorP.SetError(txtemail, "correo no valido");
            else
                errorP.Clear();
           
        }
        public static bool textVacios(TextBox pTxt)
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

        private void txtNombre_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))


            {
                e.Handled = false;


            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras ");
            }

            if (textVacios(txtNombre))
                errorP.SetError(txtNombre, "No puede ser vacio, ingrese Nombre");
            else
                errorP.Clear();

            txtNombre.MaxLength = 10;
        }

        private void txtdn_TextChanged(object sender, KeyPressEventArgs e)
        {


            txtdn.MaxLength = 7;

            if (Char.IsNumber(e.KeyChar))


            {
                e.Handled = false;


            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros sin la letra del final");
            }
            errorP.SetError(txtdn, "Acuerdate, solo  se permiten NUMEROS sin la letra del final, ademas de que solo se pueden 7  ");

            if (textVacios(txtdn))
                errorP.SetError(txtdn, "No puede ser vacio, ingrese DNI");
            else
                errorP.Clear();

            /*
            if (txtdn.MaxLength > 7)
            {
                MessageBox.Show("Solo se permiten 7 caracteres");
                

            }
            */
           
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {
            if (textVacios(txtRol))
                errorP.SetError(txtRol, "No puede ser vacio, ingrese rol");
            else
                errorP.Clear();


            txtRol.MaxLength = 9;

        }
    }
}
