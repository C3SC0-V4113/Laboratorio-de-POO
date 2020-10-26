namespace Ejercicio_2
{
    partial class frm_ejercicio21
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dtp_bday = new System.Windows.Forms.DateTimePicker();
            this.lbl_bday = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(324, 34);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(116, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "CAPTURA DE DATOS";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(101, 110);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Carnet";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(101, 149);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Nombre";
            // 
            // dtp_bday
            // 
            this.dtp_bday.Location = new System.Drawing.Point(295, 186);
            this.dtp_bday.Name = "dtp_bday";
            this.dtp_bday.Size = new System.Drawing.Size(200, 20);
            this.dtp_bday.TabIndex = 3;
            // 
            // lbl_bday
            // 
            this.lbl_bday.AutoSize = true;
            this.lbl_bday.Location = new System.Drawing.Point(98, 186);
            this.lbl_bday.Name = "lbl_bday";
            this.lbl_bday.Size = new System.Drawing.Size(108, 13);
            this.lbl_bday.TabIndex = 4;
            this.lbl_bday.Text = "Fecha de Nacimiento";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(101, 227);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(94, 13);
            this.lbl_mail.TabIndex = 5;
            this.lbl_mail.Text = "Correo Electronico";
            // 
            // lbl_responsable
            // 
            this.lbl_responsable.AutoSize = true;
            this.lbl_responsable.Location = new System.Drawing.Point(104, 275);
            this.lbl_responsable.Name = "lbl_responsable";
            this.lbl_responsable.Size = new System.Drawing.Size(69, 13);
            this.lbl_responsable.TabIndex = 6;
            this.lbl_responsable.Text = "Responsable";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(295, 102);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 7;
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(295, 149);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 8;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(295, 227);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 9;
            this.txt_mail.Leave += new System.EventHandler(this.txt_mail_Leave);
            // 
            // txt_responsable
            // 
            this.txt_responsable.Location = new System.Drawing.Point(295, 275);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.Size = new System.Drawing.Size(100, 20);
            this.txt_responsable.TabIndex = 10;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(582, 361);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = "SIGUIENTE";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // frm_ejercicio21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_responsable);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_responsable);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_bday);
            this.Controls.Add(this.dtp_bday);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_ejercicio21";
            this.Text = "CAPTURA DE DATOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DateTimePicker dtp_bday;
        private System.Windows.Forms.Label lbl_bday;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_responsable;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_responsable;
        private System.Windows.Forms.Button btn_next;
    }
}

