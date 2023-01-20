namespace Admin_empleados.PL
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdmi = new System.Windows.Forms.Button();
            this.btnDep = new System.Windows.Forms.Button();
            this.btntrabajador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jefe de Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trabajador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jefe de Piso";
            // 
            // btnAdmi
            // 
            this.btnAdmi.Image = global::Admin_empleados.Properties.Resources._1820;
            this.btnAdmi.Location = new System.Drawing.Point(271, 57);
            this.btnAdmi.Name = "btnAdmi";
            this.btnAdmi.Size = new System.Drawing.Size(150, 150);
            this.btnAdmi.TabIndex = 4;
            this.btnAdmi.UseVisualStyleBackColor = true;
            this.btnAdmi.Click += new System.EventHandler(this.btnAdmi_Click);
            // 
            // btnDep
            // 
            this.btnDep.Image = global::Admin_empleados.Properties.Resources.images1;
            this.btnDep.Location = new System.Drawing.Point(271, 232);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(150, 150);
            this.btnDep.TabIndex = 5;
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btntrabajador
            // 
            this.btntrabajador.Image = global::Admin_empleados.Properties.Resources.descarga;
            this.btntrabajador.Location = new System.Drawing.Point(271, 409);
            this.btntrabajador.Name = "btntrabajador";
            this.btntrabajador.Size = new System.Drawing.Size(150, 150);
            this.btntrabajador.TabIndex = 6;
            this.btntrabajador.UseVisualStyleBackColor = true;
            this.btntrabajador.Click += new System.EventHandler(this.btntrabajador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inicio";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(-1, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_empleados.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(450, 566);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntrabajador);
            this.Controls.Add(this.btnDep);
            this.Controls.Add(this.btnAdmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdmi;
        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.Button btntrabajador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}