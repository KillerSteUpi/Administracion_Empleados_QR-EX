using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_empleados.PL
{
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmDep2 frmDep2 = new frmDep2();
           // Form1 form1 = new Form1();

            //oLoginDAL.Logueo(RecuperarInformacion());
            if (txtusuario.Text == "JefeDepartamento" && txtContraseña.Text == "789")
            {
                //form1.Show();
                
                frmDep2.Show();
                this.DialogResult = DialogResult.OK;
                LimpiarEntradas();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Usuario / Contraseña incorrecta");
                this.DialogResult = DialogResult.None;
                LimpiarEntradas();
            }
        }

        public void LimpiarEntradas()
        {
            txtusuario.Text = "";
            txtContraseña.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
