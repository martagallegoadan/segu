using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Datos
{
    internal class UsuariosAdmin
    {
        public List<users> ConsultarUsu()
        {
            using (DatabaseEntities contexto = new DatabaseEntities())
            {
                return contexto.users.AsNoTracking().ToList();
            }
        }
        public void GuardarUsu(users modelo)
        {
            using (DatabaseEntities contexto = new DatabaseEntities())
            {
                contexto.users.Add(modelo);
                contexto.SaveChanges();
            }

        }
    }
}
