using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;

namespace ProvaSisWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.SoundLocation = Server.MapPath(@"music/muc.wav");
                simpleSound.PlayLooping();
            }
            Button1.ID = "Button1b";
            if (Logado.getLogin() == false)
            {
                Button2.Attributes.Add("OnClick", "alert('Você precisa estar logado!')");
                Button3.Attributes.Add("OnClick", "alert('Você precisa estar logado!')");
                Button4.Attributes.Add("OnClick", "alert('Você precisa estar logado!')");
                Button5.Attributes.Add("OnClick", "alert('Você precisa estar logado!')");
                Button6.Attributes.Add("OnClick", "alert('Você precisa estar logado!')");
                Button1.ID = "Button1";
            }
            else if(!IsPostBack)
            {
                Button2.Attributes.Remove("onClick");
                Button3.Attributes.Remove("onClick");
                Button4.Attributes.Remove("onClick");
                Button5.Attributes.Remove("onClick");
                Button6.Attributes.Remove("onClick");
                Button6.Attributes.Add("onclick", "return ConfirmLogoff()");
                Button1.Attributes.Add("OnClick", "alert('Você já está logado!')");
                Button7.Visible = true;
                Button7.Text = Cad.getLogado() + ' ' + Cad.getHora() + ' ' + Cad.getBrowser();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Logado.getLogin() == false)
            {
               
                Response.Redirect("WebForm2.aspx");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            if (Logado.getLogin() == true && DAL.verificaADM())
            {
                Response.Redirect("WebForm3.aspx");
            }
            else Button2.Attributes.Add("OnClick", "alert('"+Erro.getMsg()+"')");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Logado.getLogin() == true)
            {                
                Response.Redirect("WebForm5.aspx");
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Logado.getLogin() == true)
            {
                Response.Redirect("WebForm6.aspx");
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Logado.getLogin() == true)
            {
                Response.Redirect("WebForm7.aspx");
            }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            Button1.Attributes.Remove("onClick");
            Button7.Visible = false;
            Logado.setLogin(false);
            Button1.ID = "Button1";
            DAL.desconecta();
            BLL.geraArquivo();
        }
    }
}