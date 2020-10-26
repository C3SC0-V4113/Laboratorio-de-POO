namespace Ejercicio_2
{
    partial class frm_ejercicio2
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
            this.lbl_titutlo = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.listbx_valores = new System.Windows.Forms.ListBox();
            this.grbox_arreglos = new System.Windows.Forms.GroupBox();
            this.lbl_Mneg = new System.Windows.Forms.Label();
            this.txt_Mneg = new System.Windows.Forms.TextBox();
            this.btn_Mneg = new System.Windows.Forms.Button();
            this.lbl_zeros = new System.Windows.Forms.Label();
            this.txt_zeros = new System.Windows.Forms.TextBox();
            this.btn_zeros = new System.Windows.Forms.Button();
            this.lbl_proneg = new System.Windows.Forms.Label();
            this.txt_proneg = new System.Windows.Forms.TextBox();
            this.btn_proneg = new System.Windows.Forms.Button();
            this.lbl_Mpp = new System.Windows.Forms.Label();
            this.txt_Mpp = new System.Windows.Forms.TextBox();
            this.btn_Mpp = new System.Windows.Forms.Button();
            this.grbox_arreglos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titutlo
            // 
            this.lbl_titutlo.AutoSize = true;
            this.lbl_titutlo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titutlo.Location = new System.Drawing.Point(12, 26);
            this.lbl_titutlo.Name = "lbl_titutlo";
            this.lbl_titutlo.Size = new System.Drawing.Size(185, 18);
            this.lbl_titutlo.TabIndex = 0;
            this.lbl_titutlo.Text = "Ingrese un valor al arreglo";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(203, 27);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(149, 20);
            this.txt_n1.TabIndex = 1;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(368, 18);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(91, 37);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // listbx_valores
            // 
            this.listbx_valores.FormattingEnabled = true;
            this.listbx_valores.Location = new System.Drawing.Point(15, 66);
            this.listbx_valores.Name = "listbx_valores";
            this.listbx_valores.Size = new System.Drawing.Size(182, 264);
            this.listbx_valores.TabIndex = 3;
            // 
            // grbox_arreglos
            // 
            this.grbox_arreglos.Controls.Add(this.btn_Mpp);
            this.grbox_arreglos.Controls.Add(this.txt_Mpp);
            this.grbox_arreglos.Controls.Add(this.lbl_Mpp);
            this.grbox_arreglos.Controls.Add(this.btn_proneg);
            this.grbox_arreglos.Controls.Add(this.txt_proneg);
            this.grbox_arreglos.Controls.Add(this.lbl_proneg);
            this.grbox_arreglos.Controls.Add(this.btn_zeros);
            this.grbox_arreglos.Controls.Add(this.txt_zeros);
            this.grbox_arreglos.Controls.Add(this.lbl_zeros);
            this.grbox_arreglos.Controls.Add(this.btn_Mneg);
            this.grbox_arreglos.Controls.Add(this.txt_Mneg);
            this.grbox_arreglos.Controls.Add(this.lbl_Mneg);
            this.grbox_arreglos.Location = new System.Drawing.Point(260, 66);
            this.grbox_arreglos.Name = "grbox_arreglos";
            this.grbox_arreglos.Size = new System.Drawing.Size(423, 264);
            this.grbox_arreglos.TabIndex = 4;
            this.grbox_arreglos.TabStop = false;
            this.grbox_arreglos.Text = "OPERACIONES CON ARREGLOS";
            // 
            // lbl_Mneg
            // 
            this.lbl_Mneg.AutoSize = true;
            this.lbl_Mneg.Location = new System.Drawing.Point(7, 34);
            this.lbl_Mneg.Name = "lbl_Mneg";
            this.lbl_Mneg.Size = new System.Drawing.Size(168, 13);
            this.lbl_Mneg.TabIndex = 0;
            this.lbl_Mneg.Text = "Número mayor de pares negativos";
            // 
            // txt_Mneg
            // 
            this.txt_Mneg.Location = new System.Drawing.Point(181, 31);
            this.txt_Mneg.Name = "txt_Mneg";
            this.txt_Mneg.ReadOnly = true;
            this.txt_Mneg.Size = new System.Drawing.Size(100, 20);
            this.txt_Mneg.TabIndex = 1;
            // 
            // btn_Mneg
            // 
            this.btn_Mneg.Location = new System.Drawing.Point(318, 31);
            this.btn_Mneg.Name = "btn_Mneg";
            this.btn_Mneg.Size = new System.Drawing.Size(75, 23);
            this.btn_Mneg.TabIndex = 2;
            this.btn_Mneg.Text = "MOSTRAR";
            this.btn_Mneg.UseVisualStyleBackColor = true;
            this.btn_Mneg.Click += new System.EventHandler(this.btn_Mneg_Click);
            // 
            // lbl_zeros
            // 
            this.lbl_zeros.AutoSize = true;
            this.lbl_zeros.Location = new System.Drawing.Point(10, 87);
            this.lbl_zeros.Name = "lbl_zeros";
            this.lbl_zeros.Size = new System.Drawing.Size(163, 13);
            this.lbl_zeros.TabIndex = 3;
            this.lbl_zeros.Text = "Porcentaje de ceros en el arreglo";
            // 
            // txt_zeros
            // 
            this.txt_zeros.Location = new System.Drawing.Point(181, 87);
            this.txt_zeros.Name = "txt_zeros";
            this.txt_zeros.ReadOnly = true;
            this.txt_zeros.Size = new System.Drawing.Size(100, 20);
            this.txt_zeros.TabIndex = 4;
            // 
            // btn_zeros
            // 
            this.btn_zeros.Location = new System.Drawing.Point(318, 87);
            this.btn_zeros.Name = "btn_zeros";
            this.btn_zeros.Size = new System.Drawing.Size(75, 23);
            this.btn_zeros.TabIndex = 5;
            this.btn_zeros.Text = "MOSTRAR";
            this.btn_zeros.UseVisualStyleBackColor = true;
            this.btn_zeros.Click += new System.EventHandler(this.btn_zeros_Click);
            // 
            // lbl_proneg
            // 
            this.lbl_proneg.AutoSize = true;
            this.lbl_proneg.Location = new System.Drawing.Point(13, 144);
            this.lbl_proneg.Name = "lbl_proneg";
            this.lbl_proneg.Size = new System.Drawing.Size(154, 13);
            this.lbl_proneg.TabIndex = 6;
            this.lbl_proneg.Text = "Promedio de impares negativos";
            // 
            // txt_proneg
            // 
            this.txt_proneg.Location = new System.Drawing.Point(181, 141);
            this.txt_proneg.Name = "txt_proneg";
            this.txt_proneg.ReadOnly = true;
            this.txt_proneg.Size = new System.Drawing.Size(100, 20);
            this.txt_proneg.TabIndex = 7;
            // 
            // btn_proneg
            // 
            this.btn_proneg.Location = new System.Drawing.Point(318, 138);
            this.btn_proneg.Name = "btn_proneg";
            this.btn_proneg.Size = new System.Drawing.Size(75, 23);
            this.btn_proneg.TabIndex = 8;
            this.btn_proneg.Text = "MOSTRAR";
            this.btn_proneg.UseVisualStyleBackColor = true;
            this.btn_proneg.Click += new System.EventHandler(this.btn_proneg_Click);
            // 
            // lbl_Mpp
            // 
            this.lbl_Mpp.AutoSize = true;
            this.lbl_Mpp.Location = new System.Drawing.Point(16, 215);
            this.lbl_Mpp.Name = "lbl_Mpp";
            this.lbl_Mpp.Size = new System.Drawing.Size(140, 13);
            this.lbl_Mpp.TabIndex = 9;
            this.lbl_Mpp.Text = "Mayor de los pares positivos";
            // 
            // txt_Mpp
            // 
            this.txt_Mpp.Location = new System.Drawing.Point(181, 208);
            this.txt_Mpp.Name = "txt_Mpp";
            this.txt_Mpp.ReadOnly = true;
            this.txt_Mpp.Size = new System.Drawing.Size(100, 20);
            this.txt_Mpp.TabIndex = 10;
            // 
            // btn_Mpp
            // 
            this.btn_Mpp.Location = new System.Drawing.Point(318, 208);
            this.btn_Mpp.Name = "btn_Mpp";
            this.btn_Mpp.Size = new System.Drawing.Size(75, 23);
            this.btn_Mpp.TabIndex = 11;
            this.btn_Mpp.Text = "MOSTRAR";
            this.btn_Mpp.UseVisualStyleBackColor = true;
            this.btn_Mpp.Click += new System.EventHandler(this.btn_Mpp_Click);
            // 
            // frm_ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 356);
            this.Controls.Add(this.grbox_arreglos);
            this.Controls.Add(this.listbx_valores);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_titutlo);
            this.Name = "frm_ejercicio2";
            this.Text = "Ejercicio 2";
            this.grbox_arreglos.ResumeLayout(false);
            this.grbox_arreglos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titutlo;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.ListBox listbx_valores;
        private System.Windows.Forms.GroupBox grbox_arreglos;
        private System.Windows.Forms.Button btn_Mpp;
        private System.Windows.Forms.TextBox txt_Mpp;
        private System.Windows.Forms.Label lbl_Mpp;
        private System.Windows.Forms.Button btn_proneg;
        private System.Windows.Forms.TextBox txt_proneg;
        private System.Windows.Forms.Label lbl_proneg;
        private System.Windows.Forms.Button btn_zeros;
        private System.Windows.Forms.TextBox txt_zeros;
        private System.Windows.Forms.Label lbl_zeros;
        private System.Windows.Forms.Button btn_Mneg;
        private System.Windows.Forms.TextBox txt_Mneg;
        private System.Windows.Forms.Label lbl_Mneg;
    }
}

