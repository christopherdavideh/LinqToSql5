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
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (!IsPostBack)
            {
                
                Session["cont"] = 3;
                lbl_error.Visible = false;
                if (Session["admin"] != null)
                {
                    Response.Redirect("Admin.aspx");
                }
                if (Session["usu"] != null)
                {
                    Response.Redirect("User.aspx");
                }
            }
            else
            {
                if (Session["admin"] != null)
                {
                    Response.Redirect("Admin.aspx");//Redirecciona a lapgina de Admin
                }
                if (Session["usu"] != null)
                {
                    Response.Redirect("User.aspx");
                }
            }
        }

        //metodo para ingresar
        public void Ingresar()
        {
            lbl_error.Visible = false;
            if (string.IsNullOrEmpty(txt_user.Text) && string.IsNullOrEmpty(txt_pass.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Los campos se encuentran vacios";
                return;
            }
            else if (string.IsNullOrEmpty(txt_user.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Usuario vacio";
                return;
            }else if (string.IsNullOrEmpty(txt_pass.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Contrasena vacia";
                return;
            }
            else
            {
                //validar usuarios
                bool existe = LogicaUsuario.verificarNom(txt_user.Text);
                {
                    if (existe)
                    {
                        if (LogicaUsuario.Atentificar(txt_user.Text, Encriptar.GetSHA256(txt_pass.Text)))
                        {
                            //instanciar tabla usuario como objeto
                            Tbl_Usuario usuario = new Tbl_Usuario();
                            usuario = LogicaUsuario.Autentificarxlogin(txt_user.Text, Encriptar.GetSHA256(txt_pass.Text));

                            //validar si es Usuario o Administrador
                            if (usuario.tip_id == 1)
                            {
                                Session["admin"] = usuario.usu_nombre + " " + usuario.usu_apellido;
                                Session["usu"] = null;
                                Session["cont"] = 3;
                                Response.Redirect("Admin.aspx");
                            }
                            else
                            {
                                Session["usu"] = usuario.usu_nombre + " " + usuario.usu_apellido;
                                Session["admin"] = null;
                                Session["cont"] = 3;
                                Response.Redirect("User.aspx");
                            }
                        }
                        else
                        {
                            if (LogicaUsuario.EstadoUsuario(txt_user.Text))
                            {
                                lbl_error.Visible = true;
                                lbl_error.Text = "Usuario Bloqueado";
                            }
                            else
                            {
                                if (Convert.ToInt32(Session["cont"].ToString()) > 1)
                                {
                                    Session["cont"] = Convert.ToInt32(Session["cont"].ToString()) - 1;
                                    //string cont2= Session["cont"].ToString();
                                    txt_pass.Text = "";
                                    lbl_error.Visible = true;
                                    lbl_error.Text = "Le quedan: " + Session["cont"] + " intentos ";
                                }
                                else
                                {

                                    lbl_error.Visible = true;
                                    LogicaUsuario.BloquearUsuario(txt_user.Text);
                                    lbl_error.Text = "Exceso de intentos, Usuario Bloqueado";
                                    txt_user.Text = "";
                                    txt_pass.Text = "";
                                    //Ingreso.Enabled = false;
                                    //Session["estado"] = "Inactivo";
                                    Session["cont"] = 3;
                                }
                            }
                        }
                    }
                    else
                    {
                        lbl_error.Visible = true;
                        lbl_error.Text = "Usuario no existe";
                        btn_registro.Visible = true;
                        return;
                    }
                }
            }
            
        }

        protected void btn_ingreso_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        protected void btn_olvido_Click(object sender, EventArgs e)
        {

        }

        protected void lnk_button_Click(object sender, EventArgs e)
        {

        }

        protected void btn_registro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}