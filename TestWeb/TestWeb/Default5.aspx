<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>List of events:</h3>
        <asp:ListBox ID="lstEvents" runat="server" Height="107px" Width="355px" />
        <br /><br />
        <h3>Controls being monitered for change events:</h3>
        <asp:TextBox ID="txt" runat="server" AutoPostBack="true" OnTextChanged="CtrlChanged" />
        <br /><br />
        <asp:CheckBox ID="chk" runat="server" AutoPostBack="true" OnCheckedChanged="CtrlChanged" />
        <br /><br />
        <asp:RadioButton ID="opt1" runat="server" GroupName="Sample" AutoPostBack="true" OnCheckedChanged="CtrlChanged" />
        <asp:RadioButton ID="opt2" runat="server" GroupName="Sample" AutoPostBack="true" OnCheckedChanged="CtrlChanged" />
    </div>
    </form>
</body>
</html>
