using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace LinqToSql
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            txt_nombre.Text = txt_ced.Text = txt_apellido.Text = txt_direc.Text = txt_telef.Text = txt_telef.Text = txt_pass.Text = txt_user.Text = txt_email.Text = "";
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            Tbl_Usuario usuario = new Tbl_Usuario();
            usuario.usu_cedula = txt_ced.Text;
            usuario.usu_nombre = txt_nombre.Text;
            usuario.usu_apellido = txt_apellido.Text;
            usuario.usu_direccion = txt_direc.Text;
            usuario.usu_telefono = txt_telef.Text;
            usuario.usu_contrasena = Encriptar.GetSHA256(txt_pass.Text.ToString());
            usuario.usu_nomlogin = txt_user.Text;
            usuario.usu_correo = txt_email.Text;
            //guardar la informacion quemada
            usuario.usu_estado = 'A';
            usuario.usu_fechacreacion = DateTime.Now;
            usuario.tip_id = 2;
            if (LogicaUsuario.save(usuario)=="Si")
            {
                lbl_mesaje.Visible = true;
                lbl_mesaje.Text = "Los datos se guardaron correctamente";
                Limpiar();
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Error! Los datos no se guardaron correctamente";
            }          
            
        }
    }
}