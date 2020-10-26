namespace GUIA_3_MODIFICADA
{
    partial class frm_Login
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
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_logeo = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(364, 282);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(101, 39);
            this.btn_register.TabIndex = 15;
            this.btn_register.Text = "Registro";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_logeo
            // 
            this.btn_logeo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logeo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_logeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logeo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logeo.Location = new System.Drawing.Point(209, 282);
            this.btn_logeo.Name = "btn_logeo";
            this.btn_logeo.Size = new System.Drawing.Size(101, 39);
            this.btn_logeo.TabIndex = 14;
            this.btn_logeo.Text = "Ingresar";
            this.btn_logeo.UseVisualStyleBackColor = true;
            this.btn_logeo.Click += new System.EventHandler(this.btn_logeo_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(209, 197);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(256, 21);
            this.txt_password.TabIndex = 13;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(209, 121);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(256, 21);
            this.txt_nombre.TabIndex = 12;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(131, 197);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(72, 15);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Contraseña";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(131, 121);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(52, 15);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(228, 36);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(163, 22);
            this.lbl_titulo.TabIndex = 16;
            this.lbl_titulo.Text = "GUIA 3 EN MENU";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(632, 359);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_logeo);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "frm_Login";
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_logeo;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_titulo;
    }
}