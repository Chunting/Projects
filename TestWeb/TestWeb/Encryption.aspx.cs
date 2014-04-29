using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;

public partial class Encryption : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Configuration config = WebConfigurationManager.OpenMachineConfiguration("/");
        ConfigurationSection appSettings = config.GetSection("appSettings");

        if (appSettings.SectionInformation.IsProtected)
        {
            appSettings.SectionInformation.UnprotectSection();
        }
        else
        {
            appSettings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
        }
        config.Save();
    }
}