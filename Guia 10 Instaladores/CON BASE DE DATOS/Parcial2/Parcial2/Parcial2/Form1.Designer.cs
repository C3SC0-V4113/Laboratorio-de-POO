namespace Parcial2
{
    partial class frm_parcial2
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
            this.dgv_Proyector = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_director = new System.Windows.Forms.TextBox();
            this.nud_año = new System.Windows.Forms.NumericUpDown();
            this.listbx_genero = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_director = new System.Windows.Forms.Label();
            this.lbl_año = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proyector)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_año)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Proyector
            // 
            this.dgv_Proyector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proyector.Location = new System.Drawing.Point(12, 83);
            this.dgv_Proyector.Name = "dgv_Proyector";
            this.dgv_Proyector.ReadOnly = true;
            this.dgv_Proyector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Proyector.Size = new System.Drawing.Size(558, 252);
            this.dgv_Proyector.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(372, 22);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(109, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "PARCIAL 2: Peliculas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_genero);
            this.groupBox1.Controls.Add(this.lbl_año);
            this.groupBox1.Controls.Add(this.lbl_director);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.listbx_genero);
            this.groupBox1.Controls.Add(this.nud_año);
            this.groupBox1.Controls.Add(this.txt_director);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Location = new System.Drawing.Point(600, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peliculas";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(7, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_director
            // 
            this.txt_director.Location = new System.Drawing.Point(7, 86);
            this.txt_director.Name = "txt_director";
            this.txt_director.Size = new System.Drawing.Size(171, 20);
            this.txt_director.TabIndex = 1;
            // 
            // nud_año
            // 
            this.nud_año.Location = new System.Drawing.Point(7, 135);
            this.nud_año.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_año.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nud_año.Name = "nud_año";
            this.nud_año.Size = new System.Drawing.Size(171, 20);
            this.nud_año.TabIndex = 2;
            this.nud_año.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // listbx_genero
            // 
            this.listbx_genero.FormattingEnabled = true;
            this.listbx_genero.Location = new System.Drawing.Point(7, 191);
            this.listbx_genero.Name = "listbx_genero";
            this.listbx_genero.Size = new System.Drawing.Size(171, 30);
            this.listbx_genero.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(600, 353);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(184, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "AGREGAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(7, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(99, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Nombre de Pelicula";
            // 
            // lbl_director
            // 
            this.lbl_director.AutoSize = true;
            this.lbl_director.Location = new System.Drawing.Point(7, 70);
            this.lbl_director.Name = "lbl_director";
            this.lbl_director.Size = new System.Drawing.Size(44, 13);
            this.lbl_director.TabIndex = 5;
            this.lbl_director.Text = "Director";
            // 
            // lbl_año
            // 
            this.lbl_año.AutoSize = true;
            this.lbl_año.Location = new System.Drawing.Point(7, 119);
            this.lbl_año.Name = "lbl_año";
            this.lbl_año.Size = new System.Drawing.Size(26, 13);
            this.lbl_año.TabIndex = 6;
            this.lbl_año.Text = "Año";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Location = new System.Drawing.Point(7, 175);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_genero.TabIndex = 7;
            this.lbl_genero.Text = "Genero";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(600, 395);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(184, 24);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "EDITAR";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(13, 342);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(13, 372);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_parcial2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv_Proyector);
            this.Name = "frm_parcial2";
            this.Text = "Parcial 2";
            this.Load += new System.EventHandler(this.frm_parcial2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proyector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_año)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Proyector;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listbx_genero;
        private System.Windows.Forms.NumericUpDown nud_año;
        private System.Windows.Forms.TextBox txt_director;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_año;
        private System.Windows.Forms.Label lbl_director;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_exit;
    }
}

