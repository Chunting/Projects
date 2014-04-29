using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for OrderService
/// </summary>
public class OrderService:ConfigurationSection
{
	public OrderService()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [ConfigurationProperty("available", IsRequired = false)]
    public bool Available
    {
        get { return (bool)base["available"]; }
        set { base["available"] = value; }
    }

    [ConfigurationProperty("pollTimeout", IsRequired = false)]
    public TimeSpan PollTimeout
    {
        get { return (TimeSpan)base["pollTimeout"]; }
        set { base["pollTimeout"] = value; }
    }

    [ConfigurationProperty("location", IsRequired = false)]
    public Location Location
    {
        get { return (Location)base["location"]; }
        set { base["location"] = value; }
    }

}