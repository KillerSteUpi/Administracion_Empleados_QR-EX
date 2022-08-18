using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Admin_empleados.BLL;
using Admin_empleados.DAL;
using System.Text.RegularExpressions;

namespace Admin_empleados.DAL
{
    class EmpleadosDAL{

        ConexionDAL conexion;

        public EmpleadosDAL() {
            conexion = new ConexionDAL();//constructor
        }

        public bool Agregar(EmpleadosBLL oEmpleadosBLL) {
            SqlCommand SQLComando = new SqlCommand("INSERT INTO Empleados VALUES (@nombres, @primerapellido, @segundoapellido, @correo, @foto)");
            //agregamos nombre
            SQLComando.Parameters.Add("@nombres", SqlDbType.VarChar).Value = oEmpleadosBLL.NombreEmpleado;
            SQLComando.Parameters.Add("@primerapellido", SqlDbType.VarChar).Value = oEmpleadosBLL.PrimerApellido;
            SQLComando.Parameters.Add("@segundoapellido", SqlDbType.VarChar).Value = oEmpleadosBLL.SegundoApellido;
            SQLComando.Parameters.Add("@correo", SqlDbType.VarChar).Value = oEmpleadosBLL.Correo;
            SQLComando.Parameters.Add("@foto", SqlDbType.Image).Value = oEmpleadosBLL.FotoEmpleado;


            return conexion.ejecutarComadoSinRetornoDatos(SQLComando); 
           
        }


        public bool Eliminar(EmpleadosBLL oEmpleadosBLL){

            SqlCommand SQLComando = new SqlCommand("DELETE FROM Empleados WHERE ID=@ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oEmpleadosBLL.ID;

            return conexion.ejecutarComadoSinRetornoDatos(SQLComando);

        }

        public bool Modificar(EmpleadosBLL oEmpleadosBLL){

            SqlCommand SQLComando = new SqlCommand("UPDATE Empleados SET Nombres=@nombres, Primerapellido=@primerapellido, Segundoapellido=@segundoapellido, Correo=@correo, Foto=@foto WHERE ID=@ID");
            SQLComando.Parameters.Add("@nombres", SqlDbType.VarChar).Value = oEmpleadosBLL.NombreEmpleado;
            SQLComando.Parameters.Add("@primerapellido", SqlDbType.VarChar).Value = oEmpleadosBLL.PrimerApellido;
            SQLComando.Parameters.Add("@segundoapellido", SqlDbType.VarChar).Value = oEmpleadosBLL.SegundoApellido;
            SQLComando.Parameters.Add("@correo", SqlDbType.VarChar).Value = oEmpleadosBLL.Correo;
            SQLComando.Parameters.Add("@foto", SqlDbType.Image).Value = oEmpleadosBLL.FotoEmpleado;
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oEmpleadosBLL.ID;
    
            return conexion.ejecutarComadoSinRetornoDatos(SQLComando);
    
        }


        public DataSet MostrarEmpleados()
        {

            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleados");

            return conexion.EjecutarSentencia(sentencia);

        }

        // se crea el método para validar el Email
        public bool Email_Valido(EmpleadosBLL oEmpleadosBLL) // Método para validar el Email ingresado
        {
            String validando;
            validando = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(oEmpleadosBLL.Correo, validando))
            {
                if (Regex.Replace(oEmpleadosBLL.Correo, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }
        }
    }
}
