using System;
using System.Collections.Generic;

public class Persona
{
    public int _idPersona;

    private String _cedulaPersona;

    public String CedulaPersona
    {
        get { return _cedulaPersona; }
        set { _cedulaPersona = value; }
    }


    private String _nombrePersona;

    public String NombrePersona
    {
        get { return _nombrePersona; }
        set { _nombrePersona = value; }
    }

    private String _apellidoPersona;

    public String ApellidoPersona
    {
        get { return _apellidoPersona; }
        set { _apellidoPersona = value; }
    }

    private DateTime _fechaNacimientoPersona;

    public DateTime FechaNacmientoPersona
    {
        get { return _fechaNacimientoPersona; }
        set { _fechaNacimientoPersona = value; }
    }

    private int _edadPersona;
                    
    public int EdadPersona

    {
        get { return _edadPersona; }
        set { _edadPersona = value; }
    }



    private String _direccionPersona;

    public String DireccionPersona
    {
        get { return _direccionPersona; }
        set { _direccionPersona = value; }
    }

    private String _telefonoCasaPersona;
    public String TelefonoCasaPersona
    {
        get
        {
            return _telefonoCasaPersona;
        }

        set
        {
            _telefonoCasaPersona = value;
        }
    }

    private String _telefonoOficinaPersona;
    public String TelefonoOficinaPersona
    {
        get
        {
            return _telefonoOficinaPersona;
        }

        set
        {
            _telefonoOficinaPersona = value;
        }
    }


    private String _celularPersona;
    public String CelularPersona
    {
        get
        {
            return _celularPersona;
        }

        set
        {
            _celularPersona = value;
        }
    }

    private String _emailPersona;
    public String EmailPersona
    {
        get
        {
            return _emailPersona;
        }

        set
        {
            _emailPersona = value;
        }
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

