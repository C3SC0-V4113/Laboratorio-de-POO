namespace Ejemplo_1
{
    partial class frm_ejemplo1
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
            this.lbl_noyp = new System.Windows.Forms.Label();
            this.lbl_lyrics = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_noyp = new System.Windows.Forms.TextBox();
            this.txt_lyrics = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_noyp
            // 
            this.lbl_noyp.AutoSize = true;
            this.lbl_noyp.Location = new System.Drawing.Point(73, 88);
            this.lbl_noyp.Name = "lbl_noyp";
            this.lbl_noyp.Size = new System.Drawing.Size(92, 13);
            this.lbl_noyp.TabIndex = 0;
            this.lbl_noyp.Text = "Números y puntos";
            // 
            // lbl_lyrics
            // 
            this.lbl_lyrics.AutoSize = true;
            this.lbl_lyrics.Location = new System.Drawing.Point(76, 156);
            this.lbl_lyrics.Name = "lbl_lyrics";
            this.lbl_lyrics.Size = new System.Drawing.Size(36, 13);
            this.lbl_lyrics.TabIndex = 1;
            this.lbl_lyrics.Text = "Letras";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(76, 241);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // txt_noyp
            // 
            this.txt_noyp.Location = new System.Drawing.Point(172, 88);
            this.txt_noyp.Name = "txt_noyp";
            this.txt_noyp.Size = new System.Drawing.Size(100, 20);
            this.txt_noyp.TabIndex = 3;
            this.txt_noyp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_noyp_KeyPress);
            // 
            // txt_lyrics
            // 
            this.txt_lyrics.Location = new System.Drawing.Point(172, 156);
            this.txt_lyrics.Name = "txt_lyrics";
            this.txt_lyrics.Size = new System.Drawing.Size(100, 20);
            this.txt_lyrics.TabIndex = 4;
            this.txt_lyrics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lyrics_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(172, 241);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 5;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(50, 389);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_ejemplo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lyrics);
            this.Controls.Add(this.txt_noyp);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_lyrics);
            this.Controls.Add(this.lbl_noyp);
            this.Name = "frm_ejemplo1";
            this.Text = "Ejemplo 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_noyp;
        private System.Windows.Forms.Label lbl_lyrics;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_noyp;
        private System.Windows.Forms.TextBox txt_lyrics;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_exit;
    }
}

