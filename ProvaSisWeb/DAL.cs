using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace ProvaSisWeb
{
    public class DAL
    {
        private static String strConexao = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + @"C:\Users\Rodrigao\Music\ProvaSisWeb\ProvaSisWeb\obj\Debug\ProvaDB.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;


        public static void conecta()
        {
            Erro.setErro(false);
            try
            {
                conn.Open();
            }
            catch
            {
                Erro.setErro("A conexão falhou!");
                return;
            }
        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static bool inserirCad()
        {
            bool insertion=false;
            String aux = "insert into Usuario(Nome,Login,Senha,CD_Tipo) values (@Nome,@Login,@Senha,@CD_Tipo)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.AddWithValue("@Nome", OleDbType.VarChar).Value = Cad.getNome();
            strSQL.Parameters.AddWithValue("@Login", OleDbType.VarChar).Value = Cad.getLogin();
            strSQL.Parameters.AddWithValue("@Senha", OleDbType.VarChar).Value = Cad.getSenha();
            strSQL.Parameters.AddWithValue("@CD_Tipo", OleDbType.VarChar).Value = Cad.getCD_Tipo();

            try
            {
                conecta();
                strSQL.ExecuteNonQuery();

                String aux_ = "insert into PersoUsu(ID_Perso,ID_Weapon,Usuario) values (@Perso,@Weapon,@Usuario)";
                strSQL = new OleDbCommand(aux_, conn);

                strSQL.Parameters.AddWithValue("@Perso", OleDbType.VarChar).Value = Cad.getID_Perso();
                strSQL.Parameters.AddWithValue("@Weapon", OleDbType.VarChar).Value = Cad.getID_Weapon();
                strSQL.Parameters.AddWithValue("@Usuario", OleDbType.VarChar).Value = Cad.getLogin();

                try
                {
                    strSQL.ExecuteNonQuery();
                    insertion = true;
                    Erro.setErro(false);
                }
                catch (Exception e)
                {

                    Erro.setErro(e.Message);
                }
            }
            catch (Exception e)
            {

                Erro.setErro(e.Message);
            }
            return insertion;
        }

        public static void deletaCad()
        {
            String aux = "delete * from Usuario where Login = @Login";

            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.AddWithValue("@Login", OleDbType.VarChar).Value = Cad.getLogin();

            strSQL.ExecuteNonQuery();
        }

        public static void consultaCad(int code)
        {
            if (code == 1)
            {
                OleDbDataReader result;
                String aux = "select * from Usuario where Login=@Login";
                strSQL = new OleDbCommand(aux, conn);

                strSQL.Parameters.AddWithValue("@Login", OleDbType.VarChar).Value = Cad.getLogin();
                try
                {
                    result = strSQL.ExecuteReader();
                    if (!result.HasRows)
                        Erro.setErro("Nenhum usuario encontrado!");
                    else
                    {
                        result.Read();

                        Cad.setNome(Convert.ToString(result["Nome"]));
                        Cad.setLogin(Convert.ToString(result["Login"]));
                        Cad.setCD_Tipo(Convert.ToString(result["CD_Tipo"]));
                        Erro.setErro(false);
                    }
                }
                catch (Exception e)
                {
                    Erro.setErro(e.Message);
                }
            }
            else
            {
                OleDbDataReader result;
                String aux = "select * from Usuario";
                strSQL = new OleDbCommand(aux, conn);
                result = strSQL.ExecuteReader();
                string algo = "";
                string algo2 = "";
                string algo3 = "";
                try
                {
                   
                    int i = 1;
                    while(i!=0)
                    {
                        result.Read();
                        algo += result["Nome"];
                        algo += " ";
                        algo2 += result["Login"];
                        algo2 += " ";
                        algo3 += result["CD_Tipo"];
                        algo3 += " ";
                        i++;
                    }
                }
                catch
                { }
         
                Cad.setNome(Convert.ToString(algo));
                Cad.setLogin(Convert.ToString(algo2));
                Cad.setCD_Tipo(Convert.ToString(algo3));
            }
        }

        public static void atualizaCad(String a)
        {
            String aux = "update Usuario set Nome=@Nome, Login=@Login, Senha=@Senha, CD_Tipo=@CD_Tipo where Login=@UsuarioAserAtt ";

            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.AddWithValue("@UsuarioAserAtt", OleDbType.VarChar).Value = a;
            strSQL.Parameters.AddWithValue("@Nome", OleDbType.VarChar).Value = Cad.getNome();
            strSQL.Parameters.AddWithValue("@Login", OleDbType.VarChar).Value = Cad.getLogin();
            strSQL.Parameters.AddWithValue("@Senha", OleDbType.VarChar).Value = Cad.getSenha();
            strSQL.Parameters.AddWithValue("@CD_Tipo", OleDbType.VarChar).Value = Cad.getCD_Tipo();

            try
            {
                strSQL.ExecuteNonQuery();
                Erro.setErro(false);
            }
            catch (Exception e) 
            {
                Erro.setErro(e.Message);
            } 

        }
        public static bool verificaLogin()
        {
            bool verification = false;
            OleDbDataReader result;
            String aux = "select * from Usuario where Login=@Login and Senha=@Senha";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.AddWithValue("@Login", OleDbType.VarChar).Value = Cad.getLogin();
            strSQL.Parameters.AddWithValue("@Senha", OleDbType.VarChar).Value = Cad.getSenha();

            try
            {
                result = strSQL.ExecuteReader();
                if (!result.HasRows)
                    throw new Exception("Login ou senha incorretos!");
                else verification = true;
                Erro.setErro(false);
            }
            catch (Exception e)
            {
                Erro.setErro(e.Message);
            }
            return verification;
        }
        public static bool verificaADM()
        {
            bool verification = false;
            OleDbDataReader result;
            String aux = "select CD_Tipo from Usuario where Login=@Login and CD_Tipo=@Tipo";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.AddWithValue("@Login", OleDbType.VarChar).Value = Cad.getLogado();
            strSQL.Parameters.AddWithValue("@Tipo", OleDbType.VarChar).Value = 1;
            try
            {
                result = strSQL.ExecuteReader();
                if (!result.HasRows)
                    throw new Exception("Não é Administrador!");
                else verification = true;
                Erro.setErro(false);
            }
            catch (Exception e)
            {
                Erro.setErro(e.Message);
            }
            return verification;
        }
        public static bool verificaExistencia()
        {
            bool verification = false;
            OleDbDataReader result;
            String aux = "select * from Usuario where Login=@Login";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.AddWithValue("@Login", OleDbType.VarChar).Value = Cad.getLogin();
            try
            {
                result = strSQL.ExecuteReader();
                if (result.HasRows) verification = true;
            }
            catch (Exception e)
            {
                Erro.setErro(e.Message);
            }
            return verification;
        }
    }
}