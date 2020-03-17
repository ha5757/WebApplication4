<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="age.aspx.cs" Inherits="WebApplication4.age" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                <td>
                    Date Of Birth
                </td>
                <td>
                    <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox>
                 
                </td>
                </tr>
                <tr>
                <td>
                    age
                </td>
                <td>
                    <asp:TextBox ID="txtage" runat="server"></asp:TextBox> 
                </td>
                </tr>

               
                <tr>

                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" style="height: 26px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
