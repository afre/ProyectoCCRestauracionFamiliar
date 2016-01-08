using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
   public class BDComun
    {
       public static SqlConnection ObtnerCOnexion()
       {

           SqlConnection Conn = new SqlConnection("Data source=DESKTOP-54H7VQA; Initial Catalog=CCRestauracionFamiliar; integrated security=true");
           //SqlConnection Conn = new SqlConnection("Data source=Frank-Pc; Initial Catalog=Escuela; User Id=sa; Password=3322");
           Conn.Open();

           return Conn;

       }


    }
}
