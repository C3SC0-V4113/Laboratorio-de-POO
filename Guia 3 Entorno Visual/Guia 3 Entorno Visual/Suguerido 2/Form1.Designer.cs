namespace Suguerido_2
{
    partial class frm_sugue2
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
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.txt_r1 = new System.Windows.Forms.TextBox();
            this.lbl_x2 = new System.Windows.Forms.Label();
            this.txt_r2 = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(244, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(233, 22);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "FORMULA CUADRATICA";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(60, 92);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(20, 13);
            this.lbl_a.TabIndex = 1;
            this.lbl_a.Text = "A=";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(87, 92);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 2;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(248, 92);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(20, 13);
            this.lbl_b.TabIndex = 3;
            this.lbl_b.Text = "B=";
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(275, 91);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(130, 20);
            this.txt_n2.TabIndex = 4;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(441, 97);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(20, 13);
            this.lbl_c.TabIndex = 5;
            this.lbl_c.Text = "C=";
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(468, 92);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(123, 20);
            this.txt_n3.TabIndex = 6;
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Location = new System.Drawing.Point(63, 179);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(26, 13);
            this.lbl_x1.TabIndex = 7;
            this.lbl_x1.Text = "X1=";
            // 
            // txt_r1
            // 
            this.txt_r1.Location = new System.Drawing.Point(96, 179);
            this.txt_r1.Name = "txt_r1";
            this.txt_r1.Size = new System.Drawing.Size(100, 20);
            this.txt_r1.TabIndex = 8;
            // 
            // lbl_x2
            // 
            this.lbl_x2.AutoSize = true;
            this.lbl_x2.Location = new System.Drawing.Point(63, 245);
            this.lbl_x2.Name = "lbl_x2";
            this.lbl_x2.Size = new System.Drawing.Size(26, 13);
            this.lbl_x2.TabIndex = 9;
            this.lbl_x2.Text = "X2=";
            // 
            // txt_r2
            // 
            this.txt_r2.Location = new System.Drawing.Point(96, 245);
            this.txt_r2.Name = "txt_r2";
            this.txt_r2.Size = new System.Drawing.Size(100, 20);
            this.txt_r2.TabIndex = 10;
            this.txt_r2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(444, 175);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(444, 234);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_sugue2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 321);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_r2);
            this.Controls.Add(this.lbl_x2);
            this.Controls.Add(this.txt_r1);
            this.Controls.Add(this.lbl_x1);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_sugue2";
            this.Text = "Suguerido 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Label lbl_x1;
        private System.Windows.Forms.TextBox txt_r1;
        private System.Windows.Forms.Label lbl_x2;
        private System.Windows.Forms.TextBox txt_r2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_salir;
    }
}

