<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="RecuperacionContraseña.aspx.cs" Inherits="CapaPresentacion.RecuperacionContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
    /* Estilos generales */
    .form-container {
        width: 400px;
        margin: 20px auto;
        background-color: #ffffff;
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
        background-color: #d81010;
        color: #ffffff;
        font-size: 16px;
    }

    .btn-primary:hover {
        background-color: darkblue;
    }

    /* Estilos específicos para el formulario de registro (inicialmente oculto) */
    .register-container {
        display: none;
    }
    .stylish-text {
            font-family: 'Arial', sans-serif; /* Cambia 'Arial' por el tipo de letra que prefieras */
            font-size: 16px; /* Tamaño del texto */
            color: #333; /* Color del texto */
            line-height: 1.5; /* Espacio entre líneas */
        }
</style>

  
    <div class="form-container">
         <div class="row">
        <p class="stylish-text">
            Ingrese su dirección de correo electrónico <br />
            para recibir instrucciones sobre cómo configurar <br />
            una nueva contraseña.
        </p>
    </div>
    
    <div class="form-group">
     
            <asp:Label ID="Label1" runat="server" Text="DIRECCIÓN DE CORREO ELECTRÓNICO"></asp:Label>
            <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <div class="row">
     
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="ENTREGAR" OnClick="BtnEntregar" />
            </div>
     <div class="row">
    <asp:Label ID="lblMensaje" runat="server" Text="lblMensaje"></asp:Label>
</div>

     

    </div>

</asp:Content>
