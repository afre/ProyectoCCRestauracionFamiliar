using System;
using System.Collections.Generic;

public class Persona
{
    private String _cedulaPersona;

    public String cedulaPersona
    {
        get { return _cedulaPersona; }
        set { _cedulaPersona = value; }
    }


    private String _nombrePersona;

    public String nombrePersona
    {
        get { return _nombrePersona; }
        set { _nombrePersona = value; }
    }

    private String _apellidoPersona;

    public String apellidoPersona
    {
        get { return _apellidoPersona; }
        set { _apellidoPersona = value; }
    }

    private DateTime _fechaNacimientoPersona;

    public DateTime fechaNacmientoPersona
    {
        get { return _fechaNacimientoPersona; }
        set { _fechaNacimientoPersona = value; }
    }

    private int _edadPersona;
                    
    public int edadPersona

    {
        get { return _edadPersona; }
        set { _edadPersona = value; }
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

