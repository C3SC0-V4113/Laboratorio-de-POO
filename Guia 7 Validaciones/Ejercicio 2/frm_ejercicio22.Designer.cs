namespace Ejercicio_2
{
    partial class frm_ejercicio22
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
            this.lbl_signature = new System.Windows.Forms.Label();
            this.cmbbx_signature = new System.Windows.Forms.ComboBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.nud_n1 = new System.Windows.Forms.NumericUpDown();
            this.nud_n2 = new System.Windows.Forms.NumericUpDown();
            this.nud_n3 = new System.Windows.Forms.NumericUpDown();
            this.btn_finalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_signature
            // 
            this.lbl_signature.AutoSize = true;
            this.lbl_signature.Location = new System.Drawing.Point(54, 41);
            this.lbl_signature.Name = "lbl_signature";
            this.lbl_signature.Size = new System.Drawing.Size(42, 13);
            this.lbl_signature.TabIndex = 0;
            this.lbl_signature.Text = "Materia";
            // 
            // cmbbx_signature
            // 
            this.cmbbx_signature.FormattingEnabled = true;
            this.cmbbx_signature.Location = new System.Drawing.Point(126, 41);
            this.cmbbx_signature.Name = "cmbbx_signature";
            this.cmbbx_signature.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_signature.TabIndex = 1;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(57, 101);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(39, 13);
            this.lbl_n1.TabIndex = 2;
            this.lbl_n1.Text = "Nota 1";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(60, 146);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(39, 13);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Nota 2";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(60, 190);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(39, 13);
            this.lbl_n3.TabIndex = 4;
            this.lbl_n3.Text = "Nota 3";
            // 
            // nud_n1
            // 
            this.nud_n1.DecimalPlaces = 1;
            this.nud_n1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_n1.Location = new System.Drawing.Point(126, 101);
            this.nud_n1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_n1.Name = "nud_n1";
            this.nud_n1.Size = new System.Drawing.Size(120, 20);
            this.nud_n1.TabIndex = 5;
            // 
            // nud_n2
            // 
            this.nud_n2.Location = new System.Drawing.Point(126, 146);
            this.nud_n2.Name = "nud_n2";
            this.nud_n2.Size = new System.Drawing.Size(120, 20);
            this.nud_n2.TabIndex = 6;
            // 
            // nud_n3
            // 
            this.nud_n3.Location = new System.Drawing.Point(126, 190);
            this.nud_n3.Name = "nud_n3";
            this.nud_n3.Size = new System.Drawing.Size(120, 20);
            this.nud_n3.TabIndex = 7;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(391, 72);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_finalizar.TabIndex = 8;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ejercicio22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 271);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.nud_n3);
            this.Controls.Add(this.nud_n2);
            this.Controls.Add(this.nud_n1);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.cmbbx_signature);
            this.Controls.Add(this.lbl_signature);
            this.Name = "frm_ejercicio22";
            this.Text = "frm_ejercicio22";
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_signature;
        private System.Windows.Forms.ComboBox cmbbx_signature;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.NumericUpDown nud_n1;
        private System.Windows.Forms.NumericUpDown nud_n2;
        private System.Windows.Forms.NumericUpDown nud_n3;
        private System.Windows.Forms.Button btn_finalizar;
    }
}