using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Persistencia
{
    public partial class RolUsuForm : Form
    {
        public RolUsuForm()
        {
            InitializeComponent();
        }

        private void RolUsuForm_Load(object sender, EventArgs e)
        {

        }
        private void GuardarRol()
        {
            try
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    RolUsuario rolUsuario = new RolUsuario();
                    rolUsuario.RolNombre = textBox1.Text.ToUpper().Trim();
                    db.SaveChanges();
                }

            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void GuardarPermiso(Permiso pPermiso)
        {
            try
            {
                using(DatabaseEntities db = new DatabaseEntities())
                {
                    db.Permiso.Add(pPermiso);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int UltimoRegistro()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var ultimo = (from c in db.RolUsuario
                              orderby c.IdRol descending
                              select c.IdRol).FirstOrDefault();
                return ultimo;
            }
        }
        private void checkRol()
        {
            Permiso permistoEntidad = new Permiso();
            int Id = UltimoRegistro();
            foreach( Control chk in panel1.Controls)
            {
                permistoEntidad.RolUsuId = Id;
                if( chk is CheckBox)
                {
                    if(((CheckBox)chk).Checked)
                    {
                        permistoEntidad.OpcionId =Convert.ToInt32( chk.Tag);
                        permistoEntidad.Permitido = true;
                        GuardarPermiso(permistoEntidad);
                    }
                    else
                    {
                        permistoEntidad.OpcionId = Convert.ToInt32(chk.Tag);
                        permistoEntidad.Permitido = false;
                        GuardarPermiso(permistoEntidad);
                    }
                }
            }
        }
        private void Limpiar()
        {
            textBox1.Text = String.Empty;
            textBox1.Focus();
            foreach (Control chk in panel1.Controls)
            {
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                        ((CheckBox)chk).Checked = false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GuardarRol();
            checkRol();
            Limpiar();

        }
    }
}
