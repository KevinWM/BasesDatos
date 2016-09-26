namespace PrograBases
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBContraseña = new System.Windows.Forms.Label();
            this.LBLabel = new System.Windows.Forms.Label();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.TBcontraseña = new System.Windows.Forms.TextBox();
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBContraseña
            // 
            this.LBContraseña.AutoSize = true;
            this.LBContraseña.Location = new System.Drawing.Point(55, 131);
            this.LBContraseña.Name = "LBContraseña";
            this.LBContraseña.Size = new System.Drawing.Size(64, 13);
            this.LBContraseña.TabIndex = 1;
            this.LBContraseña.Text = "Contraseña:";
            // 
            // LBLabel
            // 
            this.LBLabel.AutoSize = true;
            this.LBLabel.Location = new System.Drawing.Point(73, 97);
            this.LBLabel.Name = "LBLabel";
            this.LBLabel.Size = new System.Drawing.Size(46, 13);
            this.LBLabel.TabIndex = 2;
            this.LBLabel.Text = "Usuario:";
            // 
            // TBusuario
            // 
            this.TBusuario.Location = new System.Drawing.Point(140, 94);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(134, 20);
            this.TBusuario.TabIndex = 3;
            // 
            // TBcontraseña
            // 
            this.TBcontraseña.Location = new System.Drawing.Point(140, 131);
            this.TBcontraseña.Name = "TBcontraseña";
            this.TBcontraseña.PasswordChar = '*';
            this.TBcontraseña.Size = new System.Drawing.Size(134, 20);
            this.TBcontraseña.TabIndex = 4;
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.Location = new System.Drawing.Point(158, 206);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(101, 35);
            this.BTNIngresar.TabIndex = 5;
            this.BTNIngresar.Text = "Ingresar";
            this.BTNIngresar.UseVisualStyleBackColor = true;
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido Sistema de Ventas";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNIngresar);
            this.Controls.Add(this.TBcontraseña);
            this.Controls.Add(this.TBusuario);
            this.Controls.Add(this.LBLabel);
            this.Controls.Add(this.LBContraseña);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBContraseña;
        private System.Windows.Forms.Label LBLabel;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.TextBox TBcontraseña;
        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.Label label1;
    }
}

