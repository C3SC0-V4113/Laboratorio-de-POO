namespace Ejemplo_1
{
    partial class frm_CalculoSalario
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
            this.grpbox_employees = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_diary = new System.Windows.Forms.Label();
            this.txt_diary = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_totalvalue = new System.Windows.Forms.Label();
            this.txt_totalvalue = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.grpbox_employees.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(178, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(419, 22);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "CALCULO DE SALARIO DE TRABAJADORES";
            // 
            // grpbox_employees
            // 
            this.grpbox_employees.Controls.Add(this.btn_save);
            this.grpbox_employees.Controls.Add(this.txt_days);
            this.grpbox_employees.Controls.Add(this.lbl_days);
            this.grpbox_employees.Controls.Add(this.lbl_diary);
            this.grpbox_employees.Controls.Add(this.txt_diary);
            this.grpbox_employees.Controls.Add(this.lbl_id);
            this.grpbox_employees.Controls.Add(this.txt_id);
            this.grpbox_employees.Controls.Add(this.txt_name);
            this.grpbox_employees.Controls.Add(this.lbl_name);
            this.grpbox_employees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_employees.Location = new System.Drawing.Point(25, 49);
            this.grpbox_employees.Name = "grpbox_employees";
            this.grpbox_employees.Size = new System.Drawing.Size(429, 213);
            this.grpbox_employees.TabIndex = 1;
            this.grpbox_employees.TabStop = false;
            this.grpbox_employees.Text = "Empleado";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(313, 88);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "GUARDAR";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_days
            // 
            this.txt_days.Location = new System.Drawing.Point(184, 152);
            this.txt_days.Name = "txt_days";
            this.txt_days.Size = new System.Drawing.Size(100, 22);
            this.txt_days.TabIndex = 7;
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(7, 155);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(98, 16);
            this.lbl_days.TabIndex = 6;
            this.lbl_days.Text = "Dias Laborados";
            // 
            // lbl_diary
            // 
            this.lbl_diary.AutoSize = true;
            this.lbl_diary.Location = new System.Drawing.Point(7, 111);
            this.lbl_diary.Name = "lbl_diary";
            this.lbl_diary.Size = new System.Drawing.Size(171, 16);
            this.lbl_diary.TabIndex = 5;
            this.lbl_diary.Text = "Asignacion de Salario Diario";
            // 
            // txt_diary
            // 
            this.txt_diary.Location = new System.Drawing.Point(184, 108);
            this.txt_diary.Name = "txt_diary";
            this.txt_diary.Size = new System.Drawing.Size(100, 22);
            this.txt_diary.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(4, 69);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(83, 16);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Identificación";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(184, 66);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(184, 20);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(4, 23);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(57, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombre:";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(511, 86);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(150, 29);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "CALCULAR SALARIO";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_totalvalue
            // 
            this.lbl_totalvalue.AutoSize = true;
            this.lbl_totalvalue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalvalue.Location = new System.Drawing.Point(519, 122);
            this.lbl_totalvalue.Name = "lbl_totalvalue";
            this.lbl_totalvalue.Size = new System.Drawing.Size(133, 16);
            this.lbl_totalvalue.TabIndex = 3;
            this.lbl_totalvalue.Text = "Valor Total devengado";
            // 
            // txt_totalvalue
            // 
            this.txt_totalvalue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalvalue.Location = new System.Drawing.Point(511, 154);
            this.txt_totalvalue.Name = "txt_totalvalue";
            this.txt_totalvalue.Size = new System.Drawing.Size(150, 22);
            this.txt_totalvalue.TabIndex = 4;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(464, 314);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "NUEVO";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(586, 314);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_CalculoSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 358);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_totalvalue);
            this.Controls.Add(this.lbl_totalvalue);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.grpbox_employees);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_CalculoSalario";
            this.Text = "Calculo de Salario";
            this.grpbox_employees.ResumeLayout(false);
            this.grpbox_employees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grpbox_employees;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_days;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_diary;
        private System.Windows.Forms.TextBox txt_diary;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_totalvalue;
        private System.Windows.Forms.TextBox txt_totalvalue;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_exit;
    }
}

