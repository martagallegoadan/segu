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
    public partial class CambioCon : Form
    {
        public CambioCon()
        {
            InitializeComponent();
        }
        

        private DataTable tabla;
        FestejosAdmin admin = new FestejosAdmin();
        UsuariosAdmin admin1 = new UsuariosAdmin();
        private void Inicializar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Password");
            

            dgCon.DataSource = tabla;
        }
        private void CambioCon_Load(object sender, EventArgs e)
        {

        }
        private void ActualizarCon_Click(object sender, EventArgs e)
        {

            int? Id = GetId();
            if (Id != null)
            {
                ActualizarCon actualizar = new ActualizarCon(Id);
                actualizar.ShowDialog();
                Inicializar();

            }
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dgCon.Rows[dgCon.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }

        private void ActualizarCon_Click_1(object sender, EventArgs e)
        {

            ActualizarCon users = new Persistencia.ActualizarCon();
            users.ShowDialog();
            Inicializar();
        }
       

    }
}
