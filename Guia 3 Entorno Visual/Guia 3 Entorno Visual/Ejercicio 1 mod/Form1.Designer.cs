namespace Ejercicio_1
{
    partial class frm_ej1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_salario4 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.rbtn_ger = new System.Windows.Forms.RadioButton();
            this.rbtn_sub = new System.Windows.Forms.RadioButton();
            this.rbtn_secre = new System.Windows.Forms.RadioButton();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(282, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(139, 24);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "EJERCICIO 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 59);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // lbl_salario4
            // 
            this.lbl_salario4.AutoSize = true;
            this.lbl_salario4.Location = new System.Drawing.Point(356, 59);
            this.lbl_salario4.Name = "lbl_salario4";
            this.lbl_salario4.Size = new System.Drawing.Size(39, 13);
            this.lbl_salario4.TabIndex = 3;
            this.lbl_salario4.Text = "Salario";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(402, 59);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(137, 20);
            this.txt_salario.TabIndex = 4;
            // 
            // rbtn_ger
            // 
            this.rbtn_ger.AutoSize = true;
            this.rbtn_ger.Location = new System.Drawing.Point(37, 131);
            this.rbtn_ger.Name = "rbtn_ger";
            this.rbtn_ger.Size = new System.Drawing.Size(63, 17);
            this.rbtn_ger.TabIndex = 5;
            this.rbtn_ger.TabStop = true;
            this.rbtn_ger.Text = "Gerente";
            this.rbtn_ger.UseVisualStyleBackColor = true;
            // 
            // rbtn_sub
            // 
            this.rbtn_sub.AutoSize = true;
            this.rbtn_sub.Location = new System.Drawing.Point(244, 131);
            this.rbtn_sub.Name = "rbtn_sub";
            this.rbtn_sub.Size = new System.Drawing.Size(85, 17);
            this.rbtn_sub.TabIndex = 6;
            this.rbtn_sub.TabStop = true;
            this.rbtn_sub.Text = "Sub-Gerente";
            this.rbtn_sub.UseVisualStyleBackColor = true;
            // 
            // rbtn_secre
            // 
            this.rbtn_secre.AutoSize = true;
            this.rbtn_secre.Location = new System.Drawing.Point(436, 131);
            this.rbtn_secre.Name = "rbtn_secre";
            this.rbtn_secre.Size = new System.Drawing.Size(73, 17);
            this.rbtn_secre.TabIndex = 7;
            this.rbtn_secre.TabStop = true;
            this.rbtn_secre.Text = "Secretaria";
            this.rbtn_secre.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(286, 248);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(286, 219);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 9;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_ej1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 321);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.rbtn_secre);
            this.Controls.Add(this.rbtn_sub);
            this.Controls.Add(this.rbtn_ger);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_salario4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_ej1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_salario4;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.RadioButton rbtn_ger;
        private System.Windows.Forms.RadioButton rbtn_sub;
        private System.Windows.Forms.RadioButton rbtn_secre;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

