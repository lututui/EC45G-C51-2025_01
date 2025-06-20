using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Cadastro_Clientes;



namespace C__Cadastro_Clientes
{
    public partial class FrmVendaProduto: Form
    {
        public FrmVendaProduto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // AlgumaComboBox.DataSource = Funcoes.BuscaSQL("SELECT DISTINCT endereco FROM pedido WHERE endereco IS NOT NULL");
            //AlgumaComboBox.DisplayMember = endereco;
            //AlgumaComboBox.SelectIndex = -1;


            if (BoxID.Text == "")
                return;
            
            ButtonSalvar.Text = "Atualizar";

            DataTable dt=Funcoes.BuscaSQL("SELECT * from produtos where id_produto=" + BoxID.Text);

                        BoxNome.Text = dt.Rows[0]["nome"].ToString();
                        BoxTelefone.Text = dt.Rows[0]["telefone"].ToString();
                        BoxData.Text = dt.Rows[0]["dia"].ToString();
                        BoxProduto.Text = dt.Rows[0]["produto"].ToString();
                        BoxObs.Text = dt.Rows[0]["obs"].ToString();
                   
                        BoxValorPago.Text = dt.Rows[0]["valor_pago"].ToString();
                        string tipoPagamento = dt.Rows[0]["tipo_pagamento"].ToString();
                        if (tipoPagamento == "Pix")
                            OpPix.Checked = true;
                        else if (tipoPagamento == "Dinheiro")
                            OpDinheiro.Checked = true;
                        else if (tipoPagamento == "Cartão")
                            OpCartao.Checked = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }

        }

        
        private void SalvarClienteNoBanco()
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=banco_certificadora_1;User=root;Password=Saaugusto09!"))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    //////////////////////////////////////////////////////////

                    // INSERCOES
                    if (BoxID.Text == "")
                    {

                        // INSERIR EM CLIENTE
                        cmd.CommandText = "INSERT INTO produtos(nome, telefone, dia, produto, obs, valor_pago) " +
                                          "VALUES (@nome, @telefone, @dia, @produto, @obs, @valor_pago)";

                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@nome", BoxNome.Text);
                        cmd.Parameters.AddWithValue("@telefone", BoxTelefone.Text);
                        cmd.Parameters.AddWithValue("@id_produto", BoxID.Text); // Adicionando o ID do   produtos como FK
                        // Tratamento da data
                        if (BoxData.Text == "  /  /")
                            cmd.Parameters.AddWithValue("@dia", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@dia", Convert.ToDateTime(BoxData.Text));
                        cmd.Parameters.AddWithValue("@produto", BoxProduto.Text);
                        cmd.Parameters.AddWithValue("@obs", BoxObs.Text);
                        cmd.Parameters.AddWithValue("@valor_pago", BoxValorPago.Text);

                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "SELECT @@IDENTITY";
                        BoxID.Text = cmd.ExecuteScalar().ToString();

                        // Definição do tipo de pagamento
                        if (OpPix.Checked)
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Pix");
                        else if (OpDinheiro.Checked)
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Dinheiro");
                        else if (OpCartao.Checked)
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Cartão");
                        else
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Não Informado");

                        cmd.ExecuteNonQuery();
                    }
                    
                    //UPDATES
                    else
                    {
                        // UPDATE EM CLIENTE
                        cmd.CommandText = "UPDATE produtos SET nome=@nome, telefone=@telefone, dia=@dia, produto=@produto, obs=@obs, valor_pago=@valor_pago, tipo_pagamento=@tipo_pagamento WHERE id_produto=" + BoxID.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nome", BoxNome.Text);
                        cmd.Parameters.AddWithValue("@telefone", BoxTelefone.Text);

                        if (BoxData.Text == "  /  /")
                            cmd.Parameters.AddWithValue("@dia", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@dia", Convert.ToDateTime(BoxData.Text));

                        cmd.Parameters.AddWithValue("@produto", BoxProduto.Text);
                        cmd.Parameters.AddWithValue("@obs", BoxObs.Text);
                        cmd.Parameters.AddWithValue("@valor_pago", BoxValorPago.Text);

                        // Definição do tipo de pagamento
                        if (OpPix.Checked)
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Pix");
                        else if (OpDinheiro.Checked)
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Dinheiro");
                        else if (OpCartao.Checked)
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Cartão");
                        else
                            cmd.Parameters.AddWithValue("@tipo_pagamento", "Não Informado");


                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Cadastro bem-sucedido!");
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (Validacao())
                return;

            ArrumarCamposInt();
            SalvarClienteNoBanco();
        }

        private bool Validacao()
        {
            // Validar se data é válida
            if (BoxData.Text != "  /  /")
            {
                try
                {
                    Convert.ToDateTime(BoxData.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Data não é válida");
                    return true;
                }
            }

            // Nova validação: BoxValorPago não pode conter vírgula
            if (BoxValorPago.Text.Contains(","))
            {
                MessageBox.Show(" Valor Pago deve usar ponto (.) como separador, não vírgula");
                return true;
            }

            // Validação: BoxValorPago deve ser um número válido (com ou sem ponto)
            decimal valor;
            if (!decimal.TryParse(BoxValorPago.Text, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out valor))
            {
                MessageBox.Show("O campo Valor Pago deve conter números.");
                return true;
            }

            return false;
        }


        private void ArrumarCamposInt()
        {
            if (BoxValorPago.Text =="")
            {
                BoxValorPago.Text = "0";
            }

        }

        private void BoxServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
         

            //limpando as box
            BoxID.Text = "";
            BoxNome.Text = "";
            BoxData.Text = "";
            BoxProduto.Text = "";
            BoxObs.Text = "";
            BoxValorPago.Text = "";
            BoxTelefone.Text = "";

            OpPix.Checked = false;
            OpDinheiro.Checked = false;
            OpCartao.Checked = false;

            ButtonSalvar.Text = "Salvar";

       

        }

        private void BoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
