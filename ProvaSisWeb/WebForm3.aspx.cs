using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaSisWeb
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Cad.setID_Perso(1);
            Cad.setID_Weapon(1);
            Response.Redirect("WebForm4.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Cad.setID_Perso(2);
            Cad.setID_Weapon(4);
            Response.Redirect("WebForm4.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Cad.setID_Perso(3);
            Cad.setID_Weapon(3);
            Response.Redirect("WebForm4.aspx");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Cad.setID_Perso(4);
            Cad.setID_Weapon(2);
            Response.Redirect("WebForm4.aspx");
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}