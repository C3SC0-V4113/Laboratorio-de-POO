namespace Suguerido_1
{
    partial class frm_sugue1
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
            this.lstbx_seleccion = new System.Windows.Forms.ListBox();
            this.lbl_selec = new System.Windows.Forms.Label();
            this.lbl_transform = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(153, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(409, 22);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "CONVERSOR DE MAGNITUDES RELATIVAS";
            // 
            // lstbx_seleccion
            // 
            this.lstbx_seleccion.FormattingEnabled = true;
            this.lstbx_seleccion.Location = new System.Drawing.Point(279, 63);
            this.lstbx_seleccion.Name = "lstbx_seleccion";
            this.lstbx_seleccion.Size = new System.Drawing.Size(120, 56);
            this.lstbx_seleccion.TabIndex = 1;
            this.lstbx_seleccion.SelectedIndexChanged += new System.EventHandler(this.lstbx_seleccion_SelectedIndexChanged);
            // 
            // lbl_selec
            // 
            this.lbl_selec.AutoSize = true;
            this.lbl_selec.Location = new System.Drawing.Point(260, 47);
            this.lbl_selec.Name = "lbl_selec";
            this.lbl_selec.Size = new System.Drawing.Size(165, 13);
            this.lbl_selec.TabIndex = 2;
            this.lbl_selec.Text = "Seleccione la operacion deseada";
            // 
            // lbl_transform
            // 
            this.lbl_transform.AutoSize = true;
            this.lbl_transform.Location = new System.Drawing.Point(217, 137);
            this.lbl_transform.Name = "lbl_transform";
            this.lbl_transform.Size = new System.Drawing.Size(0, 13);
            this.lbl_transform.TabIndex = 3;
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(279, 159);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(120, 20);
            this.txt_n1.TabIndex = 4;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(299, 185);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(299, 228);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_sugue1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 323);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_transform);
            this.Controls.Add(this.lbl_selec);
            this.Controls.Add(this.lstbx_seleccion);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_sugue1";
            this.Text = "Suguerido 1";
            this.Load += new System.EventHandler(this.frm_sugue1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ListBox lstbx_seleccion;
        private System.Windows.Forms.Label lbl_selec;
        private System.Windows.Forms.Label lbl_transform;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_salir;
    }
}

