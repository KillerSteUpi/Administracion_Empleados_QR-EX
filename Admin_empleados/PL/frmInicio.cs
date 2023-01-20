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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btntrabajador_Click(object sender, EventArgs e)
        {
            frmVista vista = new frmVista();
            vista.Show();
        }

        private void btnAdmi_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            frmLogin1 login1 = new frmLogin1();
            login1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
    }

