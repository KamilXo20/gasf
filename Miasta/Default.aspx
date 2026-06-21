<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Województwa"></asp:Label></td><td style="width: 302px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="300px" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
        
     
        <tr>
        <td>Miasta</td><td>
        <asp:DropDownList ID="DropDownList2" runat="server" Width="300px">
        </asp:DropDownList>
        </td>
        </tr>
      </table>
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pokaz wspolrzedne" />
        </p>

        <asp:Label ID="labelkomunikat" runat="server"></asp:Label>
        
    </form>
</body>
</html>
