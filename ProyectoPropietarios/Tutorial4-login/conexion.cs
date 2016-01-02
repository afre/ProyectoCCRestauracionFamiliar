using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tutorial4_login
{
    class conexion
    {
        public string cadenaconexion;
        protected string sql;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;
        protected string mensaje;
        protected SqlDataReader dr;

        
        

        public conexion()
        {
           

                this.cadenaconexion = ("Data Source=LEONARDO;Initial Catalog = IgRestauraciónFamiliar; integrated security=true");
                this.cnn = new SqlConnection(this.cadenaconexion);

            
            

        }

       /* public void llenarItems(ComboBox cb)
        {
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
        }*/
      
       
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }

    }
}
