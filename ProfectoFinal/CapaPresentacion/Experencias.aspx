<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="Experencias.aspx.cs" Inherits="CapaPresentacion.Experencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <style>
/* Estilos generales */
.form-container {
    width: 400px;
    margin: 20px auto;
    background-color: #ffd800;
    border: 1px solid #ccc;
    border-radius: 8px;
    padding: 20px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.form-group {
    margin-bottom: 15px;
}

label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
}

.form-control {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 5px;
}

.btn {
    width: 100%;
    padding: 10px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
}

.btn-primary {
    background-color: #ff0000;
    color: #fff;
    font-size: 16px;
}

.btn-primary:hover {
    background-color: darkblue;
}

/* Estilos específicos para el formulario de registro (inicialmente oculto) */
.register-container {
    display: none;
}
         </style>

    <div class="form-container">
        <div class="row">
            <asp:Label ID="Label3" runat="server" Text="Codigo Usuario"></asp:Label>
            <asp:TextBox ID="txtCodigoUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
     <div class="row " >
         <asp:Label ID="Label2" runat="server" Text="FechaInicio"></asp:Label>
         <asp:Calendar ID="dtdFechaInicio" runat="server"></asp:Calendar>
           </div>
        <div class="row">
            <asp:Label ID="Label4" runat="server" Text="Fecha Fin"></asp:Label>
            <asp:Calendar ID="dtdFechaFin" runat="server"></asp:Calendar>

        </div>
        <div class="row">
            <asp:DropDownList ID="cboCargo" runat="server" CssClass=" form-control" style="margin-bottom: 0">
                <asp:ListItem>Profesor</asp:ListItem>
                <asp:ListItem>Director o Rector</asp:ListItem>
                <asp:ListItem>Coordinador Académico</asp:ListItem>
                <asp:ListItem>Consejero Educativo</asp:ListItem>
                <asp:ListItem>Especialista en Tecnología Educativa</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row">
            <asp:Label ID="Label1" runat="server" Text="Nombre Empresa"></asp:Label>
            <asp:TextBox ID="txtNombreEmpresa" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="row">
            <h4> Subir Ceritificado</h4>
            <asp:FileUpload ID="ofSuburCertificado" runat="server" CssClass="form-control" />

        </div>
        <div class="form-group">
            <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" />

        </div>

    </div>
     
</asp:Content>
