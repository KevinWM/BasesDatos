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
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label numFacturaLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BTNpagoFactura = new System.Windows.Forms.Button();
            this.numeroPagoFacturaTextBox = new System.Windows.Forms.TextBox();
            this.numFacturaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.montoPagoFacturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaPagoFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            numeroLabel = new System.Windows.Forms.Label();
            numFacturaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.agregarFacturaPanel.SuspendLayout();
            this.agregarProductoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadProductoFactura)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
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
            // BTNfinalizarVentaProducto
            // 
            this.BTNfinalizarVentaProducto.Location = new System.Drawing.Point(269, 337);
            this.BTNfinalizarVentaProducto.Name = "BTNfinalizarVentaProducto";
            this.BTNfinalizarVentaProducto.Size = new System.Drawing.Size(104, 37);
            this.BTNfinalizarVentaProducto.TabIndex = 23;
            this.BTNfinalizarVentaProducto.Text = "Finalizar Venta";
            this.BTNfinalizarVentaProducto.UseVisualStyleBackColor = true;
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
            this.agregarFacturaPanel.Size = new System.Drawing.Size(208, 267);
            this.agregarFacturaPanel.TabIndex = 22;
            // 
            // TXTNumFact
            // 
            this.TXTNumFact.Location = new System.Drawing.Point(26, 67);
            this.TXTNumFact.Name = "TXTNumFact";
            this.TXTNumFact.Size = new System.Drawing.Size(129, 20);
            this.TXTNumFact.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumFactura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula de cliente";
            // 
            // CBoxCedulaClente
            // 
            this.CBoxCedulaClente.Enabled = false;
            this.CBoxCedulaClente.FormattingEnabled = true;
            this.CBoxCedulaClente.Location = new System.Drawing.Point(26, 173);
            this.CBoxCedulaClente.Name = "CBoxCedulaClente";
            this.CBoxCedulaClente.Size = new System.Drawing.Size(121, 21);
            this.CBoxCedulaClente.TabIndex = 5;
            // 
            // CBoxTipoFactura
            // 
            this.CBoxTipoFactura.FormattingEnabled = true;
            this.CBoxTipoFactura.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.CBoxTipoFactura.Location = new System.Drawing.Point(26, 117);
            this.CBoxTipoFactura.Name = "CBoxTipoFactura";
            this.CBoxTipoFactura.Size = new System.Drawing.Size(121, 21);
            this.CBoxTipoFactura.TabIndex = 4;
            this.CBoxTipoFactura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTNabrirVentAdmin
            // 
            this.BTNabrirVentAdmin.Location = new System.Drawing.Point(445, 338);
            this.BTNabrirVentAdmin.Name = "BTNabrirVentAdmin";
            this.BTNabrirVentAdmin.Size = new System.Drawing.Size(100, 36);
            this.BTNabrirVentAdmin.TabIndex = 21;
            this.BTNabrirVentAdmin.Text = "--> Administrar";
            this.BTNabrirVentAdmin.UseVisualStyleBackColor = true;
            // 
            // BTNAgregarFactura
            // 
            this.BTNAgregarFactura.Location = new System.Drawing.Point(22, 337);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(numeroLabel);
            this.tabPage3.Controls.Add(this.numeroPagoFacturaTextBox);
            this.tabPage3.Controls.Add(numFacturaLabel);
            this.tabPage3.Controls.Add(this.numFacturaPagoComboBox);
            this.tabPage3.Controls.Add(montoLabel);
            this.tabPage3.Controls.Add(this.montoPagoFacturaTextBox);
            this.tabPage3.Controls.Add(fechaPagoLabel);
            this.tabPage3.Controls.Add(this.fechaPagoFacturaDateTimePicker);
            this.tabPage3.Controls.Add(this.BTNpagoFactura);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(591, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagos de facturas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BTNpagoFactura
            // 
            this.BTNpagoFactura.Location = new System.Drawing.Point(220, 307);
            this.BTNpagoFactura.Name = "BTNpagoFactura";
            this.BTNpagoFactura.Size = new System.Drawing.Size(125, 40);
            this.BTNpagoFactura.TabIndex = 12;
            this.BTNpagoFactura.Text = "Realizar Pago";
            this.BTNpagoFactura.UseVisualStyleBackColor = true;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(60, 140);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(75, 13);
            numeroLabel.TabIndex = 12;
            numeroLabel.Text = "Numero Pago:";
            // 
            // numeroPagoFacturaTextBox
            // 
            this.numeroPagoFacturaTextBox.Location = new System.Drawing.Point(145, 137);
            this.numeroPagoFacturaTextBox.Name = "numeroPagoFacturaTextBox";
            this.numeroPagoFacturaTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroPagoFacturaTextBox.TabIndex = 13;
            // 
            // numFacturaLabel
            // 
            numFacturaLabel.AutoSize = true;
            numFacturaLabel.Location = new System.Drawing.Point(49, 166);
            numFacturaLabel.Name = "numFacturaLabel";
            numFacturaLabel.Size = new System.Drawing.Size(86, 13);
            numFacturaLabel.TabIndex = 14;
            numFacturaLabel.Text = "Numero Factura:";
            // 
            // numFacturaPagoComboBox
            // 
            this.numFacturaPagoComboBox.FormattingEnabled = true;
            this.numFacturaPagoComboBox.Location = new System.Drawing.Point(145, 163);
            this.numFacturaPagoComboBox.Name = "numFacturaPagoComboBox";
            this.numFacturaPagoComboBox.Size = new System.Drawing.Size(200, 21);
            this.numFacturaPagoComboBox.TabIndex = 15;
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(95, 193);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 16;
            montoLabel.Text = "Monto:";
            // 
            // montoPagoFacturaTextBox
            // 
            this.montoPagoFacturaTextBox.Location = new System.Drawing.Point(145, 190);
            this.montoPagoFacturaTextBox.Name = "montoPagoFacturaTextBox";
            this.montoPagoFacturaTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoPagoFacturaTextBox.TabIndex = 17;
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(67, 219);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 18;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // fechaPagoFacturaDateTimePicker
            // 
            this.fechaPagoFacturaDateTimePicker.Location = new System.Drawing.Point(145, 216);
            this.fechaPagoFacturaDateTimePicker.Name = "fechaPagoFacturaDateTimePicker";
            this.fechaPagoFacturaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaPagoFacturaDateTimePicker.TabIndex = 19;
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
        private System.Windows.Forms.TextBox numeroPagoFacturaTextBox;
        private System.Windows.Forms.ComboBox numFacturaPagoComboBox;
        private System.Windows.Forms.TextBox montoPagoFacturaTextBox;
        private System.Windows.Forms.DateTimePicker fechaPagoFacturaDateTimePicker;
    }
}