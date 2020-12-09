using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaSisWeb
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                Cad.setLogin(TextBox1.Text);
                DAL.consultaCad(1);
                if (Erro.getErro()) Button2.Attributes.Add("onclick", "alert('" + Erro.getErro() + "')");
                else
                {
                    ListBox1.Items.Add(" Nome: " + Cad.getNome());
                    ListBox1.Items.Add(" Login: " + Cad.getLogin());
                    ListBox1.Items.Add(" Tipo: " + Cad.getCD_Tipo().ToString());
                    ListBox1.Visible = true;
                }
            }
            else
            {
                DAL.consultaCad(0);
                ListBox1.Items.Add(" Nome: " + Cad.getNome());
                ListBox1.Items.Add(" Login: " + Cad.getLogin());
                ListBox1.Items.Add(" Tipo: " + Cad.getCD_Tipo().ToString());
                ListBox1.Visible = true;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}