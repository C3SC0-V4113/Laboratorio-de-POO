namespace Ejemplo_1
{
    partial class frm_ejemplo_1_2
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
            this.lbl_ventana2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ventana2
            // 
            this.lbl_ventana2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ventana2.AutoSize = true;
            this.lbl_ventana2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ventana2.Location = new System.Drawing.Point(292, 142);
            this.lbl_ventana2.Name = "lbl_ventana2";
            this.lbl_ventana2.Size = new System.Drawing.Size(0, 18);
            this.lbl_ventana2.TabIndex = 0;
            this.lbl_ventana2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(713, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(713, 386);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // frm_ejemplo_1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_ventana2);
            this.Name = "frm_ejemplo_1_2";
            this.Text = "Ejemplo 1, ventana 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ventana2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_volver;
    }
}