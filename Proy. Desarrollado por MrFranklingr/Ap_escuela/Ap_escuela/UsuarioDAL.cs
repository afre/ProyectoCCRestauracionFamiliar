using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Ap_escuela
{
    class UsuarioDAL
    {

        public static int CrearCuentas(string pUsuario, string pContraseña, string textBox1, string textBox2)
        //public static int CrearCuentas(string pUsuario, string pContraseña)
            {

                int resultado = 0;
               
                    SqlConnection Conn = BDComun.ObtnerCOnexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (idUsuario, nombreUsuario, passwordUsuario,idPersona ) values ({0},'{1}','{2}',{3} )", pUsuario, pContraseña, textBox1, textBox2), Conn);
            // SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (idUsuario, nombreUsuario, passwordUsuario,idPersona ) values (textBox1.Text,'Jun', '123',textBox2.Text )", pUsuario, pContraseña), Conn);
            // SqlDataAdapter writter = Comando.ExecuteReader();
            Console.WriteLine("esperemos que valga");
            resultado = Comando.ExecuteNonQuery();
            Conn.Close();

            /*try
           {
              SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (idUsuario, nombreUsuario, passwordUsuario,idPersona ) values ({0},{1}, PwdEncrypt({2}),{3} )", int.Parse(textBox1), pUsuario, pContraseña, int.Parse(textBox2)), Conn);
               // SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (idUsuario, nombreUsuario, passwordUsuario,idPersona ) values (textBox1.Text,'Jun', '123',textBox2.Text )", pUsuario, pContraseña), Conn);
               // SqlDataAdapter writter = Comando.ExecuteReader();
               Console.WriteLine("esperemos que valga");
               resultado = Comando.ExecuteNonQuery();
               Conn.Close();
            }*/

            // catch{

            // }
            return resultado;
            }



        public static int Autentificar(String pUsuarios, String pContraseña)
        {
            int resultado = -1;
           
                SqlConnection conexion = BDComun.ObtnerCOnexion();

                SqlCommand comando = new SqlCommand(string.Format(
                    "Select * From Usuario Where nombreUsuario = '{0}' and   passwordUsuario='{1}' ", pUsuarios, pContraseña), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    resultado = 50;
                }

                conexion.Close();
                
            
           
            return resultado;
        }


        public void llenarItems(ComboBox cb)
        {

            // bool Resultado1 = false;
          try
            {


                SqlConnection conexion = BDComun.ObtnerCOnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                SqlConnection conexion = BDComun.ObtnerCOnexion();
                SqlCommand comando = new SqlCommand("Select nombreModulo from Modulo ORDER BY nombreModulo ASC ", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                
                cb.Items.Add("Seleccione una Opción");

                while (reader.Read())
                {
                    cb.Items.Add(reader["nombreModulo"].ToString());
                }

                cb.SelectedIndex = 0;

                reader.Close();
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }





        }
        public void autoCompletar(TextBox textBox1)
        {

            /*
            string sql = @"SELECT idUsuario FROM Usuario WHERE idUsuario=(SELECT max(idUsuario) FROM Usuario)";
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand command = new SqlCommand(sql, conexion);
                //conexion.Open();
                string codmax = Convert.ToString(command.ExecuteScalar());
                int cod = Convert.ToInt32(codmax) + 1;
                textBox1.Text = Convert.ToString(cod);
            }

*/

            try
            {


                SqlConnection conexion = BDComun.ObtnerCOnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

            try
            {
                SqlConnection conexion = BDComun.ObtnerCOnexion();
                SqlCommand comando = new SqlCommand("SELECT idUsuario FROM Usuario WHERE idUsuario=(SELECT max(idUsuario) FROM Usuario)", conexion);
              
                    string codmax = Convert.ToString(comando.ExecuteScalar());
                    int cod = Convert.ToInt32(codmax) + 1;
                   textBox1.Text = Convert.ToString(cod);
                    
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el TextBox: " + ex.ToString());
            }

            

        }



    }
}
