namespace Ejemplo_3
{
    partial class frm_ejemplo3
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_try = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(316, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(156, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "DIVISIÓN DE DOS NÚMEROS";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(44, 83);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(55, 13);
            this.lbl_n1.TabIndex = 1;
            this.lbl_n1.Text = "Dividendo";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(47, 172);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(39, 13);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = "Divisor";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(47, 241);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "Resultado";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(171, 83);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 4;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(171, 164);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 5;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(171, 241);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 6;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(397, 138);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 31);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "CALCULAR";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_try
            // 
            this.lbl_try.Location = new System.Drawing.Point(397, 175);
            this.lbl_try.Name = "lbl_try";
            this.lbl_try.Size = new System.Drawing.Size(101, 31);
            this.lbl_try.TabIndex = 8;
            this.lbl_try.Text = "REINTENTAR";
            this.lbl_try.UseVisualStyleBackColor = true;
            this.lbl_try.Click += new System.EventHandler(this.lbl_try_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(688, 407);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 31);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_ejemplo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_try);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_ejemplo3";
            this.Text = "Ejemplo 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button lbl_try;
        private System.Windows.Forms.Button btn_exit;
    }
}

