<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calendar.aspx.cs" Inherits="Calendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar runat="server" ID="Calendar1" ForeColor="Red" BackColor="LightYellow" />
        <asp:Label runat="server" ID="Label1" />

    </div>
    </form>
</body>
</html>
