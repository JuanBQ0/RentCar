namespace Presentacion
{
    partial class FrmAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlquiler));
            this.TextCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextTipoid = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PlacaTxt = new System.Windows.Forms.TextBox();
            this.BtnBuscarPlaca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KilometrajeActualTxt = new System.Windows.Forms.TextBox();
            this.Dtp1 = new System.Windows.Forms.DateTimePicker();
            this.Dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.KmRecepcionTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ValorTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescuentoTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextCedula
            // 
            this.TextCedula.Location = new System.Drawing.Point(209, 54);
            this.TextCedula.Margin = new System.Windows.Forms.Padding(2);
            this.TextCedula.Name = "TextCedula";
            this.TextCedula.Size = new System.Drawing.Size(85, 20);
            this.TextCedula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(153, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(153, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // TextNombre
            // 
            this.TextNombre.Enabled = false;
            this.TextNombre.Location = new System.Drawing.Point(239, 93);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(129, 20);
            this.TextNombre.TabIndex = 7;
            // 
            // TextTipoid
            // 
            this.TextTipoid.Enabled = false;
            this.TextTipoid.Location = new System.Drawing.Point(239, 118);
            this.TextTipoid.Margin = new System.Windows.Forms.Padding(2);
            this.TextTipoid.Name = "TextTipoid";
            this.TextTipoid.Size = new System.Drawing.Size(129, 20);
            this.TextTipoid.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(298, 52);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(29, 23);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Placa:";
            // 
            // PlacaTxt
            // 
            this.PlacaTxt.Location = new System.Drawing.Point(599, 55);
            this.PlacaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PlacaTxt.Name = "PlacaTxt";
            this.PlacaTxt.Size = new System.Drawing.Size(85, 20);
            this.PlacaTxt.TabIndex = 15;
            // 
            // BtnBuscarPlaca
            // 
            this.BtnBuscarPlaca.BackColor = System.Drawing.Color.White;
            this.BtnBuscarPlaca.FlatAppearance.BorderSize = 0;
            this.BtnBuscarPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPlaca.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarPlaca.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarPlaca.Image")));
            this.BtnBuscarPlaca.Location = new System.Drawing.Point(688, 52);
            this.BtnBuscarPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarPlaca.Name = "BtnBuscarPlaca";
            this.BtnBuscarPlaca.Size = new System.Drawing.Size(29, 23);
            this.BtnBuscarPlaca.TabIndex = 16;
            this.BtnBuscarPlaca.UseVisualStyleBackColor = false;
            this.BtnBuscarPlaca.Click += new System.EventHandler(this.BtnBuscarPlaca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(595, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(522, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "KilometrajeActual:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(655, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 19;
            // 
            // KilometrajeActualTxt
            // 
            this.KilometrajeActualTxt.Enabled = false;
            this.KilometrajeActualTxt.Location = new System.Drawing.Point(655, 117);
            this.KilometrajeActualTxt.Margin = new System.Windows.Forms.Padding(2);
            this.KilometrajeActualTxt.Name = "KilometrajeActualTxt";
            this.KilometrajeActualTxt.Size = new System.Drawing.Size(68, 20);
            this.KilometrajeActualTxt.TabIndex = 20;
            // 
            // Dtp1
            // 
            this.Dtp1.Location = new System.Drawing.Point(265, 203);
            this.Dtp1.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp1.Name = "Dtp1";
            this.Dtp1.Size = new System.Drawing.Size(135, 20);
            this.Dtp1.TabIndex = 21;
            this.Dtp1.ValueChanged += new System.EventHandler(this.Dtp1_ValueChanged);
            // 
            // Dtp2
            // 
            this.Dtp2.Location = new System.Drawing.Point(274, 241);
            this.Dtp2.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp2.Name = "Dtp2";
            this.Dtp2.Size = new System.Drawing.Size(135, 20);
            this.Dtp2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha Entrega";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha Recepcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(523, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "KmRecepcion";
            // 
            // KmRecepcionTxt
            // 
            this.KmRecepcionTxt.Location = new System.Drawing.Point(623, 187);
            this.KmRecepcionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.KmRecepcionTxt.Name = "KmRecepcionTxt";
            this.KmRecepcionTxt.Size = new System.Drawing.Size(88, 20);
            this.KmRecepcionTxt.TabIndex = 26;
            this.KmRecepcionTxt.TextChanged += new System.EventHandler(this.KmRecepcionTxt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(553, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "ValorKm";
            // 
            // ValorTxt
            // 
            this.ValorTxt.Location = new System.Drawing.Point(623, 216);
            this.ValorTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ValorTxt.Name = "ValorTxt";
            this.ValorTxt.Size = new System.Drawing.Size(88, 20);
            this.ValorTxt.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(542, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Descuento";
            // 
            // DescuentoTxt
            // 
            this.DescuentoTxt.Location = new System.Drawing.Point(623, 243);
            this.DescuentoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DescuentoTxt.Name = "DescuentoTxt";
            this.DescuentoTxt.Size = new System.Drawing.Size(88, 20);
            this.DescuentoTxt.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(576, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Total";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(623, 278);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 20);
            this.textBox6.TabIndex = 32;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(606, 314);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 25);
            this.BtnGuardar.TabIndex = 33;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(916, 517);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DescuentoTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ValorTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.KmRecepcionTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dtp2);
            this.Controls.Add(this.Dtp1);
            this.Controls.Add(this.KilometrajeActualTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnBuscarPlaca);
            this.Controls.Add(this.PlacaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TextTipoid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextCedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmAlquiler";
            this.Text = "FrmAlquiler";
            this.Load += new System.EventHandler(this.FrmAlquiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextTipoid;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlacaTxt;
        private System.Windows.Forms.Button BtnBuscarPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox KilometrajeActualTxt;
        private System.Windows.Forms.DateTimePicker Dtp1;
        private System.Windows.Forms.DateTimePicker Dtp2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox KmRecepcionTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ValorTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescuentoTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button BtnGuardar;
    }
}