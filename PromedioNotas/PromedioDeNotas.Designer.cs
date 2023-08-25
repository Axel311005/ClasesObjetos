namespace PromedioNotas
{
    partial class PromedioDeNotas
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPromedio = new TextBox();
            txtNotaBaja = new TextBox();
            txtCondicion = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 31);
            label1.Name = "label1";
            label1.Size = new Size(564, 45);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE PROMEDIO DE NOTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(47, 115);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 1;
            label2.Text = "ESTUDIANTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(735, 115);
            label3.Name = "label3";
            label3.Size = new Size(237, 32);
            label3.TabIndex = 2;
            label3.Text = "REGISTRO DE NOTAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(584, 175);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 3;
            label4.Text = "NOTA1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(702, 175);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 4;
            label5.Text = "NOTA2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Silver;
            label6.Location = new Point(824, 175);
            label6.Name = "label6";
            label6.Size = new Size(88, 32);
            label6.TabIndex = 5;
            label6.Text = "NOTA3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Silver;
            label7.Location = new Point(940, 175);
            label7.Name = "label7";
            label7.Size = new Size(88, 32);
            label7.TabIndex = 6;
            label7.Text = "NOTA4";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(47, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(501, 39);
            txtNombre.TabIndex = 7;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(584, 252);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(101, 39);
            txtNota1.TabIndex = 8;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(702, 252);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(91, 39);
            txtNota2.TabIndex = 9;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(824, 252);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(89, 39);
            txtNota3.TabIndex = 10;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(940, 252);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(93, 39);
            txtNota4.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DodgerBlue;
            btnCalcular.ForeColor = SystemColors.Control;
            btnCalcular.Location = new Point(46, 248);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DodgerBlue;
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(229, 248);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 363);
            label8.Name = "label8";
            label8.Size = new Size(251, 32);
            label8.TabIndex = 14;
            label8.Text = "PROMEDIO DE NOTAS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 449);
            label9.Name = "label9";
            label9.Size = new Size(192, 32);
            label9.TabIndex = 15;
            label9.Text = "NOTA MAS BAJA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 526);
            label10.Name = "label10";
            label10.Size = new Size(144, 32);
            label10.TabIndex = 16;
            label10.Text = "CONDICIÓN";
            // 
            // txtPromedio
            // 
            txtPromedio.Enabled = false;
            txtPromedio.Location = new Point(321, 363);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(200, 39);
            txtPromedio.TabIndex = 17;
            // 
            // txtNotaBaja
            // 
            txtNotaBaja.Enabled = false;
            txtNotaBaja.Location = new Point(321, 446);
            txtNotaBaja.Name = "txtNotaBaja";
            txtNotaBaja.Size = new Size(200, 39);
            txtNotaBaja.TabIndex = 18;
            // 
            // txtCondicion
            // 
            txtCondicion.Enabled = false;
            txtCondicion.Location = new Point(321, 523);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(200, 39);
            txtCondicion.TabIndex = 19;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(883, 583);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 46);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // PromedioDeNotas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1071, 654);
            Controls.Add(btnSalir);
            Controls.Add(txtCondicion);
            Controls.Add(txtNotaBaja);
            Controls.Add(txtPromedio);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PromedioDeNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PromedioDeNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtPromedio;
        private TextBox txtNotaBaja;
        private TextBox txtCondicion;
        private Button btnSalir;
    }
}