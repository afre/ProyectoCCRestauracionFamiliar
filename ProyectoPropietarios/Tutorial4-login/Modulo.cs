using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tutorial4_login
{
     
    class Modulo : conexion
    {
        public bool Resultado1;
        private string modulo;
        //private string contraseña;
        //private string modo;


        public Modulo()
        {
            modulo = string.Empty;
            //contraseña = string.Empty;
            this.sql = string.Empty;
        }
        public string Modulos
        {
            get { return this.modulo; }
            set { this.modulo = value; }

        }
        //public string Contraseña
        //{
           // get { return this.contraseña; }
         //   set { this.contraseña = value; }

       // }
        //public bool Llena()
        //{
          
         //   return Resultado1;
       // }
        
        public void llenarItems(ComboBox cb)
        {

           // bool Resultado1 = false;
            try
            {


                this.cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                comandosql = new SqlCommand("Select NOMBREMODULO from MODULO", cnn);
                dr = comandosql.ExecuteReader();
                cb.Items.Add("Seleccione una Opción");
                while (dr.Read())
                {
                    cb.Items.Add(dr["NOMBREMODULO"].ToString());
                }

                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }
        

        /*
        public bool Buscar()
        {
            bool Resultado1 = false;
            this.sql = string.Format(@"Select NOMBREMODULO from MODULO", this.modulo);
            this.comandosql = new SqlCommand(this.sql, this.cnn);
            try
            {
                this.cnn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read())
            {
                //Resultado = true;
                Resultado1 = true;
               // this.mensaje = "Bienvenido al sistema de la Iglesia Restauración Familiar";
            }
            else
            {
                this.mensaje = "Debe seleccionar una opción, por favor verifique e intente de nuevo";
            }
            this.cnn.Close();
            return Resultado1;
        }


        */





    }
}
