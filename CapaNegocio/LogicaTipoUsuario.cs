using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaNegocio
{

    public class LogicaTipoUsuario
    {
        //instanciar el data context
        public static DataClasses1DataContext dc = new DataClasses1DataContext();

        //metodo para obtener la informacion de la entidad
        public static List<Tbl_TipoUsuario> obtenerTusuario()
        {
            var lista = dc.Tbl_TipoUsuarios.Where(tusu => tusu.tip_estado == 'A'); //Select * from
            return lista.ToList();
        }
    }
}
