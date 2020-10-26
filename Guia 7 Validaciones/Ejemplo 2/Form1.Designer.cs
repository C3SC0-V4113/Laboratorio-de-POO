namespace Ejemplo_2
{
    partial class frm_ejemplo2
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
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_bdate = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.dtp_bdate = new System.Windows.Forms.DateTimePicker();
            this.errorp1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(351, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(85, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "VALIDACIONES";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 64);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nombre";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(15, 124);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(44, 13);
            this.lbl_lname.TabIndex = 2;
            this.lbl_lname.Text = "Apellido";
            // 
            // lbl_bdate
            // 
            this.lbl_bdate.AutoSize = true;
            this.lbl_bdate.Location = new System.Drawing.Point(18, 181);
            this.lbl_bdate.Name = "lbl_bdate";
            this.lbl_bdate.Size = new System.Drawing.Size(108, 13);
            this.lbl_bdate.TabIndex = 3;
            this.lbl_bdate.Text = "Fecha de Nacimiento";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(21, 257);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(32, 13);
            this.lbl_age.TabIndex = 4;
            this.lbl_age.Text = "Edad";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(676, 406);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "GUARDAR";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(569, 406);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(140, 56);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(140, 116);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 8;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(149, 257);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 9;
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.Location = new System.Drawing.Point(149, 181);
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_bdate.TabIndex = 10;
            // 
            // errorp1
            // 
            this.errorp1.ContainerControl = this;
            // 
            // frm_ejemplo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_bdate);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_bdate);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_ejemplo2";
            this.Text = "Ejemplo 2";
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_bdate;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.DateTimePicker dtp_bdate;
        private System.Windows.Forms.ErrorProvider errorp1;
    }
}

