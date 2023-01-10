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

namespace WindowsFormsApp1.Persistencia
{
    public partial class ActualizarCon : Form
    {
        
        public int? Id;
        users modelo = null;
        UsuariosAdmin admin1 = new UsuariosAdmin();
        public ActualizarCon(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (Id != null)
            {
                CargaDatos();
            }
        }

        private void ActualizarCon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                if (Id == null)

                    modelo = new users();

               
                modelo.password = textPassN.Text;



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
        private void CargaDatos()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {

                modelo = db.users.Find(Id);

                textPassN.Text = modelo.password;
                

            }
        }
        private void Guardar()
        {
            users modelo = new users()
            {

                password = textPassN.Text,



            };
            admin1.GuardarUsu(modelo);
        }

        private void ActualizarCon_Load_1(object sender, EventArgs e)
        {

        }
    }
}
