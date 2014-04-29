using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CtrlChanged(object sender, EventArgs e)
    {
        string ctrlName = ((Control)sender).ID;
        lstEvents.Items.Add(ctrlName+" Changed");
        lstEvents.SelectedIndex = lstEvents.Items.Count - 1;
    }

}