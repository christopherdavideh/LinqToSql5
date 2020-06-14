using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToSql
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (!IsPostBack)
            {
                
                if (Session["admin"] != null )
                {
                    lbl_usuario.Visible = true;
                    lbl_usuario1.Visible = true;
                    lbl_usuario3.Visible = true;
                    lbl_usuario.Text += Session["admin"].ToString();
                    lbl_usuario1.Text += Session["admin"].ToString();
                    lbl_usuario3.Text += Session["admin"].ToString();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btn_session_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}