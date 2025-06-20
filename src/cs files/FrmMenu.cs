using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using Cadastro_Clientes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


namespace C__Cadastro_Clientes
{
    public partial class FrmMenu: Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            FrmVendaProduto frm = new FrmVendaProduto();

            frm.ShowDialog();

            AtualizarDataGridView();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();


        }

        private void ReorganizarMenu()
        {
            foreach (DataGridViewRow lin in dgListaClientes.Rows)
            {

                lin.DefaultCellStyle.ForeColor = System.Drawing.Color.SteelBlue;
                
            }
            dgListaClientes.ClearSelection();

            ButtonEditar.Enabled = false;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string texto = "";

            foreach (DataGridViewColumn col in dgListaClientes.Columns)
            {
                texto += "\r" + col.Name + ":" + col.Width.ToString();
            }

            MessageBox.Show(texto);
        }

        private void dgListaClientes_Sorted(object sender, EventArgs e)
        {
            ReorganizarMenu();
            
        }

        private void dgListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditar.Enabled = true;
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            FrmVendaProduto frm = new FrmVendaProduto();

            frm.BoxID.Text = dgListaClientes.CurrentRow.Cells["id_produto"].Value.ToString();

            frm.ShowDialog();

            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            dgListaClientes.DataSource = Funcoes.BuscaSQL("SELECT * FROM  produtos WHERE 1 " + GerarCriterios() + " ORDER BY id_produto DESC");

            dgListaClientes.ClearSelection();

            ReorganizarMenu();
        }

        private void PesqCod_TextChanged(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private string GerarCriterios()
        {
            string c = "";

            if (PesqCod.Text != string.Empty)
            {
                c += " AND id_produto = " + PesqCod.Text;
            }

            if (PesqNome.Text != string.Empty)
            {
                c += " AND nome LIKE '%" + PesqNome.Text + "%'";
            }

            if(PesqProduto.Text != string.Empty)
            {
                c += " AND  produto LIKE '%" + PesqProduto.Text + "%'";

            }

            return c;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void PesqProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Funcoes.Pergunta("Tem Certeza que deseja deletar tudo ?") == false)
            {
                return;
            }

            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=banco_certificadora_1;User=root;Password=Saaugusto09!"))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                
                    
                    // 🔴 Desativa temporariamente as chaves estrangeiras
                    cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM cliente; DELETE FROM pedido; DELETE FROM palavras;";
                    cmd.ExecuteNonQuery();

                    // 🔴 Reseta o ID da tabela   produtos para 1
                    cmd.CommandText = "ALTER TABLE   produtos AUTO_INCREMENT = 1";
                    cmd.ExecuteNonQuery();

                    // 🟢 Reativa as chaves estrangeiras
                    cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 1";
                    cmd.ExecuteNonQuery();

                    

                    AtualizarDataGridView();
                }

            }
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //CALCULO DA DATA
                DateTime data1 = Convert.ToDateTime(PesqData1.Text);
                DateTime data2 = Convert.ToDateTime(PesqData2.Text);

                //CALCULO VALOR PAGO
                decimal TotalValorPago = Funcoes.SomaValoresPago(data1, data2);
                BoxTotalValor.Text = TotalValorPago.ToString();

                //CALCULO MAO DE OBRA
                decimal TotalProdutos = Funcoes.SomaProdutos(data1, data2);
                BoxTotalProdutos.Text = TotalProdutos.ToString();

            }
            catch (Exception)
            {
            }
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funcoes.FazerBackupClientesExcel();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BoxTotalMao_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
