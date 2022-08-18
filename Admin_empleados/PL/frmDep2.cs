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
    public partial class frmDep2 : Form
    {
        public frmDep2()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmDepartamentos frmDepartamentos = new frmDepartamentos();
            frmDepartamentos.Show();
        }

        private void btnTablas_Click(object sender, EventArgs e)
        {
            frmVista frmVista = new frmVista();
            frmVista.Show();
        }
    }
}
