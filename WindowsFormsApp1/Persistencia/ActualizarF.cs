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
    public partial class ActualizarF : Form
    {
        public int? Id;
        Festejos modelo = null;
        public ActualizarF(int? Id=null)
        {
            InitializeComponent();
            this.Id = Id;
            if(Id != null)
            {
                CargaDatos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                if (Id == null)

                    modelo = new Festejos();

                modelo.Id = int.Parse(txtId.Text);
                modelo.festejo = txtfest.Text;
                modelo.tipo_festejo = (txttipo.Text);
                modelo.localidad = txtlocal.Text;
                modelo.provincia = txtprov.Text;

               
                if(Id==null)
                    db.Festejos.Add(modelo);
                else
                {
                    db.Entry(modelo).State=System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();
            }
        }
    private   void CargaDatos()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                
                modelo = db.Festejos.Find( Id);

                txtfest.Text = modelo.festejo;
                txttipo.Text = modelo.tipo_festejo;
                txtlocal.Text=modelo.localidad;
                txtprov.Text=modelo.provincia;

            }
        }

        private void ActualizarF_Load(object sender, EventArgs e)
        {

        }
    }
}
