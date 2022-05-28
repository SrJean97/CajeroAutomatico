namespace CajeroAutomatico
{
    partial class FOperacionesCuenta
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMostrarSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.txtPuntosCanjear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuntosDisponibles = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtSaldoRetirar = new System.Windows.Forms.TextBox();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtValorEnviar = new System.Windows.Forms.TextBox();
            this.txtNumeroCuentaEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnConsultar.Location = new System.Drawing.Point(612, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 28);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Ir";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMostrarSaldo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(828, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Saldo";
            // 
            // txtMostrarSaldo
            // 
            this.txtMostrarSaldo.Location = new System.Drawing.Point(19, 28);
            this.txtMostrarSaldo.Name = "txtMostrarSaldo";
            this.txtMostrarSaldo.Size = new System.Drawing.Size(145, 29);
            this.txtMostrarSaldo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese numero  de cuenta";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(320, 38);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(260, 23);
            this.txtNumeroCuenta.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCanjear);
            this.groupBox2.Controls.Add(this.txtPuntosCanjear);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPuntosDisponibles);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 221);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canjear Puntos";
            // 
            // btnCanjear
            // 
            this.btnCanjear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCanjear.Location = new System.Drawing.Point(95, 175);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(91, 32);
            this.btnCanjear.TabIndex = 4;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = false;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // txtPuntosCanjear
            // 
            this.txtPuntosCanjear.Location = new System.Drawing.Point(156, 115);
            this.txtPuntosCanjear.Name = "txtPuntosCanjear";
            this.txtPuntosCanjear.Size = new System.Drawing.Size(115, 29);
            this.txtPuntosCanjear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puntos a Canjear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntos Totales";
            // 
            // txtPuntosDisponibles
            // 
            this.txtPuntosDisponibles.Location = new System.Drawing.Point(156, 37);
            this.txtPuntosDisponibles.Name = "txtPuntosDisponibles";
            this.txtPuntosDisponibles.Size = new System.Drawing.Size(115, 29);
            this.txtPuntosDisponibles.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRetirar);
            this.groupBox3.Controls.Add(this.txtSaldoRetirar);
            this.groupBox3.Controls.Add(this.txtSaldoActual);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(420, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 219);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retirar Saldo";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRetirar.Location = new System.Drawing.Point(121, 175);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(91, 32);
            this.btnRetirar.TabIndex = 5;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtSaldoRetirar
            // 
            this.txtSaldoRetirar.Location = new System.Drawing.Point(157, 113);
            this.txtSaldoRetirar.Name = "txtSaldoRetirar";
            this.txtSaldoRetirar.Size = new System.Drawing.Size(150, 29);
            this.txtSaldoRetirar.TabIndex = 3;
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Location = new System.Drawing.Point(157, 43);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(150, 29);
            this.txtSaldoActual.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saldo a Retirar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saldo Actual";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtValorEnviar);
            this.groupBox4.Controls.Add(this.txtNumeroCuentaEnviar);
            this.groupBox4.Controls.Add(this.btnEnviar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(777, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 208);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transferir Saldo";
            // 
            // txtValorEnviar
            // 
            this.txtValorEnviar.Location = new System.Drawing.Point(140, 105);
            this.txtValorEnviar.Name = "txtValorEnviar";
            this.txtValorEnviar.Size = new System.Drawing.Size(153, 29);
            this.txtValorEnviar.TabIndex = 8;
            // 
            // txtNumeroCuentaEnviar
            // 
            this.txtNumeroCuentaEnviar.Location = new System.Drawing.Point(140, 47);
            this.txtNumeroCuentaEnviar.Name = "txtNumeroCuentaEnviar";
            this.txtNumeroCuentaEnviar.Size = new System.Drawing.Size(153, 29);
            this.txtNumeroCuentaEnviar.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEnviar.Location = new System.Drawing.Point(112, 162);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(91, 32);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "#Cuenta";
            // 
            // FOperacionesCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 623);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FOperacionesCuenta";
            this.Text = "Operaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMostrarSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuntosDisponibles;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.TextBox txtPuntosCanjear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtSaldoRetirar;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtValorEnviar;
        private System.Windows.Forms.TextBox txtNumeroCuentaEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}