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
namespace Admin_empleados.PL
{
    public partial class frmDepartamentos : Form
    {

        DepartamentosDAL oDepartamentosDAL; //creamos el objeto
        public frmDepartamentos()
        {
            oDepartamentosDAL = new DepartamentosDAL();//instanceamos el objeto
            InitializeComponent();
            LlenarGrid();
            LimpiarEntradas();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //iNFORMACION DE LA INTERFAZ
            //RecuperarInformacion();
            //ConexionDAL conexion = new ConexionDAL();
            //conexion.PruebaConectar();//retorna boleano
            
            if(txtNombreDepartamento.Text==""){
                MessageBox.Show("Llena el campo faltante...");
            }else{

                MessageBox.Show("Guardado...");
            oDepartamentosDAL.Agregar(RecuperarInformacion());//el metodo recibe un objeto que tiene la informacion de la inter
            LlenarGrid();
            LimpiarEntradas();
            }
        }

        private DepartamentoBLL RecuperarInformacion(){
            //Crea una instancia utilizando clase dpartamento
            DepartamentoBLL oDepartamentoBLL = new DepartamentoBLL(); //creramos objeto

            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamentoBLL.ID = ID;

            oDepartamentoBLL.Departamento = txtNombreDepartamento.Text;

            return oDepartamentoBLL;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvDepartamentos.ClearSelection();

            if( indice>=0 )
            {

            txtID.Text = dgvDepartamentos.Rows[indice].Cells[0].Value.ToString();
            txtNombreDepartamento.Text = dgvDepartamentos.Rows[indice].Cells[1].Value.ToString();

            btnAgregar.Enabled = false;
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;


            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrado...");
            oDepartamentosDAL.Eliminar(RecuperarInformacion());
            LlenarGrid();
            LimpiarEntradas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificado...");
            oDepartamentosDAL.Modificar(RecuperarInformacion());
            LlenarGrid();
            LimpiarEntradas();
        }

        public void LlenarGrid(){
            
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];

            dgvDepartamentos.Columns[0].HeaderText="ID";
            dgvDepartamentos.Columns[1].HeaderText = "Nombre Departamentos";
        }

        public void LimpiarEntradas(){

            txtID.Text = "";
            txtNombreDepartamento.Text = "";

            btnAgregar.Enabled = true;
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {

        }
    }
  
}
