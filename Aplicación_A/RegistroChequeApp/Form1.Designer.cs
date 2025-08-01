namespace RegistroChequeApp
{
    partial class Form1
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
            this.txtNumeroCheque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoLetra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCrearCarpetas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarCarpetas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroCheque
            // 
            this.txtNumeroCheque.Location = new System.Drawing.Point(28, 50);
            this.txtNumeroCheque.Name = "txtNumeroCheque";
            this.txtNumeroCheque.Size = new System.Drawing.Size(151, 22);
            this.txtNumeroCheque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de cheque";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(28, 111);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(200, 22);
            this.txtConcepto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Concepto de pago";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(28, 176);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(151, 22);
            this.txtCedula.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cédula";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(292, 50);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaPago.TabIndex = 6;
            this.dtpFechaPago.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de pago";
            // 
            // txtMontoNum
            // 
            this.txtMontoNum.Location = new System.Drawing.Point(28, 306);
            this.txtMontoNum.Name = "txtMontoNum";
            this.txtMontoNum.Size = new System.Drawing.Size(164, 22);
            this.txtMontoNum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monto (número)";
            // 
            // txtMontoLetra
            // 
            this.txtMontoLetra.Location = new System.Drawing.Point(28, 373);
            this.txtMontoLetra.Name = "txtMontoLetra";
            this.txtMontoLetra.Size = new System.Drawing.Size(225, 22);
            this.txtMontoLetra.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monto (letra)";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(28, 236);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(164, 22);
            this.txtFactura.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Factura pagada";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(517, 113);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(187, 57);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCrearCarpetas
            // 
            this.btnCrearCarpetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCarpetas.Location = new System.Drawing.Point(496, 191);
            this.btnCrearCarpetas.Name = "btnCrearCarpetas";
            this.btnCrearCarpetas.Size = new System.Drawing.Size(226, 57);
            this.btnCrearCarpetas.TabIndex = 15;
            this.btnCrearCarpetas.Text = "Crear Carpetas";
            this.btnCrearCarpetas.UseVisualStyleBackColor = true;
            this.btnCrearCarpetas.Click += new System.EventHandler(this.btnCrearCarpetas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(556, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 57);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarCarpetas
            // 
            this.btnBorrarCarpetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCarpetas.Location = new System.Drawing.Point(490, 271);
            this.btnBorrarCarpetas.Name = "btnBorrarCarpetas";
            this.btnBorrarCarpetas.Size = new System.Drawing.Size(237, 57);
            this.btnBorrarCarpetas.TabIndex = 17;
            this.btnBorrarCarpetas.Text = "Borrar Carpetas";
            this.btnBorrarCarpetas.UseVisualStyleBackColor = true;
            this.btnBorrarCarpetas.Click += new System.EventHandler(this.btnBorrarCarpetas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrarCarpetas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearCarpetas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoLetra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroCheque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroCheque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoLetra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCrearCarpetas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarCarpetas;
    }
}

