using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Ctrl_ServerChange(object sender, EventArgs e)
    {
        Response.Write("<ul><li>ServerChange detected for"+((Control)sender).ID+"</li></ul>");
    }
}