namespace C__Cadastro_Clientes
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonAdicionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PesqProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PesqNome = new System.Windows.Forms.TextBox();
            this.PesqCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BoxTotalValor = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BoxTotalProdutos = new System.Windows.Forms.TextBox();
            this.PesqData1 = new System.Windows.Forms.MaskedTextBox();
            this.PesqData2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonCalcular = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ButtonAdicionar);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Produto";
            // 
            // ButtonAdicionar
            // 
            this.ButtonAdicionar.FlatAppearance.BorderSize = 0;
            this.ButtonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdicionar.Image")));
            this.ButtonAdicionar.Location = new System.Drawing.Point(87, 17);
            this.ButtonAdicionar.Name = "ButtonAdicionar";
            this.ButtonAdicionar.Size = new System.Drawing.Size(65, 62);
            this.ButtonAdicionar.TabIndex = 1;
            this.ButtonAdicionar.UseVisualStyleBackColor = true;
            this.ButtonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ButtonEditar);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(220, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 84);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.FlatAppearance.BorderSize = 0;
            this.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEditar.Image")));
            this.ButtonEditar.Location = new System.Drawing.Point(27, 25);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(57, 54);
            this.ButtonEditar.TabIndex = 1;
            this.ButtonEditar.UseVisualStyleBackColor = true;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.AllowUserToAddRows = false;
            this.dgListaClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            this.dgListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgListaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.produto,
            this.dia,
            this.nome,
            this.telefone,
            this.valor_pago,
            this.tipo_pagamento});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaClientes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgListaClientes.EnableHeadersVisualStyles = false;
            this.dgListaClientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgListaClientes.Location = new System.Drawing.Point(74, 133);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.ReadOnly = true;
            this.dgListaClientes.RowHeadersVisible = false;
            this.dgListaClientes.RowHeadersWidth = 4;
            this.dgListaClientes.RowTemplate.Height = 30;
            this.dgListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaClientes.Size = new System.Drawing.Size(1134, 472);
            this.dgListaClientes.TabIndex = 1;
            this.dgListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaClientes_CellClick);
            this.dgListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaClientes_CellContentClick);
            this.dgListaClientes.Sorted += new System.EventHandler(this.dgListaClientes_Sorted);
            // 
            // id_produto
            // 
            this.id_produto.DataPropertyName = "id_produto";
            this.id_produto.Frozen = true;
            this.id_produto.HeaderText = "Código";
            this.id_produto.MinimumWidth = 6;
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 125;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "produto";
            this.produto.HeaderText = "Produto";
            this.produto.MinimumWidth = 6;
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 116;
            // 
            // dia
            // 
            this.dia.DataPropertyName = "dia";
            this.dia.HeaderText = "Data";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Width = 125;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 160;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 6;
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 170;
            // 
            // valor_pago
            // 
            this.valor_pago.DataPropertyName = "valor_pago";
            this.valor_pago.HeaderText = "Valor Pago";
            this.valor_pago.MinimumWidth = 6;
            this.valor_pago.Name = "valor_pago";
            this.valor_pago.ReadOnly = true;
            this.valor_pago.Width = 210;
            // 
            // tipo_pagamento
            // 
            this.tipo_pagamento.DataPropertyName = "tipo_pagamento";
            this.tipo_pagamento.HeaderText = "Tipo de Pagamento";
            this.tipo_pagamento.MinimumWidth = 6;
            this.tipo_pagamento.Name = "tipo_pagamento";
            this.tipo_pagamento.ReadOnly = true;
            this.tipo_pagamento.Width = 250;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.PesqProduto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.PesqNome);
            this.groupBox4.Controls.Add(this.PesqCod);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox4.Location = new System.Drawing.Point(720, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 84);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // PesqProduto
            // 
            this.PesqProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PesqProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PesqProduto.Font = new System.Drawing.Font("Consolas", 11F);
            this.PesqProduto.FormattingEnabled = true;
            this.PesqProduto.Items.AddRange(new object[] {
            "Kit TPM",
            "Lenço umedecido",
            "Sabonete íntimo",
            "Absorvente externo",
            "",
            "",
            "Absorvente interno",
            "Calcinha menstrual",
            "",
            "",
            "Coletor menstrual",
            "Disco menstrual",
            "Bolsa térmica"});
            this.PesqProduto.Location = new System.Drawing.Point(111, 49);
            this.PesqProduto.Name = "PesqProduto";
            this.PesqProduto.Size = new System.Drawing.Size(280, 30);
            this.PesqProduto.TabIndex = 28;
            this.PesqProduto.SelectedIndexChanged += new System.EventHandler(this.PesqProduto_SelectedIndexChanged);
            this.PesqProduto.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(107, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Produto";
            // 
            // PesqNome
            // 
            this.PesqNome.Font = new System.Drawing.Font("Consolas", 11F);
            this.PesqNome.ForeColor = System.Drawing.Color.SteelBlue;
            this.PesqNome.Location = new System.Drawing.Point(415, 50);
            this.PesqNome.Name = "PesqNome";
            this.PesqNome.Size = new System.Drawing.Size(210, 29);
            this.PesqNome.TabIndex = 15;
            this.PesqNome.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // PesqCod
            // 
            this.PesqCod.Font = new System.Drawing.Font("Consolas", 11F);
            this.PesqCod.ForeColor = System.Drawing.Color.SteelBlue;
            this.PesqCod.Location = new System.Drawing.Point(16, 49);
            this.PesqCod.Name = "PesqCod";
            this.PesqCod.Size = new System.Drawing.Size(72, 29);
            this.PesqCod.TabIndex = 15;
            this.PesqCod.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(411, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome do Comprador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Deletar tudo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 11F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(53, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 62);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox8.Location = new System.Drawing.Point(364, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(170, 84);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Salvar Backup";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(373, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 138);
            this.label4.TabIndex = 31;
            this.label4.Text = "                 \r\n\r\n  \r\n\r\n\r\n\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(321, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 115);
            this.label5.TabIndex = 31;
            this.label5.Text = "         \r\n\r\n\r\n\r\n\r\n";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F);
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(195, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Data Final";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.BoxTotalValor);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox5.Location = new System.Drawing.Point(828, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 84);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Valor Recebido";
            // 
            // BoxTotalValor
            // 
            this.BoxTotalValor.Location = new System.Drawing.Point(59, 32);
            this.BoxTotalValor.Name = "BoxTotalValor";
            this.BoxTotalValor.Size = new System.Drawing.Size(95, 31);
            this.BoxTotalValor.TabIndex = 32;
            this.BoxTotalValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.BoxTotalProdutos);
            this.groupBox6.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox6.Location = new System.Drawing.Point(523, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 84);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Produtos Vendidos";
            // 
            // BoxTotalProdutos
            // 
            this.BoxTotalProdutos.Location = new System.Drawing.Point(82, 32);
            this.BoxTotalProdutos.Name = "BoxTotalProdutos";
            this.BoxTotalProdutos.Size = new System.Drawing.Size(119, 31);
            this.BoxTotalProdutos.TabIndex = 32;
            this.BoxTotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxTotalProdutos.TextChanged += new System.EventHandler(this.BoxTotalMao_TextChanged);
            // 
            // PesqData1
            // 
            this.PesqData1.BeepOnError = true;
            this.PesqData1.Font = new System.Drawing.Font("Consolas", 11F);
            this.PesqData1.Location = new System.Drawing.Point(39, 65);
            this.PesqData1.Mask = "00/00/0000";
            this.PesqData1.Name = "PesqData1";
            this.PesqData1.Size = new System.Drawing.Size(113, 29);
            this.PesqData1.TabIndex = 4;
            // 
            // PesqData2
            // 
            this.PesqData2.BeepOnError = true;
            this.PesqData2.Font = new System.Drawing.Font("Consolas", 11F);
            this.PesqData2.Location = new System.Drawing.Point(199, 65);
            this.PesqData2.Mask = "00/00/0000";
            this.PesqData2.Name = "PesqData2";
            this.PesqData2.Size = new System.Drawing.Size(113, 29);
            this.PesqData2.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(25, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data Inicial";
            // 
            // ButtonCalcular
            // 
            this.ButtonCalcular.BackColor = System.Drawing.Color.Salmon;
            this.ButtonCalcular.Font = new System.Drawing.Font("Consolas", 11F);
            this.ButtonCalcular.ForeColor = System.Drawing.Color.Black;
            this.ButtonCalcular.Location = new System.Drawing.Point(345, 40);
            this.ButtonCalcular.Name = "ButtonCalcular";
            this.ButtonCalcular.Size = new System.Drawing.Size(121, 67);
            this.ButtonCalcular.TabIndex = 5;
            this.ButtonCalcular.Text = "Calcular";
            this.ButtonCalcular.UseVisualStyleBackColor = false;
            this.ButtonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.ButtonCalcular);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.PesqData2);
            this.groupBox9.Controls.Add(this.PesqData1);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox9.Location = new System.Drawing.Point(21, 611);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1197, 130);
            this.groupBox9.TabIndex = 33;
            this.groupBox9.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(32, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "R$ ";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1403, 761);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgListaClientes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox9);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonAdicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonEditar;
        public System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox PesqCod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox PesqNome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox PesqProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox BoxTotalValor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox BoxTotalProdutos;
        public System.Windows.Forms.MaskedTextBox PesqData1;
        public System.Windows.Forms.MaskedTextBox PesqData2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonCalcular;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pagamento;
        private System.Windows.Forms.Label label8;
    }
}