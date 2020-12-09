using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaSisWeb
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text==""||TextBox2.Text == ""||TextBox3.Text == ""||TextBox4.Text == "")
                Button2.Attributes.Add("OnClick", "alert('Obrigatorio o preenchimento de todos os campos')");
            else
            {
                String a = Cad.getLogin();
                Cad.setLogin(TextBox1.Text);
                Cad.setSenha(Cad.GerarMD5(TextBox2.Text));
                Cad.setNome(TextBox3.Text);
                Cad.setCD_Tipo(TextBox4.Text);
                DAL.atualizaCad(a);
                Response.Write("alert('ATUALIZADO!')");
                Response.Redirect("WebForm1.aspx");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}