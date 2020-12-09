using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaSisWeb
{
    public class Logado
    {
        public static bool login;

        public static void setLogin(bool _codigo) { login = _codigo; }
        public static bool getLogin() { return login; }
    }
}