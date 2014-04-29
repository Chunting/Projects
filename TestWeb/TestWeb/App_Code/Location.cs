using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for Location
/// </summary>
public class Location:ConfigurationElement
{
	public Location()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [ConfigurationProperty("computer", IsRequired = true)]
    public string Computer
    {
        get { return (string)base["computer"]; }
        set { base["computer"] = value; }
    }

    [ConfigurationProperty("port", IsRequired = true)]
    public int Port
    {
        get { return (int)base["port"]; }
        set { base["port"] = value; }
    }

    [ConfigurationProperty("endpoint", IsRequired = true)]
    public string Endpoint
    {
        get { return (string)base["endpoint"]; }
        set { base["endpoint"] = value; }
    }

}