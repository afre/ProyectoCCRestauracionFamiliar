using System;
using System.Collections.Generic;

public class Opciones
{
	public int idOpciones;

    //private String nombreOpciones;

    private String _nombreOpciones;
    

    public String NombreOpciones
    {
        get { return _nombreOpciones; }
        set { _nombreOpciones = value; }
    }
    

    public IList<Object> crearOpciones()
	{
		return null;
	}

	public IList<Object> consultarOpciones()
	{
		return null;
	}

	public IList<Object> modificarOpciones()
	{
		return null;
	}

}

