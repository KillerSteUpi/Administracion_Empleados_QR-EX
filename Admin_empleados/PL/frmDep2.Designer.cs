namespace Admin_empleados.PL
{
    partial class frmDep2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDep2));
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnTablas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleados.Image = global::Admin_empleados.Properties.Resources.departamentos;
            this.btnEmpleados.Location = new System.Drawing.Point(37, 45);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(362, 149);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Departamentos";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnTablas
            // 
            this.btnTablas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTablas.Image = global::Admin_empleados.Properties.Resources._2770619;
            this.btnTablas.Location = new System.Drawing.Point(37, 233);
            this.btnTablas.Margin = new System.Windows.Forms.Padding(5);
            this.btnTablas.Name = "btnTablas";
            this.btnTablas.Size = new System.Drawing.Size(362, 149);
            this.btnTablas.TabIndex = 1;
            this.btnTablas.Text = "Tablas";
            this.btnTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTablas.UseVisualStyleBackColor = false;
            this.btnTablas.Click += new System.EventHandler(this.btnTablas_Click);
            // 
            // frmDep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_empleados.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(454, 416);
            this.Controls.Add(this.btnTablas);
            this.Controls.Add(this.btnEmpleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDep2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBienvenida2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnTablas;
    }
}