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
        private string _nombreUsuario;
        private string _passwordUsuario;
        //private string modo;
        
        
        public Usuarios()
        {
            _nombreUsuario = string.Empty;
            _passwordUsuario = string.Empty;
            this.sql = string.Empty;
        }
        public string NombreUsuario
        {
            get { return this._nombreUsuario; }
            set { this._nombreUsuario = value; }

        }
        public string PasswordUsuario
        {
            get { return this._passwordUsuario; }
            set { this._passwordUsuario = value; }

        }

        public IList<Object> crearUsuario()
        {
            return null;
        }

        public IList<Object> consultarUsuario()
        {
            return null;
        }

        public IList<Object> modificarUsuario()
        {
            return null;
        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT IDUSUARIO FROM USUARIO WHERE  NOMBREUSUARIO='{0}' AND  PASSWORDUSUARIO='{1}'", this._nombreUsuario, this._passwordUsuario);
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
