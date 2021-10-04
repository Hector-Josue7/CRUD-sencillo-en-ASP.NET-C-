<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularioCrud.aspx.cs" Inherits="ejemploCrudAsp.formularioCrud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
   
    


     <form id="form2" runat="server">
        <div>
            <h1>SELECT</h1>
            <asp:Label ID="Label1" runat="server" Text="ID articulo"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="78px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Mostrar ID Mochilas" OnClick="Button1_Click"  />
            <br />
            <hr />
            <h1>INSERT</h1>
            <asp:Label ID="Label2" runat="server" Text="Ingrese el articulo: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Ingrese el precio"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Guardar" OnClick="Button2_Click"  />
            <br />
            <hr />
            <h1>UPDATE</h1>
            <asp:Label ID="Label3" runat="server" Text="Actualiza descripcion del ID producto = 5:"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nueva descripcion: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Nuevo precio"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Actualizar" OnClick="Button3_Click"  />
            <br />
            <hr />
            <h1>DELETE</h1>
            <asp:Label ID="Label5" runat="server" Text="Borrar producto: "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="Button4_Click" />
            <br />
            <hr />
        </div>
    </form>

</body>
</html>
