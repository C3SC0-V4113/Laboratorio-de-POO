namespace Primer_Parcial_Practico
{
    partial class frm_Ejercicio_2
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.dgv_notas = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(215, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(300, 18);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "SISTEMA DE NOTAS PARA 3 ALUMNOS";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 64);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(141, 18);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nombre de Alumno";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(13, 99);
            this.lbl_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(54, 18);
            this.lbl_n1.TabIndex = 2;
            this.lbl_n1.Text = "Nota 1";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(18, 136);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(54, 18);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Nota 2";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(169, 64);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(148, 26);
            this.txt_name.TabIndex = 4;
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(169, 99);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(148, 26);
            this.txt_n1.TabIndex = 5;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(169, 136);
            this.txt_n2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(148, 26);
            this.txt_n2.TabIndex = 6;
            // 
            // dgv_notas
            // 
            this.dgv_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notas.Location = new System.Drawing.Point(358, 64);
            this.dgv_notas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_notas.Name = "dgv_notas";
            this.dgv_notas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_notas.Size = new System.Drawing.Size(378, 213);
            this.dgv_notas.TabIndex = 7;
            this.dgv_notas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_notas_CellClick);
            this.dgv_notas.DoubleClick += new System.EventHandler(this.dgv_notas_DoubleClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(23, 217);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 32);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "AGREGAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(169, 215);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 32);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "ELIMINAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(624, 300);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 32);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Enabled = false;
            this.btn_finish.Location = new System.Drawing.Point(454, 299);
            this.btn_finish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(112, 32);
            this.btn_finish.TabIndex = 11;
            this.btn_finish.Text = "FINALIZAR";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // frm_Ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 364);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_notas);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Ejercicio_2";
            this.Text = "Ejercicio 2-Sistema de Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.DataGridView dgv_notas;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_finish;
    }
}

