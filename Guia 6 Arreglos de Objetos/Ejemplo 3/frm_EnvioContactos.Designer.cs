namespace Ejemplo_3
{
    partial class frm_EnvioContactos
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
            this.dgv_contacts = new System.Windows.Forms.DataGridView();
            this.btn_fill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_contacts
            // 
            this.dgv_contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contacts.Location = new System.Drawing.Point(45, 36);
            this.dgv_contacts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_contacts.Name = "dgv_contacts";
            this.dgv_contacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contacts.Size = new System.Drawing.Size(1120, 298);
            this.dgv_contacts.TabIndex = 24;
            // 
            // btn_fill
            // 
            this.btn_fill.Location = new System.Drawing.Point(562, 415);
            this.btn_fill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(112, 32);
            this.btn_fill.TabIndex = 25;
            this.btn_fill.Text = "LLENAR";
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // frm_EnvioContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btn_fill);
            this.Controls.Add(this.dgv_contacts);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_EnvioContactos";
            this.Text = "CONTACTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contacts;
        private System.Windows.Forms.Button btn_fill;
    }
}