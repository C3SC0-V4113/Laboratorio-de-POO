namespace Ejemplo_2
{
    partial class frm_1
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.grpbx_products = new System.Windows.Forms.GroupBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.grpbx_products.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(490, 42);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(268, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "LISTADO DE PRODUCTOS";
            // 
            // dgv_principal
            // 
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_principal.Location = new System.Drawing.Point(46, 107);
            this.dgv_principal.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_principal.Size = new System.Drawing.Size(700, 370);
            this.dgv_principal.TabIndex = 1;
            this.dgv_principal.DoubleClick += new System.EventHandler(this.dgv_principal_DoubleClick);
            // 
            // grpbx_products
            // 
            this.grpbx_products.Controls.Add(this.txt_stock);
            this.grpbx_products.Controls.Add(this.txt_price);
            this.grpbx_products.Controls.Add(this.txt_brand);
            this.grpbx_products.Controls.Add(this.txt_description);
            this.grpbx_products.Controls.Add(this.txt_name);
            this.grpbx_products.Controls.Add(this.lbl_stock);
            this.grpbx_products.Controls.Add(this.lbl_price);
            this.grpbx_products.Controls.Add(this.lbl_brand);
            this.grpbx_products.Controls.Add(this.lbl_description);
            this.grpbx_products.Controls.Add(this.lbl_name);
            this.grpbx_products.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_products.Location = new System.Drawing.Point(754, 107);
            this.grpbx_products.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_products.Name = "grpbx_products";
            this.grpbx_products.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_products.Size = new System.Drawing.Size(428, 370);
            this.grpbx_products.TabIndex = 2;
            this.grpbx_products.TabStop = false;
            this.grpbx_products.Text = "MANTENIMIENTO DE PRODUCTOS";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(132, 313);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(148, 26);
            this.txt_stock.TabIndex = 9;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(132, 242);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(148, 26);
            this.txt_price.TabIndex = 8;
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(132, 173);
            this.txt_brand.Margin = new System.Windows.Forms.Padding(4);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(148, 26);
            this.txt_brand.TabIndex = 7;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(132, 105);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(148, 26);
            this.txt_description.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(132, 39);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(148, 26);
            this.txt_name.TabIndex = 5;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(9, 313);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(72, 18);
            this.lbl_stock.TabIndex = 4;
            this.lbl_stock.Text = "Cantidad";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(12, 242);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(54, 18);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Precio";
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(12, 173);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(52, 18);
            this.lbl_brand.TabIndex = 2;
            this.lbl_brand.Text = "Marca";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(9, 108);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(92, 18);
            this.lbl_description.TabIndex = 1;
            this.lbl_description.Text = "Descripción";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(9, 39);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombre";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1006, 485);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 32);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(46, 485);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 32);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(839, 485);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 32);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "GUARDAR";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.grpbx_products);
            this.Controls.Add(this.dgv_principal);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_1";
            this.Text = "LISTADO DE PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.grpbx_products.ResumeLayout(false);
            this.grpbx_products.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.GroupBox grpbx_products;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
    }
}

