using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SimpleHandler
/// </summary>
public class SimpleHandler:IHttpHandler
{
	public SimpleHandler()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void ProcessRequest(System.Web.HttpContext context)
    {
        HttpResponse response = context.Response;
        response.Write("<html><body><h1>Rendered by the SimpleHandler");
    }
    public bool IsReusable
    {
        get { return true; }
    }
}