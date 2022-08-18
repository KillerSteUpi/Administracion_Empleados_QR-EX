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
using Admin_empleados.DAL;
using Admin_empleados.PL;

namespace Admin_empleados.PL
{
    public partial class frmVista : Form
    {
        DepartamentosDAL oDepartamentosDAL; //creamos el objeto
        EmpleadosDAL oEmpleadosDAL;
        public frmVista()
        {
            oDepartamentosDAL = new DepartamentosDAL();//instanceamos el objeto
            oEmpleadosDAL = new EmpleadosDAL();

            InitializeComponent();
            LlenarGrid();
        }


        public void LlenarGrid()
        {

            dgvVista.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];

            dgvVista.Columns[0].HeaderText = "ID";
            dgvVista.Columns[1].HeaderText = "Nombre Departamentos";

            dgvEmpleados.DataSource = oEmpleadosDAL.MostrarEmpleados().Tables[0];

            dgvEmpleados.Columns[0].HeaderText = "ID";
            dgvEmpleados.Columns[1].HeaderText = "Nombre";
            dgvEmpleados.Columns[2].HeaderText = "Apellido Paterno";
            dgvEmpleados.Columns[3].HeaderText = "Apellido Materno";
            dgvEmpleados.Columns[4].HeaderText = "Correo";
            dgvEmpleados.Columns[5].HeaderText = "Foto";

        }

        private void dgvVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVista_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
