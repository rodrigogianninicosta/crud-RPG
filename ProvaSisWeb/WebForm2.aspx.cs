using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.DynamicData;

namespace ProvaSisWeb
{

    public partial class WebForm2 : System.Web.UI.Page
    {
        string message;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "") 
                Button2.Attributes.Add("OnClick", "alert('O campo de Login e Senha devem ser preenchidos!')");
            else
            {
                Cad.setLogin(TextBox1.Text);
                Cad.setLogado(Cad.getLogin());
                Cad.setBrowser(Request.Browser.Browser);
                Cad.setHora(DateTime.Now);
                Cad.setSenha(Cad.GerarMD5(TextBox2.Text));
                DAL.conecta();
                if (Erro.getErro() == false)
                {
                    if (DAL.verificaLogin())
                    {

                        message= "alert('Logado com sucesso!')";
                        Logado.setLogin(true);
                        Response.Redirect("WebForm1.aspx");
                        
                    }
                    else
                    {
                        message= "alert('" + Erro.getMsg() + "')";
                        DAL.desconecta();
                    }
                    Button2.Attributes.Add("OnClick", message);
                }
                else
                {
                    Button2.Attributes.Add("OnClick", "alert('" + Erro.getMsg() + "')");
                    DAL.desconecta();
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
        

    }
}