namespace C__Cadastro_Clientes
{
    partial class FrmVendaProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxValorPago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OpPix = new System.Windows.Forms.RadioButton();
            this.OpCartao = new System.Windows.Forms.RadioButton();
            this.OpDinheiro = new System.Windows.Forms.RadioButton();
            this.BoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.BoxData = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxProduto = new System.Windows.Forms.ComboBox();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonFechar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BoxID = new System.Windows.Forms.TextBox();
            this.BoxObs = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto Vendido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Comprador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BoxNome
            // 
            this.BoxNome.Font = new System.Drawing.Font("Consolas", 11F);
            this.BoxNome.Location = new System.Drawing.Point(30, 126);
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(296, 29);
            this.BoxNome.TabIndex = 0;
            this.BoxNome.TextChanged += new System.EventHandler(this.BoxNome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(238, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 0;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(405, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefone do Comprador";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(366, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data da Venda";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F);
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(26, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor Recebido";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // BoxValorPago
            // 
            this.BoxValorPago.Font = new System.Drawing.Font("Consolas", 11F);
            this.BoxValorPago.Location = new System.Drawing.Point(30, 210);
            this.BoxValorPago.Name = "BoxValorPago";
            this.BoxValorPago.Size = new System.Drawing.Size(176, 29);
            this.BoxValorPago.TabIndex = 6;
            this.BoxValorPago.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F);
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(26, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Observacoes";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(487, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de Pagamento";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // OpPix
            // 
            this.OpPix.AutoSize = true;
            this.OpPix.Font = new System.Drawing.Font("Consolas", 12F);
            this.OpPix.ForeColor = System.Drawing.Color.Purple;
            this.OpPix.Location = new System.Drawing.Point(3, 3);
            this.OpPix.Name = "OpPix";
            this.OpPix.Size = new System.Drawing.Size(64, 27);
            this.OpPix.TabIndex = 9;
            this.OpPix.Text = "Pix";
            this.OpPix.UseVisualStyleBackColor = true;
            // 
            // OpCartao
            // 
            this.OpCartao.AutoSize = true;
            this.OpCartao.Font = new System.Drawing.Font("Consolas", 12F);
            this.OpCartao.ForeColor = System.Drawing.Color.Purple;
            this.OpCartao.Location = new System.Drawing.Point(85, 3);
            this.OpCartao.Name = "OpCartao";
            this.OpCartao.Size = new System.Drawing.Size(97, 27);
            this.OpCartao.TabIndex = 10;
            this.OpCartao.Text = "Cartão";
            this.OpCartao.UseVisualStyleBackColor = true;
            // 
            // OpDinheiro
            // 
            this.OpDinheiro.AutoSize = true;
            this.OpDinheiro.Font = new System.Drawing.Font("Consolas", 12F);
            this.OpDinheiro.ForeColor = System.Drawing.Color.Purple;
            this.OpDinheiro.Location = new System.Drawing.Point(198, 3);
            this.OpDinheiro.Name = "OpDinheiro";
            this.OpDinheiro.Size = new System.Drawing.Size(119, 27);
            this.OpDinheiro.TabIndex = 11;
            this.OpDinheiro.Text = "Dinheiro";
            this.OpDinheiro.UseVisualStyleBackColor = true;
            // 
            // BoxTelefone
            // 
            this.BoxTelefone.BeepOnError = true;
            this.BoxTelefone.Font = new System.Drawing.Font("Consolas", 11F);
            this.BoxTelefone.Location = new System.Drawing.Point(409, 126);
            this.BoxTelefone.Mask = "(00) 00000-0000";
            this.BoxTelefone.Name = "BoxTelefone";
            this.BoxTelefone.Size = new System.Drawing.Size(224, 29);
            this.BoxTelefone.TabIndex = 2;
            // 
            // BoxData
            // 
            this.BoxData.BeepOnError = true;
            this.BoxData.Font = new System.Drawing.Font("Consolas", 11F);
            this.BoxData.Location = new System.Drawing.Point(370, 208);
            this.BoxData.Mask = "00/00/0000";
            this.BoxData.Name = "BoxData";
            this.BoxData.Size = new System.Drawing.Size(138, 29);
            this.BoxData.TabIndex = 3;
            this.BoxData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.BoxData_MaskInputRejected);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OpPix);
            this.panel1.Controls.Add(this.OpCartao);
            this.panel1.Controls.Add(this.OpDinheiro);
            this.panel1.Location = new System.Drawing.Point(448, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 36);
            this.panel1.TabIndex = 5;
            this.panel1.TabStop = true;
            // 
            // BoxProduto
            // 
            this.BoxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BoxProduto.Font = new System.Drawing.Font("Consolas", 11F);
            this.BoxProduto.FormattingEnabled = true;
            this.BoxProduto.Items.AddRange(new object[] {
            "Kit TPM",
            "Lenço umedecido",
            "Sabonete íntimo",
            "Absorvente externo",
            "Absorvente interno",
            "Calcinha menstrual",
            "Coletor menstrual",
            "Disco menstrual",
            "Bolsa térmica"});
            this.BoxProduto.Location = new System.Drawing.Point(30, 52);
            this.BoxProduto.Name = "BoxProduto";
            this.BoxProduto.Size = new System.Drawing.Size(287, 30);
            this.BoxProduto.TabIndex = 4;
            this.BoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.BackColor = System.Drawing.Color.MintCream;
            this.ButtonNovo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ButtonNovo.FlatAppearance.BorderSize = 3;
            this.ButtonNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.Font = new System.Drawing.Font("Consolas", 10F);
            this.ButtonNovo.ForeColor = System.Drawing.Color.Black;
            this.ButtonNovo.Location = new System.Drawing.Point(205, 514);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(148, 43);
            this.ButtonNovo.TabIndex = 7;
            this.ButtonNovo.TabStop = false;
            this.ButtonNovo.Text = "Novo";
            this.ButtonNovo.UseVisualStyleBackColor = false;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ButtonSalvar.FlatAppearance.BorderSize = 3;
            this.ButtonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Consolas", 10F);
            this.ButtonSalvar.ForeColor = System.Drawing.Color.Black;
            this.ButtonSalvar.Location = new System.Drawing.Point(594, 514);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(175, 43);
            this.ButtonSalvar.TabIndex = 7;
            this.ButtonSalvar.TabStop = false;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonFechar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ButtonFechar.FlatAppearance.BorderSize = 3;
            this.ButtonFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.ButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFechar.Font = new System.Drawing.Font("Consolas", 10F);
            this.ButtonFechar.ForeColor = System.Drawing.Color.Black;
            this.ButtonFechar.Location = new System.Drawing.Point(21, 514);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(148, 43);
            this.ButtonFechar.TabIndex = 7;
            this.ButtonFechar.TabStop = false;
            this.ButtonFechar.Text = "Fechar";
            this.ButtonFechar.UseVisualStyleBackColor = false;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F);
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(409, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código do Produto";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // BoxID
            // 
            this.BoxID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BoxID.Font = new System.Drawing.Font("Consolas", 11F);
            this.BoxID.Location = new System.Drawing.Point(437, 53);
            this.BoxID.Name = "BoxID";
            this.BoxID.ReadOnly = true;
            this.BoxID.Size = new System.Drawing.Size(147, 29);
            this.BoxID.TabIndex = 0;
            this.BoxID.TabStop = false;
            this.BoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxID.TextChanged += new System.EventHandler(this.BoxID_TextChanged);
            // 
            // BoxObs
            // 
            this.BoxObs.Font = new System.Drawing.Font("Consolas", 11F);
            this.BoxObs.Location = new System.Drawing.Point(30, 299);
            this.BoxObs.Multiline = true;
            this.BoxObs.Name = "BoxObs";
            this.BoxObs.Size = new System.Drawing.Size(384, 176);
            this.BoxObs.TabIndex = 5;
            this.BoxObs.TextChanged += new System.EventHandler(this.BoxServico_TextChanged);
            // 
            // FrmVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(817, 653);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.ButtonFechar);
            this.Controls.Add(this.ButtonNovo);
            this.Controls.Add(this.BoxProduto);
            this.Controls.Add(this.BoxData);
            this.Controls.Add(this.BoxTelefone);
            this.Controls.Add(this.BoxValorPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BoxID);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BoxObs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadCliente_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonFechar;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox BoxID;
        public System.Windows.Forms.TextBox BoxNome;
        public System.Windows.Forms.TextBox BoxValorPago;
        public System.Windows.Forms.RadioButton OpPix;
        public System.Windows.Forms.RadioButton OpCartao;
        public System.Windows.Forms.RadioButton OpDinheiro;
        public System.Windows.Forms.MaskedTextBox BoxTelefone;
        public System.Windows.Forms.MaskedTextBox BoxData;
        public System.Windows.Forms.ComboBox BoxProduto;
        public System.Windows.Forms.TextBox BoxObs;
    }
}

