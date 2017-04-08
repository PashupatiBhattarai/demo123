<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="output.aspx.cs" Inherits="newdata.output" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <div>
            <table>
                <tr>
                    <td>Userid</td>
                    <td>
                        <asp:TextBox ID="txtUserid" runat="server"></asp:TextBox>
<%--                       // <asp:RequiredFieldValidator ID="txtuseridvalidate" ControlToValidate="txtUserid" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>--%>

                    </td>
                </tr>
                <tr>
                    <td>Name 
                    </td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="txtnamevalidate" ControlToValidate="txtname" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>price</td>
                    <td>
                        <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="txtpricevalidate" ControlToValidate="txtprice" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                  <tr>
                    <td>Edition</td>
                    <td>
                        <asp:TextBox ID="txtedition" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="txteditionvalidate" ControlToValidate="txtedition" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="txtbutton" runat="server" Text="save" OnClick="txtbutton_Click" />
                        <asp:Label ID="txtlabel" runat="server" Text="">
                        </asp:Label>
                       <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<%--                       <a--%>sp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />--%>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
