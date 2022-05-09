using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = E:\\Projetos\\CursoC#\\Academia\\Academia\\banco\\banco_academia.db");
            conexao.Open();

            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception e)
            {
                ConexaoBanco().Close();
                throw e;
            }
        }
        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception e)
            {
                ConexaoBanco().Close();
                throw e;
            }
        }

        public static void NovoUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            
            if (ExisteUsuario(u))
            {
                MessageBox.Show("Username já existe!");
                return;
            }
            else
            {
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO tb_usuarios(T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                        cmd.Parameters.AddWithValue("@nome",u.nome);
                        cmd.Parameters.AddWithValue("@username", u.username);
                        cmd.Parameters.AddWithValue("@senha", u.senha);
                        cmd.Parameters.AddWithValue("@status", u.stauts);
                        cmd.Parameters.AddWithValue("@nivel", u.nivel);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Novo usuário inserido com sucesso!");
                        ConexaoBanco().Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao gravar novo usuário!");
                    ConexaoBanco().Close();
                }
            }
        }

        public static bool ExisteUsuario(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT T_USERNAME FROM tb_Usuarios WHERE T_USERNAME = '" + u.username + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                    ConexaoBanco().Close();
                    return res;
                }
            }
            catch (Exception e)
            {
                ConexaoBanco().Close();
                throw e;
            }
        }
    }
}
