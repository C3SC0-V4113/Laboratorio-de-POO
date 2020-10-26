namespace LoginBasico
{
    partial class frm_logeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logeo));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logeo = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.chb_mostrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(298, 104);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(52, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(298, 180);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(72, 15);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Contraseña";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(376, 104);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(256, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(376, 180);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(256, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logeo
            // 
            this.btn_logeo.FlatAppearance.BorderSize = 0;
            this.btn_logeo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_logeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logeo.Location = new System.Drawing.Point(376, 265);
            this.btn_logeo.Name = "btn_logeo";
            this.btn_logeo.Size = new System.Drawing.Size(101, 39);
            this.btn_logeo.TabIndex = 5;
            this.btn_logeo.Text = "Ingresar";
            this.btn_logeo.UseVisualStyleBackColor = true;
            this.btn_logeo.Click += new System.EventHandler(this.btn_logeo_Click);
            // 
            // btn_register
            // 
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(531, 265);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(101, 39);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Registro";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(713, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // chb_mostrar
            // 
            this.chb_mostrar.AutoSize = true;
            this.chb_mostrar.Location = new System.Drawing.Point(638, 183);
            this.chb_mostrar.Name = "chb_mostrar";
            this.chb_mostrar.Size = new System.Drawing.Size(118, 17);
            this.chb_mostrar.TabIndex = 9;
            this.chb_mostrar.Text = "Mostrar Contraseña";
            this.chb_mostrar.UseVisualStyleBackColor = true;
            // 
            // frm_logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chb_mostrar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_logeo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "frm_logeo";
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_logeo;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.CheckBox chb_mostrar;
    }
}

