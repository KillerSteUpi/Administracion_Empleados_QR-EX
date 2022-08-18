using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Admin_empleados.DAL
{
    class ConexionDAL
    {

        public string CadenaConexion = "Data Source=DESKTOP-261EV9R; Initial Catalog=dbSis_Empleados; Integrated Security=True";//variable para conectarme directamente a la base de datos
        SqlConnection Conexion;//Declaracion de un objeto

        public SqlConnection EstablecerConexion(){ //declaramos el metodo que se conente todo el tiempo con la cadena de conexion 
           /*objeto*/this.Conexion = new SqlConnection(this.CadenaConexion); //hacemos referencia a la conexion
                                          /*instancia*/

            return this.Conexion; //retornamos conexion
        }

        //Metodo de insertar borrar y modificar se ejecute;
        public bool ejecutarComadoSinRetornoDatos(string strComando){//recibe parametro comando
           
            try //obtencion de errores
            {

                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = strComando;
                Comando.Connection = this.EstablecerConexion();//Permitir la conexion a la base de datos utilizando el metodo Establecer conecion
                Conexion.Open(); //conexion abierta 
                Comando.ExecuteNonQuery(); //devuelve el número de filas afectadas.
                Conexion.Close();//Conexion cerrada

                return true;
            }catch
            {
                return false;
            }

        }
        //sobre carga 2 metodos con el mismo nombre PASAMOS ARGUMENTO DIFERENTE
        
        public bool ejecutarComadoSinRetornoDatos(SqlCommand SQLComando) //Hicimos la sobrecarga porque le pasamos un argumento diferente
        {//recibe parametro comando

            try
            {
                SqlCommand Comando = SQLComando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }


        // Retorno de datos de tipo select

        public DataSet EjecutarSentencia(SqlCommand sqlComando){ //

            DataSet Ds = new DataSet(); //Almacenar toda la informacion
            SqlDataAdapter adaptador = new SqlDataAdapter(); //adaptamos el contenido recuperar y guardar datos.


            try
            {


                SqlCommand Comando = new SqlCommand(); //Comando
                Comando = sqlComando; //crea un comando sql pero le asigna la sentancia a comando
                Comando.Connection = EstablecerConexion();
                adaptador.SelectCommand = Comando;//procedimiento de almacenado
                Conexion.Open(); //
                adaptador.Fill(Ds);//llenado de adaptador Agrega o actualiza filas en el DataSet para que coincidan con las del origen de datos.
                Conexion.Close();
                return Ds;//retorno de la informacion
                
                
            }
            catch
            {
                return Ds; 
            }
        }
    }
}
