using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_empleados.BLL;
using Admin_empleados.DAL;
using Microsoft.Office.Interop.Excel;
using Admin_empleados.PL;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;


// NuGet Package Manager
namespace Admin_empleados.PL
{
    public partial class frmEmpleados : Form
    {
        EmpleadosDAL oEmpleadosDAL;
        byte[] imagenByte;
        public frmEmpleados()
        {
            oEmpleadosDAL = new EmpleadosDAL();
            InitializeComponent();
            LimpiarEntradas();
            LlenarGrid();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtSegundoApellido.Text == "" ||txtPrimerApellido.Text=="" || txtCorreo.Text== "" ||picFoto.Image==null)
            {

                MessageBox.Show("Llene todos los campos / Correo Incorrecto...");
            }
            else{
                MessageBox.Show("Guardado...");
                //oEmpleadosDAL.Agregar
                oEmpleadosDAL.Agregar(RecuperarInformacion());//el metodo recibe un objeto que tiene la informacion de la inter
                LlenarGrid();
                LimpiarEntradas();
            }
    }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DepartamentosDAL objDepartamentos = new DepartamentosDAL();//OBJETOS
            cbxDepartamento.DataSource = objDepartamentos.MostrarDepartamentos().Tables[0];
            cbxDepartamento.DisplayMember = "departamento";//MOSTRAMOS
            cbxDepartamento.ValueMember = "ID";
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorimagen = new OpenFileDialog();
            selectorimagen.Title = "Delecciona imagen";

            if (selectorimagen.ShowDialog()==DialogResult.OK){
                picFoto.Image = Image.FromStream(selectorimagen.OpenFile());

                MemoryStream memoria = new MemoryStream();
                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

                    imagenByte = memoria.ToArray();

               
            }
        }

        private EmpleadosBLL RecuperarInformacion(){

            EmpleadosBLL oEmpleadosBLL = new EmpleadosBLL();

            int codigoEmpleado = 0; int.TryParse(txtID.Text, out codigoEmpleado);

            oEmpleadosBLL.ID = codigoEmpleado;
            oEmpleadosBLL.NombreEmpleado = txtNombre.Text;
            oEmpleadosBLL.PrimerApellido = txtPrimerApellido.Text;
            oEmpleadosBLL.SegundoApellido = txtSegundoApellido.Text;
            oEmpleadosBLL.Correo = txtCorreo.Text;

            int IDDepartamento = 0;
            int.TryParse(cbxDepartamento.SelectedValue.ToString(),out IDDepartamento);

            oEmpleadosBLL.Departamento = IDDepartamento;

            oEmpleadosBLL.FotoEmpleado = imagenByte;

            return oEmpleadosBLL;
        }

        public void LimpiarEntradas()
        {

            txtID.Text = "";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreo.Text = "";
            picFoto.Image = null;

            btnExaminar.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificado...");
            oEmpleadosDAL.Modificar(RecuperarInformacion());
            LlenarGrid();
            LimpiarEntradas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrado...");
            oEmpleadosDAL.Eliminar(RecuperarInformacion());
            LlenarGrid();
            LimpiarEntradas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LlenarGrid();
            LimpiarEntradas();
        }
        public void LlenarGrid(){

            dgvEmpleados.DataSource = oEmpleadosDAL.MostrarEmpleados().Tables[0];
            
            dgvEmpleados.Columns[0].HeaderText = "ID";
            dgvEmpleados.Columns[1].HeaderText = "Nombre";
            dgvEmpleados.Columns[2].HeaderText = "Apellido Paterno";
            dgvEmpleados.Columns[3].HeaderText = "Apellido Materno";
            dgvEmpleados.Columns[4].HeaderText = "Correo";
            dgvEmpleados.Columns[5].HeaderText = "Foto";
    
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvEmpleados.ClearSelection();

            if (indice >= 0)
            {

                txtID.Text = dgvEmpleados.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.Rows[indice].Cells[1].Value.ToString();
            txtPrimerApellido.Text = dgvEmpleados.Rows[indice].Cells[2].Value.ToString();
            txtSegundoApellido.Text = dgvEmpleados.Rows[indice].Cells[3].Value.ToString();
            txtCorreo.Text = dgvEmpleados.Rows[indice].Cells[4].Value.ToString();

                MemoryStream ms = new MemoryStream((byte[])dgvEmpleados.CurrentRow.Cells[5].Value);
                picFoto.Image = Image.FromStream(ms);

            btnAgregar.Enabled = false;
            btnExaminar.Enabled = true;
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;

            }
        }
        
        public void ExportarDatos(DataGridView dgvEmpleados)
        {/*
            //creamos objeto de microsoft office 
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            //creamos nueva hoja de trabajo
            exportarexcel.Application.Workbooks.Add(true);

            //leer columnas
            int indicecolumnas = 0;

            foreach (DataGridViewColumn column in dgvEmpleados.Columns){//metimos columnas

                indicecolumnas++;

                exportarexcel.Cells[1, indicecolumnas] = column.Name;
                
            }

            int indicefila = 0;
            foreach (DataGridViewRow fila in dgvEmpleados.Rows) {

                indicefila++;

                indicecolumnas = 0;

                foreach (DataGridViewColumn column in dgvEmpleados.Columns)
                {
                    indicecolumnas++;
                 
                    exportarexcel.Cells[indicefila + 1, indicecolumnas] = fila.Cells[column.Name].Value;
                    exportarexcel.Visible = true;
                }
                
            }*/

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel(*.xls)|*.xls";
                saveFileDialog.FileName = "ArchivoExportado";

                if(saveFileDialog.ShowDialog()== DialogResult.OK) {
                    Microsoft.Office.Interop.Excel.Application application;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet Hoja_trabajo;
                    application = new Microsoft.Office.Interop.Excel.Application();

                    libros_trabajo = application.Workbooks.Add();

                    Hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
               
                for (int i=0; i < dgvEmpleados.Rows.Count - 1; i++ ){
                        for (int j = 0; j < dgvEmpleados.Columns.Count; j++){
                               if ((dgvEmpleados.Rows[i].Cells[j].Value==null)==false){

                                Hoja_trabajo.Cells[i + 1, j + 1] = dgvEmpleados.Rows[i].Cells[j].Value.ToString();

                               }


                        }

                    }

                    libros_trabajo.SaveAs(saveFileDialog.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    application.Quit();
                }
            }catch (Exception ex){
                MessageBox.Show("Fallo al guardar informacion"+ ex);

            }
        }
        

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvEmpleados);
        }
        //QR
        private void btnGenerarqr_Click(object sender, EventArgs e)
        {

            string cadena =  txtID.Text;
            string cadena1 = txtNombre.Text;
            string cadena2 = txtPrimerApellido.Text;
            string cadena3 = txtSegundoApellido.Text;
            string cadena4 = txtCorreo.Text;

            try {

                if (txtID.Text == "" || txtSegundoApellido.Text == "" || txtPrimerApellido.Text == "" || txtCorreo.Text == "" || txtCorreo.Text == "") {

                    MessageBox.Show("Llene todos los campos");
                }else {

                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 15;
                    Bitmap bmp = encoder.Encode(cadena +" " + cadena1+" " + cadena2+" "+cadena3+" "+ cadena4);

                    picQR.Image = bmp;


                    bmp.Save(@"D:\c#\Admin_empleados\QR"+cadena+".png", ImageFormat.Png);
                }

            }
            catch (Exception ex) {
               
               MessageBox.Show("Error al guardar"+ ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
         }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

