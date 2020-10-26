namespace Ejemplo_2
{
    partial class frm_ejemplo2
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.rbtn_opbasicas = new System.Windows.Forms.RadioButton();
            this.rbtn_opavanzadas = new System.Windows.Forms.RadioButton();
            this.listbx_opavanced = new System.Windows.Forms.ListBox();
            this.cmb_opbasic = new System.Windows.Forms.ComboBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(273, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(156, 22);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "CALCULADORA";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(46, 62);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(53, 13);
            this.lbl_n1.TabIndex = 1;
            this.lbl_n1.Text = "Número 1";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(49, 118);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(53, 13);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = "Número 2";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(127, 54);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(165, 20);
            this.txt_n1.TabIndex = 3;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(127, 118);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(165, 20);
            this.txt_n2.TabIndex = 4;
            // 
            // rbtn_opbasicas
            // 
            this.rbtn_opbasicas.AutoSize = true;
            this.rbtn_opbasicas.Location = new System.Drawing.Point(369, 62);
            this.rbtn_opbasicas.Name = "rbtn_opbasicas";
            this.rbtn_opbasicas.Size = new System.Drawing.Size(124, 17);
            this.rbtn_opbasicas.TabIndex = 5;
            this.rbtn_opbasicas.TabStop = true;
            this.rbtn_opbasicas.Text = "Operaciones basicas";
            this.rbtn_opbasicas.UseVisualStyleBackColor = true;
            this.rbtn_opbasicas.CheckedChanged += new System.EventHandler(this.rbtn_opbasicas_CheckedChanged);
            // 
            // rbtn_opavanzadas
            // 
            this.rbtn_opavanzadas.AutoSize = true;
            this.rbtn_opavanzadas.Location = new System.Drawing.Point(530, 62);
            this.rbtn_opavanzadas.Name = "rbtn_opavanzadas";
            this.rbtn_opavanzadas.Size = new System.Drawing.Size(140, 17);
            this.rbtn_opavanzadas.TabIndex = 6;
            this.rbtn_opavanzadas.TabStop = true;
            this.rbtn_opavanzadas.Text = "Operaciones avanzadas";
            this.rbtn_opavanzadas.UseVisualStyleBackColor = true;
            this.rbtn_opavanzadas.CheckedChanged += new System.EventHandler(this.rbtn_opavanzadas_CheckedChanged);
            // 
            // listbx_opavanced
            // 
            this.listbx_opavanced.FormattingEnabled = true;
            this.listbx_opavanced.Location = new System.Drawing.Point(530, 98);
            this.listbx_opavanced.Name = "listbx_opavanced";
            this.listbx_opavanced.Size = new System.Drawing.Size(120, 95);
            this.listbx_opavanced.TabIndex = 7;
            // 
            // cmb_opbasic
            // 
            this.cmb_opbasic.FormattingEnabled = true;
            this.cmb_opbasic.Location = new System.Drawing.Point(369, 98);
            this.cmb_opbasic.Name = "cmb_opbasic";
            this.cmb_opbasic.Size = new System.Drawing.Size(121, 21);
            this.cmb_opbasic.TabIndex = 8;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(339, 203);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(339, 244);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_ejemplo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 322);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.cmb_opbasic);
            this.Controls.Add(this.listbx_opavanced);
            this.Controls.Add(this.rbtn_opavanzadas);
            this.Controls.Add(this.rbtn_opbasicas);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_ejemplo2";
            this.Text = "Ejemplo 2";
            this.Load += new System.EventHandler(this.frm_ejemplo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.RadioButton rbtn_opbasicas;
        private System.Windows.Forms.RadioButton rbtn_opavanzadas;
        private System.Windows.Forms.ListBox listbx_opavanced;
        private System.Windows.Forms.ComboBox cmb_opbasic;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_salir;
    }
}

