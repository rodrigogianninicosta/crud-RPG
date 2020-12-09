using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ProvaSisWeb
{
    public class BLL
    {
        public static void geraArquivo()
        {
            FileStream outfile;

            string al = @"C:\Users\Rodrigao\Pictures\Screenshots\sessão.txt";
            outfile = new System.IO.FileStream(al,
                                               System.IO.FileMode.Create,
                                               System.IO.FileAccess.Write);

            string algo = Cad.getLogado();
            for (int i = 0; i < algo.Length; ++i)
            {
                outfile.WriteByte((byte)char.ToUpper(algo[i]));
            }
            algo = Cad.getHora().ToString();
            for (int i = 0; i < algo.Length; ++i)
            {
                outfile.WriteByte((byte)char.ToUpper(algo[i]));
            }
            algo = Cad.getBrowser();
            for (int i = 0; i < algo.Length; ++i)
            {
                outfile.WriteByte((byte)char.ToUpper(algo[i]));
            }
            outfile.Close();
        }
    }
}