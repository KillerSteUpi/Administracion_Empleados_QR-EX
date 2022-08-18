using Admin_empleados.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_empleados.BLL;
using System.Data.SqlClient;



namespace Admin_empleados.PL
{
    public partial class frmLogin : Form
    {
        LoginDAL oLoginDAL;
        public frmLogin()
        {
            oLoginDAL = new LoginDAL();
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
           


            //oLoginDAL.Logueo(RecuperarInformacion());
            if (txtusuario.Text == "JefePiso" && txtContraseña.Text == "456")
            {
               
               
                form1.Show();
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
        /*
        private LoginBLL RecuperarInformacion() {
            LoginBLL oLoginBLL = new LoginBLL();
            oLoginBLL.Usuario = txtusuario.Text;
            oLoginBLL.contraseña = txtContraseña.Text;
            return oLoginBLL;
        }
        */
        public void LimpiarEntradas()
        {
            txtusuario.Text = "";
            txtContraseña.Text = "";
   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

