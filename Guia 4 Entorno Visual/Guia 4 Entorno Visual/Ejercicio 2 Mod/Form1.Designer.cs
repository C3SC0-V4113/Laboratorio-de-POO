namespace Ejercicio_2_Mod
{
    partial class frm_ej2mod
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.listbx_arreglo = new System.Windows.Forms.ListBox();
            this.grpbox_operaciones = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n4 = new System.Windows.Forms.TextBox();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.grpbox_operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(30, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(220, 16);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "INGRESE UN VALOR AL ARREGLO";
            // 
            // txt_no
            // 
            this.txt_no.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_no.Location = new System.Drawing.Point(256, 13);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(100, 22);
            this.txt_no.TabIndex = 1;
            this.txt_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_KeyPress_1);
            // 
            // listbx_arreglo
            // 
            this.listbx_arreglo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listbx_arreglo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbx_arreglo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listbx_arreglo.FormattingEnabled = true;
            this.listbx_arreglo.ItemHeight = 16;
            this.listbx_arreglo.Location = new System.Drawing.Point(33, 55);
            this.listbx_arreglo.Name = "listbx_arreglo";
            this.listbx_arreglo.Size = new System.Drawing.Size(181, 244);
            this.listbx_arreglo.TabIndex = 2;
            // 
            // grpbox_operaciones
            // 
            this.grpbox_operaciones.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.grpbox_operaciones.Controls.Add(this.btn_clean);
            this.grpbox_operaciones.Controls.Add(this.btn_update);
            this.grpbox_operaciones.Controls.Add(this.lbl_n4);
            this.grpbox_operaciones.Controls.Add(this.lbl_n3);
            this.grpbox_operaciones.Controls.Add(this.lbl_n2);
            this.grpbox_operaciones.Controls.Add(this.lbl_n1);
            this.grpbox_operaciones.Controls.Add(this.txt_n4);
            this.grpbox_operaciones.Controls.Add(this.txt_n3);
            this.grpbox_operaciones.Controls.Add(this.txt_n2);
            this.grpbox_operaciones.Controls.Add(this.txt_n1);
            this.grpbox_operaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_operaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpbox_operaciones.Location = new System.Drawing.Point(260, 55);
            this.grpbox_operaciones.Name = "grpbox_operaciones";
            this.grpbox_operaciones.Size = new System.Drawing.Size(387, 251);
            this.grpbox_operaciones.TabIndex = 3;
            this.grpbox_operaciones.TabStop = false;
            this.grpbox_operaciones.Text = "OPERACIONES CON ARREGLOS";
            // 
            // btn_clean
            // 
            this.btn_clean.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_clean.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clean.Location = new System.Drawing.Point(136, 215);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(105, 29);
            this.btn_clean.TabIndex = 8;
            this.btn_clean.Text = "BORRAR";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(267, 215);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 29);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "ACTUALIZAR";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_n4.Location = new System.Drawing.Point(21, 173);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(173, 16);
            this.lbl_n4.TabIndex = 7;
            this.lbl_n4.Text = "Mayor de los pares positivos";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_n3.Location = new System.Drawing.Point(21, 122);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(189, 16);
            this.lbl_n3.TabIndex = 6;
            this.lbl_n3.Text = "Promedio de impares negativos";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_n2.Location = new System.Drawing.Point(12, 70);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(199, 16);
            this.lbl_n2.TabIndex = 5;
            this.lbl_n2.Text = "Porcentaje de ceros en el arreglo";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_n1.Location = new System.Drawing.Point(7, 22);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(205, 16);
            this.lbl_n1.TabIndex = 4;
            this.lbl_n1.Text = "Número mayor de pares negativos";
            // 
            // txt_n4
            // 
            this.txt_n4.Location = new System.Drawing.Point(232, 170);
            this.txt_n4.Name = "txt_n4";
            this.txt_n4.ReadOnly = true;
            this.txt_n4.Size = new System.Drawing.Size(140, 22);
            this.txt_n4.TabIndex = 3;
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(232, 119);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.ReadOnly = true;
            this.txt_n3.Size = new System.Drawing.Size(140, 22);
            this.txt_n3.TabIndex = 2;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(232, 67);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.ReadOnly = true;
            this.txt_n2.Size = new System.Drawing.Size(140, 22);
            this.txt_n2.TabIndex = 1;
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(232, 19);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.ReadOnly = true;
            this.txt_n1.Size = new System.Drawing.Size(140, 22);
            this.txt_n1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(527, 314);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(105, 29);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_ej2mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(694, 355);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.grpbox_operaciones);
            this.Controls.Add(this.listbx_arreglo);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_ej2mod";
            this.Text = "Ejercicio 2 modificado";
            this.grpbox_operaciones.ResumeLayout(false);
            this.grpbox_operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.ListBox listbx_arreglo;
        private System.Windows.Forms.GroupBox grpbox_operaciones;
        private System.Windows.Forms.TextBox txt_n4;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clean;
    }
}

