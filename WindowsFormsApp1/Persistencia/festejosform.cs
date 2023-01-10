using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Datos;
using WindowsFormsApp1.Modelo;
using WindowsFormsApp1.Persistencia;

namespace WindowsFormsApp1
{
    public partial class festejosform : Form
    {
       
        private DataTable tabla;
        FestejosAdmin admin = new FestejosAdmin();
       UsuariosAdmin admin1 = new UsuariosAdmin();
        private void Inicializar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("festejo");
            tabla.Columns.Add("tipo festejo");
            tabla.Columns.Add("localidad");
            tabla.Columns.Add("provincia");

            dgFestejo.DataSource = tabla;
        }
        private void InicializarUsu()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("nombre");
            tabla.Columns.Add("email");
            tabla.Columns.Add("password");
          
            dgUsuario.DataSource = tabla;
        }
        public festejosform()
        {
            InitializeComponent();

            Consultar();
            ConsultarUsu();
        }
        private void Consultar()
        {
            Inicializar();
            List<Festejos> lista = admin.Consultar();
            foreach (var item in lista)
            {
                DataRow row = tabla.NewRow();
                row["Id"] = item.Id;
                row["festejo"] = item.festejo;
                row["tipo festejo"] = item.tipo_festejo;
                row["localidad"] = item.localidad;
                row["provincia"] = item.provincia;
                tabla.Rows.Add(row);
               
            }

        }

        private void ConsultarUsu()
        {
            InicializarUsu();
            List<users> lista = admin1.ConsultarUsu();
            foreach (var item in lista)
            {
                DataRow row = tabla.NewRow();
                row["Id"] = item.Id;
                row["nombre"] = item.nombre;
                row["email"] = item.email;
                row["password"] = item.password;
                tabla.Rows.Add(row);

            }

        }

        private void Guardar()
        {
            Festejos modelo = new Festejos()
            {
                Id = int.Parse(txtId.Text),
                festejo = txtfestejo.Text,
                tipo_festejo = txttipo.Text,
                localidad = txtlocalidad.Text,
                provincia = txtprovincia.Text,

            };
            admin.Guardar(modelo);
        }
        private void GuardarUsu()
        {
            users modelo = new users()
            {
                Id = int.Parse(textdni.Text),
                nombre= textnombre.Text,
               email = textemail.Text,
                password = textpassword.Text,
            

            };
            admin1.GuardarUsu(modelo);
        }


        public void Limpiar()
            {
                txtId.Text = "";
                txtfestejo.Text = "";
                txttipo.Text = "";
                txtlocalidad.Text = "";
                   txtprovincia.Text = "";
        }

        public void LimpiarUsu()
        {
            textdni.Text = "";
            textnombre.Text = "";
            textemail.Text = "";
            textpassword.Text = "";
            
        }


        private void InsertarF_Click(object sender, EventArgs e)
        {

            Guardar();
            Consultar();
            Limpiar();
            MessageBox.Show("Insertado correctamente");
           
        }
        private void InsertarUsu_Click(object sender, EventArgs e)
        {

            GuardarUsu();
            ConsultarUsu();
            LimpiarUsu();
            MessageBox.Show("Insertado usuario  correctamente");
            
        }

        private void festejosform_Load(object sender, EventArgs e)
        {
           users  us = new users();
            this.label1.Text = this.textBox6.Text;
        }
       
        private int? GetId()
        {
            try
            {
               return  int.Parse(dgFestejo.Rows[dgFestejo.CurrentRow.Index].Cells[0].Value.ToString());
            }catch{
                return null;
            }
           
        }
        private int? GetIdUsu()
        {
            try
            {
                return int.Parse(dgUsuario.Rows[dgUsuario.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }
        private void ActualizarF_Click(object sender, EventArgs e)
        {
               
             int? Id = GetId();
            if(Id != null)
            {
                ActualizarF actualizar = new ActualizarF(Id);
                actualizar.ShowDialog();
                Inicializar();

            }
            Consultar();
        }
        private void ActualizarUsu_Click_1(object sender, EventArgs e)
        {
            int? Id = GetIdUsu();
            if (Id != null)
            {
                ActualizarUsu actualizar = new ActualizarUsu(Id);
                actualizar.ShowDialog();
                Inicializar();

            }
            Consultar();
        }

        public void EliminarF_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
               using ( DatabaseEntities db = new DatabaseEntities())
                {
                    Festejos modelo = db.Festejos.Find(Id);
                    db.Festejos.Remove(modelo);
                    db.SaveChanges();
                }
                Inicializar();
                MessageBox.Show("Eliminado correctamente");
            }
            Consultar();
        }
        public void EliminarUsu_Click(object sender, EventArgs e)
        {
            int? Id = GetIdUsu();
            if (Id != null)
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    users modelo = db.users.Find(Id);
                    db.users.Remove(modelo);
                    db.SaveChanges();
                }
                Inicializar();
                MessageBox.Show("Eliminado correctamente");
            }
            Consultar();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            users us = new users();
            if (textBox6.Text == "Admin")
            {
                EliminarF.Enabled = false;

                EliminarUsu.Enabled = false;

            }
            else if (textBox6.Text == "Usuario")
            {
                InsertarF.Enabled = false;
                EliminarF.Enabled = false;
                ActualizarF.Enabled = false;

                InsertarUsu.Enabled = false;
                EliminarUsu.Enabled = false;
                ActualizarUsu.Enabled = false;

            }

            else if (textBox6.Text == "SuperAdmin")
            {
                InsertarF.Enabled = true;
                EliminarF.Enabled = true;
                ActualizarF.Enabled = true;

                InsertarUsu.Enabled = true;
                EliminarUsu.Enabled = true;
                ActualizarUsu.Enabled = true;
            }
            else if (textBox6.Text == "")
            {

                InsertarF.Enabled = true;
                EliminarF.Enabled = true;
                ActualizarF.Enabled = true;

                InsertarUsu.Enabled = true;
                EliminarUsu.Enabled = true;
                ActualizarUsu.Enabled = true;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if(txtFiltro.Text != "")
            {
         
                dgFestejo.CurrentCell = null;
              
                
                foreach( DataGridViewRow r in dgFestejo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgFestejo.Rows)
                {
                    foreach( DataGridViewCell c in r.Cells)
                        {
                        if((c.Value.ToString().ToUpper()).IndexOf(txtFiltro.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }

                    }
                }
               
            }
            else
            {
                _ = dgFestejo.DataSource;
                
            }
            
        }

        private void textFiltroUsu_TextChanged(object sender, EventArgs e)
        {
            if (textFiltroUsu.Text != "")
            {

                dgUsuario.CurrentCell = null;


                foreach (DataGridViewRow r in dgUsuario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgUsuario.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(textFiltroUsu.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }

                    }
                }
            }
            else
            {
                _ = dgUsuario.DataSource;
            }
        }
    }

       
    }
