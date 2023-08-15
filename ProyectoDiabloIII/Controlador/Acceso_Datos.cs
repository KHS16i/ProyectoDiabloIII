using ProyectoDiabloIII.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiabloIII.Controlador
{
    public class Acceso_Datos
    {
        #region VARIABLES GLOBALES


        #endregion


        public List<Habilidad> obtenerHabilidades()
        {
            using (dbDiabloIII db = new dbDiabloIII())
            {
                var query = db.Habilidad.ToList();

                return query;
            }
        }

        public double cargarSalud(int idPersonaje)
        {
            double porc;

            using (dbDiabloIII db = new dbDiabloIII())
            {
                var query = (from S in db.Salud
                            where S.IdPersonaje == idPersonaje
                            orderby S.IdSalud descending
                            select new
                            {
                                S.Porcentaje
                            }).FirstOrDefault();

                porc = Convert.ToDouble(query.Porcentaje);

                return porc;
            }
        }

        public bool guardarPartida(double vida, int idPersonaje) 
        {
            using (dbDiabloIII db = new dbDiabloIII())
            {
                var queryGuardar = new Salud
                {
                    Porcentaje = Convert.ToDecimal(vida),
                    IdPersonaje = idPersonaje
                };

                db.Salud.Add(queryGuardar);

                try
                {
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {   
                    return false;
                }

            }
        }
    }

}
