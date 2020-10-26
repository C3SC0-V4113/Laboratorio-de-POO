namespace GUIA_3_MODIFICADA
{
    partial class frm_ejercicio1
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.rbtn_secre = new System.Windows.Forms.RadioButton();
            this.rbtn_sub = new System.Windows.Forms.RadioButton();
            this.rbtn_ger = new System.Windows.Forms.RadioButton();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.lbl_salario4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(331, 250);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 19;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(331, 279);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // rbtn_secre
            // 
            this.rbtn_secre.AutoSize = true;
            this.rbtn_secre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_secre.Location = new System.Drawing.Point(500, 162);
            this.rbtn_secre.Name = "rbtn_secre";
            this.rbtn_secre.Size = new System.Drawing.Size(85, 20);
            this.rbtn_secre.TabIndex = 17;
            this.rbtn_secre.TabStop = true;
            this.rbtn_secre.Text = "Secretaria";
            this.rbtn_secre.UseVisualStyleBackColor = true;
            // 
            // rbtn_sub
            // 
            this.rbtn_sub.AutoSize = true;
            this.rbtn_sub.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_sub.Location = new System.Drawing.Point(295, 162);
            this.rbtn_sub.Name = "rbtn_sub";
            this.rbtn_sub.Size = new System.Drawing.Size(99, 20);
            this.rbtn_sub.TabIndex = 16;
            this.rbtn_sub.TabStop = true;
            this.rbtn_sub.Text = "Sub-Gerente";
            this.rbtn_sub.UseVisualStyleBackColor = true;
            // 
            // rbtn_ger
            // 
            this.rbtn_ger.AutoSize = true;
            this.rbtn_ger.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_ger.Location = new System.Drawing.Point(90, 162);
            this.rbtn_ger.Name = "rbtn_ger";
            this.rbtn_ger.Size = new System.Drawing.Size(72, 20);
            this.rbtn_ger.TabIndex = 15;
            this.rbtn_ger.TabStop = true;
            this.rbtn_ger.Text = "Gerente";
            this.rbtn_ger.UseVisualStyleBackColor = true;
            // 
            // txt_salario
            // 
            this.txt_salario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario.Location = new System.Drawing.Point(445, 87);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(137, 22);
            this.txt_salario.TabIndex = 14;
            // 
            // lbl_salario4
            // 
            this.lbl_salario4.AutoSize = true;
            this.lbl_salario4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario4.Location = new System.Drawing.Point(391, 90);
            this.lbl_salario4.Name = "lbl_salario4";
            this.lbl_salario4.Size = new System.Drawing.Size(48, 16);
            this.lbl_salario4.TabIndex = 13;
            this.lbl_salario4.Text = "Salario";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(141, 87);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(134, 22);
            this.txt_nombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(291, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(139, 24);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "EJERCICIO 1";
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(331, 309);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 23);
            this.btn_menu.TabIndex = 20;
            this.btn_menu.Text = "Menú";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // frm_ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 349);
            this.Controls.Add(this.btn_menu);
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
            this.Name = "frm_ejercicio1";
            this.Text = "SALARIOS";
            this.Load += new System.EventHandler(this.frm_ejercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.RadioButton rbtn_secre;
        private System.Windows.Forms.RadioButton rbtn_sub;
        private System.Windows.Forms.RadioButton rbtn_ger;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label lbl_salario4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_menu;
    }
}

