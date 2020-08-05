namespace EjercicioCondicionales2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.gbresumenpago = new System.Windows.Forms.GroupBox();
            this.lblsalarioapagar = new System.Windows.Forms.Label();
            this.lblincremento = new System.Windows.Forms.Label();
            this.lblpagosalud = new System.Windows.Forms.Label();
            this.lblsalariobase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlimpiarcampos = new System.Windows.Forms.Button();
            this.gbresumenpago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de salario empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(36, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa las horas trabajadas del empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(36, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el valor de la hora trabajada:";
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txthorastrabajadas.Location = new System.Drawing.Point(465, 122);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(163, 53);
            this.txthorastrabajadas.TabIndex = 3;
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtvalorhora.Location = new System.Drawing.Point(465, 181);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(285, 53);
            this.txtvalorhora.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btncalcular.Location = new System.Drawing.Point(465, 250);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(119, 47);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // gbresumenpago
            // 
            this.gbresumenpago.Controls.Add(this.lblsalarioapagar);
            this.gbresumenpago.Controls.Add(this.lblincremento);
            this.gbresumenpago.Controls.Add(this.lblpagosalud);
            this.gbresumenpago.Controls.Add(this.lblsalariobase);
            this.gbresumenpago.Controls.Add(this.label7);
            this.gbresumenpago.Controls.Add(this.label4);
            this.gbresumenpago.Controls.Add(this.label6);
            this.gbresumenpago.Controls.Add(this.label5);
            this.gbresumenpago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbresumenpago.Location = new System.Drawing.Point(41, 330);
            this.gbresumenpago.Name = "gbresumenpago";
            this.gbresumenpago.Size = new System.Drawing.Size(709, 154);
            this.gbresumenpago.TabIndex = 6;
            this.gbresumenpago.TabStop = false;
            this.gbresumenpago.Text = "Resumen de pago";
            this.gbresumenpago.Visible = false;
            // 
            // lblsalarioapagar
            // 
            this.lblsalarioapagar.AutoSize = true;
            this.lblsalarioapagar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalarioapagar.Location = new System.Drawing.Point(510, 112);
            this.lblsalarioapagar.Name = "lblsalarioapagar";
            this.lblsalarioapagar.Size = new System.Drawing.Size(88, 27);
            this.lblsalarioapagar.TabIndex = 14;
            this.lblsalarioapagar.Text = "label11";
            // 
            // lblincremento
            // 
            this.lblincremento.AutoSize = true;
            this.lblincremento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincremento.Location = new System.Drawing.Point(160, 112);
            this.lblincremento.Name = "lblincremento";
            this.lblincremento.Size = new System.Drawing.Size(90, 27);
            this.lblincremento.TabIndex = 13;
            this.lblincremento.Text = "label10";
            // 
            // lblpagosalud
            // 
            this.lblpagosalud.AutoSize = true;
            this.lblpagosalud.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagosalud.Location = new System.Drawing.Point(160, 75);
            this.lblpagosalud.Name = "lblpagosalud";
            this.lblpagosalud.Size = new System.Drawing.Size(77, 27);
            this.lblpagosalud.TabIndex = 12;
            this.lblpagosalud.Text = "label9";
            // 
            // lblsalariobase
            // 
            this.lblsalariobase.AutoSize = true;
            this.lblsalariobase.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalariobase.Location = new System.Drawing.Point(160, 38);
            this.lblsalariobase.Name = "lblsalariobase";
            this.lblsalariobase.Size = new System.Drawing.Size(77, 27);
            this.lblsalariobase.TabIndex = 11;
            this.lblsalariobase.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salario a pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario base:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Incremento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pago salud:";
            // 
            // btnlimpiarcampos
            // 
            this.btnlimpiarcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcampos.Location = new System.Drawing.Point(631, 250);
            this.btnlimpiarcampos.Name = "btnlimpiarcampos";
            this.btnlimpiarcampos.Size = new System.Drawing.Size(119, 74);
            this.btnlimpiarcampos.TabIndex = 7;
            this.btnlimpiarcampos.Text = "Limpiar campos";
            this.btnlimpiarcampos.UseVisualStyleBackColor = true;
            this.btnlimpiarcampos.Click += new System.EventHandler(this.btnlimpiarcampos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnlimpiarcampos);
            this.Controls.Add(this.gbresumenpago);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de Salarios";
            this.gbresumenpago.ResumeLayout(false);
            this.gbresumenpago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.GroupBox gbresumenpago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblsalarioapagar;
        private System.Windows.Forms.Label lblincremento;
        private System.Windows.Forms.Label lblpagosalud;
        private System.Windows.Forms.Label lblsalariobase;
        private System.Windows.Forms.Button btnlimpiarcampos;
    }
}

