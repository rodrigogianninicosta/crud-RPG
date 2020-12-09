using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaSisWeb
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
                Button2.Attributes.Add("OnClick", "alert('Obrigatorio o preenchimento do campo')");
            else
            {
                Cad.setLogin(TextBox1.Text);
                if (DAL.verificaExistencia())
                    Response.Redirect("WebForm8.aspx");
                else
                {
                    Button2.Attributes.Add("OnClick", "alert('Usuario Inexistente')");
                }
            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}