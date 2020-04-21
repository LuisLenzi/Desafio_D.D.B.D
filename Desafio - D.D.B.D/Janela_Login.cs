using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Desafio___D.D.B.D
{
    public partial class Janela_Login : Form
    {

        public Janela_Login()
        {
            InitializeComponent();
        }

        private void Texto_Conectando_Click(object sender, EventArgs e)
        {

        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            string Server = Servidor.Text;
            string User = Usuario.Text;
            string Password = Senha.Text;

            if (Server != "remotemysql.com" || User != "UaCNgJNJSY" || Password != "xwe3cLq9OY")
            {
                MessageBox.Show(" Erro ao Conectar ");
                MessageBox.Show(" Informações Inválidas ");
            }
            else
            {
                MySqlConnectionStringBuilder string_Conexao = new MySqlConnectionStringBuilder();
                string_Conexao.Server = "remotemysql.com";
                string_Conexao.Database = "UaCNgJNJSY";
                string_Conexao.UserID = "UaCNgJNJSY";
                string_Conexao.Password = "xwe3cLq9OY";
                string_Conexao.Port = 3306;
                MySqlConnection Conexao = new MySqlConnection();
                Conexao.ConnectionString = string_Conexao.ConnectionString;
                try
                {
                    Conexao.Open();
                    MessageBox.Show(" Sucesso ao Conectar ");
                }
                catch (Exception)
                {
                    MessageBox.Show(" Erro ao Conectar ");
                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Texto_Login_Click(object sender, EventArgs e)
        {

        }

        private void Texto_Senha_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Executar_Click(object sender, EventArgs e)
        {
            string Server = Servidor.Text;
            string User = Usuario.Text;
            string Password = Senha.Text;

            if (Server != "remotemysql.com" || User != "UaCNgJNJSY" || Password != "xwe3cLq9OY")
            {
                MessageBox.Show(" Certifique-se de ter conectado com o usuário e senha corretos. ");
            }
            else
            {
                MySqlConnectionStringBuilder string_Conexao = new MySqlConnectionStringBuilder();
                string_Conexao.Server = "remotemysql.com";
                string_Conexao.Database = "UaCNgJNJSY";
                string_Conexao.UserID = "UaCNgJNJSY";
                string_Conexao.Password = "xwe3cLq9OY";
                string_Conexao.Port = 3306;
                MySqlConnection Conexao = new MySqlConnection();
                Conexao.ConnectionString = string_Conexao.ConnectionString;
                string Instruction = InstructionBox.Text;
                try
                {
                    Conexao.Open();
                    try
                    {
                        MySqlCommand Comando = new MySqlCommand();
                        Comando.CommandText = Instruction;
                        Comando.Connection = Conexao;
                        Comando.ExecuteNonQuery();
                        MessageBox.Show(" Instrução Executada com Sucesso ");
                        MessageBox.Show(" → " + Instruction + " ← ");
                    }
                    catch (Exception)
                    {
                        if (Instruction == null)
                        {
                            MessageBox.Show(" Nada atribuído ");
                        }
                        else
                        {
                            MessageBox.Show(" Comando Inválido ");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(" Comando Inválido ");
                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        private void Janela_Login_Load(object sender, EventArgs e)
        {

        }

        private void Servidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstructionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}