using Entidades;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Historial
{
    public class HistorialDAL
    {
        public static Resultado InsertarHistorial(Entidades.Historial historial) {

            try
            {
                var db = BDConn.Connector();

                var result = db.Insert(historial);

                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Insertado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar"
                    };
                }
            }

            catch (Exception)
            {
                throw;
            }


        }

    }
}
