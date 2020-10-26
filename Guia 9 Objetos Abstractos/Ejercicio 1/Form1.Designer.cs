namespace Ejemplo_1
{
    partial class frm_ejercicio1
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
            this.tabctrl_1 = new System.Windows.Forms.TabControl();
            this.tabpageCuadrado = new System.Windows.Forms.TabPage();
            this.lbl_respuesta = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_lado = new System.Windows.Forms.TextBox();
            this.lbl_lado = new System.Windows.Forms.Label();
            this.tabpageCirculo = new System.Windows.Forms.TabPage();
            this.lbl_Respuestac = new System.Windows.Forms.Label();
            this.btn_calcularc = new System.Windows.Forms.Button();
            this.txt_radio = new System.Windows.Forms.TextBox();
            this.lbl_radio = new System.Windows.Forms.Label();
            this.tabPagerombo = new System.Windows.Forms.TabPage();
            this.lbl_d1 = new System.Windows.Forms.Label();
            this.lbl_d2 = new System.Windows.Forms.Label();
            this.txt_d1 = new System.Windows.Forms.TextBox();
            this.txt_d2 = new System.Windows.Forms.TextBox();
            this.lbl_resultadoR = new System.Windows.Forms.Label();
            this.btn_calculorombo = new System.Windows.Forms.Button();
            this.tabctrl_1.SuspendLayout();
            this.tabpageCuadrado.SuspendLayout();
            this.tabpageCirculo.SuspendLayout();
            this.tabPagerombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrl_1
            // 
            this.tabctrl_1.Controls.Add(this.tabpageCuadrado);
            this.tabctrl_1.Controls.Add(this.tabpageCirculo);
            this.tabctrl_1.Controls.Add(this.tabPagerombo);
            this.tabctrl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrl_1.Location = new System.Drawing.Point(0, 0);
            this.tabctrl_1.Name = "tabctrl_1";
            this.tabctrl_1.SelectedIndex = 0;
            this.tabctrl_1.Size = new System.Drawing.Size(800, 450);
            this.tabctrl_1.TabIndex = 0;
            // 
            // tabpageCuadrado
            // 
            this.tabpageCuadrado.Controls.Add(this.lbl_respuesta);
            this.tabpageCuadrado.Controls.Add(this.btn_calcular);
            this.tabpageCuadrado.Controls.Add(this.txt_lado);
            this.tabpageCuadrado.Controls.Add(this.lbl_lado);
            this.tabpageCuadrado.Location = new System.Drawing.Point(4, 22);
            this.tabpageCuadrado.Name = "tabpageCuadrado";
            this.tabpageCuadrado.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCuadrado.Size = new System.Drawing.Size(792, 424);
            this.tabpageCuadrado.TabIndex = 0;
            this.tabpageCuadrado.Text = "Cuadrado";
            this.tabpageCuadrado.UseVisualStyleBackColor = true;
            // 
            // lbl_respuesta
            // 
            this.lbl_respuesta.AutoSize = true;
            this.lbl_respuesta.Location = new System.Drawing.Point(69, 112);
            this.lbl_respuesta.Name = "lbl_respuesta";
            this.lbl_respuesta.Size = new System.Drawing.Size(0, 13);
            this.lbl_respuesta.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(538, 264);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(90, 30);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_lado
            // 
            this.txt_lado.Location = new System.Drawing.Point(133, 60);
            this.txt_lado.Name = "txt_lado";
            this.txt_lado.Size = new System.Drawing.Size(100, 20);
            this.txt_lado.TabIndex = 1;
            // 
            // lbl_lado
            // 
            this.lbl_lado.AutoSize = true;
            this.lbl_lado.Location = new System.Drawing.Point(66, 68);
            this.lbl_lado.Name = "lbl_lado";
            this.lbl_lado.Size = new System.Drawing.Size(31, 13);
            this.lbl_lado.TabIndex = 0;
            this.lbl_lado.Text = "Lado";
            // 
            // tabpageCirculo
            // 
            this.tabpageCirculo.Controls.Add(this.lbl_Respuestac);
            this.tabpageCirculo.Controls.Add(this.btn_calcularc);
            this.tabpageCirculo.Controls.Add(this.txt_radio);
            this.tabpageCirculo.Controls.Add(this.lbl_radio);
            this.tabpageCirculo.Location = new System.Drawing.Point(4, 22);
            this.tabpageCirculo.Name = "tabpageCirculo";
            this.tabpageCirculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCirculo.Size = new System.Drawing.Size(792, 424);
            this.tabpageCirculo.TabIndex = 1;
            this.tabpageCirculo.Text = "Circulo";
            this.tabpageCirculo.UseVisualStyleBackColor = true;
            // 
            // lbl_Respuestac
            // 
            this.lbl_Respuestac.AutoSize = true;
            this.lbl_Respuestac.Location = new System.Drawing.Point(51, 118);
            this.lbl_Respuestac.Name = "lbl_Respuestac";
            this.lbl_Respuestac.Size = new System.Drawing.Size(0, 13);
            this.lbl_Respuestac.TabIndex = 5;
            // 
            // btn_calcularc
            // 
            this.btn_calcularc.Location = new System.Drawing.Point(441, 245);
            this.btn_calcularc.Name = "btn_calcularc";
            this.btn_calcularc.Size = new System.Drawing.Size(90, 30);
            this.btn_calcularc.TabIndex = 4;
            this.btn_calcularc.Text = "CALCULAR";
            this.btn_calcularc.UseVisualStyleBackColor = true;
            this.btn_calcularc.Click += new System.EventHandler(this.btn_calcularc_Click);
            // 
            // txt_radio
            // 
            this.txt_radio.Location = new System.Drawing.Point(118, 58);
            this.txt_radio.Name = "txt_radio";
            this.txt_radio.Size = new System.Drawing.Size(100, 20);
            this.txt_radio.TabIndex = 3;
            // 
            // lbl_radio
            // 
            this.lbl_radio.AutoSize = true;
            this.lbl_radio.Location = new System.Drawing.Point(51, 66);
            this.lbl_radio.Name = "lbl_radio";
            this.lbl_radio.Size = new System.Drawing.Size(35, 13);
            this.lbl_radio.TabIndex = 2;
            this.lbl_radio.Text = "Radio";
            // 
            // tabPagerombo
            // 
            this.tabPagerombo.Controls.Add(this.btn_calculorombo);
            this.tabPagerombo.Controls.Add(this.lbl_resultadoR);
            this.tabPagerombo.Controls.Add(this.txt_d2);
            this.tabPagerombo.Controls.Add(this.txt_d1);
            this.tabPagerombo.Controls.Add(this.lbl_d2);
            this.tabPagerombo.Controls.Add(this.lbl_d1);
            this.tabPagerombo.Location = new System.Drawing.Point(4, 22);
            this.tabPagerombo.Name = "tabPagerombo";
            this.tabPagerombo.Size = new System.Drawing.Size(792, 424);
            this.tabPagerombo.TabIndex = 2;
            this.tabPagerombo.Text = "Rombo";
            this.tabPagerombo.UseVisualStyleBackColor = true;
            // 
            // lbl_d1
            // 
            this.lbl_d1.AutoSize = true;
            this.lbl_d1.Location = new System.Drawing.Point(57, 47);
            this.lbl_d1.Name = "lbl_d1";
            this.lbl_d1.Size = new System.Drawing.Size(81, 13);
            this.lbl_d1.TabIndex = 0;
            this.lbl_d1.Text = "Diagonal Mayor";
            // 
            // lbl_d2
            // 
            this.lbl_d2.AutoSize = true;
            this.lbl_d2.Location = new System.Drawing.Point(60, 108);
            this.lbl_d2.Name = "lbl_d2";
            this.lbl_d2.Size = new System.Drawing.Size(82, 13);
            this.lbl_d2.TabIndex = 1;
            this.lbl_d2.Text = "Diagonal Menor";
            // 
            // txt_d1
            // 
            this.txt_d1.Location = new System.Drawing.Point(159, 47);
            this.txt_d1.Name = "txt_d1";
            this.txt_d1.Size = new System.Drawing.Size(100, 20);
            this.txt_d1.TabIndex = 2;
            // 
            // txt_d2
            // 
            this.txt_d2.Location = new System.Drawing.Point(159, 108);
            this.txt_d2.Name = "txt_d2";
            this.txt_d2.Size = new System.Drawing.Size(100, 20);
            this.txt_d2.TabIndex = 3;
            // 
            // lbl_resultadoR
            // 
            this.lbl_resultadoR.AutoSize = true;
            this.lbl_resultadoR.Location = new System.Drawing.Point(159, 176);
            this.lbl_resultadoR.Name = "lbl_resultadoR";
            this.lbl_resultadoR.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultadoR.TabIndex = 4;
            // 
            // btn_calculorombo
            // 
            this.btn_calculorombo.Location = new System.Drawing.Point(386, 201);
            this.btn_calculorombo.Name = "btn_calculorombo";
            this.btn_calculorombo.Size = new System.Drawing.Size(75, 23);
            this.btn_calculorombo.TabIndex = 5;
            this.btn_calculorombo.Text = "CALCULAR";
            this.btn_calculorombo.UseVisualStyleBackColor = true;
            this.btn_calculorombo.Click += new System.EventHandler(this.btn_calculorombo_Click);
            // 
            // frm_ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabctrl_1);
            this.Name = "frm_ejercicio1";
            this.Text = "Ejercicio 1";
            this.tabctrl_1.ResumeLayout(false);
            this.tabpageCuadrado.ResumeLayout(false);
            this.tabpageCuadrado.PerformLayout();
            this.tabpageCirculo.ResumeLayout(false);
            this.tabpageCirculo.PerformLayout();
            this.tabPagerombo.ResumeLayout(false);
            this.tabPagerombo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrl_1;
        private System.Windows.Forms.TabPage tabpageCuadrado;
        private System.Windows.Forms.Label lbl_respuesta;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_lado;
        private System.Windows.Forms.Label lbl_lado;
        private System.Windows.Forms.TabPage tabpageCirculo;
        private System.Windows.Forms.Label lbl_Respuestac;
        private System.Windows.Forms.Button btn_calcularc;
        private System.Windows.Forms.TextBox txt_radio;
        private System.Windows.Forms.Label lbl_radio;
        private System.Windows.Forms.TabPage tabPagerombo;
        private System.Windows.Forms.Button btn_calculorombo;
        private System.Windows.Forms.Label lbl_resultadoR;
        private System.Windows.Forms.TextBox txt_d2;
        private System.Windows.Forms.TextBox txt_d1;
        private System.Windows.Forms.Label lbl_d2;
        private System.Windows.Forms.Label lbl_d1;
    }
}

