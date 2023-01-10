using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Datos
{
    internal class FestejosAdmin
    {

        public List<Festejos> Consultar()
        {
            using (DatabaseEntities contexto = new DatabaseEntities())
            {
                return contexto.Festejos.AsNoTracking().ToList();
            }
        }
        public void Guardar (Festejos modelo)
        {
            using (DatabaseEntities contexto = new DatabaseEntities())
            {
                contexto.Festejos.Add(modelo);
                contexto.SaveChanges();
            }

         }
    }
       
    
}
