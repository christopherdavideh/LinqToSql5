using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaNegocio
{
    public class LogicaUsuario
    {
        //istancias mi data context
        public static DataClasses1DataContext dc = new DataClasses1DataContext();

        // Metodo para retornar los datos
        public static List<Tbl_Usuario> obtenerUsuario()
        {
            var lista = dc.Tbl_Usuarios.Where(usu => usu.usu_estado == 'A');
            return lista.ToList();
        }

        //metodo para verificar credenciales
        public static bool Atentificar(string nombre, string pass)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == 'A' & usu.usu_nomlogin.Equals(nombre) & usu.usu_contrasena.Equals(pass));
            return auto;
        }

        public static bool EstadoUsuario(string nombre)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == 'B' & usu.usu_nomlogin.Equals(nombre));
            return auto;
        }

        //vereficar usuarios especificos
        public static Tbl_Usuario Autentificarxlogin(string nombre, string pass)
        {
            //Single traer una solo dato de la base de datos
            var nlogin = dc.Tbl_Usuarios.Single(usu => usu.usu_estado == 'A' & usu.usu_nomlogin.Equals(nombre) & usu.usu_contrasena.Equals(pass));
            return nlogin;
        }

        //verificar cedula (evitar duplicidad)
        public static bool AutentificarCed(string ced)
        {
            var autoced = dc.Tbl_Usuarios.Any(usu => usu.usu_cedula.Equals(ced));
            return autoced;
        }


        //metodo para verificar el nombre login
        public static bool verificarNom(string nombre)
        {
            var vrnom = dc.Tbl_Usuarios.Any(usu => usu.usu_nomlogin.Equals(nombre));
            return vrnom;
        }

        //metodo para guardar
        public static string save(Tbl_Usuario usuario)
        {
            try
            {
                
                //guardar el objeto en la BD
                //Insert om Submit Insertar datos en la BD
                dc.Tbl_Usuarios.InsertOnSubmit(usuario);
                dc.SubmitChanges();//guardo directo en la base de los cambios por IsertOnSubmit
                return "Si";
            }
            catch (Exception ex)
            {
                //throw new ArgumentException("Los datos no han sido guardados" + ex.Message);
                return "No";
            }
        }

        public static void BloquearUsuario(string user)
        {
            try
            {
                Tbl_Usuario usulog = dc.Tbl_Usuarios.SingleOrDefault(usu => usu.usu_nomlogin.Equals(user));
                usulog.usu_estado = 'B';
                //dc.Tbl_Usuarios.InsertOnSubmit(usuario);
                dc.SubmitChanges();//guardo directo en la base de los cambios por IsertOnSubmit
                //return "Si";
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados" + ex.Message);
                //return "No";
            }

        }
    }
}
