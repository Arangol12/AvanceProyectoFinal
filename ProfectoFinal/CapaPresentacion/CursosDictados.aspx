<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="CursosDictados.aspx.cs" Inherits="CapaPresentacion.CursosDictados" %>
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
            <asp:Label ID="Label1" runat="server" Text="Nombre Docente"></asp:Label>
            <asp:DropDownList ID="cboNombreDocente" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="row">
            <asp:Label ID="Label2" runat="server" Text="---Seleccionar Curso----"></asp:Label>
            <asp:DropDownList ID="cboCursos" runat="server" CssClass="form-control"></asp:DropDownList>

        </div>
        <div class="row"> 
            <asp:Label ID="Label3" runat="server" Text="Precio X Hora"></asp:Label>
            <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>     
            
        </div>
        <div class="row"> 
            <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Text="Registrar " />
        </div>

    </div>
</asp:Content>
