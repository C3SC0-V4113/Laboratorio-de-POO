namespace Ejemplo_4
{
    partial class frm_ejemplo4
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
            this.gropubx_empleado = new System.Windows.Forms.GroupBox();
            this.lbl_carnet = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txt_carnet = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.btn_catch = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gropubx_empleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gropubx_empleado
            // 
            this.gropubx_empleado.Controls.Add(this.txt_edad);
            this.gropubx_empleado.Controls.Add(this.txt_name);
            this.gropubx_empleado.Controls.Add(this.txt_carnet);
            this.gropubx_empleado.Controls.Add(this.lbl_age);
            this.gropubx_empleado.Controls.Add(this.lbl_name);
            this.gropubx_empleado.Controls.Add(this.lbl_carnet);
            this.gropubx_empleado.Location = new System.Drawing.Point(32, 21);
            this.gropubx_empleado.Name = "gropubx_empleado";
            this.gropubx_empleado.Size = new System.Drawing.Size(404, 239);
            this.gropubx_empleado.TabIndex = 0;
            this.gropubx_empleado.TabStop = false;
            this.gropubx_empleado.Text = "Empleado";
            // 
            // lbl_carnet
            // 
            this.lbl_carnet.AutoSize = true;
            this.lbl_carnet.Location = new System.Drawing.Point(7, 33);
            this.lbl_carnet.Name = "lbl_carnet";
            this.lbl_carnet.Size = new System.Drawing.Size(38, 13);
            this.lbl_carnet.TabIndex = 0;
            this.lbl_carnet.Text = "Carnet";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(10, 91);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nombre";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(13, 150);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(32, 13);
            this.lbl_age.TabIndex = 2;
            this.lbl_age.Text = "Edad";
            // 
            // txt_carnet
            // 
            this.txt_carnet.Location = new System.Drawing.Point(87, 33);
            this.txt_carnet.Name = "txt_carnet";
            this.txt_carnet.Size = new System.Drawing.Size(100, 20);
            this.txt_carnet.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(87, 83);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(87, 150);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 5;
            // 
            // btn_catch
            // 
            this.btn_catch.Location = new System.Drawing.Point(42, 299);
            this.btn_catch.Name = "btn_catch";
            this.btn_catch.Size = new System.Drawing.Size(75, 23);
            this.btn_catch.TabIndex = 1;
            this.btn_catch.Text = "Capturar";
            this.btn_catch.UseVisualStyleBackColor = true;
            this.btn_catch.Click += new System.EventHandler(this.btn_catch_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(359, 299);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_ejemplo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 343);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_catch);
            this.Controls.Add(this.gropubx_empleado);
            this.Name = "frm_ejemplo4";
            this.Text = "Ejemplo 4";
            this.gropubx_empleado.ResumeLayout(false);
            this.gropubx_empleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gropubx_empleado;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_carnet;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_carnet;
        private System.Windows.Forms.Button btn_catch;
        private System.Windows.Forms.Button btn_exit;
    }
}

