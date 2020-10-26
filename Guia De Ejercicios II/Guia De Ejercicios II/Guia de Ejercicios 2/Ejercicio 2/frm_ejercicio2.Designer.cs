namespace Ejercicio_2
{
    partial class frm_ejercicio2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabcrtl_todo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_motor = new System.Windows.Forms.TextBox();
            this.txt_chasis = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbx_gas = new System.Windows.Forms.ComboBox();
            this.nud_ruedas = new System.Windows.Forms.NumericUpDown();
            this.nud_cc = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.cmbx_palanca = new System.Windows.Forms.ComboBox();
            this.cmbx_traccion = new System.Windows.Forms.ComboBox();
            this.nud_puertas = new System.Windows.Forms.NumericUpDown();
            this.dgv_res = new System.Windows.Forms.DataGridView();
            this.btn_moto = new System.Windows.Forms.Button();
            this.btn_auto = new System.Windows.Forms.Button();
            this.btn_bus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabcrtl_todo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ruedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_puertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_res)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_res);
            this.splitContainer1.Size = new System.Drawing.Size(831, 450);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabcrtl_todo
            // 
            this.tabcrtl_todo.Controls.Add(this.tabPage1);
            this.tabcrtl_todo.Controls.Add(this.tabPage2);
            this.tabcrtl_todo.Controls.Add(this.tabPage3);
            this.tabcrtl_todo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcrtl_todo.Location = new System.Drawing.Point(0, 0);
            this.tabcrtl_todo.Name = "tabcrtl_todo";
            this.tabcrtl_todo.SelectedIndex = 0;
            this.tabcrtl_todo.Size = new System.Drawing.Size(339, 277);
            this.tabcrtl_todo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_moto);
            this.tabPage1.Controls.Add(this.nud_cc);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Moto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_auto);
            this.tabPage2.Controls.Add(this.cmbx_traccion);
            this.tabPage2.Controls.Add(this.cmbx_palanca);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_bus);
            this.tabPage3.Controls.Add(this.nud_puertas);
            this.tabPage3.Controls.Add(this.nud_precio);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(331, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bus";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.nud_ruedas);
            this.splitContainer2.Panel1.Controls.Add(this.cmbx_gas);
            this.splitContainer2.Panel1.Controls.Add(this.txt_tipo);
            this.splitContainer2.Panel1.Controls.Add(this.txt_chasis);
            this.splitContainer2.Panel1.Controls.Add(this.txt_motor);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabcrtl_todo);
            this.splitContainer2.Size = new System.Drawing.Size(831, 277);
            this.splitContainer2.SplitterDistance = 488;
            this.splitContainer2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de Ruedas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Gasolina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo Chasis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Motor";
            // 
            // txt_motor
            // 
            this.txt_motor.Location = new System.Drawing.Point(171, 48);
            this.txt_motor.Name = "txt_motor";
            this.txt_motor.Size = new System.Drawing.Size(200, 20);
            this.txt_motor.TabIndex = 10;
            // 
            // txt_chasis
            // 
            this.txt_chasis.Location = new System.Drawing.Point(171, 85);
            this.txt_chasis.Name = "txt_chasis";
            this.txt_chasis.Size = new System.Drawing.Size(200, 20);
            this.txt_chasis.TabIndex = 11;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(171, 216);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(200, 20);
            this.txt_tipo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cilindraje";
            // 
            // cmbx_gas
            // 
            this.cmbx_gas.FormattingEnabled = true;
            this.cmbx_gas.Location = new System.Drawing.Point(171, 125);
            this.cmbx_gas.Name = "cmbx_gas";
            this.cmbx_gas.Size = new System.Drawing.Size(200, 21);
            this.cmbx_gas.TabIndex = 15;
            // 
            // nud_ruedas
            // 
            this.nud_ruedas.Location = new System.Drawing.Point(171, 168);
            this.nud_ruedas.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nud_ruedas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_ruedas.Name = "nud_ruedas";
            this.nud_ruedas.Size = new System.Drawing.Size(121, 20);
            this.nud_ruedas.TabIndex = 16;
            this.nud_ruedas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_cc
            // 
            this.nud_cc.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_cc.Location = new System.Drawing.Point(98, 32);
            this.nud_cc.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_cc.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_cc.Name = "nud_cc";
            this.nud_cc.Size = new System.Drawing.Size(120, 20);
            this.nud_cc.TabIndex = 1;
            this.nud_cc.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_cc.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Palanca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Traccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cantidad de Puertas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Precio";
            // 
            // nud_precio
            // 
            this.nud_precio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_precio.Location = new System.Drawing.Point(161, 79);
            this.nud_precio.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_precio.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(120, 20);
            this.nud_precio.TabIndex = 2;
            this.nud_precio.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // cmbx_palanca
            // 
            this.cmbx_palanca.FormattingEnabled = true;
            this.cmbx_palanca.Location = new System.Drawing.Point(96, 32);
            this.cmbx_palanca.Name = "cmbx_palanca";
            this.cmbx_palanca.Size = new System.Drawing.Size(121, 21);
            this.cmbx_palanca.TabIndex = 2;
            // 
            // cmbx_traccion
            // 
            this.cmbx_traccion.FormattingEnabled = true;
            this.cmbx_traccion.Location = new System.Drawing.Point(96, 122);
            this.cmbx_traccion.Name = "cmbx_traccion";
            this.cmbx_traccion.Size = new System.Drawing.Size(121, 21);
            this.cmbx_traccion.TabIndex = 3;
            // 
            // nud_puertas
            // 
            this.nud_puertas.Location = new System.Drawing.Point(161, 19);
            this.nud_puertas.Name = "nud_puertas";
            this.nud_puertas.Size = new System.Drawing.Size(120, 20);
            this.nud_puertas.TabIndex = 3;
            // 
            // dgv_res
            // 
            this.dgv_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_res.Location = new System.Drawing.Point(0, 0);
            this.dgv_res.Name = "dgv_res";
            this.dgv_res.Size = new System.Drawing.Size(831, 169);
            this.dgv_res.TabIndex = 0;
            // 
            // btn_moto
            // 
            this.btn_moto.Location = new System.Drawing.Point(126, 194);
            this.btn_moto.Name = "btn_moto";
            this.btn_moto.Size = new System.Drawing.Size(75, 23);
            this.btn_moto.TabIndex = 2;
            this.btn_moto.Text = "AGREGAR";
            this.btn_moto.UseVisualStyleBackColor = true;
            this.btn_moto.Click += new System.EventHandler(this.btn_moto_Click);
            // 
            // btn_auto
            // 
            this.btn_auto.Location = new System.Drawing.Point(142, 194);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(75, 23);
            this.btn_auto.TabIndex = 4;
            this.btn_auto.Text = "AGREGAR";
            this.btn_auto.UseVisualStyleBackColor = true;
            // 
            // btn_bus
            // 
            this.btn_bus.Location = new System.Drawing.Point(122, 184);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Size = new System.Drawing.Size(75, 23);
            this.btn_bus.TabIndex = 4;
            this.btn_bus.Text = "AGREGAR";
            this.btn_bus.UseVisualStyleBackColor = true;
            // 
            // frm_ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_ejercicio2";
            this.Text = "Ejercicio 2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabcrtl_todo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ruedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_puertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_res)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabcrtl_todo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_chasis;
        private System.Windows.Forms.TextBox txt_motor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_ruedas;
        private System.Windows.Forms.ComboBox cmbx_gas;
        private System.Windows.Forms.NumericUpDown nud_cc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbx_traccion;
        private System.Windows.Forms.ComboBox cmbx_palanca;
        private System.Windows.Forms.NumericUpDown nud_puertas;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.DataGridView dgv_res;
        private System.Windows.Forms.Button btn_moto;
        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.Button btn_bus;
    }
}

