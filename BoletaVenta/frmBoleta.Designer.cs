namespace BoletaVenta
{
    partial class frmBoleta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNumero = new Label();
            txtCliente = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtFecha = new TextBox();
            label8 = new Label();
            txtCedula = new TextBox();
            dhsh = new GroupBox();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cboProducto = new ComboBox();
            label9 = new Label();
            lvEstadisticas = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnRegistrar = new Button();
            label12 = new Label();
            label13 = new Label();
            lblTotal = new Label();
            lvDetalle = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnSalir = new Button();
            dhsh.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(402, 65);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(389, 51);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(977, 26);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 1;
            label2.Text = "RUC 51004402";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(957, 80);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(240, 36);
            label3.TabIndex = 2;
            label3.Text = "BOLETA DE VENTA";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(957, 135);
            lblNumero.Margin = new Padding(6, 0, 6, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(79, 32);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "00000";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(155, 229);
            txtCliente.Margin = new Padding(6, 6, 6, 6);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(466, 39);
            txtCliente.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 235);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 5;
            label5.Text = "CLIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 327);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 32);
            label6.TabIndex = 6;
            label6.Text = "DIRECCION";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(155, 327);
            txtDireccion.Margin = new Padding(6, 6, 6, 6);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(466, 39);
            txtDireccion.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(716, 235);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 32);
            label7.TabIndex = 8;
            label7.Text = "FECHA";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(820, 229);
            txtFecha.Margin = new Padding(6, 6, 6, 6);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(420, 39);
            txtFecha.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(716, 327);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 32);
            label8.TabIndex = 10;
            label8.Text = "CEDULA";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(820, 310);
            txtCedula.Margin = new Padding(6, 6, 6, 6);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(420, 39);
            txtCedula.TabIndex = 11;
            // 
            // dhsh
            // 
            dhsh.BackColor = Color.MistyRose;
            dhsh.Controls.Add(btnAgregar);
            dhsh.Controls.Add(txtCantidad);
            dhsh.Controls.Add(txtPrecio);
            dhsh.Controls.Add(label11);
            dhsh.Controls.Add(label10);
            dhsh.Controls.Add(cboProducto);
            dhsh.Controls.Add(label9);
            dhsh.Location = new Point(20, 408);
            dhsh.Margin = new Padding(6, 6, 6, 6);
            dhsh.Name = "dhsh";
            dhsh.Padding = new Padding(6, 6, 6, 6);
            dhsh.Size = new Size(1346, 250);
            dhsh.TabIndex = 12;
            dhsh.TabStop = false;
            dhsh.Text = "DATOS DEL PRODUCTO";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Crimson;
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(1051, 130);
            btnAgregar.Margin = new Padding(6, 6, 6, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 49);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(747, 130);
            txtCantidad.Margin = new Padding(6, 6, 6, 6);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(182, 39);
            txtCantidad.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(446, 132);
            txtPrecio.Margin = new Padding(6, 6, 6, 6);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(182, 39);
            txtPrecio.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(773, 60);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(129, 32);
            label11.TabIndex = 3;
            label11.Text = "CANTIDAD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(488, 60);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 32);
            label10.TabIndex = 2;
            label10.Text = "PRECIO";
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "PS5 + 1 MANDO DS5", "PS4(1TB) + 1 MANDO DS4", "MANDO PS5/ DS5", "MANDO PS4/ DS4" });
            cboProducto.Location = new Point(41, 132);
            cboProducto.Margin = new Padding(6, 6, 6, 6);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(221, 40);
            cboProducto.TabIndex = 1;
            cboProducto.Text = "(SELECCIONE)";
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 60);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(161, 32);
            label9.TabIndex = 0;
            label9.Text = "DESCRIPCION";
            // 
            // lvEstadisticas
            // 
            lvEstadisticas.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvEstadisticas.GridLines = true;
            lvEstadisticas.Location = new Point(15, 1066);
            lvEstadisticas.Margin = new Padding(6, 6, 6, 6);
            lvEstadisticas.Name = "lvEstadisticas";
            lvEstadisticas.Size = new Size(1347, 199);
            lvEstadisticas.TabIndex = 14;
            lvEstadisticas.UseCompatibleStateImageBehavior = false;
            lvEstadisticas.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "NUM.BOLETA";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "FECHA";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TOTAL PRODUCTOS";
            columnHeader7.Width = 240;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "MONTO TOTAL";
            columnHeader8.Width = 240;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Crimson;
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(18, 948);
            btnRegistrar.Margin = new Padding(6, 6, 6, 6);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(234, 60);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "REGISTRAR BOLETA";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 1025);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(358, 32);
            label12.TabIndex = 16;
            label12.Text = "RESUMEN REGISTRO DE BOLETA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(957, 978);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(80, 32);
            label13.TabIndex = 17;
            label13.Text = "TOTAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(1087, 978);
            lblTotal.Margin = new Padding(6, 0, 6, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(128, 45);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "label14";
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvDetalle.GridLines = true;
            lvDetalle.Location = new Point(20, 679);
            lvDetalle.Margin = new Padding(6, 6, 6, 6);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(1343, 262);
            lvDetalle.TabIndex = 19;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CANTIDAD";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "DESCRIPCION";
            columnHeader2.Width = 360;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PREC.UNI";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "IMPORTE";
            columnHeader4.Width = 120;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(19, 1310);
            btnSalir.Margin = new Padding(6, 6, 6, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 46);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmBoleta
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1401, 1399);
            Controls.Add(btnSalir);
            Controls.Add(lvDetalle);
            Controls.Add(lblTotal);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnRegistrar);
            Controls.Add(lvEstadisticas);
            Controls.Add(dhsh);
            Controls.Add(txtCedula);
            Controls.Add(label8);
            Controls.Add(txtFecha);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCliente);
            Controls.Add(lblNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmBoleta";
            Text = "Contol de venta";
            Load += frmBoleta_Load;
            dhsh.ResumeLayout(false);
            dhsh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNumero;
        private TextBox txtCliente;
        private Label label5;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtFecha;
        private Label label8;
        private TextBox txtCedula;
        private GroupBox dhsh;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Label label11;
        private Label label10;
        private ComboBox cboProducto;
        private Label label9;
        private ListView lvEstadisticas;
        private Button btnRegistrar;
        private Label label12;
        private Label label13;
        private Label lblTotal;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView lvDetalle;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnSalir;
    }
}