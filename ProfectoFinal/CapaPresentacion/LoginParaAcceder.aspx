<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="LoginParaAcceder.aspx.cs" Inherits="CapaPresentacion.LoginParaAcceder" %>

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
          display: contents;
          margin-bottom: 5px;
          font-weight: 300;
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
          background-color: #e2112b;
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
  </style>


    

    
    <div class="form-container"> 



        <div class="form-group"> 
      
                <asp:Label ID="Label1" runat="server" Text="DIRECCIÓN DE CORREO ELECTRÓNICO"></asp:Label>
                <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
            
                    <asp:Label ID="Label2" runat="server" Text="CONTRASEÑA"></asp:Label>
                    <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="row">
                   
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="ACCESO" OnClick="btnAcceso_Click1" />

                    </div>
                    <div class="row">
                     
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RecuperacionContraseña.aspx">Has olvidado tu contraseña</asp:HyperLink>

                        </div>
        <div class="row"> 
            <div >
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Login.aspx"> Crear una cuenta</asp:HyperLink>
            </div>


        </div>

                 


            </div>

   


   

    


</asp:Content>
