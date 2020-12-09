using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaSisWeb
{

    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.Attributes.Add("onclick", "return ConfirmOnDelete()");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Cad.setLogin(TextBox1.Text);
            DAL.deletaCad();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}