namespace PrograBases.ventanas
{
    partial class vendedor
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
            System.Windows.Forms.Label numFacturaLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label11;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Salir = new System.Windows.Forms.Button();
            this.BTNagregarCliente = new System.Windows.Forms.Button();
            this.HoraVendedordateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaVendedordateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BTNfinalizarVentaProducto = new System.Windows.Forms.Button();
            this.agregarFacturaPanel = new System.Windows.Forms.Panel();
            this.TXTNumFact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoxCedulaClente = new System.Windows.Forms.ComboBox();
            this.CBoxTipoFactura = new System.Windows.Forms.ComboBox();
            this.BTNabrirVentAdmin = new System.Windows.Forms.Button();
            this.BTNAgregarFactura = new System.Windows.Forms.Button();
            this.agregarProductoPanel = new System.Windows.Forms.Panel();
            this.NumCantidadProductoFactura = new System.Windows.Forms.NumericUpDown();
            this.BTNAgregarProductoFactura = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTStockProductoFactura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTPrecioProductoFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTNombreProductoFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxCodigoProductoFactura = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.ConsultarPorFamiliabutton = new System.Windows.Forms.Button();
            this.MostrarPorFamiliacomboBox = new System.Windows.Forms.ComboBox();
            this.MontrasProductoDatosdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ConsultarIDbutton = new System.Windows.Forms.Button();
            this.ConsultarNombrebutton = new System.Windows.Forms.Button();
            this.ConsultarNombretextBox = new System.Windows.Forms.TextBox();
            this.ConsultarIDcomboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saldoPagoFacturatextBox = new System.Windows.Forms.TextBox();
            this.saldoActualPagoFacturatextBox = new System.Windows.Forms.TextBox();
            this.BTNpagoFactura = new System.Windows.Forms.Button();
            this.numFacturaPagoFacturaComboBox = new System.Windows.Forms.ComboBox();
            this.montoPagoFacturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaPagoFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            numFacturaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.agregarFacturaPanel.SuspendLayout();
            this.agregarProductoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadProductoFactura)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MontrasProductoDatosdataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numFacturaLabel
            // 
            numFacturaLabel.AutoSize = true;
            numFacturaLabel.Location = new System.Drawing.Point(33, 72);
            numFacturaLabel.Name = "numFacturaLabel";
            numFacturaLabel.Size = new System.Drawing.Size(86, 13);
            numFacturaLabel.TabIndex = 2;
            numFacturaLabel.Text = "Numero Factura:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(79, 148);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(41, 13);
            montoLabel.TabIndex = 4;
            montoLabel.Text = "Abono:";
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(51, 174);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 6;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(49, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 13);
            label4.TabIndex = 9;
            label4.Text = "Saldo Actual:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(82, 198);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(37, 13);
            label11.TabIndex = 11;
            label11.Text = "Saldo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Salir);
            this.tabPage1.Controls.Add(this.BTNagregarCliente);
            this.tabPage1.Controls.Add(this.HoraVendedordateTimePicker);
            this.tabPage1.Controls.Add(this.FechaVendedordateTimePicker);
            this.tabPage1.Controls.Add(this.BTNfinalizarVentaProducto);
            this.tabPage1.Controls.Add(this.agregarFacturaPanel);
            this.tabPage1.Controls.Add(this.BTNabrirVentAdmin);
            this.tabPage1.Controls.Add(this.BTNAgregarFactura);
            this.tabPage1.Controls.Add(this.agregarProductoPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(395, 386);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(80, 36);
            this.Salir.TabIndex = 29;
            this.Salir.Text = "<-- Salir    ";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // BTNagregarCliente
            // 
            this.BTNagregarCliente.Location = new System.Drawing.Point(64, 312);
            this.BTNagregarCliente.Name = "BTNagregarCliente";
            this.BTNagregarCliente.Size = new System.Drawing.Size(108, 28);
            this.BTNagregarCliente.TabIndex = 28;
            this.BTNagregarCliente.Text = "Agregar Cliente";
            this.BTNagregarCliente.UseVisualStyleBackColor = true;
            this.BTNagregarCliente.Click += new System.EventHandler(this.BTNagregarCliente_Click);
            // 
            // HoraVendedordateTimePicker
            // 
            this.HoraVendedordateTimePicker.CustomFormat = "HH:mm:ss";
            this.HoraVendedordateTimePicker.Enabled = false;
            this.HoraVendedordateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraVendedordateTimePicker.Location = new System.Drawing.Point(22, 266);
            this.HoraVendedordateTimePicker.Name = "HoraVendedordateTimePicker";
            this.HoraVendedordateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HoraVendedordateTimePicker.TabIndex = 27;
            // 
            // FechaVendedordateTimePicker
            // 
            this.FechaVendedordateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.FechaVendedordateTimePicker.Enabled = false;
            this.FechaVendedordateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVendedordateTimePicker.Location = new System.Drawing.Point(22, 240);
            this.FechaVendedordateTimePicker.Name = "FechaVendedordateTimePicker";
            this.FechaVendedordateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaVendedordateTimePicker.TabIndex = 26;
            // 
            // BTNfinalizarVentaProducto
            // 
            this.BTNfinalizarVentaProducto.Location = new System.Drawing.Point(331, 312);
            this.BTNfinalizarVentaProducto.Name = "BTNfinalizarVentaProducto";
            this.BTNfinalizarVentaProducto.Size = new System.Drawing.Size(104, 37);
            this.BTNfinalizarVentaProducto.TabIndex = 23;
            this.BTNfinalizarVentaProducto.Text = "Finalizar Venta";
            this.BTNfinalizarVentaProducto.UseVisualStyleBackColor = true;
            this.BTNfinalizarVentaProducto.Click += new System.EventHandler(this.BTNfinalizarVentaProducto_Click);
            // 
            // agregarFacturaPanel
            // 
            this.agregarFacturaPanel.Controls.Add(this.TXTNumFact);
            this.agregarFacturaPanel.Controls.Add(this.label1);
            this.agregarFacturaPanel.Controls.Add(this.label2);
            this.agregarFacturaPanel.Controls.Add(this.label3);
            this.agregarFacturaPanel.Controls.Add(this.CBoxCedulaClente);
            this.agregarFacturaPanel.Controls.Add(this.CBoxTipoFactura);
            this.agregarFacturaPanel.Location = new System.Drawing.Point(22, 18);
            this.agregarFacturaPanel.Name = "agregarFacturaPanel";
            this.agregarFacturaPanel.Size = new System.Drawing.Size(208, 202);
            this.agregarFacturaPanel.TabIndex = 22;
            // 
            // TXTNumFact
            // 
            this.TXTNumFact.Location = new System.Drawing.Point(29, 51);
            this.TXTNumFact.Name = "TXTNumFact";
            this.TXTNumFact.Size = new System.Drawing.Size(129, 20);
            this.TXTNumFact.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumFactura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula de cliente";
            // 
            // CBoxCedulaClente
            // 
            this.CBoxCedulaClente.Enabled = false;
            this.CBoxCedulaClente.FormattingEnabled = true;
            this.CBoxCedulaClente.Location = new System.Drawing.Point(29, 157);
            this.CBoxCedulaClente.Name = "CBoxCedulaClente";
            this.CBoxCedulaClente.Size = new System.Drawing.Size(121, 21);
            this.CBoxCedulaClente.TabIndex = 5;
            // 
            // CBoxTipoFactura
            // 
            this.CBoxTipoFactura.FormattingEnabled = true;
            this.CBoxTipoFactura.Items.AddRange(new object[] {
            "Contado",
            "Crédito"});
            this.CBoxTipoFactura.Location = new System.Drawing.Point(29, 101);
            this.CBoxTipoFactura.Name = "CBoxTipoFactura";
            this.CBoxTipoFactura.Size = new System.Drawing.Size(121, 21);
            this.CBoxTipoFactura.TabIndex = 4;
            this.CBoxTipoFactura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTNabrirVentAdmin
            // 
            this.BTNabrirVentAdmin.Location = new System.Drawing.Point(485, 386);
            this.BTNabrirVentAdmin.Name = "BTNabrirVentAdmin";
            this.BTNabrirVentAdmin.Size = new System.Drawing.Size(100, 36);
            this.BTNabrirVentAdmin.TabIndex = 21;
            this.BTNabrirVentAdmin.Text = "--> Administrar";
            this.BTNabrirVentAdmin.UseVisualStyleBackColor = true;
            this.BTNabrirVentAdmin.Click += new System.EventHandler(this.BTNabrirVentAdmin_Click);
            // 
            // BTNAgregarFactura
            // 
            this.BTNAgregarFactura.Location = new System.Drawing.Point(30, 367);
            this.BTNAgregarFactura.Name = "BTNAgregarFactura";
            this.BTNAgregarFactura.Size = new System.Drawing.Size(174, 37);
            this.BTNAgregarFactura.TabIndex = 20;
            this.BTNAgregarFactura.Text = "Agregar Factura";
            this.BTNAgregarFactura.UseVisualStyleBackColor = true;
            this.BTNAgregarFactura.Click += new System.EventHandler(this.BTNAgregarFactura_Click);
            // 
            // agregarProductoPanel
            // 
            this.agregarProductoPanel.Controls.Add(this.NumCantidadProductoFactura);
            this.agregarProductoPanel.Controls.Add(this.BTNAgregarProductoFactura);
            this.agregarProductoPanel.Controls.Add(this.label10);
            this.agregarProductoPanel.Controls.Add(this.TXTStockProductoFactura);
            this.agregarProductoPanel.Controls.Add(this.label9);
            this.agregarProductoPanel.Controls.Add(this.TXTPrecioProductoFactura);
            this.agregarProductoPanel.Controls.Add(this.label8);
            this.agregarProductoPanel.Controls.Add(this.label7);
            this.agregarProductoPanel.Controls.Add(this.TXTNombreProductoFactura);
            this.agregarProductoPanel.Controls.Add(this.label5);
            this.agregarProductoPanel.Controls.Add(this.CBoxCodigoProductoFactura);
            this.agregarProductoPanel.Controls.Add(this.label6);
            this.agregarProductoPanel.Enabled = false;
            this.agregarProductoPanel.Location = new System.Drawing.Point(269, 18);
            this.agregarProductoPanel.Name = "agregarProductoPanel";
            this.agregarProductoPanel.Size = new System.Drawing.Size(315, 267);
            this.agregarProductoPanel.TabIndex = 11;
            // 
            // NumCantidadProductoFactura
            // 
            this.NumCantidadProductoFactura.Location = new System.Drawing.Point(162, 71);
            this.NumCantidadProductoFactura.Name = "NumCantidadProductoFactura";
            this.NumCantidadProductoFactura.Size = new System.Drawing.Size(44, 20);
            this.NumCantidadProductoFactura.TabIndex = 20;
            // 
            // BTNAgregarProductoFactura
            // 
            this.BTNAgregarProductoFactura.Location = new System.Drawing.Point(159, 115);
            this.BTNAgregarProductoFactura.Name = "BTNAgregarProductoFactura";
            this.BTNAgregarProductoFactura.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregarProductoFactura.TabIndex = 19;
            this.BTNAgregarProductoFactura.Text = "Agregar";
            this.BTNAgregarProductoFactura.UseVisualStyleBackColor = true;
            this.BTNAgregarProductoFactura.Click += new System.EventHandler(this.BTNAgregarProductoFactura_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cantidad";
            // 
            // TXTStockProductoFactura
            // 
            this.TXTStockProductoFactura.Location = new System.Drawing.Point(11, 222);
            this.TXTStockProductoFactura.Name = "TXTStockProductoFactura";
            this.TXTStockProductoFactura.Size = new System.Drawing.Size(104, 20);
            this.TXTStockProductoFactura.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Stock";
            // 
            // TXTPrecioProductoFactura
            // 
            this.TXTPrecioProductoFactura.Location = new System.Drawing.Point(11, 173);
            this.TXTPrecioProductoFactura.Name = "TXTPrecioProductoFactura";
            this.TXTPrecioProductoFactura.Size = new System.Drawing.Size(104, 20);
            this.TXTPrecioProductoFactura.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre";
            // 
            // TXTNombreProductoFactura
            // 
            this.TXTNombreProductoFactura.Location = new System.Drawing.Point(11, 118);
            this.TXTNombreProductoFactura.Name = "TXTNombreProductoFactura";
            this.TXTNombreProductoFactura.Size = new System.Drawing.Size(104, 20);
            this.TXTNombreProductoFactura.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Productos";
            // 
            // CBoxCodigoProductoFactura
            // 
            this.CBoxCodigoProductoFactura.FormattingEnabled = true;
            this.CBoxCodigoProductoFactura.Location = new System.Drawing.Point(12, 67);
            this.CBoxCodigoProductoFactura.Name = "CBoxCodigoProductoFactura";
            this.CBoxCodigoProductoFactura.Size = new System.Drawing.Size(103, 21);
            this.CBoxCodigoProductoFactura.TabIndex = 9;
            this.CBoxCodigoProductoFactura.SelectedIndexChanged += new System.EventHandler(this.CBoxCodigoProductoFactura_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.ConsultarPorFamiliabutton);
            this.tabPage2.Controls.Add(this.MostrarPorFamiliacomboBox);
            this.tabPage2.Controls.Add(this.MontrasProductoDatosdataGridView);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.ConsultarIDbutton);
            this.tabPage2.Controls.Add(this.ConsultarNombrebutton);
            this.tabPage2.Controls.Add(this.ConsultarNombretextBox);
            this.tabPage2.Controls.Add(this.ConsultarIDcomboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Familia Producto";
            // 
            // ConsultarPorFamiliabutton
            // 
            this.ConsultarPorFamiliabutton.Location = new System.Drawing.Point(391, 111);
            this.ConsultarPorFamiliabutton.Name = "ConsultarPorFamiliabutton";
            this.ConsultarPorFamiliabutton.Size = new System.Drawing.Size(75, 23);
            this.ConsultarPorFamiliabutton.TabIndex = 18;
            this.ConsultarPorFamiliabutton.Text = "Consultar";
            this.ConsultarPorFamiliabutton.UseVisualStyleBackColor = true;
            this.ConsultarPorFamiliabutton.Click += new System.EventHandler(this.ConsultarPorFamiliabutton_Click);
            // 
            // MostrarPorFamiliacomboBox
            // 
            this.MostrarPorFamiliacomboBox.FormattingEnabled = true;
            this.MostrarPorFamiliacomboBox.Items.AddRange(new object[] {
            "Frutas y verduras",
            "Refrescos",
            "Aceites, vinagres y sal",
            "Congelados",
            "Lácteos",
            "Embutidos envasados",
            "Snacks",
            "Canasta Basica",
            "Limpieza"});
            this.MostrarPorFamiliacomboBox.Location = new System.Drawing.Point(391, 68);
            this.MostrarPorFamiliacomboBox.Name = "MostrarPorFamiliacomboBox";
            this.MostrarPorFamiliacomboBox.Size = new System.Drawing.Size(121, 21);
            this.MostrarPorFamiliacomboBox.TabIndex = 17;
            // 
            // MontrasProductoDatosdataGridView
            // 
            this.MontrasProductoDatosdataGridView.AllowUserToAddRows = false;
            this.MontrasProductoDatosdataGridView.AllowUserToDeleteRows = false;
            this.MontrasProductoDatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MontrasProductoDatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.MontrasProductoDatosdataGridView.Location = new System.Drawing.Point(59, 185);
            this.MontrasProductoDatosdataGridView.Name = "MontrasProductoDatosdataGridView";
            this.MontrasProductoDatosdataGridView.ReadOnly = true;
            this.MontrasProductoDatosdataGridView.Size = new System.Drawing.Size(457, 184);
            this.MontrasProductoDatosdataGridView.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "ID Producto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nombre Producto";
            // 
            // ConsultarIDbutton
            // 
            this.ConsultarIDbutton.Location = new System.Drawing.Point(212, 111);
            this.ConsultarIDbutton.Name = "ConsultarIDbutton";
            this.ConsultarIDbutton.Size = new System.Drawing.Size(75, 23);
            this.ConsultarIDbutton.TabIndex = 13;
            this.ConsultarIDbutton.Text = "Consultar";
            this.ConsultarIDbutton.UseVisualStyleBackColor = true;
            this.ConsultarIDbutton.Click += new System.EventHandler(this.ConsultarIDbutton_Click);
            // 
            // ConsultarNombrebutton
            // 
            this.ConsultarNombrebutton.Location = new System.Drawing.Point(56, 111);
            this.ConsultarNombrebutton.Name = "ConsultarNombrebutton";
            this.ConsultarNombrebutton.Size = new System.Drawing.Size(75, 23);
            this.ConsultarNombrebutton.TabIndex = 12;
            this.ConsultarNombrebutton.Text = "Consultar";
            this.ConsultarNombrebutton.UseVisualStyleBackColor = true;
            this.ConsultarNombrebutton.Click += new System.EventHandler(this.ConsultarNombrebutton_Click);
            // 
            // ConsultarNombretextBox
            // 
            this.ConsultarNombretextBox.Location = new System.Drawing.Point(56, 69);
            this.ConsultarNombretextBox.Name = "ConsultarNombretextBox";
            this.ConsultarNombretextBox.Size = new System.Drawing.Size(100, 20);
            this.ConsultarNombretextBox.TabIndex = 11;
            // 
            // ConsultarIDcomboBox
            // 
            this.ConsultarIDcomboBox.FormattingEnabled = true;
            this.ConsultarIDcomboBox.Location = new System.Drawing.Point(209, 69);
            this.ConsultarIDcomboBox.Name = "ConsultarIDcomboBox";
            this.ConsultarIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ConsultarIDcomboBox.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(label11);
            this.tabPage3.Controls.Add(this.saldoPagoFacturatextBox);
            this.tabPage3.Controls.Add(label4);
            this.tabPage3.Controls.Add(this.saldoActualPagoFacturatextBox);
            this.tabPage3.Controls.Add(this.BTNpagoFactura);
            this.tabPage3.Controls.Add(numFacturaLabel);
            this.tabPage3.Controls.Add(this.numFacturaPagoFacturaComboBox);
            this.tabPage3.Controls.Add(montoLabel);
            this.tabPage3.Controls.Add(this.montoPagoFacturaTextBox);
            this.tabPage3.Controls.Add(fechaPagoLabel);
            this.tabPage3.Controls.Add(this.fechaPagoFacturaDateTimePicker);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(591, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagos de Facturas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // saldoPagoFacturatextBox
            // 
            this.saldoPagoFacturatextBox.Location = new System.Drawing.Point(125, 195);
            this.saldoPagoFacturatextBox.Name = "saldoPagoFacturatextBox";
            this.saldoPagoFacturatextBox.Size = new System.Drawing.Size(200, 20);
            this.saldoPagoFacturatextBox.TabIndex = 12;
            // 
            // saldoActualPagoFacturatextBox
            // 
            this.saldoActualPagoFacturatextBox.Location = new System.Drawing.Point(125, 96);
            this.saldoActualPagoFacturatextBox.Name = "saldoActualPagoFacturatextBox";
            this.saldoActualPagoFacturatextBox.Size = new System.Drawing.Size(200, 20);
            this.saldoActualPagoFacturatextBox.TabIndex = 10;
            // 
            // BTNpagoFactura
            // 
            this.BTNpagoFactura.Location = new System.Drawing.Point(238, 276);
            this.BTNpagoFactura.Name = "BTNpagoFactura";
            this.BTNpagoFactura.Size = new System.Drawing.Size(113, 32);
            this.BTNpagoFactura.TabIndex = 8;
            this.BTNpagoFactura.Text = "Realizar Pago";
            this.BTNpagoFactura.UseVisualStyleBackColor = true;
            this.BTNpagoFactura.Click += new System.EventHandler(this.BTNpagoFactura_Click);
            // 
            // numFacturaPagoFacturaComboBox
            // 
            this.numFacturaPagoFacturaComboBox.FormattingEnabled = true;
            this.numFacturaPagoFacturaComboBox.Location = new System.Drawing.Point(125, 69);
            this.numFacturaPagoFacturaComboBox.Name = "numFacturaPagoFacturaComboBox";
            this.numFacturaPagoFacturaComboBox.Size = new System.Drawing.Size(200, 21);
            this.numFacturaPagoFacturaComboBox.TabIndex = 3;
            this.numFacturaPagoFacturaComboBox.SelectedIndexChanged += new System.EventHandler(this.numFacturaPagoFacturaComboBox_SelectedIndexChanged);
            // 
            // montoPagoFacturaTextBox
            // 
            this.montoPagoFacturaTextBox.Location = new System.Drawing.Point(125, 143);
            this.montoPagoFacturaTextBox.Name = "montoPagoFacturaTextBox";
            this.montoPagoFacturaTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoPagoFacturaTextBox.TabIndex = 5;
            // 
            // fechaPagoFacturaDateTimePicker
            // 
            this.fechaPagoFacturaDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.fechaPagoFacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaPagoFacturaDateTimePicker.Location = new System.Drawing.Point(125, 169);
            this.fechaPagoFacturaDateTimePicker.Name = "fechaPagoFacturaDateTimePicker";
            this.fechaPagoFacturaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaPagoFacturaDateTimePicker.TabIndex = 7;
            // 
            // vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "vendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.vendedor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.agregarFacturaPanel.ResumeLayout(false);
            this.agregarFacturaPanel.PerformLayout();
            this.agregarProductoPanel.ResumeLayout(false);
            this.agregarProductoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadProductoFactura)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MontrasProductoDatosdataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel agregarProductoPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTNombreProductoFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxCodigoProductoFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxCedulaClente;
        private System.Windows.Forms.ComboBox CBoxTipoFactura;
        private System.Windows.Forms.TextBox TXTNumFact;
        private System.Windows.Forms.TextBox TXTStockProductoFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTPrecioProductoFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTNAgregarFactura;
        private System.Windows.Forms.NumericUpDown NumCantidadProductoFactura;
        private System.Windows.Forms.Button BTNAgregarProductoFactura;
        private System.Windows.Forms.Button BTNabrirVentAdmin;
        private System.Windows.Forms.Panel agregarFacturaPanel;
        private System.Windows.Forms.Button BTNfinalizarVentaProducto;
        private System.Windows.Forms.Button BTNpagoFactura;
        private System.Windows.Forms.ComboBox numFacturaPagoFacturaComboBox;
        private System.Windows.Forms.TextBox montoPagoFacturaTextBox;
        private System.Windows.Forms.DateTimePicker fechaPagoFacturaDateTimePicker;
        private System.Windows.Forms.TextBox saldoActualPagoFacturatextBox;
        private System.Windows.Forms.TextBox saldoPagoFacturatextBox;
        private System.Windows.Forms.DateTimePicker HoraVendedordateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaVendedordateTimePicker;
        private System.Windows.Forms.Button BTNagregarCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ConsultarPorFamiliabutton;
        private System.Windows.Forms.ComboBox MostrarPorFamiliacomboBox;
        private System.Windows.Forms.DataGridView MontrasProductoDatosdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ConsultarIDbutton;
        private System.Windows.Forms.Button ConsultarNombrebutton;
        private System.Windows.Forms.TextBox ConsultarNombretextBox;
        private System.Windows.Forms.ComboBox ConsultarIDcomboBox;
        private System.Windows.Forms.Button Salir;
    }
}