using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Catalogo
{
    public int idCatalogo;

    private String _nombreCatalogo;

    public String nombreCatalogo
    {
        get { return _nombreCatalogo; }
        set { _nombreCatalogo = value; }
    }

    public IList<Object> crearCatalogo()
    {
        return null;
    }

    public IList<Object> consultarCatalogo()
    {
        return null;
    }

    public IList<Object> modificarCatalogo()
    {
        return null;
    }

}

