namespace GUIA_3_MODIFICADA
{
    partial class Menù
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
            this.btn_eje1 = new System.Windows.Forms.Button();
            this.btn_eje2 = new System.Windows.Forms.Button();
            this.btn_eje3 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(229, 39);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(230, 24);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "MENÚ DE SELECCIÓN";
            // 
            // btn_eje1
            // 
            this.btn_eje1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eje1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_eje1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eje1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eje1.Location = new System.Drawing.Point(288, 102);
            this.btn_eje1.Name = "btn_eje1";
            this.btn_eje1.Size = new System.Drawing.Size(97, 35);
            this.btn_eje1.TabIndex = 1;
            this.btn_eje1.Text = "Salarios";
            this.btn_eje1.UseVisualStyleBackColor = true;
            this.btn_eje1.Click += new System.EventHandler(this.btn_eje1_Click);
            // 
            // btn_eje2
            // 
            this.btn_eje2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eje2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_eje2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eje2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eje2.Location = new System.Drawing.Point(288, 144);
            this.btn_eje2.Name = "btn_eje2";
            this.btn_eje2.Size = new System.Drawing.Size(97, 35);
            this.btn_eje2.TabIndex = 2;
            this.btn_eje2.Text = "Formula";
            this.btn_eje2.UseVisualStyleBackColor = true;
            this.btn_eje2.Click += new System.EventHandler(this.btn_eje2_Click);
            // 
            // btn_eje3
            // 
            this.btn_eje3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eje3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_eje3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eje3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eje3.Location = new System.Drawing.Point(288, 183);
            this.btn_eje3.Name = "btn_eje3";
            this.btn_eje3.Size = new System.Drawing.Size(97, 35);
            this.btn_eje3.TabIndex = 3;
            this.btn_eje3.Text = "Magnitudes";
            this.btn_eje3.UseVisualStyleBackColor = true;
            this.btn_eje3.Click += new System.EventHandler(this.btn_eje3_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(288, 226);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Menù
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_eje3);
            this.Controls.Add(this.btn_eje2);
            this.Controls.Add(this.btn_eje1);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Menù";
            this.Text = "Menù";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_eje1;
        private System.Windows.Forms.Button btn_eje2;
        private System.Windows.Forms.Button btn_eje3;
        private System.Windows.Forms.Button btn_exit;
    }
}