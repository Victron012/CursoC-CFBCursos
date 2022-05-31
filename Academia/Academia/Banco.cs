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
            conexao = new SQLiteConnection("Data Source = " + Globais.caminhoBanco);
            conexao.Open();

            return conexao;
        }
        public static DataTable dql(string sql)//Data Query Language
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void dml(string sql, string msgOk=null, string msgErro=null)//Data Manipulation Language
        {
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOk!=null) 
                {
                    MessageBox.Show(msgOk);
                }
            }
            catch (Exception e)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n"+ e.Message);
                }
                throw e;
            }
        }
        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.
                Close();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void NovoUsuario(Usuario u)
        {
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
                    var vcon = ConexaoBanco();
                    var cmd = vcon.CreateCommand();

                    cmd.CommandText = "INSERT INTO tb_usuarios(T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.stauts);
                    cmd.Parameters.AddWithValue("@nivel", u.nivel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo usuário inserido com sucesso!");
                    vcon.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao gravar novo usuário!");
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
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT T_USERNAME FROM tb_Usuarios WHERE T_USERNAME = '" + u.username + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                vcon.Close();
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable ObterUsuariosId()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT N_IDUSUARIO as 'Id Usuário', T_NOMEUSUARIO as 'Nome Usuário', T_USERNAME as 'Username', T_STATUSUSUARIO as 'Status' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable ObterUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.
                Close();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static DataTable ExcluirUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.
                Close();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void AlterarUsuario(Usuario u)
        {
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO = @nome, T_USERNAME = @username, T_SENHAUSUARIO = @senha, T_STATUSUSUARIO = @status, N_NIVELUSUARIO = @nivel WHERE N_IDUSUARIO = @id";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.stauts);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário atualizado com sucesso!");
                vcon.Close();
            }
            catch (Exception)
            {
                if (ExisteUsuario(u))
                {
                    MessageBox.Show("Username já existe!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar usuário!");
                }
            }
        }
    }
}
