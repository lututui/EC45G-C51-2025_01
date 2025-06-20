using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;

namespace Cadastro_Clientes
{
    class Funcoes
    {
        public static void MsgErro(string Msg)
        {
            MessageBox.Show(Msg,
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public static void MsgAlerta(string Msg)
        {
            MessageBox.Show(Msg,
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        public static void MsgInfo(string Msg)
        {
            MessageBox.Show(Msg,
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        public static bool Pergunta(string Msg)
        {
            if (MessageBox.Show(Msg,
                                "",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public static DataTable BuscaSQL(string ComandoSql)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=banco_certificadora_1;User=root;Password=Saaugusto09!"))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = ComandoSql;

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static void CarregarCombobox(ComboBox cb, string tabela, string campo)
        {
            cb.DataSource = Funcoes.BuscaSQL("SELECT DISTINCT " + campo + " FROM " + tabela + " WHERE " + campo + " IS NOT NULL");
            cb.DisplayMember = campo;
            cb.SelectedIndex = -1;
            //COMO USAR: Funcoes.CarregarCombobox(ComboBoxNome, "Tabela", "campo");

        }

        public static decimal SomaValoresPago(DateTime dataInicial, DateTime dataFinal)
        {
            decimal total = 0;

            string conexaoString = "Server=localhost;Port=3306;Database=banco_certificadora_1;User=root;Password=Saaugusto09!";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string query = "SELECT SUM(valor_pago) FROM produtos WHERE dia BETWEEN @dataInicial AND @dataFinal";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@dataInicial", dataInicial.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dataFinal", dataFinal.ToString("yyyy-MM-dd"));

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value && resultado != null)
                    {
                        total = Convert.ToDecimal(resultado);
                    }
                }
            }

            return total;
        }


        public static decimal SomaProdutos(DateTime dataInicial, DateTime dataFinal)
        {
            decimal total = 0;

            string conexaoString = "Server=localhost;Port=3306;Database=banco_certificadora_1;User=root;Password=Saaugusto09!";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string query = " SELECT COUNT(*) FROM produtos WHERE dia BETWEEN @dataInicial AND @dataFinal ";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@dataInicial", dataInicial.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dataFinal", dataFinal.ToString("yyyy-MM-dd"));

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value && resultado != null)
                    {
                        total = Convert.ToDecimal(resultado);
                    }
                }
            }

            return total;
        }

        public static void FazerBackupClientesExcel()
        {
            // Obtém o caminho da pasta Downloads do usuário
            string caminhoPastaDownloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\backup_produtos.xlsx";

            using (MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=banco_certificadora_1;User=root;Password=Saaugusto09!"))
            {
                conexao.Open();
                string query = "SELECT * FROM produtos ;";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Preenche a DataTable com os dados do banco

                    // Criar a planilha no formato XLSX
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var planilha = workbook.Worksheets.Add("Produtos");
                        planilha.Cell(1, 1).InsertTable(dt); // Insere a DataTable na planilha

                        // Salva o arquivo Excel no caminho definido
                        workbook.SaveAs(caminhoPastaDownloads);
                    }
                }
            }

            MessageBox.Show("Backup salvo em Downloads como 'backup_produtos.xlsx'!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ComandoSQL(string ComandoSql)
        {
            

            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=banco_certificadora_1;User=root;Password=Saaugusto09!"))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = ComandoSql;
                    cmd.ExecuteNonQuery();

                }
            }

            
        }
    }
}
