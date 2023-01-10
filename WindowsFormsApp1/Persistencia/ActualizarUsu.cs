using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Persistencia
{
    public partial class ActualizarUsu : Form
    {
        public int? Id;
       users modelo = null;

        public ActualizarUsu(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (Id != null)
            {
                CargaDatos();
            }

        }

        private void ActualizarUsu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                using (DatabaseEntities db = new DatabaseEntities())
                {
                    if (Id == null)

                        modelo = new users();

                    modelo.Id = int.Parse(txtId.Text);
                    modelo.nombre = txtNombre.Text;
                    modelo.email = (txtEmail.Text);
                    modelo.password = txtPassword.Text;



                    if (Id == null)
                        db.users.Add(modelo);
                    else
                    {
                        db.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
      
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
            }
        }



        private void CargaDatos()
        {
            try
            {

                using (DatabaseEntities db = new DatabaseEntities())
                {

                    modelo = db.users.Find(Id);
                    txtNombre.Text = modelo.nombre;
                    txtEmail.Text = modelo.email;
                    txtPassword.Text = modelo.password;

                }
            }
            
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
            }
        }

    }
}
  
