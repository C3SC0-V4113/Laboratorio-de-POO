namespace Ejercicio_1
{
    partial class frm_menu
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.lbl_signature = new System.Windows.Forms.Label();
            this.cmbx_signature = new System.Windows.Forms.ComboBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.nud_n1 = new System.Windows.Forms.NumericUpDown();
            this.nud_n2 = new System.Windows.Forms.NumericUpDown();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(563, 35);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(207, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "SISTEMA DE NOTAS";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(58, 120);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(164, 18);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nombre de Estudiante";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(255, 116);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(253, 26);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(58, 233);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(175, 18);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Identificación Estudiantil";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(255, 233);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(253, 26);
            this.txt_id.TabIndex = 4;
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(63, 174);
            this.lbl_lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(165, 18);
            this.lbl_lname.TabIndex = 5;
            this.lbl_lname.Text = "Apellido de Estudiante";
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(255, 174);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(253, 26);
            this.txt_lname.TabIndex = 6;
            // 
            // lbl_signature
            // 
            this.lbl_signature.AutoSize = true;
            this.lbl_signature.Location = new System.Drawing.Point(63, 291);
            this.lbl_signature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_signature.Name = "lbl_signature";
            this.lbl_signature.Size = new System.Drawing.Size(61, 18);
            this.lbl_signature.TabIndex = 7;
            this.lbl_signature.Text = "Materia";
            // 
            // cmbx_signature
            // 
            this.cmbx_signature.FormattingEnabled = true;
            this.cmbx_signature.Location = new System.Drawing.Point(255, 291);
            this.cmbx_signature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbx_signature.Name = "cmbx_signature";
            this.cmbx_signature.Size = new System.Drawing.Size(253, 26);
            this.cmbx_signature.TabIndex = 9;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(63, 350);
            this.lbl_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(103, 18);
            this.lbl_n1.TabIndex = 10;
            this.lbl_n1.Text = "Calificacion 1";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(68, 403);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(103, 18);
            this.lbl_n2.TabIndex = 11;
            this.lbl_n2.Text = "Calificación 2";
            // 
            // nud_n1
            // 
            this.nud_n1.DecimalPlaces = 1;
            this.nud_n1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_n1.Location = new System.Drawing.Point(255, 350);
            this.nud_n1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_n1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_n1.Name = "nud_n1";
            this.nud_n1.Size = new System.Drawing.Size(255, 26);
            this.nud_n1.TabIndex = 12;
            // 
            // nud_n2
            // 
            this.nud_n2.DecimalPlaces = 1;
            this.nud_n2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_n2.Location = new System.Drawing.Point(255, 403);
            this.nud_n2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_n2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_n2.Name = "nud_n2";
            this.nud_n2.Size = new System.Drawing.Size(255, 26);
            this.nud_n2.TabIndex = 13;
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(567, 120);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(598, 310);
            this.dgv_data.TabIndex = 14;
            this.dgv_data.DoubleClick += new System.EventHandler(this.dgv_data_DoubleClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(63, 497);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 32);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "AGREGAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(202, 497);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 32);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1053, 497);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 32);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.nud_n2);
            this.Controls.Add(this.nud_n1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.cmbx_signature);
            this.Controls.Add(this.lbl_signature);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_menu";
            this.Text = "SISTEMA DE NOTAS";
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label lbl_signature;
        private System.Windows.Forms.ComboBox cmbx_signature;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.NumericUpDown nud_n1;
        private System.Windows.Forms.NumericUpDown nud_n2;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
    }
}

