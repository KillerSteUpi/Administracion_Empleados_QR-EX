using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Admin_empleados.BLL;
using Admin_empleados.DAL;
namespace Admin_empleados.DAL
{
    class DepartamentosDAL
    {
        ConexionDAL conexion;

        public DepartamentosDAL()
        {
            conexion = new ConexionDAL();//constructor
        }

        public bool Agregar(DepartamentoBLL oDepartamentoBLL){

            //pasar parametros de sql

            SqlCommand SQLComando = new SqlCommand("INSERT INTO Departamentos VALUES ( @departamento)");
            SQLComando.Parameters.Add("@departamento",SqlDbType.VarChar).Value= oDepartamentoBLL.Departamento;

            return conexion.ejecutarComadoSinRetornoDatos(SQLComando);
            //return conexion.ejecutarComadoSinRetornoDatos("INSERT INTO Departamentos(departamento) VALUES('"+oDepartamentoBLL.Departamento+"')");

            
           
        }
        public bool Eliminar(DepartamentoBLL oDepartamentoBLL){

            SqlCommand SQLComando = new SqlCommand("DELETE FROM Departamentos WHERE ID=@ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartamentoBLL.ID;

            return conexion.ejecutarComadoSinRetornoDatos(SQLComando);

            // conexion.ejecutarComadoSinRetornoDatos("DELETE FROM Departamentos WHERE ID="+oDepartamentoBLL.ID);
            //return 1;

        }

        public bool Modificar(DepartamentoBLL oDepartamentoBLL){

            SqlCommand SQLComando = new SqlCommand("UPDATE Departamentos SET departamento=@Departamento WHERE ID=@ID ");
            SQLComando.Parameters.Add("@Departamento", SqlDbType.VarChar).Value = oDepartamentoBLL.Departamento;
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartamentoBLL.ID;
            return conexion.ejecutarComadoSinRetornoDatos(SQLComando);
            //int retorno = 0;
            // conexion.ejecutarComadoSinRetornoDatos("UPDATE Departamentos"+ 
            //   "SET departamento ='" + oDepartamentoBLL.Departamento+ "' " +
            // "WHERE ID="+oDepartamentoBLL.ID);

            //SqlCommand sentencia = new SqlCommand(string.Format("UPDATE Departamentos" + "SET departamento ='" + oDepartamentoBLL.Departamento + "' " + "WHERE ID=" + oDepartamentoBLL.ID));
            //return 1;
            //retorno = sentencia.ExecuteNonQuery();

        }



        public DataSet MostrarDepartamentos(){

            SqlCommand sentencia = new SqlCommand("SELECT * FROM Departamentos");

            return conexion.EjecutarSentencia(sentencia);
            
        }

       
    }
}

