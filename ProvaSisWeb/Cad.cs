using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace ProvaSisWeb
{
    public class Cad
    {
        private static int ID_Usu;
        private static int ID_PersoUsu;
        private static int Forca;
        private static int ID_Perso;
        private static int ID_Weapon;
        //Acima é do BD ID_Usu.

        private static String Nome;
        private static String Login;
        private static String Senha;
        private static String CD_Tipo;
        // Acima é do BD Usuario.

        private static String Logado;
        private static DateTime Hora;
        private static String Browser;
        //Acima o usuario Logado

        public static void setLogado(String _Logado) { Logado = _Logado; }
        public static void setHora(DateTime _Hora) { Hora = _Hora; }
        public static void setBrowser(String _Browser) { Browser = _Browser; }
        //Acima é o set do Usuario Logado.

        public static void setID_Usu(int _ID_Usu) { ID_Usu = _ID_Usu; }
        public static void setID_PersoUsu(int _ID_PersoUsu) { ID_PersoUsu = _ID_PersoUsu; }
        public static void setForca(int _Forca) { Forca = _Forca; }
        public static void setID_Perso(int _ID_Perso) { ID_Perso = _ID_Perso; }
        public static void setID_Weapon(int _ID_Weapon) { ID_Weapon = _ID_Weapon; }
        public static void setNome(String _Nome) { Nome = _Nome; }
        public static void setLogin(String _Login) { Login = _Login; }
        public static void setSenha(String _Senha) { Senha = _Senha; }
        public static void setCD_Tipo(String _CD_Tipo) { CD_Tipo = _CD_Tipo; }
        //Acima é o set do Banco.



        public static String getLogado() { return Logado; }
        public static DateTime getHora() { return Hora; }
        public static String getBrowser() { return Browser; }

        //Acima é o get do Usuario Logado.

        public static int getID_Usu() { return ID_Usu; }
        public static int getID_PersoUsu() { return ID_PersoUsu; }
        public static int getForca() { return Forca; }
        public static int getID_Perso() { return ID_Perso; }
        public static int getID_Weapon() { return ID_Weapon; }
        public static String getNome() { return Nome; }
        public static String getLogin() { return Login; }
        public static String getSenha() { return Senha; }
        public static String getCD_Tipo() { return CD_Tipo; }

        public static string GerarMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
                str.Append(result[i].ToString("x2"));
            return str.ToString();
        }
    }
}