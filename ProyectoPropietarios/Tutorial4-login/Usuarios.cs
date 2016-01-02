using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tutorial4_login
{
    class Usuarios:conexion
    {
        private string usuario;
        private string contraseña;
        //private string modo;
        
        
        public Usuarios()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;
        }
        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }

        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }

        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT IDUSUARIO FROM USUARIO WHERE  NOMBREUSUARIO='{0}' AND  PASSWORDUSUARIO='{1}'", this.usuario, this.contraseña);
            this.comandosql = new SqlCommand(this.sql, this.cnn);
            try{


            this.cnn.Open();
                }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read())
            {
                //Resultado = true;
                Resultado = true;
                this.mensaje = "Bienvenido al sistema de la Iglesia Restauración Familiar";

            }
            else
            {
                this.mensaje = "Los datos ingresados son incorrectos, por favor verifique e intente de nuevo";
            }
            this.cnn.Close();
            return Resultado;
        }





        


    }
}
