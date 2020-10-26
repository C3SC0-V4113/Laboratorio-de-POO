namespace Ejercicio_1
{
    partial class fr_bank
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
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_sucursal = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.lisbx_type = new System.Windows.Forms.ListBox();
            this.lbl_typecode = new System.Windows.Forms.Label();
            this.lbl_separate = new System.Windows.Forms.Label();
            this.listbx_sucursal = new System.Windows.Forms.ListBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(274, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(175, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "CESQUE BANCO";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(17, 146);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(34, 18);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "DUI";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(17, 52);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(73, 18);
            this.lbl_lname.TabIndex = 2;
            this.lbl_lname.Text = "Apellidos";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(17, 97);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(72, 18);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Nombres";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(20, 251);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(114, 18);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Text = "Tipo de Cuenta";
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(20, 201);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(31, 18);
            this.lbl_nit.TabIndex = 5;
            this.lbl_nit.Text = "NIT";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(20, 298);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(139, 18);
            this.lbl_count.TabIndex = 6;
            this.lbl_count.Text = "Número de Cuenta";
            // 
            // lbl_sucursal
            // 
            this.lbl_sucursal.AutoSize = true;
            this.lbl_sucursal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucursal.Location = new System.Drawing.Point(22, 338);
            this.lbl_sucursal.Name = "lbl_sucursal";
            this.lbl_sucursal.Size = new System.Drawing.Size(68, 18);
            this.lbl_sucursal.TabIndex = 7;
            this.lbl_sucursal.Text = "Sucursal";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(144, 49);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(162, 26);
            this.txt_lname.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(144, 94);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 26);
            this.txt_name.TabIndex = 9;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(144, 143);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(162, 26);
            this.txt_id.TabIndex = 10;
            // 
            // txt_nit
            // 
            this.txt_nit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nit.Location = new System.Drawing.Point(144, 198);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(162, 26);
            this.txt_nit.TabIndex = 11;
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(240, 295);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(113, 26);
            this.txt_count.TabIndex = 13;
            // 
            // lisbx_type
            // 
            this.lisbx_type.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisbx_type.FormattingEnabled = true;
            this.lisbx_type.ItemHeight = 18;
            this.lisbx_type.Location = new System.Drawing.Point(147, 247);
            this.lisbx_type.Name = "lisbx_type";
            this.lisbx_type.Size = new System.Drawing.Size(159, 22);
            this.lisbx_type.TabIndex = 14;
            this.lisbx_type.SelectedIndexChanged += new System.EventHandler(this.lisbx_type_SelectedIndexChanged);
            // 
            // lbl_typecode
            // 
            this.lbl_typecode.AutoSize = true;
            this.lbl_typecode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typecode.Location = new System.Drawing.Point(196, 298);
            this.lbl_typecode.Name = "lbl_typecode";
            this.lbl_typecode.Size = new System.Drawing.Size(0, 18);
            this.lbl_typecode.TabIndex = 15;
            this.lbl_typecode.TextChanged += new System.EventHandler(this.lbl_typecode_TextChanged);
            // 
            // lbl_separate
            // 
            this.lbl_separate.AutoSize = true;
            this.lbl_separate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_separate.Location = new System.Drawing.Point(221, 298);
            this.lbl_separate.Name = "lbl_separate";
            this.lbl_separate.Size = new System.Drawing.Size(13, 18);
            this.lbl_separate.TabIndex = 16;
            this.lbl_separate.Text = "-";
            // 
            // listbx_sucursal
            // 
            this.listbx_sucursal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbx_sucursal.FormattingEnabled = true;
            this.listbx_sucursal.ItemHeight = 18;
            this.listbx_sucursal.Location = new System.Drawing.Point(147, 338);
            this.listbx_sucursal.Name = "listbx_sucursal";
            this.listbx_sucursal.Size = new System.Drawing.Size(250, 22);
            this.listbx_sucursal.TabIndex = 17;
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(312, 52);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(398, 217);
            this.dgv_data.TabIndex = 18;
            this.dgv_data.DoubleClick += new System.EventHandler(this.dgv_data_DoubleClick);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(612, 275);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 28);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "GUARDAR";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(508, 275);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 28);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(612, 394);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 28);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(22, 383);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(51, 18);
            this.lbl_monto.TabIndex = 22;
            this.lbl_monto.Text = "Monto";
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(147, 383);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(250, 26);
            this.txt_monto.TabIndex = 23;
            // 
            // fr_bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 434);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.listbx_sucursal);
            this.Controls.Add(this.lbl_separate);
            this.Controls.Add(this.lbl_typecode);
            this.Controls.Add(this.lisbx_type);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.lbl_sucursal);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_title);
            this.Name = "fr_bank";
            this.Text = "INSCRIPCION DE CLIENTES";
            this.Load += new System.EventHandler(this.fr_bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_sucursal;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.ListBox lisbx_type;
        private System.Windows.Forms.Label lbl_typecode;
        private System.Windows.Forms.Label lbl_separate;
        private System.Windows.Forms.ListBox listbx_sucursal;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_monto;
    }
}

