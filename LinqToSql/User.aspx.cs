using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToSql
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (!IsPostBack)
            {
                
                if (Session["usu"] != null)
                {
                    lbl_usuario.Visible = true;
                    lbl_usuario1.Visible = true;
                    lbl_usuario3.Visible = true;
                    lbl_usuario.Text += Session["usu"].ToString();
                    lbl_usuario1.Text += Session["usu"].ToString();
                    lbl_usuario3.Text += Session["usu"].ToString();
                    Session["valor"] = 0;
                    Session["historial"] = "";
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btn_session_Click(object sender, EventArgs e)
        {
            Session["usu"] = null;
            Response.Redirect("Login.aspx");
        }
        public void LimpiarDatos()
        {
            Session["valor"] = 0;
            Session["historial"] = "";
            txt_valor1.Text = "";
            txt_valor2.Text = "";
            txt_resultado.Text = "";
        }

        protected void suma_Click(object sender, EventArgs e)
        {            
            Session["valor"] = Convert.ToDouble(Session["valor"].ToString()) + Convert.ToDouble(txt_resultado.Text);
            //Session["historial2"] = txt_resultado.Text + "+";
            Session["historial"] = Session["historial"].ToString() + "+" + txt_resultado.Text;
            txt_valor1.Text = Session["historial"].ToString();
            txt_valor2.Text = Session["valor"].ToString();
            txt_resultado.Text = "";
            //Session["cont"] = Convert.ToInt32(Session["cont"].ToString()) - 1
        }

        protected void resta_Click(object sender, EventArgs e)
        {
            Session["valor"] = Convert.ToDouble(Session["valor"].ToString()) - Convert.ToDouble(txt_resultado.Text);
            //Session["historial2"] = txt_resultado.Text + "+";
            Session["historial"] = Session["historial"].ToString() + "-" + txt_resultado.Text;
            txt_valor1.Text = Session["historial"].ToString();
            txt_valor2.Text = Session["valor"].ToString();
            txt_resultado.Text = "";
        }

        protected void multiplicacion_Click(object sender, EventArgs e)
        {
            Session["valor"] = Convert.ToDouble(Session["valor"].ToString()) * Convert.ToDouble(txt_resultado.Text);
            //Session["historial2"] = txt_resultado.Text + "+";
            Session["historial"] = Session["historial"].ToString() + "x" + txt_resultado.Text;
            txt_valor1.Text = Session["historial"].ToString();
            txt_valor2.Text = Session["valor"].ToString();
            txt_resultado.Text = "";
        }

        protected void division_Click(object sender, EventArgs e)
        {
            Session["valor"] = Convert.ToDouble(Session["valor"].ToString()) / Convert.ToDouble(txt_resultado.Text);
            //Session["historial2"] = txt_resultado.Text + "+";
            Session["historial"] = Session["historial"].ToString() + "/" + txt_resultado.Text;
            txt_valor1.Text = Session["historial"].ToString();
            txt_valor2.Text = Session["valor"].ToString();
            txt_resultado.Text = "";
        }

        protected void potenciacion_Click(object sender, EventArgs e)
        {
            Session["valor"] = Math.Pow(Convert.ToDouble(Session["valor"].ToString()), Convert.ToDouble(txt_resultado.Text));
            //Session["historial2"] = txt_resultado.Text + "+";
            Session["historial"] = Session["historial"].ToString() + "^ (" + txt_resultado.Text + ")";
            txt_valor1.Text = Session["historial"].ToString();
            txt_valor2.Text = Session["valor"].ToString();
            txt_resultado.Text = "";
        }

        protected void radicacion_Click(object sender, EventArgs e)
        {
            Session["valor"] = Math.Pow(Convert.ToDouble(Session["valor"].ToString()), (1/Convert.ToDouble(txt_resultado.Text)));
            //Session["historial2"] = txt_resultado.Text + "+";
            Session["historial"] = Session["historial"].ToString() + "^ (1/" + txt_resultado.Text + ")";
            txt_valor1.Text = Session["historial"].ToString();
            txt_valor2.Text = Session["valor"].ToString();
            txt_resultado.Text = "";
        }

        protected void almacenar_Click(object sender, EventArgs e)
        {

            LimpiarDatos();
        }

        protected void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}