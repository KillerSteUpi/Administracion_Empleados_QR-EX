using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Admin_empleados.BLL;
using Admin_empleados.PL;
using Admin_empleados.DAL;
using System.Windows.Forms;


namespace Admin_empleados.DAL
{
    class LoginDAL{


        ConexionDAL conexion;

        public LoginDAL(){
            conexion = new ConexionDAL();//constructor
        }

        /*
        public bool Logueo (LoginBLL oLoginBLL){

            
                SqlCommand SQLComando = new SqlCommand("SELECT nombres, tipo_usuario FROM Usuario=@usuario AND Contraseña=@contraseña");
                SQLComando.Parameters.Add("@usuario",SqlDbType.VarChar).Value= oLoginBLL.Usuario;
                SQLComando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value=oLoginBLL.contraseña;
                conexion.ejecutarComadoSinRetornoDatos(SQLComando);
                SqlDataAdapter sda = new SqlDataAdapter(SQLComando);
                DataTable dt = new DataTable();
                sda.Fill(dt);//https://stackoverflow.com/questions/54843315/system-data-sqlclient-sqlexception-incorrect-syntax-near
            if (dt.Rows.Count==1) {
                
                    
                    if (dt.Rows[0][1].ToString() == "admin"){//fila y columna

                        new Form1().Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario"){

                        new frmDepartamentos().Show();

                    }

                }
                else {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }

            return true;
        }
        */

        public bool Logueo(LoginBLL oLoginBLL)
        {


            SqlCommand SQLComando = new SqlCommand("SELECT Usuario=@usuario AND Contraseña=@contraseña FROM Acceso ");
            SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = oLoginBLL.Usuario;
            SQLComando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = oLoginBLL.contraseña;
            conexion.ejecutarComadoSinRetornoDatos(SQLComando);
            SqlDataReader dr = SQLComando.ExecuteReader();
            if(dr.Read()){

                MessageBox.Show("Bienvenido");
                new Form1().Show();
            }else{

                MessageBox.Show("Usuario / Contraseña Invalido");

            }
            return conexion.ejecutarComadoSinRetornoDatos(SQLComando);
        }
    }
}
